namespace Test
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Header = new System.Windows.Forms.Panel();
            this.ExitApp = new Bunifu.Framework.UI.BunifuImageButton();
            this.ClearAll = new Bunifu.Framework.UI.BunifuImageButton();
            this.appName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.addItem = new Bunifu.Framework.UI.BunifuImageButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.input_text = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClearAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addItem)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(148)))), ((int)(((byte)(246)))));
            this.Header.Controls.Add(this.ExitApp);
            this.Header.Controls.Add(this.ClearAll);
            this.Header.Controls.Add(this.appName);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(478, 84);
            this.Header.TabIndex = 0;
            // 
            // ExitApp
            // 
            this.ExitApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(148)))), ((int)(((byte)(246)))));
            this.ExitApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitApp.Image = ((System.Drawing.Image)(resources.GetObject("ExitApp.Image")));
            this.ExitApp.ImageActive = null;
            this.ExitApp.Location = new System.Drawing.Point(431, 25);
            this.ExitApp.Name = "ExitApp";
            this.ExitApp.Size = new System.Drawing.Size(35, 34);
            this.ExitApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitApp.TabIndex = 2;
            this.ExitApp.TabStop = false;
            this.ExitApp.Zoom = 0;
            this.ExitApp.Click += new System.EventHandler(this.ExitApp_Click);
            // 
            // ClearAll
            // 
            this.ClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(148)))), ((int)(((byte)(246)))));
            this.ClearAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearAll.Image = ((System.Drawing.Image)(resources.GetObject("ClearAll.Image")));
            this.ClearAll.ImageActive = null;
            this.ClearAll.Location = new System.Drawing.Point(12, 25);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(35, 34);
            this.ClearAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClearAll.TabIndex = 1;
            this.ClearAll.TabStop = false;
            this.ClearAll.Zoom = 0;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appName.ForeColor = System.Drawing.Color.White;
            this.appName.Location = new System.Drawing.Point(154, 26);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(164, 32);
            this.appName.TabIndex = 0;
            this.appName.Text = "C# To Do App";
            // 
            // addItem
            // 
            this.addItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.addItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addItem.Image = ((System.Drawing.Image)(resources.GetObject("addItem.Image")));
            this.addItem.ImageActive = null;
            this.addItem.Location = new System.Drawing.Point(404, 587);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(62, 55);
            this.addItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addItem.TabIndex = 1;
            this.addItem.TabStop = false;
            this.addItem.Zoom = 0;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Location = new System.Drawing.Point(12, 90);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(466, 491);
            this.mainPanel.TabIndex = 3;
            // 
            // input_text
            // 
            this.input_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_text.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_text.ForeColor = System.Drawing.Color.Black;
            this.input_text.HintForeColor = System.Drawing.Color.Empty;
            this.input_text.HintText = "";
            this.input_text.isPassword = false;
            this.input_text.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.input_text.LineIdleColor = System.Drawing.Color.Gray;
            this.input_text.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.input_text.LineThickness = 2;
            this.input_text.Location = new System.Drawing.Point(19, 585);
            this.input_text.Margin = new System.Windows.Forms.Padding(4);
            this.input_text.Name = "input_text";
            this.input_text.Size = new System.Drawing.Size(383, 46);
            this.input_text.TabIndex = 4;
            this.input_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.appName;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(478, 647);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.input_text);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClearAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel Header;
        private Bunifu.Framework.UI.BunifuCustomLabel appName;
        private Bunifu.Framework.UI.BunifuImageButton addItem;
        private System.Windows.Forms.Panel mainPanel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox input_text;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton ClearAll;
        private Bunifu.Framework.UI.BunifuImageButton ExitApp;
    }
}

