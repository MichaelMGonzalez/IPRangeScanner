namespace IPRangeScanner
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.toIP3 = new System.Windows.Forms.NumericUpDown();
            this.toIP2 = new System.Windows.Forms.NumericUpDown();
            this.toIP1 = new System.Windows.Forms.NumericUpDown();
            this.toIP0 = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.fromIP0 = new System.Windows.Forms.NumericUpDown();
            this.fromIP1 = new System.Windows.Forms.NumericUpDown();
            this.fromIP2 = new System.Windows.Forms.NumericUpDown();
            this.fromIP3 = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toIP3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toIP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toIP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toIP0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromIP0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromIP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromIP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromIP3)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.toIP3);
            this.flowLayoutPanel3.Controls.Add(this.toIP2);
            this.flowLayoutPanel3.Controls.Add(this.toIP1);
            this.flowLayoutPanel3.Controls.Add(this.toIP0);
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 133);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(278, 59);
            this.flowLayoutPanel3.TabIndex = 2;
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
            this.toIP3.TabIndex = 0;
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
            this.toIP2.TabIndex = 1;
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
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 68);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(278, 59);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "--Start IP--";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "--End IP--";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Scan";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "IPRangeScanner";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toIP3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toIP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toIP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toIP0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromIP0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromIP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromIP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromIP3)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.NumericUpDown toIP3;
        private System.Windows.Forms.NumericUpDown toIP2;
        private System.Windows.Forms.NumericUpDown toIP1;
        private System.Windows.Forms.NumericUpDown toIP0;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NumericUpDown fromIP3;
        private System.Windows.Forms.NumericUpDown fromIP2;
        private System.Windows.Forms.NumericUpDown fromIP1;
        private System.Windows.Forms.NumericUpDown fromIP0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

