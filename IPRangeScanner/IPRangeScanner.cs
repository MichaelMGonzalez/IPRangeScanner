﻿using System;
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
        // Constants
        private const int ONEBYTE = 8;
        private const int TWOBYTE = 16;
        private const int THREEBYTE = 24;

        public int timeout = 1500;
        public int Length = 0;
        public delegate void Del(int l);
        public delegate void IPDel(IPAddress ip);
        /* The HTML table contains any HTML read from buildIPTable */
        public Queue<string> htmlTable = new Queue<string>();
        /* The IP table contains any valid IPs read from buildIPTable */
        public Queue<string> ipTable = new Queue<string>();
        public string tempfile;
        private IPAddress ip, startRange, endRange;
        public IPRangeScanner( Int64 startAddress, Int64 endAddress )
        {
            startRange = new IPAddress(startAddress);
            endRange = new IPAddress(endAddress);
            tempfile = null;
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
        
        // This updates the length variable. The length is the distance between
        // endIP and startIP inclusive.
        private void setRangeLength()
        {
            Byte[] startIP = startRange.GetAddressBytes();
            Byte[] endIP = endRange.GetAddressBytes();
            short[] endBuff = new short[4];
            int result = 0;
            Array.Reverse(startIP);
            Array.Reverse(endIP);
            // Copy endIP into endBuff
            for (int i = 0, n = endIP.Length; i < n; i++)
                endBuff[i] = endIP[i];
                // Treat each byte as a base 256 number
                for (int b = 0, n = startIP.Length; b < n; b++)
                {
                    if (endBuff[b] < startIP[b])
                    {
                        endBuff[b] += 255;
                        endBuff[b + 1] -= 1;
                    }
                    result += (int)((endBuff[b] - startIP[b]) * Math.Pow(256, b));
                }
            Length = ++result;
        }
        public override string ToString()
        {
            return (startRange + " to " + endRange);
        }
        // This function itterates through the address range
        public async Task buildIPTableAsync()
        {
            await buildIPTableAsync(null, null);
        }
        public async Task buildIPTableAsync(Del locDel)
        {
            await buildIPTableAsync(locDel, null);
        }
        public async Task buildIPTableAsync(IPDel ipDel)
        {
            await buildIPTableAsync(null, ipDel);
        }
        // If loc delegate is provided, this function passes an integer value
        // of the current index relative to the length of the range
        // If ip delegate is provided, this function passes the current IP
        // to the delegate
        public async Task buildIPTableAsync(Del locDel, IPDel ipDel)
        {
            Byte[] startIP = startRange.GetAddressBytes();
            Byte[] endIP = endRange.GetAddressBytes();
            Byte[] originalEndIP = endRange.GetAddressBytes();
            IPAddress currIP;
            //setRangeLength();
            long currAddress;
            int loc = 0;
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
                        for(int l = startIP[3]; l <= endIP[3]; l++, loc++)
                        {
                            currAddress = generateIPAddress((uint)l, (uint)k, 
                                                            (uint)j, (uint)i);
                            currIP = new IPAddress(currAddress);
                            if (locDel != null)
                                locDel(loc);
                            if (ipDel != null)
                                ipDel(currIP);
                            readHTML(currIP);
                            await Task.Delay(50);
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
            Uri currURI = new Uri("http://" + address.ToString() );
            WebRequest request = WebRequest.Create(currURI);
            request.Timeout = timeout;
            string currString;
            try
            {
                // Get the response.
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                // Display the status.
                Console.WriteLine(response.StatusDescription);
                // Get the stream containing content returned by the server.
                Stream dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content. 
                currString = reader.ReadToEnd();
                // Cleanup the streams and the response.
                reader.Close();
                dataStream.Close();
                response.Close();
                ipTable.Enqueue(string.Copy(address.ToString()));
                htmlTable.Enqueue(string.Copy(currString));
                // If tempfile isn't null, then append the current IP to it
                if (tempfile != null) 
                    IPRangeWriter.appendTempIPTable(address, tempfile);
            }
            catch (WebException)
            {
               
            }
            
        }
        public void setStartIP(long address)
        {
            startRange = new IPAddress(address);
        }
        public void setEndIP(long address)
        {
            endRange = new IPAddress(address);
            setRangeLength();
        }

       
    }
}
