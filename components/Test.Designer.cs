namespace TODOList.components
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.showGroupBox1 = new TODOList.Controls.ShowGroupBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.showGroupBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(39, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(686, 395);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // showGroupBox1
            // 
            this.showGroupBox1.addTime = 0;
            this.showGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.showGroupBox1.Name = "showGroupBox1";
            this.showGroupBox1.numCount = 0;
            this.showGroupBox1.Size = new System.Drawing.Size(275, 99);
            this.showGroupBox1.TabIndex = 0;
            this.showGroupBox1.teamName = null;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Test";
            this.Text = "Test";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Controls.ShowGroupBox showGroupBox1;
    }
}