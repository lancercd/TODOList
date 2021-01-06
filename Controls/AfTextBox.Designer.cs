using TODOList.Controls;

namespace TODOList.components
{
    partial class AfTextBox
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.edit = new PlaceholderTextBox();
            this.SuspendLayout();
            // 
            // edit
            // 
            this.edit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edit.Font = new System.Drawing.Font("宋体", 13F);
            this.edit.Location = new System.Drawing.Point(22, 38);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(334, 25);
            this.edit.TabIndex = 0;
            this.edit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onEnterPress);
            // 
            // AfTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.edit);
            this.Name = "AfTextBox";
            this.Size = new System.Drawing.Size(374, 109);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //public System.Windows.Forms.TextBox edit;
        public PlaceholderTextBox edit;
    }
}
