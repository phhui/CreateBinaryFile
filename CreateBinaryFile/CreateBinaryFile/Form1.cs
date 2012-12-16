using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CreateBinaryFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void changeFile(TextBox tb)
        {
            OpenFileDialog fb = new OpenFileDialog();
            if (fb.ShowDialog() == DialogResult.OK)
            {
                tb.Text = fb.FileName;
            }
        }
        private void txt_filePath_Click(object sender, EventArgs e)
        {
            changeFile(txt_filePath);
        }

        private void txt_readPath_Click(object sender, EventArgs e)
        {
            changeFile(txt_readPath);
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string fileNameTime = Directory.GetCurrentDirectory() + "\\" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".bitt";//获取当前程序路径并以当前系统时间为文件名创建文本文件
            FileStream myStream = new FileStream(fileNameTime, FileMode.Create);//创建文件
            BinaryWriter myWriter = new BinaryWriter(myStream);
            byte a = 0xff;
            myWriter.Write(File.ReadAllBytes(txt_filePath.Text));//向文件写入二进制值
            myWriter.Close();
            myStream.Close();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = File.OpenText(txt_readPath.Text))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    txt_value.Text = s;
                }
                pic.Image = Image.FromStream(sr.BaseStream);
            }
        }
    }
}
