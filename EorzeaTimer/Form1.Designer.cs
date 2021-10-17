
namespace EorzeaTimer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.eorzeaTime = new System.Windows.Forms.Label();
            this.eorzeatimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.localTime = new System.Windows.Forms.Label();
            this.LocalTimer = new System.Windows.Forms.Timer(this.components);
            this.trackQuestionLabel = new System.Windows.Forms.Label();
            this.resourceList = new System.Windows.Forms.ListBox();
            this.spawnTimeLabel = new System.Windows.Forms.Label();
            this.currentlyTrackingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eorzeaTime
            // 
            this.eorzeaTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eorzeaTime.Location = new System.Drawing.Point(9, 28);
            this.eorzeaTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eorzeaTime.Name = "eorzeaTime";
            this.eorzeaTime.Size = new System.Drawing.Size(136, 41);
            this.eorzeaTime.TabIndex = 0;
            this.eorzeaTime.Text = "00:00";
            // 
            // eorzeatimer
            // 
            this.eorzeatimer.Enabled = true;
            this.eorzeatimer.Interval = 50;
            this.eorzeatimer.Tick += new System.EventHandler(this.eorzea_timer_tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Eorzea Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current Local Time";
            // 
            // localTime
            // 
            this.localTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localTime.Location = new System.Drawing.Point(298, 28);
            this.localTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.localTime.Name = "localTime";
            this.localTime.Size = new System.Drawing.Size(130, 41);
            this.localTime.TabIndex = 3;
            this.localTime.Text = "00:00";
            // 
            // LocalTimer
            // 
            this.LocalTimer.Enabled = true;
            this.LocalTimer.Interval = 1000;
            this.LocalTimer.Tick += new System.EventHandler(this.local_timer_tick);
            // 
            // trackQuestionLabel
            // 
            this.trackQuestionLabel.AutoSize = true;
            this.trackQuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackQuestionLabel.Location = new System.Drawing.Point(10, 72);
            this.trackQuestionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.trackQuestionLabel.Name = "trackQuestionLabel";
            this.trackQuestionLabel.Size = new System.Drawing.Size(214, 20);
            this.trackQuestionLabel.TabIndex = 4;
            this.trackQuestionLabel.Text = "What would you like to track?";
            // 
            // resourceList
            // 
            this.resourceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resourceList.FormattingEnabled = true;
            this.resourceList.ItemHeight = 17;
            this.resourceList.Location = new System.Drawing.Point(13, 96);
            this.resourceList.Margin = new System.Windows.Forms.Padding(2);
            this.resourceList.Name = "resourceList";
            this.resourceList.Size = new System.Drawing.Size(402, 123);
            this.resourceList.TabIndex = 5;
            this.resourceList.SelectedIndexChanged += new System.EventHandler(this.resourceList_SelectedIndexChanged);
            this.resourceList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.resourceList_MouseDoubleClick);
            // 
            // spawnTimeLabel
            // 
            this.spawnTimeLabel.AutoSize = true;
            this.spawnTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spawnTimeLabel.Location = new System.Drawing.Point(11, 253);
            this.spawnTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.spawnTimeLabel.Name = "spawnTimeLabel";
            this.spawnTimeLabel.Size = new System.Drawing.Size(239, 20);
            this.spawnTimeLabel.TabIndex = 8;
            this.spawnTimeLabel.Text = "Next Spawn Time (Eorzea Time):";
            // 
            // currentlyTrackingLabel
            // 
            this.currentlyTrackingLabel.AutoSize = true;
            this.currentlyTrackingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentlyTrackingLabel.Location = new System.Drawing.Point(11, 221);
            this.currentlyTrackingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentlyTrackingLabel.Name = "currentlyTrackingLabel";
            this.currentlyTrackingLabel.Size = new System.Drawing.Size(256, 20);
            this.currentlyTrackingLabel.TabIndex = 10;
            this.currentlyTrackingLabel.Text = "Currently Tracking: <Select Above>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 292);
            this.Controls.Add(this.currentlyTrackingLabel);
            this.Controls.Add(this.spawnTimeLabel);
            this.Controls.Add(this.resourceList);
            this.Controls.Add(this.trackQuestionLabel);
            this.Controls.Add(this.localTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eorzeaTime);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eorzeaTime;
        private System.Windows.Forms.Timer eorzeatimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label localTime;
        private System.Windows.Forms.Timer LocalTimer;
        private System.Windows.Forms.Label trackQuestionLabel;
        private System.Windows.Forms.ListBox resourceList;
        private System.Windows.Forms.Label spawnTimeLabel;
        private System.Windows.Forms.Label currentlyTrackingLabel;
    }
}

