using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace Dll3_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(dialog.FileName);
                pictureBox1.Width = image.Width;
                pictureBox1.Height = image.Height;
                IntPtr ptr = DllLib.LoadPicture(dialog.FileName, 500, 20);
                Image image1 = Image.FromHbitmap(ptr);
                pictureBox1.Image = image1;
            }

        }
    }
}
