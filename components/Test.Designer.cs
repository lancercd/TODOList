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
            this.labelButton1 = new TODOList.Controls.LabelButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelButton1
            // 
            this.labelButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelButton1.isSelect = true;
            this.labelButton1.Location = new System.Drawing.Point(108, 136);
            this.labelButton1.Name = "labelButton1";
            this.labelButton1.Size = new System.Drawing.Size(170, 69);
            this.labelButton1.TabIndex = 0;
            this.labelButton1.Text = "labelButton1";
            this.labelButton1.LabelBtnClick += new System.EventHandler(this.labelButton1_LabelBtnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 20F);
            this.label1.Location = new System.Drawing.Point(419, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelButton1);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.LabelButton labelButton1;
        private System.Windows.Forms.Label label1;
    }
}