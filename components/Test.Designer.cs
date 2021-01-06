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
            this.label1 = new System.Windows.Forms.Label();
            this.iconBtn1 = new TODOList.Controls.IconBtn();
            this.label2 = new System.Windows.Forms.Label();
            this.iconBtn2 = new TODOList.Controls.IconBtn();
            this.stepBox1 = new TODOList.Controls.StepBox();
            this.taskBox1 = new TODOList.components.TaskBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::TODOList.Properties.Resources.add_red_icon;
            this.label1.Location = new System.Drawing.Point(237, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // iconBtn1
            // 
            this.iconBtn1.Image = ((System.Drawing.Image)(resources.GetObject("iconBtn1.Image")));
            this.iconBtn1.isCorrent = false;
            this.iconBtn1.isFinish = false;
            this.iconBtn1.Location = new System.Drawing.Point(160, 155);
            this.iconBtn1.Name = "iconBtn1";
            this.iconBtn1.Size = new System.Drawing.Size(288, 46);
            this.iconBtn1.TabIndex = 3;
            this.iconBtn1.title = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = global::TODOList.Properties.Resources.listingBtnDefault;
            this.label2.Location = new System.Drawing.Point(375, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // iconBtn2
            // 
            this.iconBtn2.Image = ((System.Drawing.Image)(resources.GetObject("iconBtn2.Image")));
            this.iconBtn2.isCorrent = false;
            this.iconBtn2.isFinish = false;
            this.iconBtn2.Location = new System.Drawing.Point(160, 75);
            this.iconBtn2.Name = "iconBtn2";
            this.iconBtn2.Size = new System.Drawing.Size(288, 46);
            this.iconBtn2.TabIndex = 5;
            this.iconBtn2.title = null;
            // 
            // stepBox1
            // 
            this.stepBox1.Image = ((System.Drawing.Image)(resources.GetObject("stepBox1.Image")));
            this.stepBox1.isCorrent = false;
            this.stepBox1.isFinish = false;
            this.stepBox1.Location = new System.Drawing.Point(269, 127);
            this.stepBox1.Name = "stepBox1";
            this.stepBox1.Size = new System.Drawing.Size(288, 46);
            this.stepBox1.TabIndex = 6;
            this.stepBox1.title = null;
            // 
            // taskBox1
            // 
            this.taskBox1.AutoSize = true;
            this.taskBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.taskBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taskBox1.Describe = null;
            this.taskBox1.isImportantTask = false;
            this.taskBox1.Location = new System.Drawing.Point(193, 12);
            this.taskBox1.Name = "taskBox1";
            this.taskBox1.Size = new System.Drawing.Size(395, 109);
            this.taskBox1.TabIndex = 7;
            this.taskBox1.TeskTitle = "taskBox1";
            this.taskBox1.Text = "taskBox1";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.taskBox1);
            this.Controls.Add(this.stepBox1);
            this.Controls.Add(this.iconBtn2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iconBtn1);
            this.Controls.Add(this.label1);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Controls.IconBtn iconBtn1;
        private System.Windows.Forms.Label label2;
        private Controls.IconBtn iconBtn2;
        private Controls.StepBox stepBox1;
        private TaskBox taskBox1;
    }
}