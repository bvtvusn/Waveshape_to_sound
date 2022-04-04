namespace Variabel_lyd
{
    partial class AddSine
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
            this.numPeriods = new System.Windows.Forms.NumericUpDown();
            this.numOffset = new System.Windows.Forms.NumericUpDown();
            this.numAmplitude = new System.Windows.Forms.NumericUpDown();
            this.btnEnter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPeriods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmplitude)).BeginInit();
            this.SuspendLayout();
            // 
            // numPeriods
            // 
            this.numPeriods.Location = new System.Drawing.Point(89, 7);
            this.numPeriods.Name = "numPeriods";
            this.numPeriods.Size = new System.Drawing.Size(61, 20);
            this.numPeriods.TabIndex = 0;
            this.numPeriods.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numOffset
            // 
            this.numOffset.DecimalPlaces = 2;
            this.numOffset.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numOffset.Location = new System.Drawing.Point(89, 59);
            this.numOffset.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOffset.Name = "numOffset";
            this.numOffset.Size = new System.Drawing.Size(61, 20);
            this.numOffset.TabIndex = 1;
            // 
            // numAmplitude
            // 
            this.numAmplitude.DecimalPlaces = 2;
            this.numAmplitude.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numAmplitude.Location = new System.Drawing.Point(89, 33);
            this.numAmplitude.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numAmplitude.Name = "numAmplitude";
            this.numAmplitude.Size = new System.Drawing.Size(61, 20);
            this.numAmplitude.TabIndex = 2;
            this.numAmplitude.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(25, 85);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(125, 23);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "OK";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Perioder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Amplitude";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Offset";
            // 
            // AddSine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 125);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.numAmplitude);
            this.Controls.Add(this.numOffset);
            this.Controls.Add(this.numPeriods);
            this.Name = "AddSine";
            this.Text = "AddSine";
            ((System.ComponentModel.ISupportInitialize)(this.numPeriods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmplitude)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numPeriods;
        private System.Windows.Forms.NumericUpDown numOffset;
        private System.Windows.Forms.NumericUpDown numAmplitude;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}