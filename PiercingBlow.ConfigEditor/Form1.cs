using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PiercingBlow.ConfigEditor
{
    public partial class Form1 : Form
    {
        private string file;
        private byte[] buf;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = file = dialog.FileName;
                buf = File.ReadAllBytes(dialog.FileName);
                textBox1.Text = File.ReadAllText(dialog.FileName);
                textBox2.Visible = false;
                button1.Visible = false;
                button3.Visible = false;
                label1.Text = "Выбран файл: " + dialog.FileName;
                button2.Visible = true;
                buf = File.ReadAllBytes(dialog.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                byte num2 = decrypt(buf, buf.Length, i);
                Array.Resize(ref buf, buf.Length + 1);
                buf[buf.Length - 1] = num2;
            }
            textBox1.Text = Encoding.GetEncoding(0x4e3).GetString(buf);
            button3.Visible = true;
            label1.Text = "Файл: " + file + " - Успешно декодирован";
            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buf = Encoding.Default.GetBytes(textBox1.Text);
            for (int i = 1; i <= 5; i++)
            {
                int num2 = encrypt(buf, buf.Length, i);
                Array.Resize(ref buf, buf.Length - 1);
            }
            if (File.Exists(file))
            {
                File.Delete(file);
            }
            File.Create(file).Write(buf, 0, buf.Length);
            label1.Text = "Файл: " + file + " Успешно кодирован и сохранен!";
            textBox1.Text = " Файл сохранён. Для открытия нового файла перезапустите программу.";
            button3.Visible = false;
        }


        public static byte decrypt(byte[] a1, int a2, int a3)
        {
            byte num = (byte)a2;
            byte num2 = (byte)a3;
            int num4 = a2 - 1;
            int num3 = 8 - a3;
            byte num6 = a1[a2 - 1];
            while (num4 >= 0)
            {
                byte num5;
                if (num4 <= 0)
                {
                    num5 = num6;
                }
                else
                {
                    num5 = a1[num4 - 1];
                }
                num = (byte)((num5 << num3) | (a1[num4--] >> num2));
                a1[num4 + 1] = num;
            }
            return num;
        }

        public static int encrypt(byte[] a1, int a2, int a3)
        {
            int num3 = a3;
            byte[] buffer = a1;
            byte num6 = a1[0];
            int num2 = 8 - a3;
            int num = 0;
            int num7 = 8 - a3;
            if (a2 <= 0)
            {
                return num;
            }
            while (true)
            {
                int num4 = (num >= (a2 - 1)) ? num6 : buffer[num + 1];
                int num5 = buffer[num++] << num3;
                buffer[num - 1] = (byte)(num5 | (num4 >> num2));
                if (num >= a2)
                {
                    return num;
                }
                int num8 = ((ushort)num2) & 0xff;
                int num9 = ((ushort)num2) >> 8;
                num2 = (num7 & 0xff) | ((num9 & 0xff) << 8);
            }
        }
    }
}
