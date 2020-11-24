using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;
using System.Diagnostics;

namespace Reader
{
    public class RWEventArgs : EventArgs
    {
        public int ID { get; set; }
    }

    public class Reader
    {
        public int ID { get; set; }
        public string FilePath { get; set; }
        public FileStream Stream { get; set; } = null;
        public int ReadTime { get; set; } = 3000;

        public delegate void ReaderOpen(object source, RWEventArgs e);
        public delegate void ReaderClose(object source, RWEventArgs e);

        public event ReaderOpen OnOpenReader;
        public event ReaderClose OnCloseReader;

        private Timer timer;

        const string filename = "Resource.txt";

        public Reader(int id, int time) // initialize a reader with an id and read time
        {
            ID = id;
            ReadTime = time;
            timer = new Timer();
        }

        public void OpenRead()
        {
            FilePath = Environment.CurrentDirectory;
            FilePath = FilePath.Substring(0, FilePath.IndexOf(@"\Reader\Reader")) + "\\" + filename; // path to resource
            timer.Elapsed += Interrupt; // add interrupt to the timer
            timer.Interval = ReadTime;
            timer.Enabled = true;

            try
            {
                // try to open the file and read from it
                Stream = File.OpenRead(FilePath);
                OnOpenReader?.Invoke(this, new RWEventArgs() { ID = this.ID }); // trigger on read event
                DoRead();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        public void DoRead()
        {
            bool reading = true;
            Stream.Seek(0, SeekOrigin.Begin); // move to the beginning of the filestream
            byte[] datesArr = new byte[Stream.Length];
            int size = (int)Stream.Length;
            string content = "";

            while (reading)
            {
                int bytesRead = Stream.Read(datesArr, 0, size);

                if (bytesRead > 0)
                    content = Encoding.ASCII.GetString(datesArr, 0, bytesRead); // read in the entire contents of the filestream
                else
                    reading = false;
            }
        }

        public void CloseRead()
        {
            if (Stream != null)
            {
                Stream.Close(); // close the stream
                OnCloseReader?.Invoke(this, new RWEventArgs() { ID = this.ID }); // trigger the on close event
            }
            else
            {
                Debug.WriteLine("The file stream was null.");
            }
        }

        private void Interrupt(object source, EventArgs e)
        {
            // interrupt after the alloted read time and close the filestream
            timer.Enabled = false;
            CloseRead();
            timer.Dispose();
        }
    }
}