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
////////////////////////////////////////////////金凯瑞对label1控件的点击事件做了改进5.10///////////////////////////////////////////////
namespace the_Sea_of_Words
{
    public partial class login : Form
    {
        static public string userID;
        static public string userPsaaword;
        private bool nullvalue()
        {
            if (tbID.Text == "")
                return false;
            if (tbpass.Text == "")
                return false;
            return true;
        }
        //ID和密码不能输入空值
        public login()
        {
            InitializeComponent();
        }
        private void tbID_TextChanged(object sender, EventArgs e)
        {
            string s = tbID.Text;
            bool bl_exist = false;
            foreach (char c in s)
            {
                if ((!char.IsLetter(c)) && (!char.IsNumber(c))) //既不是字母又不是数字
                { bl_exist = true; }
            }
            if (bl_exist)
            {
                MessageBox.Show("ID只能包括字母和数字");
                tbID.Text = "";
            }
        }
        //对ID和密码的输入检验
        private void tbpass_TextChanged(object sender, EventArgs e)
        {
            string ss = tbpass.Text;
            bool bll_exist = false;
            foreach (char cc in ss)
            {
                if ((!char.IsLetter(cc)) && (!char.IsNumber(cc))) //既不是字母又不是数字
                { bll_exist = true; }
            }
            if (bll_exist)
            {
                MessageBox.Show("存在特殊字符");
                tbpass.Text = "";
            }
            if (ss.Length > 10)
            {
                MessageBox.Show("请设置10位以内的密码");
                tbpass.Text = "";
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            //检验不能输入空值
            if (!nullvalue())
            {
                MessageBox.Show("请输入ID与密码！");
                return;
            }
            else
            {
                OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Application.StartupPath + "\\the Sea of Words.mdb");
                //数据库建立连接
                conn.Open();
                //数据库查询语句
                OleDbCommand repeat = new OleDbCommand("select count(`ID`) from [USERS] where `ID`='" + tbID.Text + "'", conn);
                int count = Convert.ToInt32(repeat.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("ID已被占用");
                    tbID.Text = "";
                }
                //检验数据库中是否有相同ID
                else
                {
                    string a = tbID.Text.ToString();
                    MessageBox.Show(a, "ID");
                    string b = tbpass.Text.ToString();
                    MessageBox.Show(b, "密码");
                    string sql = "insert into [USERS](`ID`,`Passwords`,`LEVELS`,`Progress`,`Nextkind`) values ('" + a + "','" + b + "','1','1','打字关卡')";
                    //向数据库USERS表内添加新用户
                    OleDbCommand mycmd = new OleDbCommand(sql, conn);
                    mycmd.ExecuteNonQuery();
                    MessageBox.Show("注册成功！");
                    //给注册成功的用户初始赋值：经验值=0，等级=1，进程=1
                } 
            }   
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //检验不能输入空值
            if (!nullvalue())
            {
                MessageBox.Show("请输入ID与密码！");
                return;
            }
            else 
            {
                OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Application.StartupPath + "\\the Sea of Words.mdb");
                //数据库建立连接
                conn.Open();
                string Access = "select ID,Passwords from [USERS] where USERS.ID='" + this.tbID.Text + "'and USERS.Passwords='" + this.tbpass.Text + "'";
                //数据库查询语句
                OleDbCommand cmd = new OleDbCommand(Access, conn);
                //数据库连接完毕，执行登录操作
                OleDbDataReader hyw = cmd.ExecuteReader();
                if (hyw.Read())
                {
                    //检验输入的ID与密码与数据库中的是否相符
                    userID = tbID.Text;
                    userPsaaword = tbpass.Text;
                    maininterface Minterface = new maininterface();
                    Minterface.userID = userID ;
                    Minterface.Show();
                    this.Hide();
                    //跳转到个人主页
                }
                else
                {
                    MessageBox.Show("ID或密码错误");
                }
            }       
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\\log.jpg");
            tbID.Visible = true;
            tbpass.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
