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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txtApiKey
            // 
            txtApiKey.Location = new Point(6, 21);
            txtApiKey.Margin = new Padding(3, 2, 3, 2);
            txtApiKey.Name = "txtApiKey";
            txtApiKey.PasswordChar = '*';
            txtApiKey.PlaceholderText = "Kunci API openweathermap.org";
            txtApiKey.Size = new Size(364, 23);
            txtApiKey.TabIndex = 0;
            txtApiKey.KeyDown += txtApiKey_KeyDown;
            // 
            // txtLat
            // 
            txtLat.Location = new Point(6, 92);
            txtLat.Margin = new Padding(3, 2, 3, 2);
            txtLat.Name = "txtLat";
            txtLat.PlaceholderText = "Latitude";
            txtLat.Size = new Size(110, 23);
            txtLat.TabIndex = 1;
            // 
            // txtLong
            // 
            txtLong.Location = new Point(122, 92);
            txtLong.Margin = new Padding(3, 2, 3, 2);
            txtLong.Name = "txtLong";
            txtLong.PlaceholderText = "Longitude";
            txtLong.Size = new Size(110, 23);
            txtLong.TabIndex = 2;
            // 
            // btnGetWeather
            // 
            btnGetWeather.Location = new Point(6, 130);
            btnGetWeather.Margin = new Padding(3, 2, 3, 2);
            btnGetWeather.Name = "btnGetWeather";
            btnGetWeather.Size = new Size(173, 22);
            btnGetWeather.TabIndex = 3;
            btnGetWeather.Text = "Dapatkan Data Cuaca";
            btnGetWeather.UseVisualStyleBackColor = true;
            btnGetWeather.Click += btnGetWeather_Click;
            // 
            // labelTemp
            // 
            labelTemp.AutoSize = true;
            labelTemp.Font = new Font("Segoe UI Semilight", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTemp.Location = new Point(6, 40);
            labelTemp.Name = "labelTemp";
            labelTemp.Size = new Size(53, 45);
            labelTemp.TabIndex = 4;
            labelTemp.Text = "-.-";
            labelTemp.Click += labelTemp_Click;
            // 
            // labelCuaca
            // 
            labelCuaca.AutoSize = true;
            labelCuaca.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCuaca.Location = new Point(6, 85);
            labelCuaca.Name = "labelCuaca";
            labelCuaca.Size = new Size(39, 32);
            labelCuaca.TabIndex = 5;
            labelCuaca.Text = "-.-";
            // 
            // txtResult
            // 
            txtResult.AcceptsReturn = true;
            txtResult.AcceptsTab = true;
            txtResult.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResult.Location = new Point(6, 119);
            txtResult.Margin = new Padding(3, 2, 3, 2);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.ScrollBars = ScrollBars.Vertical;
            txtResult.Size = new Size(456, 229);
            txtResult.TabIndex = 6;
            txtResult.WordWrap = false;
            // 
            // labelKota
            // 
            labelKota.AutoSize = true;
            labelKota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelKota.Location = new Point(6, 19);
            labelKota.Name = "labelKota";
            labelKota.Size = new Size(25, 21);
            labelKota.TabIndex = 7;
            labelKota.Text = "-.-";
            labelKota.Click += labelKota_Click;
            // 
            // txtKota
            // 
            txtKota.Location = new Point(6, 21);
            txtKota.Margin = new Padding(3, 2, 3, 2);
            txtKota.Name = "txtKota";
            txtKota.PlaceholderText = "Nama Tempat";
            txtKota.Size = new Size(208, 23);
            txtKota.TabIndex = 8;
            txtKota.TextChanged += textBox1_TextChanged;
            txtKota.KeyDown += txtKota_KeyDown;
            // 
            // btnGeocode
            // 
            btnGeocode.Location = new Point(220, 22);
            btnGeocode.Margin = new Padding(3, 2, 3, 2);
            btnGeocode.Name = "btnGeocode";
            btnGeocode.Size = new Size(48, 22);
            btnGeocode.TabIndex = 9;
            btnGeocode.Text = "Cari";
            btnGeocode.UseVisualStyleBackColor = true;
            btnGeocode.Click += btnGeocode_Click;
            // 
            // cmbResult
            // 
            cmbResult.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbResult.FormattingEnabled = true;
            cmbResult.Location = new Point(6, 54);
            cmbResult.Margin = new Padding(3, 2, 3, 2);
            cmbResult.Name = "cmbResult";
            cmbResult.Size = new Size(208, 23);
            cmbResult.TabIndex = 10;
            cmbResult.SelectedIndexChanged += cmbResult_SelectedIndexChanged;
            // 
            // btnSaveAPI
            // 
            btnSaveAPI.Location = new Point(376, 20);
            btnSaveAPI.Margin = new Padding(3, 2, 3, 2);
            btnSaveAPI.Name = "btnSaveAPI";
            btnSaveAPI.Size = new Size(82, 22);
            btnSaveAPI.TabIndex = 11;
            btnSaveAPI.Text = "Simpan API";
            btnSaveAPI.UseVisualStyleBackColor = true;
            btnSaveAPI.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtApiKey);
            groupBox1.Controls.Add(btnSaveAPI);
            groupBox1.Location = new Point(21, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(483, 59);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kunci API";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtLat);
            groupBox2.Controls.Add(txtLong);
            groupBox2.Controls.Add(cmbResult);
            groupBox2.Controls.Add(btnGetWeather);
            groupBox2.Controls.Add(txtKota);
            groupBox2.Controls.Add(btnGeocode);
            groupBox2.Location = new Point(21, 77);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(483, 177);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cari Lokasi";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(labelTemp);
            groupBox3.Controls.Add(labelKota);
            groupBox3.Controls.Add(labelCuaca);
            groupBox3.Controls.Add(txtResult);
            groupBox3.Location = new Point(21, 260);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(483, 362);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cuaca";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 634);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Cuaca";
            Load += Form1_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
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
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}
