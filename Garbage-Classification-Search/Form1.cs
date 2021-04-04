using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Garbage_Classification_Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Path.Combine(Application.StartupPath, "garbage.json");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSON File|*.json";
            dialog.InitialDirectory = Application.StartupPath;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.FileName;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "") { return; }
            ddo();
            progressBar1.Visible = false;
        }
        void ddo(){
            progressBar1.Visible = true;
            progressBar1.Value = 0;
            try
            {
                string result = "共搜索到以下结果：";
                var arr = JArray.Parse(File.ReadAllText(textBox1.Text));
                progressBar1.Maximum = arr.Count + 5;
                foreach (var obj in arr)
                {
                    progressBar1.Value++;
                    Application.DoEvents();
                    if (obj["name"].ToString().ToUpper().Contains(textBox2.Text.ToUpper()))
                    {
                        int i = int.Parse(obj["category"].ToString());
                        switch (i)
                        {
                            case 1:
                                {
                                    result+="\n"+(obj["name"]+"，"+"可回收垃圾");
                                    break;
                                }
                            case 2:
                                {
                                    result+="\n"+(obj["name"]+"，"+"有害垃圾");
                                    break;
                                }
                            case 3:
                                {
                                    result+="\n"+(obj["name"]+"，"+"可回收垃圾，有害垃圾");
                                    break;
                                }
                            case 4:
                                {
                                    result+="\n"+(obj["name"]+"，"+"湿垃圾");
                                    break;
                                }
                            case 5:
                                {
                                    result+="\n"+(obj["name"]+"，"+"可回收垃圾，湿垃圾");
                                    break;
                                }
                            case 6:
                                {
                                    result+="\n"+(obj["name"]+"，"+"有害垃圾，湿垃圾");
                                    break;
                                }
                            case 7:
                                {
                                    result+="\n"+(obj["name"]+"，"+"可回收垃圾，有害垃圾，湿垃圾");
                                    break;
                                }
                            case 8:
                                {
                                    result+="\n"+(obj["name"]+"，"+"干垃圾");
                                    break;
                                }
                            case 9:
                                {
                                    result+="\n"+(obj["name"]+"，"+"可回收垃圾，干垃圾");
                                    break;
                                }
                            case 10:
                                {
                                    result+="\n"+(obj["name"]+"，"+"有害垃圾，干垃圾");
                                    break;
                                }
                            case 11:
                                {
                                    result+="\n"+(obj["name"]+"，"+"可回收垃圾，有害垃圾，干垃圾");
                                    break;
                                }
                            case 12:
                                {
                                    result+="\n"+(obj["name"]+"，"+"湿垃圾，干垃圾");
                                    break;
                                }
                            case 13:
                                {
                                    result+="\n"+(obj["name"]+"，"+"可回收垃圾，湿垃圾，干垃圾");
                                    break;
                                }
                            case 14:
                                {
                                    result+="\n"+(obj["name"]+"，"+"有害垃圾，湿垃圾，干垃圾");
                                    break;
                                }
                            case 15:
                                {
                                    result+="\n"+(obj["name"]+"，"+"可回收垃圾，有害垃圾，湿垃圾，干垃圾");
                                    break;
                                }
                            case 16:
                                {
                                    result+="\n"+(obj["name"]+"，"+"大件垃圾");
                                    break;
                                }
                            case 17:
                                {
                                    result+="\n"+(obj["name"]+"，"+"可回收垃圾，大件垃圾");
                                    break;
                                }
                            case 18:
                                {
                                    result+="\n"+(obj["name"]+"，"+"有害垃圾，大件垃圾");
                                    break;
                                }
                            case 19:
                                {
                                    result+="\n"+(obj["name"]+"，"+"可回收垃圾，有害垃圾，大件垃圾");
                                    break;
                                }
                            case 20:
                                {
                                    result+="\n"+(obj["name"]+"，"+"湿垃圾，大件垃圾");
                                    break;
                                }
                            case 21:
                                {
                                    result+="\n"+(obj["name"]+"，"+"可回收垃圾，湿垃圾，大件垃圾");
                                    break;
                                }
                            case 22:
                                {
                                    result+="\n"+(obj["name"]+"，"+"有害垃圾，湿垃圾，大件垃圾");
                                    break;
                                }
                            case 23:
                                {
                                    result+="\n"+(obj["name"]+"，"+"可回收垃圾，有害垃圾，湿垃圾，大件垃圾");
                                    break;
                                }
                            case 24:
                                {
                                    result+="\n"+(obj["name"]+"，"+"干垃圾，大件垃圾");
                                    break;
                                }
                            case 25:
                                {
                                    result+="\n"+(obj["name"]+"，"+"可回收垃圾，干垃圾，大件垃圾");
                                    break;
                                }
                            case 26:
                                {
                                    result+="\n"+(obj["name"]+"，"+"有害垃圾，干垃圾，大件垃圾");
                                    break;
                                }
                            case 27:
                                {
                                    result+="\n"+(obj["name"]+"，"+"可回收垃圾，有害垃圾，干垃圾，大件垃圾");
                                    break;
                                }
                            case 28:
                                {
                                    result+="\n"+(obj["name"]+"，"+"湿垃圾，干垃圾，大件垃圾");
                                    break;
                                }
                            case 29:
                                {
                                    result+="\n"+(obj["name"]+"，"+"可回收垃圾，湿垃圾，干垃圾，大件垃圾");
                                    break;
                                }
                            case 30:
                                {
                                    result+="\n"+(obj["name"]+"，"+"有害垃圾，湿垃圾，干垃圾，大件垃圾");
                                    break;
                                }
                            case 31:
                                {
                                    result+="\n"+(obj["name"]+"，"+"可回收垃圾，有害垃圾，湿垃圾，干垃圾，大件垃圾");
                                    break;
                                }
                        }
                       
                    }
                    
                }
                if (result == "共搜索到以下结果：")
                    {
                        result = "没有找到结果。";
                    }
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            progressBar1.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/alexayan/garbage-classification-data/raw/master/garbage.json");
        }

    }
}
