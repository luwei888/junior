using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> listSongs = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择音乐文件";
            ofd.InitialDirectory = @"C:\Users\Administrator\Music";
            ofd.Multiselect = true;
            ofd.Filter = "音乐文件|*.flac|所有文件|*.*";
            ofd.ShowDialog();
            string[] path = ofd.FileNames;
            for (int i = 0; i < path.Length; i++)
            {
                //将音乐文件的文件名加载到listbox中
                listBox1.Items.Add(Path.GetFileName(path[i]));
                listSongs.Add(path[i]);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }


        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = listSongs[listBox1.SelectedIndex];
            sp.Play();
        }
    }
}
