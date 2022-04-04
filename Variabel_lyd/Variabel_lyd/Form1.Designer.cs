namespace Variabel_lyd
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.trackBarFrequency = new System.Windows.Forms.TrackBar();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.btnPause = new System.Windows.Forms.Button();
            this.trackBarWaveShape = new System.Windows.Forms.TrackBar();
            this.btnUpdateGraph = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbChooseWave = new System.Windows.Forms.ComboBox();
            this.lblHz = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.btnAddSine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWaveShape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(21, 103);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(102, 103);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // trackBarFrequency
            // 
            this.trackBarFrequency.Location = new System.Drawing.Point(12, 12);
            this.trackBarFrequency.Maximum = 100;
            this.trackBarFrequency.Name = "trackBarFrequency";
            this.trackBarFrequency.Size = new System.Drawing.Size(260, 45);
            this.trackBarFrequency.TabIndex = 2;
            this.trackBarFrequency.Value = 20;
            this.trackBarFrequency.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(12, 52);
            this.trackBarVolume.Maximum = 1000;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(260, 45);
            this.trackBarVolume.TabIndex = 3;
            this.trackBarVolume.Value = 100;
            this.trackBarVolume.ValueChanged += new System.EventHandler(this.trackBarVolume_ValueChanged);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(183, 103);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // trackBarWaveShape
            // 
            this.trackBarWaveShape.Location = new System.Drawing.Point(12, 141);
            this.trackBarWaveShape.Maximum = 1000;
            this.trackBarWaveShape.Name = "trackBarWaveShape";
            this.trackBarWaveShape.Size = new System.Drawing.Size(260, 45);
            this.trackBarWaveShape.TabIndex = 5;
            this.trackBarWaveShape.Value = 100;
            this.trackBarWaveShape.ValueChanged += new System.EventHandler(this.trackBarWaveShape_ValueChanged);
            // 
            // btnUpdateGraph
            // 
            this.btnUpdateGraph.Location = new System.Drawing.Point(102, 287);
            this.btnUpdateGraph.Name = "btnUpdateGraph";
            this.btnUpdateGraph.Size = new System.Drawing.Size(120, 23);
            this.btnUpdateGraph.TabIndex = 6;
            this.btnUpdateGraph.Text = "UpdateGraph";
            this.btnUpdateGraph.UseVisualStyleBackColor = true;
            this.btnUpdateGraph.Click += new System.EventHandler(this.btnUpdatewaveShape_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(346, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(647, 300);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // cmbChooseWave
            // 
            this.cmbChooseWave.FormattingEnabled = true;
            this.cmbChooseWave.Items.AddRange(new object[] {
            "Customwave",
            "SineWave",
            "Squarewave",
            "trianglewave",
            "combinedSine",
            "MultipleSineWaves"});
            this.cmbChooseWave.Location = new System.Drawing.Point(81, 186);
            this.cmbChooseWave.Name = "cmbChooseWave";
            this.cmbChooseWave.Size = new System.Drawing.Size(96, 21);
            this.cmbChooseWave.TabIndex = 9;
            this.cmbChooseWave.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblHz
            // 
            this.lblHz.AutoSize = true;
            this.lblHz.Location = new System.Drawing.Point(278, 23);
            this.lblHz.Name = "lblHz";
            this.lblHz.Size = new System.Drawing.Size(20, 13);
            this.lblHz.TabIndex = 10;
            this.lblHz.Text = "Hz";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(278, 63);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(20, 13);
            this.lblVolume.TabIndex = 11;
            this.lblVolume.Text = "dB";
            // 
            // btnAddSine
            // 
            this.btnAddSine.Location = new System.Drawing.Point(183, 184);
            this.btnAddSine.Name = "btnAddSine";
            this.btnAddSine.Size = new System.Drawing.Size(75, 23);
            this.btnAddSine.TabIndex = 12;
            this.btnAddSine.Text = "btnAddSine";
            this.btnAddSine.UseVisualStyleBackColor = true;
            this.btnAddSine.Click += new System.EventHandler(this.btnAddSine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Bølgetype:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddSine);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblHz);
            this.Controls.Add(this.cmbChooseWave);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnUpdateGraph);
            this.Controls.Add(this.trackBarWaveShape);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.trackBarFrequency);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWaveShape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TrackBar trackBarFrequency;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.TrackBar trackBarWaveShape;
        private System.Windows.Forms.Button btnUpdateGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox cmbChooseWave;
        private System.Windows.Forms.Label lblHz;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button btnAddSine;
        private System.Windows.Forms.Label label1;
    }
}

