using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace Reader
{
    public partial class ReaderForm : Form
    {
        private System.Timers.Timer refresh = new System.Timers.Timer();
        private int id_count = 0;

        public ReaderForm()
        {
            InitializeComponent();
        }

        private void RunSetup()
        {
            // initialize the application from the user interface parameters
            RefreshRate = (int)queueRefreshRate.Value * 1000;
            refresh.Interval = RefreshRate; // set the interval
            refresh.Elapsed += AddReadersToQueue; // add a reader to the queue every time the refresh rate is hit
            refresh.Enabled = true; // start the timer
            QueueSize = (int)queueSize.Value;
            queueProgressBar.Maximum = QueueSize;
            ReadTime = (int)readTime.Value * 1000;
            queueProgressBar.Value = QueueSize; // initialize the size of the progress bar that represents the queue
        }

        private void RunQueue()
        {
            // empty the queue of readers
            while (readers.Count > 0)
            {
                Reader r = readers.Dequeue();
                r.OnOpenReader += OnOpenReader;
                r.OnCloseReader += OnCloseReader;
                r.OpenRead();
            }
        }

        private void AddReadersToQueue(object source, EventArgs e)
        {
            // once triggered fill the queue of readers and then start reading again
            refresh.Enabled = false;
            if (readers.Count < QueueSize)
            {
                int fillCount = QueueSize - readers.Count;

                for (int i = 0; i < fillCount; i++)
                    readers.Enqueue(new Reader(++id_count, ReadTime));
            }
            refresh.Enabled = true;
            RunQueue();
        }

        private void OnOpenReader(object source, RWEventArgs e)
        {
            if (outputBox.InvokeRequired)
            {
                // invoke to have the function call on the same thread as the reader object
                var d = new Reader.ReaderOpen(OnOpenReader);
                outputBox.Invoke(d, new object[] { source, e });
            }
            else
            {
                // print out the reader's id and opening message
                Debug.WriteLine($"Opening reader.");
                outputBox.AppendText($"Reader {e.ID} Open.\n");
            }
        }

        private void OnCloseReader(object source, RWEventArgs e)
        {
            if (outputBox.InvokeRequired)
            {
                // invoke to have the function call on the same thread as the reader object
                var d = new Reader.ReaderClose(OnCloseReader);
                outputBox.Invoke(d, new object[] { source, e });
            }
            else
            {
                // print out the reader's id and closing message
                Debug.WriteLine($"Closing reader.");

                outputBox.AppendText($"Reader {e.ID} Closed.\n");
                queueProgressBar.Value = readers.Count; // update the queue size
                
                if (!refresh.Enabled)
                    refresh.Enabled = true;
            }
        }

        private void runAppBtn_Click(object sender, EventArgs e)
        {
            RunSetup(); // setup the application
        }

        private void closeAppBtn_Click(object sender, EventArgs e)
        {
            Close(); // close the form
        }
    }
}
