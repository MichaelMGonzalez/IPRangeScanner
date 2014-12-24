using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPRangeScanner
{
    public partial class MainGUI : Form
    {
        IPRangeScanner scanner = new IPRangeScanner( 0, 0);
        public MainGUI()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void fromIP0_Enter(object sender, System.EventArgs e)
        {
            fromIP0.Select(0, fromIP0.Text.Length);
        }

        private void fromIP1_Enter(object sender, System.EventArgs e)
        {
            fromIP1.Select(0, fromIP1.Text.Length);
        }

        private void fromIP2_Enter(object sender, EventArgs e)
        {
            fromIP2.Select(0, fromIP2.Text.Length);
        }

        private void fromIP3_Enter(object sender, EventArgs e)
        {
            fromIP3.Select(0, fromIP3.Text.Length);
        }

        private void toIP0_Enter(object sender, System.EventArgs e)
        {
            toIP0.Select(0, toIP0.Text.Length);
        }

        private void toIP1_Enter(object sender, System.EventArgs e)
        {
            toIP1.Select(0, toIP1.Text.Length);
        }

        private void toIP2_Enter(object sender, System.EventArgs e)
        {
            toIP2.Select(0, toIP2.Text.Length);
        }

        private void toIP3_Enter(object sender, System.EventArgs e)
        {
            toIP3.Select(0, toIP3.Text.Length);
        }
        private async void scanButton_Click(object sender, EventArgs e)
        {
            buildScanList();
            if(scanner.Length > 0 && saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                progressBar1.Maximum = scanner.Length + 1;      
                IPRangeWriter writer = new IPRangeWriter(scanner);
                writer.createTempFile(saveFileDialog1.FileName);
                Task scan = scanner.buildIPTableAsync(updateProgressBar, updateIPLabel);
                await scan;
                writer.writeIPTable(saveFileDialog1.FileName);
                writer.writeHTMLTable(saveFileDialog1.FileName);      
                updateProgressBar(0);
                currentIPLabel.Text = "Current IP: N/A";
                currentIPLabel.Refresh();
                MessageBox.Show("Scan complete!\nNumber of " + numberOfIPs.Text);
            }
            else if(scanner.Length <= 0)
                MessageBox.Show("Invalid Range");
            
        }
        private void updateProgressBar( int value )
        {
            progressBar1.Value = value;
        }
        private void updateIPLabel( IPAddress ip )
        {
            currentIPLabel.Text = "Current IP: " + ip.ToString();
            currentIPLabel.Refresh();
            numberOfIPs.Text = "IPs Found: " + scanner.ipTable.Count;
        }
        private void buildScanList()
        {
            long end = IPRangeScanner.generateIPAddress((uint)toIP0.Value,
                                                          (uint)toIP1.Value,
                                                          (uint)toIP2.Value,
                                                          (uint)toIP3.Value);
            long start = IPRangeScanner.generateIPAddress((uint)fromIP0.Value,
                                                        (uint)fromIP1.Value,
                                                        (uint)fromIP2.Value,
                                                        (uint)fromIP3.Value);
            scanner.setStartIP(start);
            scanner.setEndIP(end);
            
            Debug.Write(scanner.ToString() + "\n");
        }
        private void fromIP3_ValueChanged(object sender, EventArgs e)
        {
            toIP3.Value = fromIP3.Value;
        }
        private void fromIP2_ValueChanged(object sender, EventArgs e)
        {
            toIP2.Value = fromIP2.Value;
        }

        private void fromIP1_ValueChanged(object sender, EventArgs e)
        {
            toIP1.Value = fromIP1.Value;
        }

        private void fromIP0_ValueChanged(object sender, EventArgs e)
        {
            toIP0.Value = fromIP0.Value;
        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timeoutNumberUpDown_ValueChanged(object sender, EventArgs e)
        {
            scanner.timeout = (int)timeoutNumberUpDown.Value;
        }

        private void MainGUI_Load(object sender, EventArgs e)
        {

        }






        
        
    }
}
