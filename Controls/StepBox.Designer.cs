﻿namespace TODOList.Controls
{
    partial class StepBox
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
            this.stepLeftIcon = new System.Windows.Forms.Label();
            this.stepRightIcon = new System.Windows.Forms.Label();
            this.afTextBox1 = new TODOList.components.AfTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.Controls.Add(this.stepLeftIcon, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.stepRightIcon, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.afTextBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(288, 46);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.MouseLeave += new System.EventHandler(this.onMouseLeaveStepBox);
            this.tableLayoutPanel1.MouseHover += new System.EventHandler(this.onMouseHoverStepBox);
            // 
            // stepLeftIcon
            // 
            this.stepLeftIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepLeftIcon.Image = global::TODOList.Properties.Resources.unfinished;
            this.stepLeftIcon.Location = new System.Drawing.Point(3, 0);
            this.stepLeftIcon.Name = "stepLeftIcon";
            this.stepLeftIcon.Size = new System.Drawing.Size(60, 46);
            this.stepLeftIcon.TabIndex = 0;
            this.stepLeftIcon.Click += new System.EventHandler(this.onStepLeftIconClick);
            // 
            // stepRightIcon
            // 
            this.stepRightIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepRightIcon.Image = global::TODOList.Properties.Resources.close;
            this.stepRightIcon.Location = new System.Drawing.Point(244, 0);
            this.stepRightIcon.Name = "stepRightIcon";
            this.stepRightIcon.Size = new System.Drawing.Size(41, 46);
            this.stepRightIcon.TabIndex = 2;
            this.stepRightIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMouseHoverStepBox);
            this.stepRightIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.onMouseHoverStepBox);
            // 
            // afTextBox1
            // 
            this.afTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.afTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.afTextBox1.Location = new System.Drawing.Point(69, 3);
            this.afTextBox1.Name = "afTextBox1";
            this.afTextBox1.Size = new System.Drawing.Size(169, 40);
            this.afTextBox1.TabIndex = 3;
            this.afTextBox1.Text = "afTextBox1";
            this.afTextBox1.EnterPress += new System.EventHandler(this.onEnterPressEvent);
            this.afTextBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMouseHoverStepBox);
            this.afTextBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.onMouseHoverStepBox);
            // 
            // StepBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StepBox";
            this.Size = new System.Drawing.Size(288, 46);
            this.MouseLeave += new System.EventHandler(this.onMouseLeaveStepBox);
            this.MouseHover += new System.EventHandler(this.onMouseHoverStepBox);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label stepLeftIcon;
        public System.Windows.Forms.Label stepRightIcon;
        public components.AfTextBox afTextBox1;
    }
}
