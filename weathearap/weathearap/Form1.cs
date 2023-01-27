using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weathearap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?q=London&appid=0af7f0fb583a9819ef4f5892bdfbcc98&units=metric";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string response = reader.ReadToEnd();
            richTextBox1.Text = response;
            WeatherResponse wr = JsonConvert.DeserializeObject<WeatherResponse>(response);
            ICity.Text = wr.Name;
            ITemperatura.Text = wr.Main.Temp.ToString();
        }
    }
}
