using System.Collections.Generic;

namespace Reader
{
    partial class ReaderForm
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
            this.runAppBtn = new System.Windows.Forms.Button();
            this.appParams = new System.Windows.Forms.GroupBox();
            this.queueRefreshLabel = new System.Windows.Forms.Label();
            this.queueRefreshRate = new System.Windows.Forms.NumericUpDown();
            this.readTimeLabel = new System.Windows.Forms.Label();
            this.readTime = new System.Windows.Forms.NumericUpDown();
            this.queueLabel = new System.Windows.Forms.Label();
            this.queueSize = new System.Windows.Forms.NumericUpDown();
            this.outputGroup = new System.Windows.Forms.GroupBox();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.queueMonitor = new System.Windows.Forms.Label();
            this.queueProgressBar = new System.Windows.Forms.ProgressBar();
            this.closeAppBtn = new System.Windows.Forms.Button();
            this.appParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queueRefreshRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queueSize)).BeginInit();
            this.outputGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // runAppBtn
            // 
            this.runAppBtn.Location = new System.Drawing.Point(30, 372);
            this.runAppBtn.Name = "runAppBtn";
            this.runAppBtn.Size = new System.Drawing.Size(206, 67);
            this.runAppBtn.TabIndex = 0;
            this.runAppBtn.Text = "Run";
            this.runAppBtn.UseVisualStyleBackColor = true;
            this.runAppBtn.Click += new System.EventHandler(this.runAppBtn_Click);
            // 
            // appParams
            // 
            this.appParams.Controls.Add(this.queueRefreshLabel);
            this.appParams.Controls.Add(this.queueRefreshRate);
            this.appParams.Controls.Add(this.readTimeLabel);
            this.appParams.Controls.Add(this.readTime);
            this.appParams.Controls.Add(this.queueLabel);
            this.appParams.Controls.Add(this.queueSize);
            this.appParams.Location = new System.Drawing.Point(30, 12);
            this.appParams.Name = "appParams";
            this.appParams.Size = new System.Drawing.Size(240, 156);
            this.appParams.TabIndex = 1;
            this.appParams.TabStop = false;
            this.appParams.Text = "Parameters";
            // 
            // queueRefreshLabel
            // 
            this.queueRefreshLabel.AutoSize = true;
            this.queueRefreshLabel.Location = new System.Drawing.Point(15, 109);
            this.queueRefreshLabel.Name = "queueRefreshLabel";
            this.queueRefreshLabel.Size = new System.Drawing.Size(92, 17);
            this.queueRefreshLabel.TabIndex = 5;
            this.queueRefreshLabel.Text = "Refresh Rate";
            // 
            // queueRefreshRate
            // 
            this.queueRefreshRate.Location = new System.Drawing.Point(112, 107);
            this.queueRefreshRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.queueRefreshRate.Name = "queueRefreshRate";
            this.queueRefreshRate.Size = new System.Drawing.Size(88, 22);
            this.queueRefreshRate.TabIndex = 4;
            this.queueRefreshRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.queueRefreshRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // readTimeLabel
            // 
            this.readTimeLabel.AutoSize = true;
            this.readTimeLabel.Location = new System.Drawing.Point(15, 69);
            this.readTimeLabel.Name = "readTimeLabel";
            this.readTimeLabel.Size = new System.Drawing.Size(77, 17);
            this.readTimeLabel.TabIndex = 3;
            this.readTimeLabel.Text = "Read Time";
            // 
            // readTime
            // 
            this.readTime.Location = new System.Drawing.Point(112, 69);
            this.readTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.readTime.Name = "readTime";
            this.readTime.Size = new System.Drawing.Size(88, 22);
            this.readTime.TabIndex = 2;
            this.readTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.readTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // queueLabel
            // 
            this.queueLabel.AutoSize = true;
            this.queueLabel.Location = new System.Drawing.Point(15, 32);
            this.queueLabel.Name = "queueLabel";
            this.queueLabel.Size = new System.Drawing.Size(82, 17);
            this.queueLabel.TabIndex = 1;
            this.queueLabel.Text = "Queue Size";
            // 
            // queueSize
            // 
            this.queueSize.Location = new System.Drawing.Point(112, 32);
            this.queueSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.queueSize.Name = "queueSize";
            this.queueSize.Size = new System.Drawing.Size(88, 22);
            this.queueSize.TabIndex = 0;
            this.queueSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.queueSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // outputGroup
            // 
            this.outputGroup.Controls.Add(this.outputBox);
            this.outputGroup.Location = new System.Drawing.Point(559, 12);
            this.outputGroup.Name = "outputGroup";
            this.outputGroup.Size = new System.Drawing.Size(418, 433);
            this.outputGroup.TabIndex = 2;
            this.outputGroup.TabStop = false;
            this.outputGroup.Text = "Output";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(23, 32);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(374, 383);
            this.outputBox.TabIndex = 2;
            this.outputBox.Text = "";
            // 
            // queueMonitor
            // 
            this.queueMonitor.AutoSize = true;
            this.queueMonitor.Location = new System.Drawing.Point(27, 272);
            this.queueMonitor.Name = "queueMonitor";
            this.queueMonitor.Size = new System.Drawing.Size(55, 17);
            this.queueMonitor.TabIndex = 1;
            this.queueMonitor.Text = "Queue:";
            // 
            // queueProgressBar
            // 
            this.queueProgressBar.Location = new System.Drawing.Point(30, 309);
            this.queueProgressBar.Name = "queueProgressBar";
            this.queueProgressBar.Size = new System.Drawing.Size(336, 23);
            this.queueProgressBar.TabIndex = 0;
            // 
            // closeAppBtn
            // 
            this.closeAppBtn.Location = new System.Drawing.Point(288, 372);
            this.closeAppBtn.Name = "closeAppBtn";
            this.closeAppBtn.Size = new System.Drawing.Size(206, 67);
            this.closeAppBtn.TabIndex = 3;
            this.closeAppBtn.Text = "Close";
            this.closeAppBtn.UseVisualStyleBackColor = true;
            this.closeAppBtn.Click += new System.EventHandler(this.closeAppBtn_Click);
            // 
            // ReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 457);
            this.Controls.Add(this.closeAppBtn);
            this.Controls.Add(this.outputGroup);
            this.Controls.Add(this.queueProgressBar);
            this.Controls.Add(this.queueMonitor);
            this.Controls.Add(this.appParams);
            this.Controls.Add(this.runAppBtn);
            this.Name = "ReaderForm";
            this.Text = "Reader";
            this.appParams.ResumeLayout(false);
            this.appParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queueRefreshRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queueSize)).EndInit();
            this.outputGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Parameters
        private int QueueSize { get; set; }
        private int ReadTime { get; set; }
        private int RefreshRate { get; set; }

        private int RunTime { get; set; }
        //Variables
        private Queue<Reader> readers { get; set; } = new Queue<Reader>();
        private bool running { get; set; } = true;

        // WinForm Variables
        private System.Windows.Forms.Button runAppBtn;
        private System.Windows.Forms.GroupBox appParams;
        private System.Windows.Forms.Label readTimeLabel;
        private System.Windows.Forms.NumericUpDown readTime;
        private System.Windows.Forms.Label queueLabel;
        private System.Windows.Forms.NumericUpDown queueSize;
        private System.Windows.Forms.GroupBox outputGroup;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Label queueMonitor;
        private System.Windows.Forms.ProgressBar queueProgressBar;
        private System.Windows.Forms.Button closeAppBtn;
        private System.Windows.Forms.Label queueRefreshLabel;
        private System.Windows.Forms.NumericUpDown queueRefreshRate;
    }
}

