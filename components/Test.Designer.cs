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
            this.afTextBox1 = new TODOList.components.AfTextBox();
            this.afLabelBox1 = new TODOList.components.AfLabelBox();
            this.iconBtn1 = new TODOList.Controls.IconBtn();
            this.SuspendLayout();
            // 
            // afTextBox1
            // 
            this.afTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.afTextBox1.Location = new System.Drawing.Point(427, 70);
            this.afTextBox1.Name = "afTextBox1";
            this.afTextBox1.Size = new System.Drawing.Size(374, 109);
            this.afTextBox1.TabIndex = 0;
            this.afTextBox1.Text = "afTextBox1";
            // 
            // afLabelBox1
            // 
            this.afLabelBox1.BackColor = System.Drawing.Color.Transparent;
            this.afLabelBox1.Location = new System.Drawing.Point(288, 185);
            this.afLabelBox1.Name = "afLabelBox1";
            this.afLabelBox1.Size = new System.Drawing.Size(374, 156);
            this.afLabelBox1.TabIndex = 1;
            this.afLabelBox1.Text = "afLabelBox1";
            // 
            // iconBtn1
            // 
            this.iconBtn1.Image = ((System.Drawing.Image)(resources.GetObject("iconBtn1.Image")));
            this.iconBtn1.isCorrent = false;
            this.iconBtn1.isFinish = false;
            this.iconBtn1.Location = new System.Drawing.Point(78, 169);
            this.iconBtn1.Name = "iconBtn1";
            this.iconBtn1.Size = new System.Drawing.Size(288, 46);
            this.iconBtn1.TabIndex = 2;
            this.iconBtn1.title = null;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iconBtn1);
            this.Controls.Add(this.afLabelBox1);
            this.Controls.Add(this.afTextBox1);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private AfTextBox afTextBox1;
        private AfLabelBox afLabelBox1;
        private Controls.IconBtn iconBtn1;
    }
}