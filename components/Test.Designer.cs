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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.label3 = new System.Windows.Forms.Label();
            this.iconBtn1 = new TODOList.Controls.IconBtn();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // iconBtn1
            // 
            this.iconBtn1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.iconBtn1.Image = ((System.Drawing.Image)(resources.GetObject("iconBtn1.Image")));
            this.iconBtn1.isCorrent = false;
            this.iconBtn1.isFinish = false;
            this.iconBtn1.Location = new System.Drawing.Point(320, 81);
            this.iconBtn1.Name = "iconBtn1";
            this.iconBtn1.Size = new System.Drawing.Size(288, 46);
            this.iconBtn1.TabIndex = 9;
            this.iconBtn1.title = null;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iconBtn1);
            this.Controls.Add(this.label3);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private Controls.IconBtn iconBtn1;
    }
}