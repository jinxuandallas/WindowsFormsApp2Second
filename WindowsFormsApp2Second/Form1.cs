using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.Devices;
using System.IO;

namespace WindowsFormsApp2Second
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = "d:\\";

            if (file.ShowDialog() == DialogResult.OK)
            {
                label_SelectedFile.Text = file.FileName;

                button_Rename.Enabled = true;
                button_Delete.Enabled = true;
                button_Copy.Enabled = true;

                label_notify.Visible = false;
            }
        }

        private void button_Rename_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(label_SelectedFile.Text))
                return;
            textBox_Newname.Enabled = true;
            button_RenameConfirm.Enabled = true;

        }

        private void button_RenameConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(label_SelectedFile.Text))
                return;
            label_notify.Visible = true;
            bool opResult = Regex.IsMatch(textBox_Newname.Text, @"(?!((^(con)$)|^(con)\\..*|(^(prn)$)|^(prn)\\..*|(^(aux)$)|^(aux)\\..*|(^(nul)$)|^(nul)\\..*|(^(com)[1-9]$)|^(com)[1-9]\\..*|(^(lpt)[1-9]$)|^(lpt)[1-9]\\..*)|^\\s+|.*\\s$)(^[^\\\\\\/\\:\\<\\>\\*\\?\\\\\\""\\\\|]{1,255}$)");
            if (!opResult)
            {
                label_notify.Text = "文件名不正确";
                return;
            }

            Computer mc = new Computer();
            mc.FileSystem.RenameFile(label_SelectedFile.Text, textBox_Newname.Text);
            label_notify.Text = "修改成功";

            label_SelectedFile.Text = "";

            textBox_Newname.Text = "";
            textBox_Newname.Enabled = false;
            button_RenameConfirm.Enabled = false;

        }

        private void label_SelectedFile_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(label_SelectedFile.Text))
            {
                button_Rename.Enabled = false;
                button_Delete.Enabled = false;
                button_Copy.Enabled = false;
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(label_SelectedFile.Text))
                return;
            File.Delete(label_SelectedFile.Text);
            label_notify.Visible = true;
            label_notify.Text = "删除成功";
            label_SelectedFile.Text = "";
        }

        private void button_Copy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(label_SelectedFile.Text))
                return;

            button_Destination.Enabled = true;
        }

        private void button_Destination_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.SelectedPath = @"d:\";
            if (folder.ShowDialog() == DialogResult.OK)
            {
                label_DestinationPath.Visible = true;
                label_DestinationPath.Text = folder.SelectedPath;
                button_DestinationConfirm.Enabled = true;
            }
        }

        private void button_DestinationConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(label_SelectedFile.Text) || string.IsNullOrWhiteSpace(label_DestinationPath.Text))
                return;
            FileInfo file = new FileInfo(label_SelectedFile.Text);

            button_Destination.Enabled = false;
            label_DestinationPath.Visible = false;
            button_DestinationConfirm.Enabled = false;



            file.CopyTo(label_DestinationPath.Text + @"\" + file.Name, true);

            label_notify.Visible = true;
            label_notify.Text = "复制成功";
            label_SelectedFile.Text = "";


        }
    }
}
