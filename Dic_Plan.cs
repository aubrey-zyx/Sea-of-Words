using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

/////////////////////////////////////////////////该窗口代码均由轩语浓完成5.9///////////////////////////////////////////////////////////
////////////////////////////////////////////////金凯瑞写了Plansetting事件，进行改进5.10///////////////////////////////////////////////
namespace the_Sea_of_Words
{
    public partial class Dic_Plan : Form
    {
        public string userID;
        public Dic_Plan()
        {
            InitializeComponent();
            this.button1.Enabled = false;
            this.button2.Enabled = false;
            this.button3.Enabled = false;
            this.button4.Enabled = false ;
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = false;
            this.button4.Visible = false;

        }
        //词库选择界面

        private void buttonchoose_Click(object sender, EventArgs e)
        {
            this.button1.Visible = true;
            this.button2.Visible = true;
            this.button3.Visible = true;
            this.button4.Visible = true;
            this.button1.Enabled = true;
            this.button2.Enabled = true;
            this.button3.Enabled = true;
            this.button4.Enabled = true;
            this.buttonchoose.Visible = false;
            this.buttonchoose.Enabled = false;
            this.buttonlog.Visible = false;
            this.buttonlog.Enabled = false;
        }
        //选择四级词库
        private void button1_Click(object sender, EventArgs e)
        {
            Dicchoose(1);
            Plansetting();
        }
        //六级
        private void button2_Click(object sender, EventArgs e)
        {
            Dicchoose(2);
            Plansetting();
        }
        //雅思
        private void button3_Click(object sender, EventArgs e)
        {
            Dicchoose(3);
            Plansetting();
        }
        //托福
        private void button4_Click(object sender, EventArgs e)
        {
            Dicchoose(4);
            Plansetting();
        }
        //返回个人主页
        private void buttonlog_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        //词库选择方法
        public void Dicchoose(int i)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Application.StartupPath + "\\the Sea of Words.mdb");
            //数据库建立连接
            conn.Open();
            OleDbCommand TO = new OleDbCommand("Update [USERS] set DictionaryID='"+i+"' where `ID`='" + userID + "'", conn);
            TO.ExecuteNonQuery();
            MessageBox.Show("选择成功！");
        }

        public void Plansetting()
        {
            this.BackgroundImage = Image.FromFile(Application .StartupPath +@"\\plan.jpg");
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            buttonlog.Visible = false;
            buttonlog.Enabled = true;
            buttonchoose.Visible = false;
            buttonchoose.Enabled = true;
            textBox1.Visible = true;
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!nullvalue())
            {
                MessageBox.Show("请设置飞行计划");
            }
            else
            {
                OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Application.StartupPath + "\\the Sea of Words.mdb");
                //数据库建立连接
                conn.Open();
                //数据库更新语句，将textbox中输入的数字更新到USERS表内的Plan
                OleDbCommand cm = new OleDbCommand("Update [USERS] set Plan='" + this.textBox1.Text + "' where `ID`='" + userID + "'", conn);
                cm.ExecuteNonQuery();
                MessageBox.Show("星星听见啦！");
            }
            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\\dic.jpg");
            button1.Visible = false ;
            button2.Visible = false  ;
            button3.Visible = false  ;
            button4.Visible = false  ;
            buttonlog.Visible = true ;
            buttonchoose.Visible = true ;
            textBox1.Visible = false ;
            button5.Visible = false ;
        }
        //空值判断方法
        private bool nullvalue()
        {
            if (textBox1.Text == "")
                return false;
            if (textBox1.Text == "0")
                return false;
            return true;
        }

        private void Dic_Plan_Load(object sender, EventArgs e)
        {

        }
    }
}
