﻿namespace IPRangeScanner
{
    partial class MainGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGUI));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.currentIPLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.toIP3 = new System.Windows.Forms.NumericUpDown();
            this.toIP2 = new System.Windows.Forms.NumericUpDown();
            this.toIP1 = new System.Windows.Forms.NumericUpDown();
            this.toIP0 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.fromIP3 = new System.Windows.Forms.NumericUpDown();
            this.fromIP2 = new System.Windows.Forms.NumericUpDown();
            this.fromIP1 = new System.Windows.Forms.NumericUpDown();
            this.fromIP0 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.scanButton = new System.Windows.Forms.Button();
            this.numberOfIPs = new System.Windows.Forms.Label();
            this.timeoutNumberUpDown = new System.Windows.Forms.NumericUpDown();
            this.timeoutLabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toIP3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toIP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toIP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toIP0)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fromIP3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromIP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromIP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromIP0)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeoutNumberUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.currentIPLabel);
            this.flowLayoutPanel3.Controls.Add(this.progressBar1);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 133);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(278, 59);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // currentIPLabel
            // 
            this.currentIPLabel.AutoSize = true;
            this.currentIPLabel.Location = new System.Drawing.Point(3, 0);
            this.currentIPLabel.Name = "currentIPLabel";
            this.currentIPLabel.Size = new System.Drawing.Size(80, 13);
            this.currentIPLabel.TabIndex = 1;
            this.currentIPLabel.Text = "Current IP: N/A";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 16);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(268, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.toIP3);
            this.flowLayoutPanel2.Controls.Add(this.toIP2);
            this.flowLayoutPanel2.Controls.Add(this.toIP1);
            this.flowLayoutPanel2.Controls.Add(this.toIP0);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 68);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(278, 59);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // toIP3
            // 
            this.toIP3.Location = new System.Drawing.Point(3, 3);
            this.toIP3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.toIP3.Name = "toIP3";
            this.toIP3.Size = new System.Drawing.Size(55, 20);
            this.toIP3.TabIndex = 1;
            this.toIP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toIP3.Enter += new System.EventHandler(this.toIP3_Enter);
            // 
            // toIP2
            // 
            this.toIP2.Location = new System.Drawing.Point(64, 3);
            this.toIP2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.toIP2.Name = "toIP2";
            this.toIP2.Size = new System.Drawing.Size(65, 20);
            this.toIP2.TabIndex = 2;
            this.toIP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toIP2.Enter += new System.EventHandler(this.toIP2_Enter);
            // 
            // toIP1
            // 
            this.toIP1.Location = new System.Drawing.Point(135, 3);
            this.toIP1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.toIP1.Name = "toIP1";
            this.toIP1.Size = new System.Drawing.Size(65, 20);
            this.toIP1.TabIndex = 2;
            this.toIP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toIP1.Enter += new System.EventHandler(this.toIP1_Enter);
            // 
            // toIP0
            // 
            this.toIP0.Location = new System.Drawing.Point(206, 3);
            this.toIP0.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.toIP0.Name = "toIP0";
            this.toIP0.Size = new System.Drawing.Size(65, 20);
            this.toIP0.TabIndex = 3;
            this.toIP0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toIP0.Enter += new System.EventHandler(this.toIP0_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "--End IP--";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.fromIP3);
            this.flowLayoutPanel1.Controls.Add(this.fromIP2);
            this.flowLayoutPanel1.Controls.Add(this.fromIP1);
            this.flowLayoutPanel1.Controls.Add(this.fromIP0);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(278, 59);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // fromIP3
            // 
            this.fromIP3.Location = new System.Drawing.Point(3, 3);
            this.fromIP3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.fromIP3.Name = "fromIP3";
            this.fromIP3.Size = new System.Drawing.Size(55, 20);
            this.fromIP3.TabIndex = 0;
            this.fromIP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fromIP3.ValueChanged += new System.EventHandler(this.fromIP3_ValueChanged);
            this.fromIP3.Enter += new System.EventHandler(this.fromIP3_Enter);
            // 
            // fromIP2
            // 
            this.fromIP2.Location = new System.Drawing.Point(64, 3);
            this.fromIP2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.fromIP2.Name = "fromIP2";
            this.fromIP2.Size = new System.Drawing.Size(65, 20);
            this.fromIP2.TabIndex = 1;
            this.fromIP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fromIP2.ValueChanged += new System.EventHandler(this.fromIP2_ValueChanged);
            this.fromIP2.Enter += new System.EventHandler(this.fromIP2_Enter);
            // 
            // fromIP1
            // 
            this.fromIP1.Location = new System.Drawing.Point(135, 3);
            this.fromIP1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.fromIP1.Name = "fromIP1";
            this.fromIP1.Size = new System.Drawing.Size(65, 20);
            this.fromIP1.TabIndex = 2;
            this.fromIP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fromIP1.ValueChanged += new System.EventHandler(this.fromIP1_ValueChanged);
            this.fromIP1.Enter += new System.EventHandler(this.fromIP1_Enter);
            // 
            // fromIP0
            // 
            this.fromIP0.Location = new System.Drawing.Point(206, 3);
            this.fromIP0.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.fromIP0.Name = "fromIP0";
            this.fromIP0.Size = new System.Drawing.Size(65, 20);
            this.fromIP0.TabIndex = 3;
            this.fromIP0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fromIP0.ValueChanged += new System.EventHandler(this.fromIP0_ValueChanged);
            this.fromIP0.Enter += new System.EventHandler(this.fromIP0_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "--Start IP--";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.scanButton);
            this.flowLayoutPanel4.Controls.Add(this.numberOfIPs);
            this.flowLayoutPanel4.Controls.Add(this.timeoutNumberUpDown);
            this.flowLayoutPanel4.Controls.Add(this.timeoutLabel);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 198);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(278, 60);
            this.flowLayoutPanel4.TabIndex = 3;
            this.flowLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel4_Paint);
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(3, 3);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(75, 23);
            this.scanButton.TabIndex = 4;
            this.scanButton.Text = "Scan";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // numberOfIPs
            // 
            this.numberOfIPs.AutoSize = true;
            this.numberOfIPs.Location = new System.Drawing.Point(3, 29);
            this.numberOfIPs.Name = "numberOfIPs";
            this.numberOfIPs.Size = new System.Drawing.Size(58, 13);
            this.numberOfIPs.TabIndex = 5;
            this.numberOfIPs.Text = "IPs Found:";
            // 
            // timeoutNumberUpDown
            // 
            this.timeoutNumberUpDown.Location = new System.Drawing.Point(84, 3);
            this.timeoutNumberUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.timeoutNumberUpDown.Name = "timeoutNumberUpDown";
            this.timeoutNumberUpDown.Size = new System.Drawing.Size(120, 20);
            this.timeoutNumberUpDown.TabIndex = 6;
            this.timeoutNumberUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeoutNumberUpDown.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.timeoutNumberUpDown.ValueChanged += new System.EventHandler(this.timeoutNumberUpDown_ValueChanged);
            // 
            // timeoutLabel
            // 
            this.timeoutLabel.AutoSize = true;
            this.timeoutLabel.Location = new System.Drawing.Point(84, 26);
            this.timeoutLabel.Name = "timeoutLabel";
            this.timeoutLabel.Size = new System.Drawing.Size(113, 13);
            this.timeoutLabel.TabIndex = 7;
            this.timeoutLabel.Text = "-- Timeout Threshold --";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "MainGUI";
            this.Text = "IPRangeScanner";
            this.Load += new System.EventHandler(this.MainGUI_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toIP3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toIP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toIP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toIP0)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fromIP3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromIP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromIP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromIP0)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeoutNumberUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        

        

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.NumericUpDown toIP1;
        private System.Windows.Forms.NumericUpDown toIP0;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NumericUpDown fromIP2;
        private System.Windows.Forms.NumericUpDown fromIP1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button scanButton;
        public System.Windows.Forms.NumericUpDown fromIP3;
        public System.Windows.Forms.NumericUpDown fromIP0;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown toIP3;
        private System.Windows.Forms.NumericUpDown toIP2;
        private System.Windows.Forms.Label currentIPLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label numberOfIPs;
        private System.Windows.Forms.NumericUpDown timeoutNumberUpDown;
        private System.Windows.Forms.Label timeoutLabel;
    }
}

