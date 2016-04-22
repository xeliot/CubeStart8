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
    public partial class Form1 : MetroForm
    {
        private GuiBackend _guiBackend;
        public Form1()
        {
            InitializeComponent();
            _guiBackend = new GuiBackend();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
