﻿namespace TODOList.components
{
    partial class Test
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.showTimeLabel = new System.Windows.Forms.Label();
            this.taskBox1 = new TODOList.components.TaskBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(328, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // showTimeLabel
            // 
            this.showTimeLabel.AutoSize = true;
            this.showTimeLabel.Location = new System.Drawing.Point(243, 259);
            this.showTimeLabel.Name = "showTimeLabel";
            this.showTimeLabel.Size = new System.Drawing.Size(55, 15);
            this.showTimeLabel.TabIndex = 1;
            this.showTimeLabel.Text = "label1";
            // 
            // taskBox1
            // 
            this.taskBox1.alert_time = "";
            this.taskBox1.AutoSize = true;
            this.taskBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.taskBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taskBox1.deadline = "";
            this.taskBox1.Describe = null;
            this.taskBox1.isImportantTask = false;
            this.taskBox1.Location = new System.Drawing.Point(436, 304);
            this.taskBox1.Name = "taskBox1";
            this.taskBox1.Size = new System.Drawing.Size(128, 59);
            this.taskBox1.TabIndex = 2;
            this.taskBox1.TeskTitle = "taskBox1";
            this.taskBox1.Text = "taskBox1";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.taskBox1);
            this.Controls.Add(this.showTimeLabel);
            this.Controls.Add(this.comboBox1);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label showTimeLabel;
        private TaskBox taskBox1;
    }
}