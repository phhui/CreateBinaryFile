namespace CreateBinaryFile
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_filePath = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.txt_readPath = new System.Windows.Forms.TextBox();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_filePath
            // 
            this.txt_filePath.Location = new System.Drawing.Point(4, 7);
            this.txt_filePath.Name = "txt_filePath";
            this.txt_filePath.ReadOnly = true;
            this.txt_filePath.Size = new System.Drawing.Size(267, 21);
            this.txt_filePath.TabIndex = 1;
            this.txt_filePath.Text = "点击这里选择文件";
            this.txt_filePath.Click += new System.EventHandler(this.txt_filePath_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(277, 5);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(93, 23);
            this.btn_create.TabIndex = 2;
            this.btn_create.Text = "存储为二进制";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(277, 35);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(93, 23);
            this.btn_read.TabIndex = 3;
            this.btn_read.Text = "读取二进制";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // txt_readPath
            // 
            this.txt_readPath.Location = new System.Drawing.Point(6, 34);
            this.txt_readPath.Name = "txt_readPath";
            this.txt_readPath.ReadOnly = true;
            this.txt_readPath.Size = new System.Drawing.Size(265, 21);
            this.txt_readPath.TabIndex = 4;
            this.txt_readPath.Text = "点这里选择读取的文件";
            this.txt_readPath.Click += new System.EventHandler(this.txt_readPath_Click);
            // 
            // txt_value
            // 
            this.txt_value.Location = new System.Drawing.Point(6, 62);
            this.txt_value.Multiline = true;
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(357, 134);
            this.txt_value.TabIndex = 5;
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(13, 203);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(350, 309);
            this.pic.TabIndex = 6;
            this.pic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 524);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.txt_value);
            this.Controls.Add(this.txt_readPath);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.txt_filePath);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_filePath;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.TextBox txt_readPath;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.PictureBox pic;
    }
}

