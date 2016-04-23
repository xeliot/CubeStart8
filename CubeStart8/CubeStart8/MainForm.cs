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
using System.Diagnostics;
using System.Net;
using System.Xml;
using System.Web.Script.Serialization;

namespace CubeStart8
{
    partial class MainForm : MetroForm
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
                    Icon ico = Icon.ExtractAssociatedIcon(@openFileDialog1.FileName);
                    pictureBox1.Image = ico.ToBitmap();
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
                    Icon ico = Icon.ExtractAssociatedIcon(@openFileDialog1.FileName);
                    pictureBox2.Image = ico.ToBitmap();
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
                    Icon ico = Icon.ExtractAssociatedIcon(@openFileDialog1.FileName);
                    pictureBox3.Image = ico.ToBitmap();
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
                    Icon ico = Icon.ExtractAssociatedIcon(@openFileDialog1.FileName);
                    pictureBox4.Image = ico.ToBitmap();
                }
            }
            else
            {
                System.Diagnostics.Process.Start(paths[pictureBox4.Name]);
            }
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (paths[pictureBox7.Name] == "")
            {
                if (DialogResult.OK == openFileDialog1.ShowDialog())
                {
                    paths[pictureBox7.Name] = openFileDialog1.FileName;
                    Icon ico = Icon.ExtractAssociatedIcon(@openFileDialog1.FileName);
                    pictureBox7.Image = ico.ToBitmap();
                }
            }
            else
            {
                System.Diagnostics.Process.Start(paths[pictureBox7.Name]);
            }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Process.Start(Uri.EscapeUriString("https://www.google.com/search?q="+googleItBox.Text));
                //Process.Start-ing a URL will open default browser
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (paths[pictureBox6.Name] == "")
            {
                if (DialogResult.OK == openFileDialog1.ShowDialog())
                {
                    paths[pictureBox6.Name] = openFileDialog1.FileName;
                }
            }
            else
            {
                System.Diagnostics.Process.Start(paths[pictureBox6.Name]);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (paths[pictureBox8.Name] == "")
            {
                if (DialogResult.OK == openFileDialog1.ShowDialog())
                {
                    paths[pictureBox8.Name] = openFileDialog1.FileName;
                }
            }
            else
            {
                System.Diagnostics.Process.Start(paths[pictureBox8.Name]);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (paths[pictureBox9.Name] == "")
            {
                if (DialogResult.OK == openFileDialog1.ShowDialog())
                {
                    paths[pictureBox9.Name] = openFileDialog1.FileName;
                }
            }
            else
            {
                System.Diagnostics.Process.Start(paths[pictureBox9.Name]);
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (paths[pictureBox10.Name] == "")
            {
                if (DialogResult.OK == openFileDialog1.ShowDialog())
                {
                    paths[pictureBox10.Name] = openFileDialog1.FileName;
                }
            }
            else
            {
                System.Diagnostics.Process.Start(paths[pictureBox10.Name]);
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (paths[pictureBox11.Name] == "")
            {
                if (DialogResult.OK == openFileDialog1.ShowDialog())
                {
                    paths[pictureBox11.Name] = openFileDialog1.FileName;
                }
            }
            else
            {
                System.Diagnostics.Process.Start(paths[pictureBox11.Name]);
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (paths[pictureBox12.Name] == "")
            {
                if (DialogResult.OK == openFileDialog1.ShowDialog())
                {
                    paths[pictureBox12.Name] = openFileDialog1.FileName;
                }
            }
            else
            {
                System.Diagnostics.Process.Start(paths[pictureBox12.Name]);
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (paths[pictureBox13.Name] == "")
            {
                if (DialogResult.OK == openFileDialog1.ShowDialog())
                {
                    paths[pictureBox13.Name] = openFileDialog1.FileName;
                }
            }
            else
            {
                System.Diagnostics.Process.Start(paths[pictureBox13.Name]);
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (paths[pictureBox14.Name] == "")
            {
                if (DialogResult.OK == openFileDialog1.ShowDialog())
                {
                    paths[pictureBox14.Name] = openFileDialog1.FileName;
                }
            }
            else
            {
                System.Diagnostics.Process.Start(paths[pictureBox14.Name]);
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (paths[pictureBox15.Name] == "")
            {
                if (DialogResult.OK == openFileDialog1.ShowDialog())
                {
                    paths[pictureBox15.Name] = openFileDialog1.FileName;
                }
            }
            else
            {
                System.Diagnostics.Process.Start(paths[pictureBox15.Name]);
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (paths[pictureBox16.Name] == "")
            {
                if (DialogResult.OK == openFileDialog1.ShowDialog())
                {
                    paths[pictureBox16.Name] = openFileDialog1.FileName;
                }
            }
            else
            {
                System.Diagnostics.Process.Start(paths[pictureBox16.Name]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        protected void GetWeatherInfo(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void lblTempMax_Click(object sender, EventArgs e)
        {

        }

        private void txtCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string appId = "37df39e9cf3691f235d7ad2fed75b01b";
                string url = string.Format("http://api.openweathermap.org/data/2.5/forecast/daily?q={0}&units=metric&cnt=1&APPID={1}", txtCity.Text.Trim(), appId);
                using (WebClient client = new WebClient())
                {
                    string json = client.DownloadString(url);

                    WeatherInfo weatherInfo = (new JavaScriptSerializer()).Deserialize<WeatherInfo>(json);
                    lblCity_Country.Text = weatherInfo.city.name + "," + weatherInfo.city.country;
                    flagPic.Load(string.Format("http://openweathermap.org/images/flags/{0}.png", weatherInfo.city.country.ToLower()));
                    lblDescription.Text = weatherInfo.list[0].weather[0].description;
                    weatherPic.Load(string.Format("http://openweathermap.org/img/w/{0}.png", weatherInfo.list[0].weather[0].icon));
                    lblTempMin.Text = string.Format("{0}°С", Math.Round(weatherInfo.list[0].temp.min, 1));
                    lblTempMax.Text = string.Format("{0}°С", Math.Round(weatherInfo.list[0].temp.max, 1));
                    lblTempDay.Text = string.Format("{0}°С", Math.Round(weatherInfo.list[0].temp.day, 1));
                    lblTempNight.Text = string.Format("{0}°С", Math.Round(weatherInfo.list[0].temp.night, 1));
                    lblHumidity.Text = weatherInfo.list[0].humidity.ToString();
                    //tblWeather.Visible = true;
                }
            }
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void weatherPic_Click(object sender, EventArgs e)
        {

        }
    }
    public class WeatherInfo
    {
        public City city { get; set; }
        public List<List> list { get; set; }
    }

    public class City
    {
        public string name { get; set; }
        public string country { get; set; }
    }

    public class Temp
    {
        public double day { get; set; }
        public double min { get; set; }
        public double max { get; set; }
        public double night { get; set; }
    }

    public class Weather
    {
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class List
    {
        public Temp temp { get; set; }
        public int humidity { get; set; }
        public List<Weather> weather { get; set; }
    }
}
