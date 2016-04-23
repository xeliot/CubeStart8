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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Users\\daveho8888\\Documents\\dave ho\\programming\\iphone.txt");
        }
    }
}
