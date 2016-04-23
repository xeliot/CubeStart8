using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using LibCubeStart;

namespace CubeStart8
{
    public partial class MainForm : MetroForm
    {
        private GuiBackend _guiBackend;
        Dictionary<string, string> paths = new Dictionary<string, string>();
        public MainForm()
        {
            InitializeComponent();
            _guiBackend = new GuiBackend();
            for (var i=1; i<16; i++) {
                paths.Add("pictureBox" + i.ToString(), "");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GuiBackend.Initialize();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (paths[pictureBox1.Name] == "")
            {
                if (DialogResult.OK == openFileDialog1.ShowDialog())
                {
                    paths[pictureBox1.Name] = openFileDialog1.FileName;
                }
            }
            else {
                System.Diagnostics.Process.Start(paths[pictureBox1.Name]);
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (paths[pictureBox2.Name] == "")
            {
                if (DialogResult.OK == openFileDialog1.ShowDialog())
                {
                    paths[pictureBox2.Name] = openFileDialog1.FileName;
                }
            }
            else
            {
                System.Diagnostics.Process.Start(paths[pictureBox2.Name]);
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (paths[pictureBox3.Name] == "")
            {
                if (DialogResult.OK == openFileDialog1.ShowDialog())
                {
                    paths[pictureBox3.Name] = openFileDialog1.FileName;
                }
            }
            else
            {
                System.Diagnostics.Process.Start(paths[pictureBox3.Name]);
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (paths[pictureBox4.Name] == "")
            {
                if (DialogResult.OK == openFileDialog1.ShowDialog())
                {
                    paths[pictureBox4.Name] = openFileDialog1.FileName;
                }
            }
            else
            {
                System.Diagnostics.Process.Start(paths[pictureBox4.Name]);
            }
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if(paths[pictureBox5.Name] == "")
            {
                if (DialogResult.OK == openFileDialog1.ShowDialog())
                {
                    paths[pictureBox5.Name] = openFileDialog1.FileName;
                }
            }
            else
            {
                System.Diagnostics.Process.Start(paths[pictureBox5.Name]);
            }
        }
    }
}
