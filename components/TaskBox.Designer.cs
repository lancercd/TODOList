namespace TODOList.components
{
    partial class TaskBox
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LeftPanl = new System.Windows.Forms.Panel();
            this.LeftIcon = new System.Windows.Forms.Label();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.RightIcon = new System.Windows.Forms.Label();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.TaskTitleLabel = new System.Windows.Forms.Label();
            this.DescribePanel = new System.Windows.Forms.Panel();
            this.DescribeText = new System.Windows.Forms.Label();
            this.LeftPanl.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.CenterPanel.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.DescribePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanl
            // 
            this.LeftPanl.Controls.Add(this.LeftIcon);
            this.LeftPanl.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanl.Location = new System.Drawing.Point(0, 0);
            this.LeftPanl.Name = "LeftPanl";
            this.LeftPanl.Size = new System.Drawing.Size(62, 60);
            this.LeftPanl.TabIndex = 0;
            // 
            // LeftIcon
            // 
            this.LeftIcon.Image = global::TODOList.Properties.Resources.circle;
            this.LeftIcon.Location = new System.Drawing.Point(9, 12);
            this.LeftIcon.Name = "LeftIcon";
            this.LeftIcon.Size = new System.Drawing.Size(40, 37);
            this.LeftIcon.TabIndex = 0;
            this.LeftIcon.MouseLeave += new System.EventHandler(this.OnMouseLeaveTaskBox);
            this.LeftIcon.MouseHover += new System.EventHandler(this.OnMouseHoverTaskBox);
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.RightIcon);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(654, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(66, 60);
            this.RightPanel.TabIndex = 1;
            // 
            // RightIcon
            // 
            this.RightIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightIcon.Image = global::TODOList.Properties.Resources.start_empty;
            this.RightIcon.Location = new System.Drawing.Point(0, 0);
            this.RightIcon.Name = "RightIcon";
            this.RightIcon.Size = new System.Drawing.Size(66, 60);
            this.RightIcon.TabIndex = 0;
            this.RightIcon.Click += new System.EventHandler(this.addToImportantIconClick);
            // 
            // CenterPanel
            // 
            this.CenterPanel.Controls.Add(this.TitlePanel);
            this.CenterPanel.Controls.Add(this.DescribePanel);
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(62, 0);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(592, 60);
            this.CenterPanel.TabIndex = 2;
            // 
            // TitlePanel
            // 
            this.TitlePanel.Controls.Add(this.TaskTitleLabel);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(592, 36);
            this.TitlePanel.TabIndex = 0;
            this.TitlePanel.MouseLeave += new System.EventHandler(this.OnMouseLeaveTaskBox);
            this.TitlePanel.MouseHover += new System.EventHandler(this.OnMouseHoverTaskBox);
            // 
            // TaskTitleLabel
            // 
            this.TaskTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TaskTitleLabel.AutoSize = true;
            this.TaskTitleLabel.Font = new System.Drawing.Font("黑体", 12F);
            this.TaskTitleLabel.Location = new System.Drawing.Point(6, 11);
            this.TaskTitleLabel.Name = "TaskTitleLabel";
            this.TaskTitleLabel.Size = new System.Drawing.Size(59, 20);
            this.TaskTitleLabel.TabIndex = 0;
            this.TaskTitleLabel.Text = "任务1";
            // 
            // DescribePanel
            // 
            this.DescribePanel.Controls.Add(this.DescribeText);
            this.DescribePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DescribePanel.Location = new System.Drawing.Point(0, 36);
            this.DescribePanel.Name = "DescribePanel";
            this.DescribePanel.Size = new System.Drawing.Size(592, 24);
            this.DescribePanel.TabIndex = 0;
            this.DescribePanel.MouseLeave += new System.EventHandler(this.OnMouseLeaveTaskBox);
            this.DescribePanel.MouseHover += new System.EventHandler(this.OnMouseHoverTaskBox);
            // 
            // DescribeText
            // 
            this.DescribeText.AutoSize = true;
            this.DescribeText.Font = new System.Drawing.Font("宋体", 10F);
            this.DescribeText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DescribeText.Location = new System.Drawing.Point(12, 5);
            this.DescribeText.Name = "DescribeText";
            this.DescribeText.Size = new System.Drawing.Size(0, 21);
            this.DescribeText.TabIndex = 0;
            // 
            // TaskBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanl);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "TaskBox";
            this.Size = new System.Drawing.Size(720, 60);
            this.Load += new System.EventHandler(this.TaskBoxTest_Load);
            this.MouseHover += new System.EventHandler(this.OnMouseHoverTaskBox);
            this.LeftPanl.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.CenterPanel.ResumeLayout(false);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.DescribePanel.ResumeLayout(false);
            this.DescribePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanl;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.Panel DescribePanel;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label LeftIcon;
        private System.Windows.Forms.Label TaskTitleLabel;
        private System.Windows.Forms.Label DescribeText;
        private System.Windows.Forms.Label RightIcon;
    }
}
