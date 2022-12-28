using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.Json;
using System.Data.SqlClient;
using System.Threading;
using System.Web;

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
            textBox2.ImeMode = ImeMode.Disable;
            bmiHeight.ImeMode = ImeMode.Disable;
            bmiWeight.ImeMode = ImeMode.Disable;
            vegTxt.ImeMode = ImeMode.Disable;
            fruitTxt.ImeMode = ImeMode.Disable;
            oilTxt.ImeMode = ImeMode.Disable;
            proteinTxt.ImeMode = ImeMode.Disable;
            grainTxt.ImeMode = ImeMode.Disable;
            weatherInfo.Text = "WAITING...";
            weatherInfo.BackColor = Color.Transparent;
            weatherInfo.Font = new Font(weatherInfo.Font.FontFamily, 16);

            nutrientLableTxt();
            joggingBtn.FlatAppearance.BorderSize = 0;
            joggingBtn.Image = Image.FromFile(@"../../images/sport.png");
            weatherBtn.FlatAppearance.BorderSize = 0;
            weatherBtn.Image = Image.FromFile(@"../../images/weatherBtn.png");
            dietBtn.FlatAppearance.BorderSize = 0;
            dietBtn.Image = Image.FromFile(@"../../images/diet.png");
            bmiBtn.FlatAppearance.BorderSize = 0;
            //bmiBtn.Image = Image.FromFile(@"../../images/~~~");
            bmiStandard.Image = Image.FromFile(@"../../images/bmiStandard.jpg");
            calorieBtn.FlatAppearance.BorderSize = 0;
            //calorieBtn.Image = Image.FromFile(@"../../images/~~~");
            backBtnJogging.Image = Image.FromFile(@"../../images/backToHome.png");
            backBtnWeather.Image = Image.FromFile(@"../../images/backToHome.png");
            backBtnDiet.Image = Image.FromFile(@"../../images/backToHome.png");
            backBtnBmi.Image = Image.FromFile(@"../../images/backToHome.png");

            SqlConnection db = new SqlConnection();
            db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                "Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SportRecord", db);
            DataSet ds = new DataSet();
            da.Fill(ds, "SportRecord");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Sort(dataGridView1.Columns["date"], ListSortDirection.Descending);
            db.Close();

            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker2.MaxDate = dateTimePicker3.Value.AddDays(-1);
        }

        private void weatherButton_Click(object sender, EventArgs e)
        {
            HomePanel.Visible = false;
            weatherPanel.Visible = true;
            weatherPanel.BringToFront();
            var w = Task<Output>.Run(async () => await GetRequestApi());
            weatherInfo.Text = w.Result.GetInfo();
        }

        private void joggingBtn_Click(object sender, EventArgs e)
        {
            HomePanel.Visible = false;
            joggingPanel.Visible = true;
            joggingPanel.BringToFront();
        }

        private void dietBtn_Click(object sender, EventArgs e)
        {
            HomePanel.Visible = false;
            dietPanel.Visible = true;
            dietPanel.BringToFront();
        }

        private void backBtnWeather_Click(object sender, EventArgs e)
        {
            weatherPanel.Visible = false;
            HomePanel.Visible = true;
            HomePanel.BringToFront();
        }


        private void backBtnJogging_Click(object sender, EventArgs e)
        {
            joggingPanel.Visible = false;
            HomePanel.Visible = true;
            HomePanel.BringToFront();
        }

        private void backBtnDiet_Click(object sender, EventArgs e)
        {
            dietPanel.Visible = false;
            HomePanel.Visible = true;
            HomePanel.BringToFront();
        }

        private void backBtnBmi_Click(object sender, EventArgs e)
        {
            bmiPanel.Visible = false;
            HomePanel.Visible = true;
            HomePanel.BringToFront();
        }


        private void bmiBtn_Click(object sender, EventArgs e)
        {
            HomePanel.Visible = false;
            bmiPanel.Visible = true;
            bmiPanel.BringToFront();
        }

        private void calorieBtn_Click(object sender, EventArgs e)
        {
        }

        private void vegBtn_Click(object sender, EventArgs e)
        {
            vegLabel.Visible = true;
            labelCloseBtn.Visible = true;
            labelCloseBtn.Enabled = true;
            vegLabel.BringToFront();
        }

        private void fruitBtn_Click(object sender, EventArgs e)
        {
            fruitLabel.Visible = true;
            labelCloseBtn.Visible = true;
            labelCloseBtn.Enabled = true;
            fruitLabel.BringToFront();
        }

        private void proteinBtn_Click(object sender, EventArgs e)
        {
            proteinLabel.Visible = true;
            labelCloseBtn.Visible = true;
            labelCloseBtn.Enabled = true;
            proteinLabel.BringToFront();
        }

        private void oilBtn_Click(object sender, EventArgs e)
        {
            oilLabel.Visible = true;
            labelCloseBtn.Visible = true;
            labelCloseBtn.Enabled = true;
            oilLabel.BringToFront();
        }

        private void grainsBtn_Click(object sender, EventArgs e)
        {
            grainLabel.Visible = true;
            labelCloseBtn.Visible = true;
            labelCloseBtn.Enabled = true;
            grainLabel.BringToFront();
        }
        private void nutrientLableTxt()
        {
            foreach (string line in System.IO.File.ReadLines(@"../../veg.txt")) vegLabel.Text += line + "\r\n";
            foreach (string line in System.IO.File.ReadLines(@"../../fruit.txt")) fruitLabel.Text += line + "\r\n";
            foreach (string line in System.IO.File.ReadLines(@"../../oil.txt")) oilLabel.Text += line + "\r\n";
            foreach (string line in System.IO.File.ReadLines(@"../../protein.txt")) proteinLabel.Text += line + "\r\n";
            foreach (string line in System.IO.File.ReadLines(@"../../grain.txt")) grainLabel.Text += line + "\r\n";
        }

        private void dietEnterBtn_Click(object sender, EventArgs e)
        {
            int record = 0; //紀錄是否達營養值
            string warningMessage = null;
            if(vegTxt.Text == "" || fruitTxt.Text == "" || oilTxt.Text == "" || proteinTxt.Text == "" || grainTxt.Text == "")
            {
                warningMessage += "請正確輸入攝取量";
                DialogResult result = MessageBox.Show(warningMessage, "當餐狀況", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (result == DialogResult.OK) warningMessage = null;
            }
            else
            {
                if (int.Parse(vegTxt.Text) > 3) warningMessage += "蔬菜攝取過量\n";
                else if (int.Parse(vegTxt.Text) < 1) warningMessage += "缺少脂溶性纖維及維生素\n";
                else record++;
                
                if (int.Parse(fruitTxt.Text) > 3) warningMessage += "水果攝取過量\n";
                else if (int.Parse(fruitTxt.Text) < 1) warningMessage += "缺少水溶性纖維及礦物質\n";
                else record++;

                if (Convert.ToDouble(oilTxt.Text) > 0.6) warningMessage += "油脂攝取過量\n";
                else if (Convert.ToDouble(oilTxt.Text) < 0.3) warningMessage += "缺少脂肪酸\n";
                else record++;

                if (int.Parse(proteinTxt.Text) > 3) warningMessage += "蛋白質攝取過量\n";
                else if (int.Parse(proteinTxt.Text) < 1) warningMessage += "缺少蛋白質\n";
                else record++;

                if (int.Parse(grainTxt.Text) > 3) warningMessage += "穀物攝取過量\n";
                else if (int.Parse(grainTxt.Text) < 1 || grainTxt.Text == "") warningMessage += "缺少碳水化合物\n";
                else record++;

                DialogResult result;
                if (record == 5)
                {
                    warningMessage += "營養皆均衡~~";
                    result = MessageBox.Show(warningMessage, "當餐狀況", MessageBoxButtons.OK);
                }
                else
                {
                    result = MessageBox.Show(warningMessage, "當餐狀況", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if(result == DialogResult.OK)
                {
                    record = 0;
                    warningMessage = null;
                    vegTxt.Text = "";
                    fruitTxt.Text = "";
                    oilTxt.Text = "";
                    proteinTxt.Text = "";
                    grainTxt.Text = "";
                }
            }
        }

        private void labelCloseBtn_Click(object sender, EventArgs e)
        {
            vegLabel.Visible = false;
            fruitLabel.Visible = false;
            oilLabel.Visible = false;
            grainLabel.Visible = false;
            proteinLabel.Visible = false;
            labelCloseBtn.Visible = false;
            labelCloseBtn.Enabled = false;
        }

        void Edit(string sqlstr)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                "Integrated Security=True";
            cn.Open();
            SqlCommand cmd = new SqlCommand(sqlstr, cn);
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SportRecord", cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "SportRecord");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Sort(dataGridView1.Columns["date"], ListSortDirection.Descending);
            cn.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string dateTime = dateTimePicker1.Value.ToString("yyyy-MM-dd"), distance = textBox2.Text;

                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                    "Integrated Security=True";
                Edit("INSERT INTO SportRecord(date,distance)VALUES('" +
                    dateTime.Replace("'", "''") + "'," +
                    distance +
                     ")");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断按键是不是要输入的类型。
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "") textBox2.Text = 0.ToString();
            int number = int.Parse(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string date;
                date = dataGridView1.CurrentRow.Cells[0].Value.ToString().Replace('/', '-');
                Edit("DELETE FROM SportRecord WHERE date='" + date.Split(' ')[0].Replace("'", "''") + "'");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string dateTime = dateTimePicker1.Value.ToString("yyyy-MM-dd"), distance = textBox2.Text;

                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                    "Integrated Security=True";

                Edit("UPDATE SportRecord SET distance=" + distance + " WHERE date='"
                    + dateTime.Replace("'", "''") + "'");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void weekRecord_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                    "Integrated Security=True"))
                {
                    if (cn.State == ConnectionState.Closed) cn.Open();
                    using (DataSet ds = new DataSet())
                    {
                        using(SqlCommand cmd = new SqlCommand("SELECT * FROM SportRecord WHERE date BETWEEN @fromdate AND @todate", cn))
                        {
                            // adding values
                            DayOfWeek currentDay = DateTime.Now.DayOfWeek;
                            int daysTillCurrentDay = currentDay - DayOfWeek.Sunday;
                            cmd.Parameters.AddWithValue("@fromdate", DateTime.Now.AddDays(-daysTillCurrentDay));
                            cmd.Parameters.AddWithValue("@todate",DateTime.Now);
                            // fill data to database
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(ds, "SportRecord");
                            // adding datasource
                            dataGridView2.DataSource = ds.Tables[0];
                            dataGridView2.Sort(dataGridView2.Columns["date"], ListSortDirection.Descending);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MaxDate = dateTimePicker3.Value.AddDays(-1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                    "Integrated Security=True"))
                {
                    if (cn.State == ConnectionState.Closed) cn.Open();
                    using (DataSet ds = new DataSet())
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT * FROM SportRecord WHERE date BETWEEN @fromdate AND @todate", cn))
                        {
                            // adding values
                            DayOfWeek currentDay = DateTime.Now.DayOfWeek;
                            int daysTillCurrentDay = currentDay - DayOfWeek.Sunday;
                            cmd.Parameters.AddWithValue("@fromdate", dateTimePicker2.Value);
                            cmd.Parameters.AddWithValue("@todate", dateTimePicker3.Value);
                            // fill data to database
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(ds, "SportRecord");
                            // adding datasource
                            dataGridView3.DataSource = ds.Tables[0];
                            dataGridView3.Sort(dataGridView3.Columns["date"], ListSortDirection.Descending);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bmiHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            int checkLength = bmiHeight.Text.IndexOf('.');
            int maxLength;
            if (checkLength == -1) maxLength = 3;
            else maxLength = checkLength + 3;

            if (bmiHeight.Text.Length >= maxLength)
            {
                if (checkLength == -1)
                {
                    if ((int)e.KeyChar != 46 && (int)e.KeyChar != 8) e.Handled = true;
                }
                else
                {
                    if ((int)e.KeyChar != 8) e.Handled = true;
                }
            }

            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;
            if ((int)e.KeyChar == 46)
            {
                if (bmiHeight.Text.Length <= 0)
                    e.Handled = true;
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(bmiHeight.Text, out oldf);
                    b2 = float.TryParse(bmiHeight.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }

        private void bmiWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            int checkLength = bmiWeight.Text.IndexOf('.');
            int maxLength;
            if(checkLength == -1) maxLength = 3;                          
            else maxLength = checkLength + 3;

            if(bmiWeight.Text.Length >= maxLength)
            {
                if(checkLength == -1)
                {
                    if ((int)e.KeyChar != 46 && (int)e.KeyChar != 8) e.Handled = true;
                }
                else
                {
                    if ((int)e.KeyChar != 8) e.Handled = true;
                }
            }
           
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;
            if ((int)e.KeyChar == 46)
            {
                if (bmiWeight.Text.Length <= 0)
                    e.Handled = true;
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(bmiWeight.Text, out oldf);
                    b2 = float.TryParse(bmiWeight.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }

        private void bmiCalculateBtn_Click(object sender, EventArgs e)
        {
            float weight;
            float height;
            if (bmiWeight.Text == "" || bmiHeight.Text == "")
            {
                MessageBox.Show("請輸入完整資料", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                weight = float.Parse(bmiWeight.Text);
                height = float.Parse(bmiHeight.Text);
                if (height < 30 || height > 275) MessageBox.Show("請確認身高", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (weight < 0.2 || weight > 415) MessageBox.Show("請確認體重", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    height /= 100;
                    bmiResult.Text = Math.Round(weight / height / height, 2) + "";
                }
            }          
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
                    httpClient.Timeout = TimeSpan.FromMilliseconds(10000);
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
            catch (TaskCanceledException ex)
            {
                MessageBox.Show($"Message :{ex.Message} ", "Timeout!");
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
                    httpClient.Timeout = TimeSpan.FromMilliseconds(10000);
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
            catch (TaskCanceledException ex)
            {
                MessageBox.Show($"Message :{ex.Message} ", "Timeout!");
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
                output += prefix[i] + weather_info[i] + "\r\n\n";
            }
            return output;
        }
    }
}
