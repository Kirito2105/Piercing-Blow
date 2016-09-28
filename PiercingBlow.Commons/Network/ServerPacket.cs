using PiercingBlow.Commons.Interface;
using PiercingBlow.Commons.Utils;
using System;
using System.IO;
using System.Text;

namespace PiercingBlow.Commons.Network
{
    public abstract class ServerPacket
        {
            private static readonly Logger Log = Logger.Instance;

            public IClientConnection Client { get; set; }

            private MemoryStream Stream = new MemoryStream();

            public void WriteB(byte[] value)
            {
                Stream.Write(value, 0, value.Length);
            }

            public void WriteD(int value)
            {
                WriteB(BitConverter.GetBytes(value));
            }

            public void WriteH(int value)
            {
                WriteB(BitConverter.GetBytes((short)value));
            }

            public void WriteC(int value)
            {
                Stream.WriteByte((byte)value);
            }

            public void WriteQ(long value)
            {
                WriteB(BitConverter.GetBytes(value));
            }

            public void WriteS(string text)
            {
                WriteS(text, text.Length);
            }

            public void WriteS(string text, int length)
            {
                if (text == null)
                {
                    text = "";
                }
                try
                {
                    WriteB(Encoding.UTF8.GetBytes(text));
                }
                catch (Exception e)
                {
                    Log.Error(e.ToString());
                }
                WriteB(new byte[length - text.Length]);
            }

            public void WriteBS(string byteString)
            {
                this.WriteB(StringToByteArray(byteString));
            }

            private static byte[] StringToByteArray(String hex)
            {
                int NumberChars = hex.Length;
                byte[] bytes = new byte[NumberChars / 2];
                for (int i = 0; i < NumberChars; i += 2)
                    bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
                return bytes;
            }

        public void WriteAnnouncer(string text, int count)
            {
                if (text != null)
                {
                    WriteB(Encoding.GetEncoding(1200).GetBytes(text));
                    WriteB(new byte[count - (text.Length)]);
                }
            }

            public void WriteUnicode(string text, int count)
            {
                if (text != null)
                {
                    WriteB(Encoding.GetEncoding(1200).GetBytes(text));
                    WriteB(new byte[count - (text.Length * 2)]);
                }
            }


            public byte[] ToByteArray()
            {
                return Stream.ToArray();
            }

            public virtual void WriteImpl()
            {
                throw new Exception("Cannot write empty packet!");
            }
        }
    }