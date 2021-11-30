using ServerWebApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;

namespace ClientWinForms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private async void buttonGetWeatherData_Click(object sender, EventArgs e)
        {
            //WebClient webClient = new WebClient();
            //webClient.Encoding = Encoding.UTF8;

            //string json = webClient.UploadString("https://localhost:44315/api/Weather/GetAll", "POST", "");

            //List<WeatherData> dataList = JsonConvert.DeserializeObject<List<WeatherData>>(json);

            //dataGridViewWeatherData.DataSource = null;
            //dataGridViewWeatherData.DataSource = dataList;

            try
            {
                HttpClient httpClient = new HttpClient();

                StringContent content = new StringContent("", Encoding.UTF8, "application/json");

                HttpResponseMessage responseMessage = await httpClient.PostAsync("https://localhost:44315/api/Weather/GetAll", content);

                string responseJson = await responseMessage.Content.ReadAsStringAsync();

                if (responseMessage.StatusCode == HttpStatusCode.OK)
                {
                    List<WeatherData> wd = JsonConvert.DeserializeObject<List<WeatherData>>(responseJson);

                    dataGridViewWeatherData.DataSource = null;
                    dataGridViewWeatherData.DataSource = wd;
                }
                else
                {
                    string error = JsonConvert.DeserializeObject<string>(responseJson);
                    MessageBox.Show((int)responseMessage.StatusCode + "  " + responseMessage.Content + error);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "SERVER ERROR");
            }
        }

        private async void buttonGetByName_Click(object sender, EventArgs e)
        {
            //WebClient webClient = new WebClient();
            //webClient.Encoding = Encoding.UTF8;
            //webClient.Headers["Content-Type"] = "application/json";

            //string cityName = JsonConvert.SerializeObject(textBoxName.Text);

            //string json = webClient.UploadString("https://localhost:44315/api/Weather/GetByCityName", "POST", cityName);

            //WeatherData data = JsonConvert.DeserializeObject<WeatherData>(json);

            //if (data == null)
            //{
            //    MessageBox.Show("Город не найден(");
            //}
            //else
            //{
            //    MessageBox.Show($"{data.CityName}: {data.Temperature}");
            //}

            try
            {
                HttpClient httpClient = new HttpClient();

                string cityName = JsonConvert.SerializeObject(textBoxName.Text);

                StringContent content = new StringContent(cityName, Encoding.UTF8, "application/json");

                HttpResponseMessage responseMessage = await httpClient.PostAsync("https://localhost:44315/api/Weather/GetByCityName", content);

                string responseJson = await responseMessage.Content.ReadAsStringAsync();

                if (responseMessage.StatusCode == HttpStatusCode.OK)
                {
                    WeatherData wd = JsonConvert.DeserializeObject<WeatherData>(responseJson);

                    if (wd == null)
                    {
                        MessageBox.Show("Город не найден(");
                    }
                    else
                    {
                        MessageBox.Show($"{wd.CityName}: {wd.Temperature}");
                    }
                }
                else
                {
                    string error = JsonConvert.DeserializeObject<string>(responseJson);
                    MessageBox.Show((int)responseMessage.StatusCode + "  " + responseMessage.Content + error);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "SERVER ERROR");
            }
        }

        private async void buttonDeleteByName_Click(object sender, EventArgs e)
        {
            //WebClient webClient = new WebClient();
            //webClient.Encoding = Encoding.UTF8;
            //webClient.Headers["Content-Type"] = "application/json";

            //string cityName = JsonConvert.SerializeObject(textBoxName.Text);

            //webClient.UploadString("https://localhost:44315/api/Weather/DeleteDataByCityName", "POST", cityName);

            try
            {
                HttpClient httpClient = new HttpClient();

                string cityName = JsonConvert.SerializeObject(textBoxName.Text);

                StringContent content = new StringContent(cityName, Encoding.UTF8, "application/json");

                HttpResponseMessage responseMessage = await httpClient.PostAsync("https://localhost:44315/api/Weather/DeleteDataByCityName", content);

                string responseJson = await responseMessage.Content.ReadAsStringAsync();

                if (responseMessage.StatusCode == HttpStatusCode.OK)
                {
                    bool wd = JsonConvert.DeserializeObject<bool>(responseJson);
                    if (wd)
                    {
                    MessageBox.Show("YEP");
                    }
                    else
                    {
                        MessageBox.Show("Город не найден");
                    }
                }
                else
                {
                    string error = JsonConvert.DeserializeObject<string>(responseJson);
                    MessageBox.Show((int)responseMessage.StatusCode + "  " + responseMessage.Content + error);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "ПРИЛЯГ ПОСПИ");
            }
        }

        private async void buttonUpdateByName_Click(object sender, EventArgs e)
        {
            // TODO: HttpClient
            //if (textBoxNewName.Text != "" && textBoxTemperature.Text != "")
            //{
            //    WebClient webClient = new WebClient();
            //    webClient.Encoding = Encoding.UTF8;
            //    webClient.Headers["Content-Type"] = "application/json";

            //    WeatherData weatherData = new WeatherData()
            //    {
            //        CityName = textBoxNewName.Text,
            //        Temperature = int.Parse(textBoxTemperature.Text)
            //    };

            //    string data = JsonConvert.SerializeObject(weatherData);

            //    webClient.UploadString("https://localhost:44315/api/Weather/PostEditDataByCityName", "POST", data);
            //}

            try
            {
                HttpClient httpClient = new HttpClient();

                WeatherData weatherData = new WeatherData()
                {
                    CityName = textBoxNewName.Text,
                    Temperature = int.Parse(textBoxTemperature.Text)
                };

                string data = JsonConvert.SerializeObject(weatherData);

                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");

                HttpResponseMessage responseMessage = await httpClient.PostAsync("https://localhost:44315/api/Weather/PostEditDataByCityName", content);

                string responseJson = await responseMessage.Content.ReadAsStringAsync();

                if (responseMessage.StatusCode == HttpStatusCode.OK)
                {
                    MessageBox.Show("YEP");
                }
                else
                {
                    string error = JsonConvert.DeserializeObject<string>(responseJson);
                    MessageBox.Show((int)responseMessage.StatusCode + "  " + responseMessage.Content + error);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "ПРИЛЯГ ПОСПИ");
            }
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            //if (textBoxNewName.Text != "" && textBoxTemperature.Text != "")
            //{

            //    WebClient webClient = new WebClient();
            //    webClient.Encoding = Encoding.UTF8;
            //    webClient.Headers["Content-Type"] = "application/json";

            //    WeatherData weatherData = new WeatherData()
            //    {
            //        CityName = textBoxNewName.Text,
            //        Temperature = int.Parse(textBoxTemperature.Text)
            //    };

            //    string data = JsonConvert.SerializeObject(weatherData);

            //    webClient.UploadString("https://localhost:44315/api/Weather/PutCityByName", "POST", data);
            //}

            try
            {
                HttpClient httpClient = new HttpClient();

                WeatherData weatherData = new WeatherData()
                {
                    CityName = textBoxNewName.Text,
                    Temperature = int.Parse(textBoxTemperature.Text)
                };

                string data = JsonConvert.SerializeObject(weatherData);

                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");

                HttpResponseMessage responseMessage = await httpClient.PostAsync("https://localhost:44315/api/Weather/PutCityByName", content);

                string responseJson = await responseMessage.Content.ReadAsStringAsync();

                if (responseMessage.StatusCode == HttpStatusCode.OK)
                {
                    MessageBox.Show("YEP");
                }
                else
                {
                    string error = JsonConvert.DeserializeObject<string>(responseJson);
                    MessageBox.Show((int)responseMessage.StatusCode + "  " + responseMessage.Content + error);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "ПРИЛЯГ ПОСПИ");
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HttpClient httpClient = new HttpClient();

                string data = JsonConvert.SerializeObject(true);

                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");

                HttpResponseMessage responseMessage = await httpClient.PostAsync("https://localhost:44315/api/Weather/GetException", content);

                string responseJson = await responseMessage.Content.ReadAsStringAsync();

                if (responseMessage.StatusCode == HttpStatusCode.OK)
                {
                    WeatherData wd = JsonConvert.DeserializeObject<WeatherData>(responseJson);

                    MessageBox.Show(wd.CityName + " --- " + wd.Temperature);
                }
                else
                {
                    string error = JsonConvert.DeserializeObject<string>(responseJson);
                    MessageBox.Show((int)responseMessage.StatusCode + "  " + responseMessage.Content + error);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "SERVER ERROR");
            }
        }
    }
}