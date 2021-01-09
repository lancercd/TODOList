namespace TODOList.Controls
{
    partial class ShowGroupBox
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.NumCountLabel = new System.Windows.Forms.Label();
            this.addTimeLabel = new System.Windows.Forms.Label();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.addTimeLabel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(275, 99);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Controls.Add(this.TeamNameLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.NumCountLabel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(269, 43);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // NumCountLabel
            // 
            this.NumCountLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.NumCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumCountLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NumCountLabel.Location = new System.Drawing.Point(222, 0);
            this.NumCountLabel.Name = "NumCountLabel";
            this.NumCountLabel.Size = new System.Drawing.Size(44, 43);
            this.NumCountLabel.TabIndex = 1;
            this.NumCountLabel.Text = "3人";
            this.NumCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NumCountLabel.Click += new System.EventHandler(this.onShowGroupBoxClick);
            // 
            // addTimeLabel
            // 
            this.addTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addTimeLabel.Font = new System.Drawing.Font("宋体", 15F);
            this.addTimeLabel.Location = new System.Drawing.Point(3, 49);
            this.addTimeLabel.Name = "addTimeLabel";
            this.addTimeLabel.Size = new System.Drawing.Size(269, 50);
            this.addTimeLabel.TabIndex = 1;
            this.addTimeLabel.Text = "2021.1.9 18:20";
            this.addTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addTimeLabel.Click += new System.EventHandler(this.onShowGroupBoxClick);
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.TeamNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeamNameLabel.Font = new System.Drawing.Font("黑体", 13F);
            this.TeamNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TeamNameLabel.Location = new System.Drawing.Point(3, 0);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(213, 43);
            this.TeamNameLabel.TabIndex = 0;
            this.TeamNameLabel.Text = "队伍名";
            this.TeamNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TeamNameLabel.Click += new System.EventHandler(this.onShowGroupBoxClick);
            // 
            // ShowGroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ShowGroupBox";
            this.Size = new System.Drawing.Size(275, 99);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label NumCountLabel;
        private System.Windows.Forms.Label addTimeLabel;
        private System.Windows.Forms.Label TeamNameLabel;
    }
}
