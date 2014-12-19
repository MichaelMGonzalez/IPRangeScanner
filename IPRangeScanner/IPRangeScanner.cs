using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
/**
 * Filename: IPRangeScanner.cs
 * Author: Michael Gonzalez
 * Description: This class scans a definable range of IP addresses and builds
 *              a table of accessable IPs within the range.
 */       
namespace IPRangeScanner
{
    class IPRangeScanner
    {
        private const int ONEBYTE = 8;
        private const int TWOBYTE = 16;
        private const int THREEBYTE = 24;
        private Queue<string> htmlTable = new Queue<string>();
        private Queue<string> ipTable = new Queue<string>();
        public IPAddress ip, startRange, endRange;
        public IPRangeScanner( Int64 startAddress, Int64 endAddress )
        {
            startRange = new IPAddress(startAddress);
            endRange = new IPAddress(endAddress);
        }
        // This function generates an IPv4 value in little-endian to be used by
        // the IPAddress constructor
        public static long generateIPAddress(uint byteZero, uint byteOne, 
                                             uint byteTwo, uint byteThree)
        {
            long address = 0;
            address |= byteThree;
            address |= (byteTwo << ONEBYTE);
            address |= (byteOne << TWOBYTE);
            address |= (byteZero << THREEBYTE);
            return address;
        }
        public void setStartIP( long address )
        {
            startRange = new IPAddress(address);
        }
        public void setEndIP(long address)
        {
            endRange = new IPAddress(address);
        }
        
        public override string ToString()
        {
            return (startRange + " to " + endRange);
        }
        // This function itterates through the address ranage
        public void buildIPTable()
        {
            Byte[] startIP = startRange.GetAddressBytes();
            Byte[] endIP = endRange.GetAddressBytes();
            Byte[] originalEndIP = endRange.GetAddressBytes();
            IPAddress currIP;
            
            long currAddress;
            for (int i = startIP[0]; i <= endIP[0]; i++ ) 
            { // Iterate through i.j.k.l 
                if (i < endIP[0])  // If the start MSB < end MSB, 
                    endIP[1] = 255;// then ensure all ranges are looped through
                else
                    endIP[1] = originalEndIP[1];
                for( int j = startIP[1]; j<= endIP[1]; j++)
                { 
                    if (j < endIP[1])
                        endIP[2] = 255;
                    else
                        endIP[2] = originalEndIP[2];
                    for( int k = startIP[2]; k <= endIP[2]; k++)
                    {
                        if (k < endIP[2])
                            endIP[3] = 255;
                        else
                            endIP[3] = originalEndIP[3];
                        for(int l = startIP[3]; l <= endIP[3]; l++)
                        {
                            currAddress = generateIPAddress((uint)l, (uint)k, 
                                                            (uint)j, (uint)i);
                            currIP = new IPAddress(currAddress);
                            readHTML(currIP);
                            Debug.Write(currIP + "\n");
                        }
                        startIP[3] = 0; // When any level of the loop reaches 
                    }                   // its end, set the start value to 0
                    startIP[2] = 0;     // so any future loops go through the
                }                       // entire address range
                startIP[1] = 0;
            }
            startIP[0] = 0;           
        }

        // This method tries to access and read index.html at a given 
        // IP Address's root directory
        private void readHTML(IPAddress address)
        {
            WebClient web = new WebClient();
            Uri currURI;
            string currString;
            currURI = new Uri("http://" + address.ToString() + "/index.html");
            try
            {
                currString = web.DownloadString(currURI);
                ipTable.Enqueue(string.Copy(address.ToString()));
                htmlTable.Enqueue(string.Copy(currString));
            }
            catch (WebException)
            {
               
            }
            
        }

        // This method takes writes both the IP Table and the HTML table to a
        // text file
        private void writeTable( string filename )
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("IPs with accessable Indexes with Index:");
            sb.AppendLine("= = = = = =");
            while( ipTable.Count > 0 )
            {
                sb.AppendLine(ipTable.Dequeue());
                sb.AppendLine("^-+-+-+-^");
                sb.AppendLine(htmlTable.Dequeue());
                sb.AppendLine("[-+-+-+-]");
                sb.AppendLine();
                sb.AppendLine();
            }
            using (StreamWriter outfile = new StreamWriter(filename))
            {
                outfile.Write(sb.ToString());
            }
            
        }
    }
}
