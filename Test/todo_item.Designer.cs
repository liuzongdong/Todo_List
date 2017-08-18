namespace Test
{
    partial class todo_item
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
            this.components = new System.ComponentModel.Container();
            this.checkButton = new Bunifu.Framework.UI.BunifuCheckbox();
            this.todo_text = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(148)))), ((int)(((byte)(246)))));
            this.checkButton.ChechedOffColor = System.Drawing.Color.Silver;
            this.checkButton.Checked = true;
            this.checkButton.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(148)))), ((int)(((byte)(246)))));
            this.checkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkButton.ForeColor = System.Drawing.Color.White;
            this.checkButton.Location = new System.Drawing.Point(26, 24);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(20, 20);
            this.checkButton.TabIndex = 0;
            this.checkButton.OnChange += new System.EventHandler(this.checkButton_OnChange);
            // 
            // todo_text
            // 
            this.todo_text.AutoSize = true;
            this.todo_text.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todo_text.Location = new System.Drawing.Point(73, 16);
            this.todo_text.Margin = new System.Windows.Forms.Padding(0);
            this.todo_text.Name = "todo_text";
            this.todo_text.Size = new System.Drawing.Size(104, 28);
            this.todo_text.TabIndex = 1;
            this.todo_text.Text = "to do item";
            this.todo_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // todo_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.todo_text);
            this.Controls.Add(this.checkButton);
            this.Name = "todo_item";
            this.Size = new System.Drawing.Size(441, 65);
            this.Load += new System.EventHandler(this.todo_item_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCheckbox checkButton;
        private Bunifu.Framework.UI.BunifuCustomLabel todo_text;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
