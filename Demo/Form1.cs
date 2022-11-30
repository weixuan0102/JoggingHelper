using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Web;
using System.Net.Http;
using System.Text.Json;

namespace Demo
{
    public partial class Form1 : Form
    {
        const string api_key = "78027a78-cebc-4832-8025-ac732908f298";
        const string api_url_prefix = "https://data.epa.gov.tw/api/v2";
        string[] api_url_postfix = { "/aqx_p_432" };
        const string offset = "0", limit = "100", format = "JSON";
        string api_url_setting = $"?offset={offset}&limit={limit}&api_key={api_key}&format={format}";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            weatherInfo.Text = "NULL";
        }

        private void getWeatherBtn_Click(object sender, EventArgs e)
        {
            var w = Task<Weather>.Run(async () => await GetRequestApi());
            
            weatherInfo.Text = w.Result.GetWeatherInfo();
        }
        private async Task<Weather> GetRequestApi()
        {
            Weather w = new Weather();
            for (int i = 0; i < api_url_postfix.Length; i++)
            {
                string URL = api_url_prefix + api_url_postfix[i] + api_url_setting;
                try
                {
                    using (HttpClient httpClient = new HttpClient())
                    {
                        HttpResponseMessage httpResponse = await httpClient.GetAsync(URL);
                        httpResponse.EnsureSuccessStatusCode();
                        var requestBody = await httpResponse.Content.ReadAsStringAsync();
                        dynamic json = JsonSerializer.Deserialize<dynamic>(requestBody);
                        //台南市 台南的空氣測站
                        string aqi = json.GetProperty("records")[45].GetProperty("aqi").ToString();
                        string pollutant = json.GetProperty("records")[45].GetProperty("pollutant").ToString();
                        string status = json.GetProperty("records")[45].GetProperty("status").ToString();
                        string info = $"AQI值:{aqi}\r\n汙染物:{pollutant}\r\n狀況:{status}";
                        w.ConcatenateInfo(info);
                    }
                }
                catch (HttpRequestException e)
                {
                    MessageBox.Show($"Message :{e.Message} ", "Exception Caught!");
                }

            }
            return w;

        }
    }
    public class Weather
    {
        private string weather_info = "";
        public Weather()
        {

        }
        public void ConcatenateInfo(string input)
        {
            weather_info += input + "\r\n";
        }
        public string GetWeatherInfo()
        {
            return weather_info;
        }
    }
}
