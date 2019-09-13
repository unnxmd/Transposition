using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transposition
{
    public partial class Form1 : Form
    {
        static int[] prmt = { 2, 3, 1, 6, 4, 5 };
        private string[] filesEncrypt;
        private string[] filesDecrypt;

        public Form1()
        {
            InitializeComponent();
        }

        private void listBoxEncrypt_DragDrop(object sender, DragEventArgs e)
        {
            filesEncrypt = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string file in filesEncrypt) listBoxEncrypt.Items.Add(file);
        }

        private void listBoxDecrypt_DragDrop(object sender, DragEventArgs e)
        {
            filesDecrypt = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string file in filesDecrypt) listBoxDecrypt.Items.Add(file);
        }

        private void listBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            foreach (string file in filesEncrypt)
            {
                byte[] to_enc = System.IO.File.ReadAllBytes(file);
                int el = to_enc.Length;
                while (el % 6 != 0) el++;
                byte[] enc = new byte[el];
                Array.Copy(to_enc, enc, to_enc.Length);
                for (int i = to_enc.Length; i < enc.Length; i++) enc[i] = 0x01;
                for (int i = 0; i < enc.Length; i += 6)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        enc = Swap(enc, j + i, prmt[j] - 1 + i);
                    }
                }
                System.IO.File.WriteAllBytes(file, enc);
                listBoxEncrypt.Items.Remove(file);
            }
            Array.Clear(filesEncrypt, 0, filesEncrypt.Length);
            MessageBox.Show("Зашифровано!");
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            foreach (string file in filesDecrypt)
            {
                byte[] enc = System.IO.File.ReadAllBytes(file);
                int last = enc.Length;
                for (int i = 0; i < enc.Length; i += 6)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        enc = Swap(enc, prmt[j] - 1 + i, j + i);
                    }
                }
                if (enc.Last() == 0x1)
                {
                    int ind = enc.Length - 1;
                    last = ind;
                    while (enc[last - 1] == 0x1) last--;
                }
                byte[] dec = new byte[last];
                Array.Copy(enc, dec, last);
                System.IO.File.WriteAllBytes(file, dec);
                listBoxDecrypt.Items.Remove(file);
            }
            Array.Clear(filesDecrypt, 0, filesDecrypt.Length);
            MessageBox.Show("Расшифровано!");
        }

        private static byte[] Swap(byte[] c, int a, int b)
        {
            byte tmp = c[a];
            c[a] = c[b];
            c[b] = tmp;
            return c;
        }
    }
}
