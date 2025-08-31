namespace cuaca_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtApiKey = new TextBox();
            txtLat = new TextBox();
            txtLong = new TextBox();
            btnGetWeather = new Button();
            labelTemp = new Label();
            labelCuaca = new Label();
            txtResult = new TextBox();
            labelKota = new Label();
            txtKota = new TextBox();
            btnGeocode = new Button();
            cmbResult = new ComboBox();
            btnSaveAPI = new Button();
            SuspendLayout();
            // 
            // txtApiKey
            // 
            txtApiKey.Location = new Point(24, 24);
            txtApiKey.Name = "txtApiKey";
            txtApiKey.PasswordChar = '*';
            txtApiKey.PlaceholderText = "Kunci API openweathermap.org";
            txtApiKey.Size = new Size(416, 27);
            txtApiKey.TabIndex = 0;
            // 
            // txtLat
            // 
            txtLat.Location = new Point(24, 57);
            txtLat.Name = "txtLat";
            txtLat.PlaceholderText = "Latitude";
            txtLat.Size = new Size(125, 27);
            txtLat.TabIndex = 1;
            // 
            // txtLong
            // 
            txtLong.Location = new Point(155, 57);
            txtLong.Name = "txtLong";
            txtLong.PlaceholderText = "Longitude";
            txtLong.Size = new Size(125, 27);
            txtLong.TabIndex = 2;
            // 
            // btnGetWeather
            // 
            btnGetWeather.Location = new Point(24, 117);
            btnGetWeather.Name = "btnGetWeather";
            btnGetWeather.Size = new Size(198, 29);
            btnGetWeather.TabIndex = 3;
            btnGetWeather.Text = "Dapatkan Data Cuaca";
            btnGetWeather.UseVisualStyleBackColor = true;
            btnGetWeather.Click += btnGetWeather_Click;
            // 
            // labelTemp
            // 
            labelTemp.AutoSize = true;
            labelTemp.Font = new Font("Segoe UI Semilight", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTemp.Location = new Point(24, 206);
            labelTemp.Name = "labelTemp";
            labelTemp.Size = new Size(64, 54);
            labelTemp.TabIndex = 4;
            labelTemp.Text = "-.-";
            labelTemp.Click += labelTemp_Click;
            // 
            // labelCuaca
            // 
            labelCuaca.AutoSize = true;
            labelCuaca.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCuaca.Location = new Point(24, 260);
            labelCuaca.Name = "labelCuaca";
            labelCuaca.Size = new Size(49, 41);
            labelCuaca.TabIndex = 5;
            labelCuaca.Text = "-.-";
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResult.Location = new Point(24, 322);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(520, 113);
            txtResult.TabIndex = 6;
            // 
            // labelKota
            // 
            labelKota.AutoSize = true;
            labelKota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelKota.Location = new Point(24, 174);
            labelKota.Name = "labelKota";
            labelKota.Size = new Size(32, 28);
            labelKota.TabIndex = 7;
            labelKota.Text = "-.-";
            // 
            // txtKota
            // 
            txtKota.Location = new Point(307, 57);
            txtKota.Name = "txtKota";
            txtKota.PlaceholderText = "Nama Tempat";
            txtKota.Size = new Size(237, 27);
            txtKota.TabIndex = 8;
            txtKota.TextChanged += textBox1_TextChanged;
            // 
            // btnGeocode
            // 
            btnGeocode.Location = new Point(307, 90);
            btnGeocode.Name = "btnGeocode";
            btnGeocode.Size = new Size(237, 29);
            btnGeocode.TabIndex = 9;
            btnGeocode.Text = "Cari Tempat";
            btnGeocode.UseVisualStyleBackColor = true;
            btnGeocode.Click += btnGeocode_Click;
            // 
            // cmbResult
            // 
            cmbResult.FormattingEnabled = true;
            cmbResult.Location = new Point(307, 125);
            cmbResult.Name = "cmbResult";
            cmbResult.Size = new Size(237, 28);
            cmbResult.TabIndex = 10;
            cmbResult.SelectedIndexChanged += cmbResult_SelectedIndexChanged;
            // 
            // btnSaveAPI
            // 
            btnSaveAPI.Location = new Point(450, 24);
            btnSaveAPI.Name = "btnSaveAPI";
            btnSaveAPI.Size = new Size(94, 29);
            btnSaveAPI.TabIndex = 11;
            btnSaveAPI.Text = "Simpan API";
            btnSaveAPI.UseVisualStyleBackColor = true;
            btnSaveAPI.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 470);
            Controls.Add(btnSaveAPI);
            Controls.Add(cmbResult);
            Controls.Add(btnGeocode);
            Controls.Add(txtKota);
            Controls.Add(labelKota);
            Controls.Add(txtResult);
            Controls.Add(labelCuaca);
            Controls.Add(labelTemp);
            Controls.Add(btnGetWeather);
            Controls.Add(txtLong);
            Controls.Add(txtLat);
            Controls.Add(txtApiKey);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtApiKey;
        private TextBox txtLat;
        private TextBox txtLong;
        private Button btnGetWeather;
        private Label labelTemp;
        private Label labelCuaca;
        private TextBox txtResult;
        private Label labelKota;
        private TextBox txtKota;
        private Button btnGeocode;
        private ComboBox cmbResult;
        private Button btnSaveAPI;
    }
}
