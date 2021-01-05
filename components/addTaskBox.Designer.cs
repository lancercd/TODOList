namespace TODOList.components
{
    partial class addTaskBox
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
            this.addTastRightBox = new System.Windows.Forms.Panel();
            this.addTaskBoxLabel = new System.Windows.Forms.Label();
            this.addTaskIcon = new System.Windows.Forms.Label();
            this.addTaskInputBox = new TODOList.components.AfTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.addTastRightBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.addTastRightBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.addTaskIcon, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(806, 69);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // addTastRightBox
            // 
            this.addTastRightBox.Controls.Add(this.addTaskInputBox);
            this.addTastRightBox.Controls.Add(this.addTaskBoxLabel);
            this.addTastRightBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addTastRightBox.Location = new System.Drawing.Point(65, 3);
            this.addTastRightBox.Name = "addTastRightBox";
            this.addTastRightBox.Size = new System.Drawing.Size(738, 63);
            this.addTastRightBox.TabIndex = 4;
            // 
            // addTaskBoxLabel
            // 
            this.addTaskBoxLabel.Font = new System.Drawing.Font("宋体", 16F);
            this.addTaskBoxLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addTaskBoxLabel.Location = new System.Drawing.Point(3, 13);
            this.addTaskBoxLabel.Name = "addTaskBoxLabel";
            this.addTaskBoxLabel.Size = new System.Drawing.Size(180, 34);
            this.addTaskBoxLabel.TabIndex = 2;
            this.addTaskBoxLabel.Text = "添加任务";
            this.addTaskBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addTaskBoxLabel.Click += new System.EventHandler(this.onAddTaskBoxFocus);
            // 
            // addTaskIcon
            // 
            this.addTaskIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addTaskIcon.Image = global::TODOList.Properties.Resources.adding;
            this.addTaskIcon.Location = new System.Drawing.Point(3, 0);
            this.addTaskIcon.Name = "addTaskIcon";
            this.addTaskIcon.Size = new System.Drawing.Size(56, 69);
            this.addTaskIcon.TabIndex = 1;
            this.addTaskIcon.Click += new System.EventHandler(this.onAddTaskBoxFocus);
            // 
            // addTaskInputBox
            // 
            this.addTaskInputBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addTaskInputBox.Location = new System.Drawing.Point(236, 13);
            this.addTaskInputBox.Name = "addTaskInputBox";
            this.addTaskInputBox.Size = new System.Drawing.Size(374, 44);
            this.addTaskInputBox.TabIndex = 3;
            this.addTaskInputBox.TextBoxLostFoucs += new System.EventHandler(this.onAddTaskBoxBlur);
            this.addTaskInputBox.TextBoxGotFoucs += new System.EventHandler(this.onAddTaskBoxFocus);
            // 
            // addTaskBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "addTaskBox";
            this.Size = new System.Drawing.Size(806, 69);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.addTastRightBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label addTaskIcon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label addTaskBoxLabel;
        private System.Windows.Forms.Panel addTastRightBox;
        private AfTextBox addTaskInputBox;
    }
}
