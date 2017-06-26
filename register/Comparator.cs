using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace register
{
    public partial class Comparator : Form
    {
        public Comparator()
        {
            InitializeComponent();
        }
        public string pathFile1="", pathFile2="";
        Hash coder = new Hash();
        private void openFile1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            pathFile1 = openFileDialog1.FileName;
            filePath1.Text = pathFile1;
            openFileDialog1.FileName = "";
            check();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "All files(*.*)|*.*";
            if (openFileDialog2.ShowDialog() == DialogResult.Cancel) return;
            pathFile2 = openFileDialog2.FileName;
            filePath2.Text = pathFile2;
            openFileDialog2.FileName = "";
            check();
        }

        public void check()
        {
            string path;
            if (radioFile1.Checked)
                path = pathFile1;
            else
                path = pathFile2;
            if (path != "" || !File.Exists(path)) {
                editor.Text = System.IO.File.ReadAllText(path, Encoding.UTF8);
            }
            //editor.Text = System.IO.File.ReadAllText(path);
        }

        private void radioFile1_CheckedChanged(object sender, EventArgs e)
        {
            check();
        }

        private void saveBut_Click(object sender, EventArgs e)
        {
            string path;
            if (radioFile1.Checked)
                path = pathFile1;
            else
                path = pathFile2;
            if (path != "")
            {
                //System.IO.File.WriteAllBytes(path, BitConverter.GetBytes(editor.Text));
                System.IO.File.WriteAllText(path, editor.Text.Replace("\n","\r\n"), Encoding.UTF8);
            }
        }

        private void compareBut_Click(object sender, EventArgs e)
        {
			int len = trackBar1.Value;
			string hash1 = coder.GOST(System.IO.File.ReadAllText(pathFile1, Encoding.UTF8), len);
			string hash2 = coder.GOST(System.IO.File.ReadAllText(pathFile2, Encoding.UTF8), len);
            hashFile1.Text = hash1;
            hashFile2.Text = hash2;
            string message;
            if (hash1 == hash2)
                message="Файлы совпадают";
            else
                message="Файлы не совпадают";
            MessageBox.Show(message, "Сравнение файлов", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Comparator_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			label3.Text = trackBar1.Value.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int[] len={2,8,16,32};
			string origin = System.IO.File.ReadAllText(pathFile1, Encoding.UTF8);
			int[] size = { 0, origin.Length / 2, origin.Length - 1 };
			int[] size2 = { 2, origin.Length / 2-5, origin.Length - 3 };
			string modString;
			editor.Clear();
			for (int modNum = 0; modNum < 4; modNum++)
				for (int pos = 0; pos < 3; pos++)
					for (int i = 0; i < len.Length; i++)
					{
						string hash1 = coder.GOST(origin, len[i]);
						modString = mod(origin, modNum, "f", size[pos], size2[pos]);
						if (i == 0)
						{
							System.Console.WriteLine(modString);
						}
						string hash2 = coder.GOST(modString, len[i]);
						if (modNum==2)
							editor.AppendText(modNum+" " + hash1 + " " + hash2 +" "+ len[i]+" " + " " + size[pos] + " " + size2[pos] + "\r\n");
						else editor.AppendText(modNum + " " + hash1 + " " + hash2 + " " + len[i] + " " + " " + size[pos] + "\r\n");
					}

			for (int i = 0; i < len.Length; i++)
				editor.AppendText(coder.GOST(origin, len[i])+" "+len[i]+"\r\n");
				//string modString = mod(origin,1,"a",origin.Length-1);
				//string modString = mod(origin, 2, "a", origin.Length-1);
				//string modString = mod(origin, 3, "a", 1,3);
				//string modString = mod(origin, 4, "a", origin.Length-1);
				//editor.Text = modString;
			/*for (int i = 0; i < 3; i++)
			{
				string hash2 = coder.hash_gost(System.IO.File.ReadAllText(pathFile2, Encoding.UTF8), len);
			}*/				
		}
		public string mod (string text, int mod, string charr="", int pos1=0, int pos2=0)
		{
			string temp="";
			switch (mod)
			{
				case 0:
					temp = text.Insert(pos1, charr);
					break;
				case 1:
					temp = text.Remove(pos1, 1).Insert(pos1, charr);
					break;
				case 2:
					string tex1 = text[pos1].ToString(), tex2 = text[pos2].ToString();
					temp = text.Remove(pos1, 1).Insert(pos1, tex2).Remove(pos2, 1).Insert(pos2, tex1);;
					break;
				case 3:
					temp = text.Remove(pos1, 1);
					break;
			}
			return temp;
		}
    }
}
