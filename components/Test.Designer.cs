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
            this.stepBox1 = new TODOList.Controls.StepBox();
            this.stepBox2 = new TODOList.Controls.StepBox();
            this.SuspendLayout();
            // 
            // stepBox1
            // 
            this.stepBox1.isFinish = false;
            this.stepBox1.Location = new System.Drawing.Point(188, 175);
            this.stepBox1.Name = "stepBox1";
            this.stepBox1.Size = new System.Drawing.Size(288, 47);
            this.stepBox1.TabIndex = 0;
            // 
            // stepBox2
            // 
            this.stepBox2.isFinish = false;
            this.stepBox2.Location = new System.Drawing.Point(222, 72);
            this.stepBox2.Name = "stepBox2";
            this.stepBox2.Size = new System.Drawing.Size(288, 64);
            this.stepBox2.TabIndex = 1;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stepBox2);
            this.Controls.Add(this.stepBox1);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.StepBox stepBox1;
        private Controls.StepBox stepBox2;
    }
}