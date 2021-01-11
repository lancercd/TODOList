namespace TODOList
{
    partial class AssignTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyDay));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.taskListPanel = new System.Windows.Forms.Panel();
            this.taskBox1 = new TODOList.components.TaskBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.addTaskBox1 = new TODOList.components.addTaskBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.shawTimeLabel = new System.Windows.Forms.Label();
            this.childFormTitle = new System.Windows.Forms.Label();
            this.RightSidePanel = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.DetilTextBox = new TODOList.components.AfTextBox();
            this.panel21 = new System.Windows.Forms.Panel();
            this.AddToOtherBtn = new TODOList.Controls.IconBtn();
            this.panel20 = new System.Windows.Forms.Panel();
            this.AddAlertBtn = new TODOList.Controls.StepBox();
            this.AddDeadLineBtn = new TODOList.Controls.StepBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.StepPanel = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel33 = new System.Windows.Forms.Panel();
            this.RightSideTitleLabel = new System.Windows.Forms.Label();
            this.panel32 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel23.SuspendLayout();
            this.taskListPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.RightSidePanel.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel33.SuspendLayout();
            this.panel32.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel23);
            this.panel1.Controls.Add(this.RightSidePanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 693);
            this.panel1.TabIndex = 0;
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.taskListPanel);
            this.panel23.Controls.Add(this.panel4);
            this.panel23.Controls.Add(this.panel2);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel23.Location = new System.Drawing.Point(0, 0);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(689, 693);
            this.panel23.TabIndex = 5;
            // 
            // taskListPanel
            // 
            this.taskListPanel.AutoScroll = true;
            this.taskListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.taskListPanel.Controls.Add(this.taskBox1);
            this.taskListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskListPanel.Location = new System.Drawing.Point(0, 93);
            this.taskListPanel.Name = "taskListPanel";
            this.taskListPanel.Size = new System.Drawing.Size(689, 495);
            this.taskListPanel.TabIndex = 1;
            // 
            // taskBox1
            // 
            this.taskBox1.AutoSize = true;
            this.taskBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.taskBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taskBox1.Describe = null;
            this.taskBox1.isImportantTask = false;
            this.taskBox1.Location = new System.Drawing.Point(0, 0);
            this.taskBox1.Name = "taskBox1";
            this.taskBox1.Size = new System.Drawing.Size(128, 0);
            this.taskBox1.TabIndex = 0;
            this.taskBox1.TeskTitle = "taskBox1";
            this.taskBox1.Text = "taskBox1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel4.Controls.Add(this.addTaskBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 588);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(689, 105);
            this.panel4.TabIndex = 2;
            // 
            // addTaskBox1
            // 
            this.addTaskBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addTaskBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.addTaskBox1.Location = new System.Drawing.Point(31, 24);
            this.addTaskBox1.Name = "addTaskBox1";
            this.addTaskBox1.Size = new System.Drawing.Size(632, 69);
            this.addTaskBox1.TabIndex = 2;
            this.addTaskBox1.SubmitEvent += new System.EventHandler(this.onEnterSubmit);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel2.Controls.Add(this.shawTimeLabel);
            this.panel2.Controls.Add(this.childFormTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 93);
            this.panel2.TabIndex = 0;
            // 
            // shawTimeLabel
            // 
            this.shawTimeLabel.AutoSize = true;
            this.shawTimeLabel.Font = new System.Drawing.Font("宋体", 10F);
            this.shawTimeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.shawTimeLabel.Location = new System.Drawing.Point(52, 62);
            this.shawTimeLabel.Name = "shawTimeLabel";
            this.shawTimeLabel.Size = new System.Drawing.Size(268, 21);
            this.shawTimeLabel.TabIndex = 1;
            this.shawTimeLabel.Text = "1月7日,星期四 上午好啊！";
            // 
            // childFormTitle
            // 
            this.childFormTitle.AutoSize = true;
            this.childFormTitle.Font = new System.Drawing.Font("黑体", 20F);
            this.childFormTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.childFormTitle.Location = new System.Drawing.Point(40, 19);
            this.childFormTitle.Name = "childFormTitle";
            this.childFormTitle.Size = new System.Drawing.Size(151, 34);
            this.childFormTitle.TabIndex = 0;
            this.childFormTitle.Text = "我的一天";
            // 
            // RightSidePanel
            // 
            this.RightSidePanel.BackColor = System.Drawing.SystemColors.Control;
            this.RightSidePanel.Controls.Add(this.panel17);
            this.RightSidePanel.Controls.Add(this.panel18);
            this.RightSidePanel.Controls.Add(this.panel22);
            this.RightSidePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightSidePanel.Location = new System.Drawing.Point(689, 0);
            this.RightSidePanel.Name = "RightSidePanel";
            this.RightSidePanel.Size = new System.Drawing.Size(266, 693);
            this.RightSidePanel.TabIndex = 4;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel17.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel17.Location = new System.Drawing.Point(0, 659);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(266, 34);
            this.panel17.TabIndex = 2;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.SystemColors.Control;
            this.panel18.Controls.Add(this.panel19);
            this.panel18.Controls.Add(this.panel21);
            this.panel18.Controls.Add(this.panel20);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel18.Location = new System.Drawing.Point(0, 235);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(266, 377);
            this.panel18.TabIndex = 1;
            // 
            // panel19
            // 
            this.panel19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel19.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel19.Controls.Add(this.DetilTextBox);
            this.panel19.Location = new System.Drawing.Point(16, 269);
            this.panel19.Name = "panel19";
            this.panel19.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel19.Size = new System.Drawing.Size(238, 71);
            this.panel19.TabIndex = 1;
            // 
            // DetilTextBox
            // 
            this.DetilTextBox.BackColor = System.Drawing.Color.Transparent;
            this.DetilTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetilTextBox.Location = new System.Drawing.Point(10, 0);
            this.DetilTextBox.Name = "DetilTextBox";
            this.DetilTextBox.Size = new System.Drawing.Size(228, 71);
            this.DetilTextBox.TabIndex = 0;
            this.DetilTextBox.Text = "afTextBox1";
            this.DetilTextBox.EnterPress += new System.EventHandler(this.onDetilTextBox);
            // 
            // panel21
            // 
            this.panel21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel21.AutoSize = true;
            this.panel21.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel21.Controls.Add(this.AddToOtherBtn);
            this.panel21.Location = new System.Drawing.Point(16, 39);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(238, 55);
            this.panel21.TabIndex = 0;
            // 
            // AddToOtherBtn
            // 
            this.AddToOtherBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddToOtherBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddToOtherBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddToOtherBtn.Image")));
            this.AddToOtherBtn.isCorrent = false;
            this.AddToOtherBtn.isFinish = false;
            this.AddToOtherBtn.Location = new System.Drawing.Point(0, 0);
            this.AddToOtherBtn.Name = "AddToOtherBtn";
            this.AddToOtherBtn.Size = new System.Drawing.Size(238, 55);
            this.AddToOtherBtn.TabIndex = 0;
            this.AddToOtherBtn.title = null;
            this.AddToOtherBtn.IconBtnClickEvent += new System.EventHandler(this.onAddToOtherBtn);
            // 
            // panel20
            // 
            this.panel20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel20.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel20.Controls.Add(this.AddAlertBtn);
            this.panel20.Controls.Add(this.AddDeadLineBtn);
            this.panel20.Location = new System.Drawing.Point(16, 120);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(238, 126);
            this.panel20.TabIndex = 1;
            // 
            // AddAlertBtn
            // 
            this.AddAlertBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddAlertBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddAlertBtn.Image")));
            this.AddAlertBtn.isCorrent = false;
            this.AddAlertBtn.isFinish = false;
            this.AddAlertBtn.Location = new System.Drawing.Point(0, 46);
            this.AddAlertBtn.Name = "AddAlertBtn";
            this.AddAlertBtn.Size = new System.Drawing.Size(238, 46);
            this.AddAlertBtn.TabIndex = 1;
            this.AddAlertBtn.title = null;
            this.AddAlertBtn.EnterPressEvent += new System.EventHandler(this.onAddAlertBtn);
            // 
            // AddDeadLineBtn
            // 
            this.AddDeadLineBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddDeadLineBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddDeadLineBtn.Image")));
            this.AddDeadLineBtn.isCorrent = false;
            this.AddDeadLineBtn.isFinish = false;
            this.AddDeadLineBtn.Location = new System.Drawing.Point(0, 0);
            this.AddDeadLineBtn.Name = "AddDeadLineBtn";
            this.AddDeadLineBtn.Size = new System.Drawing.Size(238, 46);
            this.AddDeadLineBtn.TabIndex = 0;
            this.AddDeadLineBtn.title = null;
            this.AddDeadLineBtn.EnterPressEvent += new System.EventHandler(this.onAddDeadLineBtn);
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel22.Controls.Add(this.StepPanel);
            this.panel22.Controls.Add(this.panel24);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel22.Location = new System.Drawing.Point(0, 0);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(266, 235);
            this.panel22.TabIndex = 0;
            // 
            // StepPanel
            // 
            this.StepPanel.AutoSize = true;
            this.StepPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StepPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StepPanel.Location = new System.Drawing.Point(0, 62);
            this.StepPanel.Name = "StepPanel";
            this.StepPanel.Size = new System.Drawing.Size(266, 173);
            this.StepPanel.TabIndex = 1;
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.panel33);
            this.panel24.Controls.Add(this.panel32);
            this.panel24.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel24.Location = new System.Drawing.Point(0, 0);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(266, 62);
            this.panel24.TabIndex = 0;
            // 
            // panel33
            // 
            this.panel33.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel33.Controls.Add(this.RightSideTitleLabel);
            this.panel33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel33.Location = new System.Drawing.Point(79, 0);
            this.panel33.Name = "panel33";
            this.panel33.Size = new System.Drawing.Size(187, 62);
            this.panel33.TabIndex = 1;
            // 
            // RightSideTitleLabel
            // 
            this.RightSideTitleLabel.AutoSize = true;
            this.RightSideTitleLabel.Font = new System.Drawing.Font("黑体", 15F);
            this.RightSideTitleLabel.Location = new System.Drawing.Point(29, 23);
            this.RightSideTitleLabel.Name = "RightSideTitleLabel";
            this.RightSideTitleLabel.Size = new System.Drawing.Size(90, 25);
            this.RightSideTitleLabel.TabIndex = 0;
            this.RightSideTitleLabel.Text = "label4";
            // 
            // panel32
            // 
            this.panel32.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel32.Controls.Add(this.radioButton1);
            this.panel32.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel32.Location = new System.Drawing.Point(0, 0);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(79, 62);
            this.panel32.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton1.Image = global::TODOList.Properties.Resources.circle;
            this.radioButton1.Location = new System.Drawing.Point(0, 0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 62);
            this.radioButton1.TabIndex = 0;
            // 
            // MyDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 693);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyDay";
            this.Text = "MyDay";
            this.panel1.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.taskListPanel.ResumeLayout(false);
            this.taskListPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.RightSidePanel.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel24.ResumeLayout(false);
            this.panel33.ResumeLayout(false);
            this.panel33.PerformLayout();
            this.panel32.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel taskListPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Panel RightSidePanel;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel StepPanel;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Panel panel33;
        private System.Windows.Forms.Panel panel32;
        private System.Windows.Forms.Label RightSideTitleLabel;
        private System.Windows.Forms.Label shawTimeLabel;
        private System.Windows.Forms.Label childFormTitle;
        private components.addTaskBox addTaskBox1;
        private Controls.IconBtn AddToOtherBtn;
        private components.AfTextBox DetilTextBox;
        private components.TaskBox taskBox1;
        private System.Windows.Forms.Label radioButton1;

        private Controls.StepBox addStepBox;
        private Controls.StepBox AddAlertBtn;
        private Controls.StepBox AddDeadLineBtn;
    }
}