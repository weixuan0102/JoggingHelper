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
        const string air_api_key = "78027a78-cebc-4832-8025-ac732908f298";
        const string weather_api_key = "CWB-131BB899-463A-4D5B-B30E-7FD3F0040531";
        const string air_api_url_prefix = "https://data.epa.gov.tw/api/v2";
        const string weather_api_url_prefix = "https://opendata.cwb.gov.tw/api";
        const string postfix_air = "/aqx_p_432";
        const string postfix_weather = "/v1/rest/datastore/F-C0032-001";
        const string location = "%E8%87%BA%E5%8D%97%E5%B8%82"; // Tainan
        const string offset = "0", limit = "100", format = "JSON";
        string api_url_setting = $"?offset={offset}&limit={limit}&api_key={air_api_key}&format={format}";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            weatherInfo.Text = "NULL";
            weatherInfo.Font = new Font(weatherInfo.Font.FontFamily,16);
        }

        private void getWeatherBtn_Click(object sender, EventArgs e)
        {
            var w = Task<Output>.Run(async () => await GetRequestApi());
            weatherInfo.Text = w.Result.GetInfo();
        }
        private async Task<Output> GetRequestApi()
        {
            Output w = new Output();

            string URL = air_api_url_prefix + postfix_air + api_url_setting;
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage httpResponse = await httpClient.GetAsync(URL);
                    httpResponse.EnsureSuccessStatusCode();
                    var requestBody = await httpResponse.Content.ReadAsStringAsync();
                    dynamic json = JsonSerializer.Deserialize<dynamic>(requestBody);
                    //台南市 台南的空氣測站
                    string sitename = json.GetProperty("records")[45].GetProperty("sitename").ToString();
                    w.SetInfo(0, sitename);
                    string wind_speed = json.GetProperty("records")[45].GetProperty("wind_speed").ToString() + " m/sec";
                    w.SetInfo(1, wind_speed);
                    string aqi = json.GetProperty("records")[45].GetProperty("aqi").ToString();
                    w.SetInfo(2, aqi);
                    string pollutant = json.GetProperty("records")[45].GetProperty("pollutant").ToString();
                    w.SetInfo(3, pollutant);
                    string status = json.GetProperty("records")[45].GetProperty("status").ToString();
                    w.SetInfo(4, status);
                }
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show($"Message :{e.Message} ", "Exception Caught!");
            }

            URL = weather_api_url_prefix + postfix_weather + $"?Authorization={weather_api_key}&format={format}&locationName={location}";
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage httpResponse = await httpClient.GetAsync(URL);
                    httpResponse.EnsureSuccessStatusCode();
                    var requestBody = await httpResponse.Content.ReadAsStringAsync();
                    dynamic json = JsonSerializer.Deserialize<dynamic>(requestBody);
                    //台南市 台南的天氣測站
                    var startTime = json.GetProperty("records").GetProperty("location")[0].GetProperty("weatherElement")[4].GetProperty("time")[0].GetProperty("startTime").ToString();
                    var endTime = json.GetProperty("records").GetProperty("location")[0].GetProperty("weatherElement")[4].GetProperty("time")[0].GetProperty("endTime").ToString();
                    var maxTemperature = json.GetProperty("records").GetProperty("location")[0].GetProperty("weatherElement")[4].GetProperty("time")[0].GetProperty("parameter").GetProperty("parameterName").ToString();
                    var minTemperature = json.GetProperty("records").GetProperty("location")[0].GetProperty("weatherElement")[2].GetProperty("time")[0].GetProperty("parameter").GetProperty("parameterName").ToString();
                    var PoP = json.GetProperty("records").GetProperty("location")[0].GetProperty("weatherElement")[1].GetProperty("time")[0].GetProperty("parameter").GetProperty("parameterName").ToString();
                    w.SetInfo(5, maxTemperature + "C");
                    w.SetInfo(6, minTemperature + "C");
                    w.SetInfo(7, PoP + " %\r\n" + startTime + "~" + endTime);

                }
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show($"Message :{e.Message} ", "Exception Caught!");
            }
            return w;
        }
    }
    public class Output
    {
        //string sitename, windSpeed, aqi, pollutant, status, temperature
        private string[] weather_info;
        private string[] prefix = { "測站名稱: ", "風速: ", "AQI值: ", "汙染物: ", "空氣狀況: ", "最高溫度: ", "最低溫度: ", "降雨機率: " };
        public Output()
        {
            weather_info = new string[prefix.Length];
        }
        public void SetInfo(int idx, string input)
        {
            if (idx < 0 || idx >= weather_info.Length) return;

            weather_info[idx] = input;
        }
        public string GetInfo()
        {
            string output = "";
            for (int i = 0; i < weather_info.Length; i++)
            {
                output += prefix[i] + weather_info[i] + "\r\n";
            }
            return output;
        }
    }
}
