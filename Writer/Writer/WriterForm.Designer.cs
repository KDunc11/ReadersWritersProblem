using System.Collections.Generic;

namespace Writer
{
    partial class WriterForm
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
            this.testButton = new System.Windows.Forms.Button();
            this.queueProgressBar = new System.Windows.Forms.ProgressBar();
            this.queueSize = new System.Windows.Forms.NumericUpDown();
            this.appParams = new System.Windows.Forms.GroupBox();
            this.refreshRateTime = new System.Windows.Forms.NumericUpDown();
            this.refreshRateLabel = new System.Windows.Forms.Label();
            this.writeTime = new System.Windows.Forms.NumericUpDown();
            this.appWriteTime = new System.Windows.Forms.Label();
            this.queueSizeLabel = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.queueProgressLabel = new System.Windows.Forms.Label();
            this.outputMonitor = new System.Windows.Forms.GroupBox();
            this.closeAppBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.queueSize)).BeginInit();
            this.appParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshRateTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.writeTime)).BeginInit();
            this.outputMonitor.SuspendLayout();
            this.SuspendLayout();
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(9, 323);
            this.testButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(153, 53);
            this.testButton.TabIndex = 0;
            this.testButton.Text = "Run";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // queueProgressBar
            // 
            this.queueProgressBar.Location = new System.Drawing.Point(9, 258);
            this.queueProgressBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.queueProgressBar.Name = "queueProgressBar";
            this.queueProgressBar.Size = new System.Drawing.Size(306, 19);
            this.queueProgressBar.TabIndex = 1;
            // 
            // queueSize
            // 
            this.queueSize.Location = new System.Drawing.Point(78, 20);
            this.queueSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.queueSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.queueSize.Name = "queueSize";
            this.queueSize.Size = new System.Drawing.Size(68, 20);
            this.queueSize.TabIndex = 3;
            this.queueSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.queueSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // appParams
            // 
            this.appParams.Controls.Add(this.refreshRateTime);
            this.appParams.Controls.Add(this.refreshRateLabel);
            this.appParams.Controls.Add(this.writeTime);
            this.appParams.Controls.Add(this.appWriteTime);
            this.appParams.Controls.Add(this.queueSizeLabel);
            this.appParams.Controls.Add(this.queueSize);
            this.appParams.Location = new System.Drawing.Point(9, 10);
            this.appParams.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.appParams.Name = "appParams";
            this.appParams.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.appParams.Size = new System.Drawing.Size(153, 122);
            this.appParams.TabIndex = 4;
            this.appParams.TabStop = false;
            this.appParams.Text = "Parameters";
            // 
            // refreshRateTime
            // 
            this.refreshRateTime.Location = new System.Drawing.Point(78, 81);
            this.refreshRateTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.refreshRateTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.refreshRateTime.Name = "refreshRateTime";
            this.refreshRateTime.Size = new System.Drawing.Size(68, 20);
            this.refreshRateTime.TabIndex = 8;
            this.refreshRateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.refreshRateTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // refreshRateLabel
            // 
            this.refreshRateLabel.AutoSize = true;
            this.refreshRateLabel.Location = new System.Drawing.Point(4, 81);
            this.refreshRateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.refreshRateLabel.Name = "refreshRateLabel";
            this.refreshRateLabel.Size = new System.Drawing.Size(70, 13);
            this.refreshRateLabel.TabIndex = 7;
            this.refreshRateLabel.Text = "Refresh Rate";
            // 
            // writeTime
            // 
            this.writeTime.Location = new System.Drawing.Point(78, 50);
            this.writeTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.writeTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.writeTime.Name = "writeTime";
            this.writeTime.Size = new System.Drawing.Size(68, 20);
            this.writeTime.TabIndex = 6;
            this.writeTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.writeTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // appWriteTime
            // 
            this.appWriteTime.AutoSize = true;
            this.appWriteTime.Location = new System.Drawing.Point(4, 50);
            this.appWriteTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.appWriteTime.Name = "appWriteTime";
            this.appWriteTime.Size = new System.Drawing.Size(58, 13);
            this.appWriteTime.TabIndex = 5;
            this.appWriteTime.Text = "Write Time";
            // 
            // queueSizeLabel
            // 
            this.queueSizeLabel.AutoSize = true;
            this.queueSizeLabel.Location = new System.Drawing.Point(4, 21);
            this.queueSizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.queueSizeLabel.Name = "queueSizeLabel";
            this.queueSizeLabel.Size = new System.Drawing.Size(62, 13);
            this.queueSizeLabel.TabIndex = 4;
            this.queueSizeLabel.Text = "Queue Size";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(13, 24);
            this.outputBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(342, 329);
            this.outputBox.TabIndex = 6;
            this.outputBox.Text = "";
            // 
            // queueProgressLabel
            // 
            this.queueProgressLabel.AutoSize = true;
            this.queueProgressLabel.Location = new System.Drawing.Point(7, 242);
            this.queueProgressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.queueProgressLabel.Name = "queueProgressLabel";
            this.queueProgressLabel.Size = new System.Drawing.Size(42, 13);
            this.queueProgressLabel.TabIndex = 5;
            this.queueProgressLabel.Text = "Queue:";
            // 
            // outputMonitor
            // 
            this.outputMonitor.Controls.Add(this.outputBox);
            this.outputMonitor.Location = new System.Drawing.Point(379, 10);
            this.outputMonitor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outputMonitor.Name = "outputMonitor";
            this.outputMonitor.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outputMonitor.Size = new System.Drawing.Size(367, 366);
            this.outputMonitor.TabIndex = 7;
            this.outputMonitor.TabStop = false;
            this.outputMonitor.Text = "Output";
            // 
            // closeAppBtn
            // 
            this.closeAppBtn.Location = new System.Drawing.Point(205, 323);
            this.closeAppBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeAppBtn.Name = "closeAppBtn";
            this.closeAppBtn.Size = new System.Drawing.Size(153, 53);
            this.closeAppBtn.TabIndex = 8;
            this.closeAppBtn.Text = "Close";
            this.closeAppBtn.UseVisualStyleBackColor = true;
            this.closeAppBtn.Click += new System.EventHandler(this.closeAppBtn_Click);
            // 
            // WriterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 396);
            this.Controls.Add(this.closeAppBtn);
            this.Controls.Add(this.outputMonitor);
            this.Controls.Add(this.queueProgressBar);
            this.Controls.Add(this.queueProgressLabel);
            this.Controls.Add(this.appParams);
            this.Controls.Add(this.testButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WriterForm";
            this.Text = "Writer";
            ((System.ComponentModel.ISupportInitialize)(this.queueSize)).EndInit();
            this.appParams.ResumeLayout(false);
            this.appParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshRateTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.writeTime)).EndInit();
            this.outputMonitor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //Writers App Parameters
        private int QueueSize { get; set; }
        private int WriteTime { get; set; }
        private int RefreshRate { get; set; }

        private Queue<Writer> writers = new Queue<Writer>(); // instantiate a queue of writers

        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.ProgressBar queueProgressBar;
        private System.Windows.Forms.NumericUpDown queueSize;
        private System.Windows.Forms.GroupBox appParams;
        private System.Windows.Forms.NumericUpDown writeTime;
        private System.Windows.Forms.Label appWriteTime;
        private System.Windows.Forms.Label queueSizeLabel;
        private System.Windows.Forms.Label queueProgressLabel;
        private System.Windows.Forms.GroupBox outputMonitor;
        public System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Button closeAppBtn;
        private System.Windows.Forms.NumericUpDown refreshRateTime;
        private System.Windows.Forms.Label refreshRateLabel;
    }
}

