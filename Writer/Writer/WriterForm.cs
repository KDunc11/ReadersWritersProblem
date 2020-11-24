using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace Writer
{
    public partial class WriterForm : Form
    {
        private delegate void UpdateProgressBar(int v, ProgressBar f);
        private System.Timers.Timer refresh = new System.Timers.Timer();
        private int id_count = 0;

        public WriterForm()
        {
            InitializeComponent();
        }

        private void RunSetup()
        {
            // initialize the application from the user interface parameters
            if (refreshRateTime.Value < writeTime.Value)
            {
                MessageBox.Show("The queue's refresh rate cannot be faster than the write time.");
                refreshRateTime.Value = 1;
                writeTime.Value = 1;
            }
            else
            {
                RefreshRate = (int)refreshRateTime.Value * 1000;
                refresh.Interval = RefreshRate; // set the interval
                refresh.Elapsed += AddWriterToQueue; // add a writer to the queue every time the refresh rate is hit
                refresh.Enabled = true; // start the timer
                QueueSize = (int)queueSize.Value;
                queueProgressBar.Maximum = QueueSize;
                WriteTime = (int)writeTime.Value * 1000;
                queueProgressBar.Value = QueueSize; // initialize the size of the progress bar that represents the queue

                // load up the queue
                for (int i = 0; i < QueueSize; i++)
                    writers.Enqueue(new Writer(++id_count, WriteTime));
           }
        }

        public void OnOpenWriter(object source, RWEventArgs e)
        {
            if (outputBox.InvokeRequired)
            {
                // invoke to have the function call on the same thread as the writer object
                var d = new Writer.WriterOpen(OnOpenWriter);
                outputBox.Invoke(d, new object[] { source, e });
            }
            else
            {
                // print out the writer's id and opening message
                Debug.WriteLine($"Opening writer.");
                outputBox.AppendText($"Writer {e.ID} Open.\n");
            }
        }

        public void OnCloseWriter(object source, RWEventArgs e)
        {
            if (outputBox.InvokeRequired)
            {
                // invoke to have the function call on the same thread as the writer object
                var d = new Writer.WriterClose(OnCloseWriter);
                outputBox.Invoke(d, new object[] { source, e });
            }
            else
            {
                // print out the writer's id and opening message
                Debug.WriteLine($"Closing writer.");

                outputBox.AppendText($"Writer {e.ID} Closed.\n");
                queueProgressBar.Value = writers.Count; // update the queue size

                if (!refresh.Enabled)
                    refresh.Enabled = true;
            }
        }

        private void AddWriterToQueue(object source, EventArgs e)
        {
            // attempt to add another writer to the queue and dequeue another writer
            refresh.Enabled = false;

            if (writers.Count < QueueSize) // if the queue is not full add another writer
            {
                writers.Enqueue(new Writer(++id_count, WriteTime));
                queueProgressBar.Invoke(new UpdateProgressBar(OnUpdateProfressBar), new object[] { writers.Count, queueProgressBar }); // update the progress bar (queue's status)
            }

            refresh.Enabled = true;
            RunQueue();
        }

        private void RunQueue()
        {
            // dequeue one writer and access start writing to the resource
            if (writers.Count > 0)
            {
                Writer w = writers.Dequeue();
                w.OnOpenWriter += OnOpenWriter;
                w.OnCloseWriter += OnCloseWriter;
                w.OpenWrite();
            }
        }

        public void OnUpdateProfressBar(int I, ProgressBar l)
        {
            queueProgressBar.Value = I;
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            RunSetup(); // setup the application
        }

        private void closeAppBtn_Click(object sender, EventArgs e)
        {
            Close(); // close the form
        }
    }
}
