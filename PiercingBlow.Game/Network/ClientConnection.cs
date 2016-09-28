using PiercingBlow.Commons.Crypto;
using PiercingBlow.Commons.Generics;
using PiercingBlow.Commons.Interface;
using PiercingBlow.Commons.Model;
using PiercingBlow.Commons.Model.Enum.Player;
using PiercingBlow.Commons.Network;
using PiercingBlow.Commons.Utils;
using PiercingBlow.Game.Model.Enum;
using PiercingBlow.Game.Network.Send;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace PiercingBlow.Game.Network
{
    public class ClientConnection : IClientConnection
    {
        private readonly Logger Log = Logger.Instance;

        public delegate void MethodContainer(ClientConnection session);

        public event MethodContainer OnDisconnected;

        byte[] buffer = new byte[2048];

        public NetworkStream Stream { get; set; }

        public TcpClient Client { get; set; }

        public int Id { get; set; }

        public byte[] RemoteIPAddress { get; set; }

        public int RemoteUdpPort { get; set; }

        public Account Account { get; set; }

        public Player Player { get; set; }

        public Character Character { get; set; }

        //public Channel Channel { get; set; }

        public void Accept(TcpClient client)
        {
            Client = client;
            Stream = client.GetStream();
            RemoteIPAddress = ((IPEndPoint)client.Client.RemoteEndPoint).Address.GetAddressBytes();
            RemoteUdpPort = 29890;
            SendPacket(new PROTOCOL_BASE_CONNECT_ACK(this));
            Stream.BeginRead(buffer, 0, buffer.Length, BeginRead, null);
        }

        public void BeginRead(IAsyncResult asyncResult)
        {
            try
            {
                int received = Stream.EndRead(asyncResult);
                if (received != 0)
                {
                    while (received >= 6)
                    {
                        int length = BitConverter.ToUInt16(buffer, 0) & 0x7FFF;

                        byte[] temp = new byte[length + 2];
                        Array.Copy(buffer, 2, temp, 0, temp.Length);

                        int bits = Id % 7 + 1;
                        BitShift.Unshift(temp, bits);

                        byte[] opcode = new byte[] { temp[0], temp[1] };
                        RecvOpcode packet = (RecvOpcode)BitConverter.ToUInt16(opcode, 0);
                        Type t = Type.GetType("PiercingBlow.Game.Network.Recv." + packet.ToString());

                        if (t != null)
                        {
                            ClientPacket clientpacket = (ClientPacket)Activator.CreateInstance(t);
                            clientpacket.Client = this;
                            clientpacket.Init(temp);
                        }
                        else
                        {
                            Log.Info("PacketId = {0}", BitConverter.ToUInt16(opcode, 0), buffer.Length);
                            Log.Trace(temp.ToHex());
                        }
                        received -= length + 4;
                        Array.Copy(buffer, length + 4, buffer, 0, received); // << Копируем оставшиеся данные в начало буфера
                    }
                    Stream.BeginRead(buffer, 0, buffer.Length, BeginRead, Stream);
                }
                else
                {
                    OnDisconnected(this);
                }
            }
            catch (IOException)
            {
                OnDisconnected(this);
            }
            catch (Exception ex)
            {
                OnDisconnected(this);
                //Log.Error(ex);
                Log.Error($"{ex.Message}\n{ex.StackTrace}");
            }
        }


        public void SendPacket(ServerPacket packet)
        {
            packet.Client = this;
            packet.WriteImpl();
            byte[] data = packet.ToByteArray();
            byte[] lenght = BitConverter.GetBytes((short)data.Length);
            byte[] opcode = BitConverter.GetBytes(Convert.ToInt16((int)Enum.Parse(typeof(SendOpcode), packet.GetType().Name)));
            byte[] buff = new byte[data.Length + 4];
            Array.Copy(lenght, 0, buff, 0, lenght.Length);
            Array.Copy(opcode, 0, buff, 2, opcode.Length);
            Array.Copy(data, 0, buff, 4, data.Length);
            Stream.Write(buff, 0, buff.Length); ;
        }
    }
}
