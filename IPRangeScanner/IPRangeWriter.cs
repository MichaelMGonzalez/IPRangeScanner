using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
/**
 * Filename: IPRangeWriter.cs
 * Author: Michael Gonzalez
 * Description: This class writes an IPRangeScanner's IP Table and HTML table
 *              to the disk.
 */ 
namespace IPRangeScanner
{
    class IPRangeWriter
    {
        private IPRangeScanner scanner;
        public IPRangeWriter( IPRangeScanner scanner )
        {
            this.scanner = scanner;
        }
        // This method writes the IP Table to a file
        public void writeIPTable(string filename)
        {
            Debug.Write(filename + "\n");
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("IP Range Scanner Results");
            sb.AppendLine("Range: " + this.scanner.ToString());
            sb.AppendLine("Number of IPs Found: " + scanner.ipTable.Count);
            sb.AppendLine("Timeout Threshold: " + scanner.timeout);
            sb.AppendLine("HTTP Accessable IPs:");
            sb.AppendLine("= = = = = = = =");
            string currIP;
            for (int i = 0, length = scanner.ipTable.Count; i < length; i++)
            {
                currIP = scanner.ipTable.Dequeue();
                sb.AppendLine(currIP);
                scanner.ipTable.Enqueue(currIP);
            }
            sb.AppendLine("= = = = = = = =");
            using (StreamWriter outfile = new StreamWriter(filename))
            {
                outfile.Write(sb.ToString());
            }
            // If there's a temp file, then delete it.
            if( scanner.tempfile != null )
            {
                File.Delete(scanner.tempfile);
            }

        }
        // This method writes each HTML file to a directory.
        // It follows the following format: filename_HTML/ip.html
        // If the filename has a file extention, this method will ignore it
        public void writeHTMLTable(string filename)
        {
            StreamWriter outfile;
            string pathname = filename;
            int dotIndex = pathname.LastIndexOf('.');
            if (dotIndex > 0)
            {
                pathname = pathname.Substring(0, dotIndex);
            }
            pathname += "_HTML/";
            Directory.CreateDirectory(pathname);
            while (scanner.ipTable.Count > 0)
            {
                string newfile = pathname + scanner.ipTable.Dequeue() + ".html";
                using (outfile = new StreamWriter(newfile))
                {
                    outfile.Write(scanner.htmlTable.Dequeue());
                }
            }
        }
        // This method creates a temporary file that will contain valid IP 
        // information. The file is appeneded as the IPRangeScanner scans.
        public void createTempFile(string filename)
        {
            StringBuilder sb = new StringBuilder();
            scanner.tempfile = String.Copy(filename);
            sb.AppendLine("IP Range Scanner Results");
            sb.AppendLine("Range: " + this.scanner.ToString());
            sb.AppendLine("HTTP Accessable IPs:");
            sb.AppendLine("= = = = = = = =");
            int dotIndex = scanner.tempfile.LastIndexOf('.');
            if (dotIndex > 0)
            {
                scanner.tempfile = scanner.tempfile.Substring(0, dotIndex);
            }
            scanner.tempfile += ".temp";
            using (StreamWriter outfile = new StreamWriter(scanner.tempfile))
            {
                outfile.Write(sb.ToString());
            }
        }
        // Static method used by IPRangeScanner to append valid IPs to a 
        // file
        public static void appendTempIPTable(IPAddress ip, string tempfile)
        {
            using (StreamWriter outfile = new StreamWriter(tempfile, true))
            {
                outfile.Write(ip.ToString()+"\n");
            }
        }
    }
}
