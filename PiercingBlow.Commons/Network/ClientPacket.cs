using PiercingBlow.Commons.Interface;
using PiercingBlow.Commons.Utils;
using System.IO;

namespace PiercingBlow.Commons.Network
{
    public abstract class ClientPacket
    {
        public static readonly Logger Log = Logger.Instance;

        public IClientConnection Client;

        MemoryStream stream;
        BinaryReader reader;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        public void Init(byte[] buffer)
        {
            //stream = new MemoryStream(buffer);
            stream = new MemoryStream(buffer, 4, buffer.Length - 4);
            reader = new BinaryReader(stream);
            ReadImpl();
            RunImpl();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        ///         
        protected byte ReadByte() => reader.ReadByte();
        protected short ReadShort() => reader.ReadInt16();
        protected int ReadInt() => reader.ReadInt32();
        protected long ReadLong() => reader.ReadInt64();
        protected byte[] ReadBytes(int count) => reader.ReadBytes(count);
        protected sbyte ReadSByte() => reader.ReadSByte();
        protected ushort ReadUShort() => reader.ReadUInt16();
        protected uint ReadUInt() => reader.ReadUInt32();
        protected ulong ReadULong() => reader.ReadUInt64();
        protected string ReadString() => reader.ReadString();
        protected void Skip(int size) => reader.ReadBytes(size);

        protected string ReadString(int l)
        {
            byte[] stringBytes = ReadBytes(l);
            string str = System.Text.Encoding.GetEncoding(1251).GetString(stringBytes);

            int length = str.IndexOf(char.MinValue);
            if (length != -1)
                str = str.Substring(0, length);

            return str;
        }

        protected string ReadStringUni(int l)
        {
            byte[] stringBytes = ReadBytes(l);
            string str = System.Text.Encoding.GetEncoding(1200).GetString(stringBytes);

            int length = str.IndexOf(char.MinValue);
            if (length != -1)
                str = str.Substring(0, length);

            return str;
        }

        public virtual void ReadImpl()
        {
        }

        public virtual void RunImpl()
        {
        }
    }
}
