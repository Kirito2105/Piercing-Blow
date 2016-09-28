using System.Text;

namespace PiercingBlow.Commons.Generics
{
    public static class BufferExtensions
    {
        /// <summary>
        /// Return string hex from byte array
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static string ToHex(this byte[] buffer)
        {
            var sb = new StringBuilder();
            int length = buffer.Length;
            int counter = 0;

            sb.AppendLine("|--------------------------------------------------------------------------|");
            sb.AppendLine("|       00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F                    |");
            sb.AppendLine("|--------------------------------------------------------------------------|");

            for (int i = 0; i < length; i++)
            {
                if (counter % 16 == 0)
                {
                    sb.Append("| " + i.ToString("X4") + ": ");
                }

                sb.Append(buffer[i].ToString("X2") + " ");
                counter++;

                if (counter == 16)
                {
                    sb.Append("   ");

                    int charpoint = i - 15;

                    for (int j = 0; j < 16; j++)
                    {
                        byte n = buffer[charpoint++];

                        if (n > 0x1f && n < 0x80)
                        {
                            sb.Append((char)n);
                        }
                        else
                        {
                            sb.Append('.');
                        }
                    }

                    sb.Append("\n");
                    counter = 0;
                }
            }

            int rest = length % 16;

            if (rest > 0)
            {
                for (int i = 0; i < 17 - rest; i++)
                {
                    sb.Append("   ");
                }

                int charpoint = length - rest;

                for (int j = 0; j < rest; j++)
                {
                    byte n = buffer[charpoint++];

                    if (n > 0x1f && n < 0x80)
                    {
                        sb.Append((char)n);
                    }
                    else
                    {
                        sb.Append('.');
                    }
                }

                sb.Append("\n");
            }

            sb.AppendLine("|--------------------------------------------------------------------------|");

            return sb.ToString().TrimEnd('\n');
        }
    }

}
