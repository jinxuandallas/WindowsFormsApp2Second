namespace WindowsFormsApp2Second
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
            this.button1 = new System.Windows.Forms.Button();
            this.label_SelectedFile = new System.Windows.Forms.Label();
            this.button_Rename = new System.Windows.Forms.Button();
            this.textBox_Newname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_RenameConfirm = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Copy = new System.Windows.Forms.Button();
            this.label_notify = new System.Windows.Forms.Label();
            this.button_DestinationConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Destination = new System.Windows.Forms.Button();
            this.label_DestinationPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "选择文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_SelectedFile
            // 
            this.label_SelectedFile.AutoSize = true;
            this.label_SelectedFile.Location = new System.Drawing.Point(154, 40);
            this.label_SelectedFile.Name = "label_SelectedFile";
            this.label_SelectedFile.Size = new System.Drawing.Size(0, 12);
            this.label_SelectedFile.TabIndex = 1;
            this.label_SelectedFile.TextChanged += new System.EventHandler(this.label_SelectedFile_TextChanged);
            // 
            // button_Rename
            // 
            this.button_Rename.Enabled = false;
            this.button_Rename.Location = new System.Drawing.Point(54, 96);
            this.button_Rename.Name = "button_Rename";
            this.button_Rename.Size = new System.Drawing.Size(75, 23);
            this.button_Rename.TabIndex = 2;
            this.button_Rename.Text = "重命名";
            this.button_Rename.UseVisualStyleBackColor = true;
            this.button_Rename.Click += new System.EventHandler(this.button_Rename_Click);
            // 
            // textBox_Newname
            // 
            this.textBox_Newname.Enabled = false;
            this.textBox_Newname.Location = new System.Drawing.Point(221, 96);
            this.textBox_Newname.Name = "textBox_Newname";
            this.textBox_Newname.Size = new System.Drawing.Size(151, 21);
            this.textBox_Newname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "新文件名：";
            // 
            // button_RenameConfirm
            // 
            this.button_RenameConfirm.Enabled = false;
            this.button_RenameConfirm.Location = new System.Drawing.Point(399, 95);
            this.button_RenameConfirm.Name = "button_RenameConfirm";
            this.button_RenameConfirm.Size = new System.Drawing.Size(75, 23);
            this.button_RenameConfirm.TabIndex = 5;
            this.button_RenameConfirm.Text = "确认";
            this.button_RenameConfirm.UseVisualStyleBackColor = true;
            this.button_RenameConfirm.Click += new System.EventHandler(this.button_RenameConfirm_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Enabled = false;
            this.button_Delete.Location = new System.Drawing.Point(54, 126);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 6;
            this.button_Delete.Text = "删除";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Copy
            // 
            this.button_Copy.Enabled = false;
            this.button_Copy.Location = new System.Drawing.Point(54, 155);
            this.button_Copy.Name = "button_Copy";
            this.button_Copy.Size = new System.Drawing.Size(75, 23);
            this.button_Copy.TabIndex = 6;
            this.button_Copy.Text = "复制";
            this.button_Copy.UseVisualStyleBackColor = true;
            this.button_Copy.Click += new System.EventHandler(this.button_Copy_Click);
            // 
            // label_notify
            // 
            this.label_notify.AutoSize = true;
            this.label_notify.ForeColor = System.Drawing.Color.Red;
            this.label_notify.Location = new System.Drawing.Point(52, 65);
            this.label_notify.Name = "label_notify";
            this.label_notify.Size = new System.Drawing.Size(77, 12);
            this.label_notify.TabIndex = 7;
            this.label_notify.Text = "文件名不正确";
            this.label_notify.Visible = false;
            // 
            // button_DestinationConfirm
            // 
            this.button_DestinationConfirm.Enabled = false;
            this.button_DestinationConfirm.Location = new System.Drawing.Point(399, 156);
            this.button_DestinationConfirm.Name = "button_DestinationConfirm";
            this.button_DestinationConfirm.Size = new System.Drawing.Size(75, 23);
            this.button_DestinationConfirm.TabIndex = 10;
            this.button_DestinationConfirm.Text = "确认";
            this.button_DestinationConfirm.UseVisualStyleBackColor = true;
            this.button_DestinationConfirm.Click += new System.EventHandler(this.button_DestinationConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "复制到：";
            // 
            // button_Destination
            // 
            this.button_Destination.Enabled = false;
            this.button_Destination.Location = new System.Drawing.Point(221, 155);
            this.button_Destination.Name = "button_Destination";
            this.button_Destination.Size = new System.Drawing.Size(75, 23);
            this.button_Destination.TabIndex = 10;
            this.button_Destination.Text = "选择";
            this.button_Destination.UseVisualStyleBackColor = true;
            this.button_Destination.Click += new System.EventHandler(this.button_Destination_Click);
            // 
            // label_DestinationPath
            // 
            this.label_DestinationPath.AutoSize = true;
            this.label_DestinationPath.Location = new System.Drawing.Point(313, 162);
            this.label_DestinationPath.Name = "label_DestinationPath";
            this.label_DestinationPath.Size = new System.Drawing.Size(41, 12);
            this.label_DestinationPath.TabIndex = 11;
            this.label_DestinationPath.Text = "label3";
            this.label_DestinationPath.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_DestinationPath);
            this.Controls.Add(this.button_Destination);
            this.Controls.Add(this.button_DestinationConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_notify);
            this.Controls.Add(this.button_Copy);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_RenameConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Newname);
            this.Controls.Add(this.button_Rename);
            this.Controls.Add(this.label_SelectedFile);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_SelectedFile;
        private System.Windows.Forms.Button button_Rename;
        private System.Windows.Forms.TextBox textBox_Newname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_RenameConfirm;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Copy;
        private System.Windows.Forms.Label label_notify;
        private System.Windows.Forms.Button button_DestinationConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Destination;
        private System.Windows.Forms.Label label_DestinationPath;
    }
}

