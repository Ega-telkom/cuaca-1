using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace cuaca_1
{
    public partial class Form1 : Form
    {
        public class GeoLocation
        {
            public string name { get; set; }
            public string lat { get; set; }
            public string lon { get; set; }
            public string country { get; set; }
            public string state { get; set; }

            public override string ToString()
            {
                return $"{name}, {state ?? "-"}, {country}";
            }
        }

        private static readonly HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private async void btnGetWeather_Click(object sender, EventArgs e)
        {
            string api = txtApiKey.Text.Trim();
            string lat = txtLat.Text.Trim();
            string lon = txtLong.Text.Trim();

            if (string.IsNullOrEmpty(api))
            {
                MessageBox.Show("Masukan Kunci API terlebih dahulu");
                return;
            }

            if (string.IsNullOrEmpty(lat) || string.IsNullOrEmpty(lon))
            {
                MessageBox.Show("Masukan Koordinatnya terlebih dahulu");
                return;
            }

            await GetWeatherData(lat, lon, api);
        }

        private async Task GetWeatherData(string lat, string lon, string api)
        {
            try
            {
                string url = $"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&units=metric&lang=id&appid={api}";
                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var responseBody = await response.Content.ReadAsStringAsync();
                JObject weatherData = JObject.Parse(responseBody);

                string kota = weatherData["name"]?.ToString();
                string suhu = weatherData["main"]["temp"]?.ToString();
                string terasa = weatherData["main"]["feels_like"]?.ToString();
                string kelembapan = weatherData["main"]["humidity"]?.ToString();
                string tekanan = weatherData["main"]["pressure"]?.ToString();
                string visibilitas = weatherData["visibility"]?.ToString();
                string arah_angin = weatherData["wind"]["deg"]?.ToString();
                string kecepatan_angin = weatherData["wind"]["speed"]?.ToString();
                string awan = weatherData["clouds"]["all"]?.ToString();
                string cuaca = weatherData["weather"]?[0]?["description"]?.ToString();

                labelKota.Text = $"{kota}";
                labelTemp.Text = $"{suhu} °C";
                labelCuaca.Text = $"{cuaca}";

                txtResult.Text = $"Terasa Seperti\t :{terasa} °C\r\n" +
                    $"Kelembapan\t :{kelembapan}%\r\n" +
                    $"Tekanan\t\t :{tekanan} hPa\r\n" +
                    $"Visibilitas\t :{visibilitas} km\r\n" +
                    $"Arah Angin\t :{arah_angin}°\r\n" +
                    $"Kecepatan Angin\t :{kecepatan_angin} m/d\r\n" +
                    $"Awan\t\t :{awan}%\r\n";
            }
            catch (HttpRequestException httpEx)
            {
                txtResult.Text = $"Galat HTTP: {httpEx.Message}";
            }
            catch (Exception ex)
            {
                txtResult.Text = $"Galat: {ex.Message}";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnGeocode_Click(object sender, EventArgs e)
        {
            string kota = txtKota.Text.Trim();
            string api = txtApiKey.Text.Trim();

            if (string.IsNullOrEmpty(kota) || string.IsNullOrEmpty(api))
            {
                MessageBox.Show("Nama kota dan kunci API harap diisi");
                return;
            }

            var limit = 5;
            string url = $"http://api.openweathermap.org/geo/1.0/direct?q={kota}&limit={limit}&appid={api}";

            try
            {
                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                var lokasi = JsonConvert.DeserializeObject<List<GeoLocation>>(json);

                if (lokasi == null || lokasi.Count == 0)
                {
                    MessageBox.Show("Lokasi tidak dapat ditemukan dimuka bumi ini...");
                    return;
                }

                cmbResult.Items.Clear();
                foreach (var lok in lokasi)
                    cmbResult.Items.Add(lok);

                cmbResult.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void cmbResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbResult.SelectedItem is GeoLocation selectedLocation)
            {
                txtLat.Text = selectedLocation.lat.ToString();
                txtLong.Text = selectedLocation.lon.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string api = txtApiKey.Text.Trim();

            if (string.IsNullOrEmpty(api))
            {
                MessageBox.Show("Kunci API tidak boleh kosong!");
                return;
            }

            Properties.Settings.Default.ApiKey = api;
            Properties.Settings.Default.Save();

            MessageBox.Show("Kunci API berhasil tersimpan!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtApiKey.Text = Properties.Settings.Default.ApiKey;
        }

        private void labelTemp_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelKota_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void txtKota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;       // Optional: suppress the beep
                e.SuppressKeyPress = true;

                // Trigger your city search button click manually
                btnGeocode.PerformClick();
            }
        }

        private void txtApiKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;       // Optional: suppress the beep
                e.SuppressKeyPress = true;

                // Trigger your city search button click manually
                btnSaveAPI.PerformClick();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://home.openweathermap.org/users/sign_in", // or your dynamic URL
                UseShellExecute = true // important for .NET Core / .NET 5+
            });
        }
    }
}
