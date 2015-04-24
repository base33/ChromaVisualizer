namespace ChromaVisualizer
{
    partial class ChromaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deviceList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.do_StartStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_createGradient = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cGradient6 = new System.Windows.Forms.PictureBox();
            this.cGradient5 = new System.Windows.Forms.PictureBox();
            this.cGradient4 = new System.Windows.Forms.PictureBox();
            this.cGradient3 = new System.Windows.Forms.PictureBox();
            this.cGradient2 = new System.Windows.Forms.PictureBox();
            this.cGradient1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.colorMode = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.spectrumSensitivity = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.presetList = new System.Windows.Forms.ComboBox();
            this.pGradient6 = new System.Windows.Forms.PictureBox();
            this.pGradient3 = new System.Windows.Forms.PictureBox();
            this.pGradient5 = new System.Windows.Forms.PictureBox();
            this.pGradient1 = new System.Windows.Forms.PictureBox();
            this.pGradient4 = new System.Windows.Forms.PictureBox();
            this.pGradient2 = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cGradient7 = new System.Windows.Forms.PictureBox();
            this.btnGradientSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cGradient6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cGradient5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cGradient4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cGradient3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cGradient2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cGradient1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGradient6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGradient3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGradient5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGradient1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGradient4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGradient2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cGradient7)).BeginInit();
            this.SuspendLayout();
            // 
            // deviceList
            // 
            this.deviceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceList.FormattingEnabled = true;
            this.deviceList.Location = new System.Drawing.Point(89, 19);
            this.deviceList.Name = "deviceList";
            this.deviceList.Size = new System.Drawing.Size(318, 21);
            this.deviceList.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar2);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.do_StartStop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.deviceList);
            this.groupBox1.Location = new System.Drawing.Point(6, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Audio Settings";
            // 
            // progressBar2
            // 
            this.progressBar2.Enabled = false;
            this.progressBar2.Location = new System.Drawing.Point(89, 75);
            this.progressBar2.MarqueeAnimationSpeed = 0;
            this.progressBar2.Maximum = 32768;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(318, 23);
            this.progressBar2.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Enabled = false;
            this.progressBar1.Location = new System.Drawing.Point(89, 46);
            this.progressBar1.MarqueeAnimationSpeed = 0;
            this.progressBar1.Maximum = 32768;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(318, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // do_StartStop
            // 
            this.do_StartStop.Location = new System.Drawing.Point(8, 45);
            this.do_StartStop.Name = "do_StartStop";
            this.do_StartStop.Size = new System.Drawing.Size(75, 23);
            this.do_StartStop.TabIndex = 3;
            this.do_StartStop.Text = "Start / Stop";
            this.do_StartStop.UseVisualStyleBackColor = true;
            this.do_StartStop.Click += new System.EventHandler(this.do_StartStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Device:";
            // 
            // btn_createGradient
            // 
            this.btn_createGradient.Location = new System.Drawing.Point(201, 83);
            this.btn_createGradient.Name = "btn_createGradient";
            this.btn_createGradient.Size = new System.Drawing.Size(104, 21);
            this.btn_createGradient.TabIndex = 6;
            this.btn_createGradient.Text = "Create Gradient ...";
            this.btn_createGradient.UseVisualStyleBackColor = true;
            this.btn_createGradient.Click += new System.EventHandler(this.btn_createGradient_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Info: Click on a Color to show a Color Picker.\r\nPress the Gradient button will ge" +
    "nerate a gradient from the first and latest color.";
            // 
            // cGradient6
            // 
            this.cGradient6.BackColor = System.Drawing.Color.Black;
            this.cGradient6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cGradient6.Location = new System.Drawing.Point(366, 42);
            this.cGradient6.Name = "cGradient6";
            this.cGradient6.Size = new System.Drawing.Size(30, 30);
            this.cGradient6.TabIndex = 5;
            this.cGradient6.TabStop = false;
            this.cGradient6.Click += new System.EventHandler(this.colorDialog_click);
            // 
            // cGradient5
            // 
            this.cGradient5.BackColor = System.Drawing.Color.Black;
            this.cGradient5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cGradient5.Location = new System.Drawing.Point(311, 42);
            this.cGradient5.Name = "cGradient5";
            this.cGradient5.Size = new System.Drawing.Size(30, 30);
            this.cGradient5.TabIndex = 4;
            this.cGradient5.TabStop = false;
            this.cGradient5.Click += new System.EventHandler(this.colorDialog_click);
            // 
            // cGradient4
            // 
            this.cGradient4.BackColor = System.Drawing.Color.Black;
            this.cGradient4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cGradient4.Location = new System.Drawing.Point(256, 42);
            this.cGradient4.Name = "cGradient4";
            this.cGradient4.Size = new System.Drawing.Size(30, 30);
            this.cGradient4.TabIndex = 3;
            this.cGradient4.TabStop = false;
            this.cGradient4.Click += new System.EventHandler(this.colorDialog_click);
            // 
            // cGradient3
            // 
            this.cGradient3.BackColor = System.Drawing.Color.Black;
            this.cGradient3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cGradient3.Location = new System.Drawing.Point(201, 42);
            this.cGradient3.Name = "cGradient3";
            this.cGradient3.Size = new System.Drawing.Size(30, 30);
            this.cGradient3.TabIndex = 2;
            this.cGradient3.TabStop = false;
            this.cGradient3.Click += new System.EventHandler(this.colorDialog_click);
            // 
            // cGradient2
            // 
            this.cGradient2.BackColor = System.Drawing.Color.Black;
            this.cGradient2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cGradient2.Location = new System.Drawing.Point(146, 42);
            this.cGradient2.Name = "cGradient2";
            this.cGradient2.Size = new System.Drawing.Size(30, 30);
            this.cGradient2.TabIndex = 1;
            this.cGradient2.TabStop = false;
            this.cGradient2.Click += new System.EventHandler(this.colorDialog_click);
            // 
            // cGradient1
            // 
            this.cGradient1.BackColor = System.Drawing.Color.Black;
            this.cGradient1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cGradient1.Location = new System.Drawing.Point(91, 42);
            this.cGradient1.Name = "cGradient1";
            this.cGradient1.Size = new System.Drawing.Size(30, 30);
            this.cGradient1.TabIndex = 0;
            this.cGradient1.TabStop = false;
            this.cGradient1.Click += new System.EventHandler(this.colorDialog_click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(6, 132);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(413, 149);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.colorMode);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.spectrumSensitivity);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(405, 123);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Spectrum Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(266, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Info: Settings will be saved and auto loaded on startup.";
            // 
            // colorMode
            // 
            this.colorMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorMode.FormattingEnabled = true;
            this.colorMode.Items.AddRange(new object[] {
            "Preset",
            "Gradient"});
            this.colorMode.Location = new System.Drawing.Point(152, 34);
            this.colorMode.Name = "colorMode";
            this.colorMode.Size = new System.Drawing.Size(141, 21);
            this.colorMode.TabIndex = 3;
            this.colorMode.SelectedIndexChanged += new System.EventHandler(this.colorMode_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Color Mode:";
            // 
            // spectrumSensitivity
            // 
            this.spectrumSensitivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.spectrumSensitivity.FormattingEnabled = true;
            this.spectrumSensitivity.Items.AddRange(new object[] {
            "High",
            "Default",
            "Low"});
            this.spectrumSensitivity.Location = new System.Drawing.Point(152, 6);
            this.spectrumSensitivity.Name = "spectrumSensitivity";
            this.spectrumSensitivity.Size = new System.Drawing.Size(141, 21);
            this.spectrumSensitivity.TabIndex = 1;
            this.spectrumSensitivity.SelectedIndexChanged += new System.EventHandler(this.spectrumSensitivity_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Spectrum Sensitivity ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.presetList);
            this.tabPage2.Controls.Add(this.pGradient6);
            this.tabPage2.Controls.Add(this.pGradient3);
            this.tabPage2.Controls.Add(this.pGradient5);
            this.tabPage2.Controls.Add(this.pGradient1);
            this.tabPage2.Controls.Add(this.pGradient4);
            this.tabPage2.Controls.Add(this.pGradient2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(405, 123);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Presets";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(225, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Description:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(225, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Author:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(189, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Info: The Presets labeld with + are default inserted presets.";
            // 
            // presetList
            // 
            this.presetList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.presetList.FormattingEnabled = true;
            this.presetList.Location = new System.Drawing.Point(6, 35);
            this.presetList.Name = "presetList";
            this.presetList.Size = new System.Drawing.Size(177, 21);
            this.presetList.TabIndex = 12;
            this.presetList.SelectedIndexChanged += new System.EventHandler(this.presetList_SelectedIndexChanged);
            // 
            // pGradient6
            // 
            this.pGradient6.BackColor = System.Drawing.Color.Black;
            this.pGradient6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pGradient6.Location = new System.Drawing.Point(369, 32);
            this.pGradient6.Name = "pGradient6";
            this.pGradient6.Size = new System.Drawing.Size(30, 30);
            this.pGradient6.TabIndex = 11;
            this.pGradient6.TabStop = false;
            // 
            // pGradient3
            // 
            this.pGradient3.BackColor = System.Drawing.Color.Black;
            this.pGradient3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pGradient3.Location = new System.Drawing.Point(261, 32);
            this.pGradient3.Name = "pGradient3";
            this.pGradient3.Size = new System.Drawing.Size(30, 30);
            this.pGradient3.TabIndex = 8;
            this.pGradient3.TabStop = false;
            // 
            // pGradient5
            // 
            this.pGradient5.BackColor = System.Drawing.Color.Black;
            this.pGradient5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pGradient5.Location = new System.Drawing.Point(333, 32);
            this.pGradient5.Name = "pGradient5";
            this.pGradient5.Size = new System.Drawing.Size(30, 30);
            this.pGradient5.TabIndex = 10;
            this.pGradient5.TabStop = false;
            // 
            // pGradient1
            // 
            this.pGradient1.BackColor = System.Drawing.Color.Black;
            this.pGradient1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pGradient1.Location = new System.Drawing.Point(189, 32);
            this.pGradient1.Name = "pGradient1";
            this.pGradient1.Size = new System.Drawing.Size(30, 30);
            this.pGradient1.TabIndex = 6;
            this.pGradient1.TabStop = false;
            // 
            // pGradient4
            // 
            this.pGradient4.BackColor = System.Drawing.Color.Black;
            this.pGradient4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pGradient4.Location = new System.Drawing.Point(297, 32);
            this.pGradient4.Name = "pGradient4";
            this.pGradient4.Size = new System.Drawing.Size(30, 30);
            this.pGradient4.TabIndex = 9;
            this.pGradient4.TabStop = false;
            // 
            // pGradient2
            // 
            this.pGradient2.BackColor = System.Drawing.Color.Black;
            this.pGradient2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pGradient2.Location = new System.Drawing.Point(225, 32);
            this.pGradient2.Name = "pGradient2";
            this.pGradient2.Size = new System.Drawing.Size(30, 30);
            this.pGradient2.TabIndex = 7;
            this.pGradient2.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGradientSave);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cGradient7);
            this.tabPage1.Controls.Add(this.btn_createGradient);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cGradient6);
            this.tabPage1.Controls.Add(this.cGradient3);
            this.tabPage1.Controls.Add(this.cGradient5);
            this.tabPage1.Controls.Add(this.cGradient1);
            this.tabPage1.Controls.Add(this.cGradient4);
            this.tabPage1.Controls.Add(this.cGradient2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(405, 123);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Custom Gradient";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Row Colors:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Background Color:";
            // 
            // cGradient7
            // 
            this.cGradient7.BackColor = System.Drawing.Color.Black;
            this.cGradient7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cGradient7.Location = new System.Drawing.Point(146, 79);
            this.cGradient7.Name = "cGradient7";
            this.cGradient7.Size = new System.Drawing.Size(30, 30);
            this.cGradient7.TabIndex = 7;
            this.cGradient7.TabStop = false;
            this.cGradient7.Click += new System.EventHandler(this.colorDialog_click);
            // 
            // btnGradientSave
            // 
            this.btnGradientSave.Location = new System.Drawing.Point(311, 83);
            this.btnGradientSave.Name = "btnGradientSave";
            this.btnGradientSave.Size = new System.Drawing.Size(75, 21);
            this.btnGradientSave.TabIndex = 10;
            this.btnGradientSave.Text = "Save ...";
            this.btnGradientSave.UseVisualStyleBackColor = true;
            this.btnGradientSave.Click += new System.EventHandler(this.btnGradientSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(424, 285);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "[v0.32]Chroma Visualizer [keving.eu]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cGradient6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cGradient5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cGradient4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cGradient3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cGradient2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cGradient1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGradient6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGradient3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGradient5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGradient1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGradient4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGradient2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cGradient7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox deviceList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button do_StartStop;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox cGradient6;
        private System.Windows.Forms.PictureBox cGradient5;
        private System.Windows.Forms.PictureBox cGradient4;
        private System.Windows.Forms.PictureBox cGradient3;
        private System.Windows.Forms.PictureBox cGradient2;
        private System.Windows.Forms.PictureBox cGradient1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btn_createGradient;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox presetList;
        private System.Windows.Forms.PictureBox pGradient6;
        private System.Windows.Forms.PictureBox pGradient3;
        private System.Windows.Forms.PictureBox pGradient5;
        private System.Windows.Forms.PictureBox pGradient1;
        private System.Windows.Forms.PictureBox pGradient4;
        private System.Windows.Forms.PictureBox pGradient2;
        private System.Windows.Forms.PictureBox cGradient7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox spectrumSensitivity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox colorMode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGradientSave;

    }
}

