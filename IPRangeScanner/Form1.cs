using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPRangeScanner
{
    public partial class Form1 : Form
    {
        IPRangeScanner scanner = new IPRangeScanner( 0, 0);
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void testButton_Click(object sender, EventArgs e)
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

        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            scanner.traverseAddressRange();
        }

        
    }
}
