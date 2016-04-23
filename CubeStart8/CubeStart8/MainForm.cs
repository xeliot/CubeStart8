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
        
        public MainForm()
        {
            InitializeComponent();
            _guiBackend = new GuiBackend();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _guiBackend.Initialize();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _guiBackend.OnPictureBoxClick(ref pictureBox1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _guiBackend.OnPictureBoxClick(ref pictureBox2);
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            _guiBackend.OnPictureBoxClick(ref pictureBox3);
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            _guiBackend.OnPictureBoxClick(ref pictureBox4);
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            _guiBackend.OnPictureBoxClick(ref pictureBox7);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            _guiBackend.OnPictureBoxClick(ref pictureBox5);
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
            _guiBackend.OnPictureBoxClick(ref pictureBox6);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            _guiBackend.OnPictureBoxClick(ref pictureBox8);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            _guiBackend.OnPictureBoxClick(ref pictureBox9);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            _guiBackend.OnPictureBoxClick(ref pictureBox10);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            _guiBackend.OnPictureBoxClick(ref pictureBox11);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            _guiBackend.OnPictureBoxClick(ref pictureBox12);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            _guiBackend.OnPictureBoxClick(ref pictureBox13);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            _guiBackend.OnPictureBoxClick(ref pictureBox14);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            _guiBackend.OnPictureBoxClick(ref pictureBox15);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            _guiBackend.OnPictureBoxClick(ref pictureBox16);
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

                    //below this is very ugly :(
                    //Don't use JavaScriptSerializer
                    //Use JSON.NET
                    //Newtonsoft.Json


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
