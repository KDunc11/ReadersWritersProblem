using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Writer
{
    public class RWEventArgs : EventArgs
    {
        public int ID { get; set; }
    }

    public class Writer
    {
        public int ID { get; set; }
        public string FilePath { get; set; }
        public FileStream Stream { get; set; } = null;
        public int WriteTime { get; set; } = 5000;
        
        public delegate void WriterOpen (object source, RWEventArgs e);
        public delegate void WriterClose (object source, RWEventArgs e);
        
        public event WriterOpen OnOpenWriter;
        public event WriterClose OnCloseWriter;

        private Timer timer;
        private const string filename = "Resource.txt";

        public Writer(int id, int time) // initialize the writer with an id and write time
        {
            ID = id;
            WriteTime = time;
            timer = new Timer();
        }

        public void OpenWrite()
        {
            FilePath = Environment.CurrentDirectory;
            FilePath = FilePath.Substring(0, FilePath.IndexOf(@"\Writer\Writer")) + "\\" + filename; // obtain the resource
            timer.Elapsed += Interrupt;
            timer.Interval = WriteTime;
            timer.Enabled = true;

            try
            {
                //Stream = File.Open(FilePath, FileMode.Append, FileAccess.Write); // old way
                Stream = GetStreamAsync().Result; // wait to open file until previous writer is finished
                OnOpenWriter?.Invoke(this, new RWEventArgs() { ID = this.ID }); // trigger the open writer event
                DoWrite();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        public void DoWrite()
        {
            long endPosition = Stream.Length; // obtain the end position of the file
            Stream.Seek(endPosition, SeekOrigin.Begin); // move to the end of the file

            string date = DateTime.Now.ToString() + "\r\n";
            byte[] dateArray = Encoding.ASCII.GetBytes(date); // obtain the current date and time
            Stream.Write(dateArray, 0, dateArray.Length); // write the current date and time to the stream from a byte array

        }

        public void CloseWrite()
        {
            if (Stream != null)
            {
                Stream.Close(); // close the filestream
                OnCloseWriter?.Invoke(this, new RWEventArgs() { ID = this.ID }); // trigger the writer close event
            }
            else
            {
                Debug.WriteLine("The file stream was null.");
            }
        }

        private void Interrupt(object source, ElapsedEventArgs e)
        {
            // interrupt after the alloted write time and close the filestream
            timer.Enabled = false;
            CloseWrite();
            timer.Dispose();
        }

        private async Task<FileStream> GetStreamAsync()
        {
            try
            {
                // try to access the resource (the filestream)
                return new FileStream(FilePath, FileMode.Append, FileAccess.Write);
            }
            catch (IOException)
            {
                // if resource cannot be found wait an attempt to access the resource again
                Debug.WriteLine("Waiting for previous writer to finish");
                await Task.Delay(TimeSpan.FromSeconds(1));
                return await GetStreamAsync(); // recursively attempt to access the resource
            }
        }
    }
}
