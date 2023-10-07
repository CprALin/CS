using System;

namespace StopWatch
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_mark = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00:00:000";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(69, 145);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(118, 55);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(238, 145);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(118, 55);
            this.button_stop.TabIndex = 2;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_mark
            // 
            this.button_mark.Location = new System.Drawing.Point(69, 234);
            this.button_mark.Name = "button_mark";
            this.button_mark.Size = new System.Drawing.Size(118, 55);
            this.button_mark.TabIndex = 3;
            this.button_mark.Text = "Mark";
            this.button_mark.UseVisualStyleBackColor = true;
            this.button_mark.Click += new System.EventHandler(this.button_mark_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(238, 234);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(118, 55);
            this.button_reset.TabIndex = 4;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(446, 109);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(179, 196);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 379);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_mark);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "StopWatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_mark;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

