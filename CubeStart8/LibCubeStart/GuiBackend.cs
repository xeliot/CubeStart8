using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LibCubeStart
{
    public class GuiBackend
    {
        private Dictionary<string, string> _paths;
        private OpenFileDialog _openFileDialog;

        public Dictionary<string, string> Paths
        {
            get
            {
                return _paths;
            }

            set
            {
                _paths = value;
            }
        }

        public void Initialize()
        {
            _paths = new Dictionary<string, string>();
            for (var i = 1; i < 16; i++)
            {
                _paths.Add("pictureBox" + i.ToString(), "");
            }
            _openFileDialog = new OpenFileDialog();
        }

        public void OnPictureBoxClick(ref System.Windows.Forms.PictureBox currentPictureBox, EventArgs e)
        {
            var mea = e as MouseEventArgs;
            switch (mea.Button)
            {
                case MouseButtons.Left:
                    OnPictureBoxLeftClick(ref currentPictureBox);
                    break;
                case MouseButtons.Right:
                    OnPictureBoxRightClick(ref currentPictureBox);
                    break;
            }
        }

        public void OnPictureBoxLeftClick(ref PictureBox currentPictureBox)
        {

            if (_paths[currentPictureBox.Name] == "")
            {
                if (DialogResult.OK == _openFileDialog.ShowDialog())
                {
                    _paths[currentPictureBox.Name] = _openFileDialog.FileName;
                    Icon ico = Icon.ExtractAssociatedIcon(_openFileDialog.FileName);
                    currentPictureBox.Image = ico.ToBitmap();
                }
            }
            else
            {
                System.Diagnostics.Process.Start(_paths[currentPictureBox.Name]);
            }
        }

        public void OnPictureBoxRightClick(ref System.Windows.Forms.PictureBox currentPictureBox)
        {
            // remove path from paths dictionary
            _paths[currentPictureBox.Name] = "";
            //change picturebox image to the add symbol
            currentPictureBox.Image = Image.FromFile(@"C:\Users\daveho8888\Documents\dave ho\programming\CubeStart8\CubeStart8\CubeStart8\Resources\add.png");
        }
    }
}