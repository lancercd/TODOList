﻿namespace TODOList.components
{
    partial class AfLabelBox
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
            this.edit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(3, 29);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(368, 23);
            this.edit.TabIndex = 1;
            this.edit.Text = "label1";
            this.edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit.Click += new System.EventHandler(this.onEditClick);
            // 
            // AfLabelBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.edit);
            this.Name = "AfLabelBox";
            this.Size = new System.Drawing.Size(374, 82);
            this.Click += new System.EventHandler(this.onBgClick);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label edit;
    }
}
