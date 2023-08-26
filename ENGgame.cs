using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


/////////////////////////////////////////本窗口代码由郑雅璇完成5.9/////////////////////////////
//////////////////////////////////金凯瑞整合时对frmTyping_Load方法进行了改进5.10///////////////
namespace the_Sea_of_Words
{
    public partial class ENGgame : Form
    {
        public static ENGgame frmtyping;
        public ENGgame()
        {
            InitializeComponent();
            frmtyping = this;
            txtScore.Text = "经验值：" + XP;
        }

        public int life=3;
        public int XP;
        public int level;
        int skill1 = 1;//电磁脉冲可使用次数
        int skill2 = 1;//时间鱼雷可使用次数
        public string[] ENG=new string[10];
        public string[] CHN=new string[10];
        string aircraftpic;

        private void frmTyping_Load(object sender, EventArgs e)
        {
            this.Width = 844;
            this.Height = 500;
            tmWord.Start();
            tmGame.Start();
            switch (level)
            {
                case 1:
                    aircraftpic =@"\1.png";
                    skill1 = 1;
                    skill2 = 1;
                    break ;
                case 2:
                    aircraftpic = @"\2.png";
                    skill1 = 2;
                    skill2 = 2;
                    break;
                case 3:
                    aircraftpic = @"\3.png";
                    skill1 = 3;
                    skill2 = 3;
                    break;
                case 4:
                    aircraftpic = @"\4.png";
                    skill1 = 4;
                    skill2 = 4;
                    break;
                case 5:
                    aircraftpic = @"\5.png";
                    skill1 = 5;
                    skill2 = 5;
                    break;

            }
            pictureBox1.Image = Image.FromFile(Application.StartupPath + aircraftpic);
            label1.Text = "电磁脉冲*" + skill1;//更新可使用次数
            label2.Text = "时间鱼雷*" + skill2;//更新可使用次数
        }

        static int c = 0;//控制每局10个单词掉落
        static int over = 0;//判断游戏结束
        private void tmWord_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            Label lblWord = new Label();//生成新单词碎片
            lblWord.Text = ENG[c] + "\n" + CHN[c];//上排显示英文 下排显示中文           
            lblWord.AutoSize = false;
            lblWord.Height = 30;
            lblWord.Width = 88;
            lblWord.Left = r.Next(5, this.Width - 85);//从页面上方随机一处出现
            lblWord.Font = new Font("Arial", 9, FontStyle.Regular);
            lblWord.TextAlign = ContentAlignment.MiddleCenter;
            lblWord.BackColor = Color.LightBlue;
            this.Controls.Add(lblWord);
            if (c == 9)
            {
                tmWord.Stop();
                over = 1;
            }
            else
                c++;
        }

        private void tmGame_Tick(object sender, EventArgs e)
        {
            foreach (Control con in this.Controls)
            {
                if ((con is Label)&&(con != label1)&&(con !=label2)&&(con != label3))
                {
                    if (con.Top >= this.Height - 150)
                    {
                        con.Dispose(); //错过单词 碎片消失
                        life--;
                        txtLife.Text = "生命值：" + life;//更新生命值
                        if (life <= 0)
                        {
                            c = 0;
                            tmGame.Stop();
                            tmWord.Stop();
                            MessageBox.Show("闯关失败！");
                        }
                    }
                    else
                        con.Top += 4;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            foreach (Control con in this.Controls)
            {
                if ((con is Label) && (con != label1) && (con != label2) && (con != label3))
                {
                    string[] strArr = con.Text.Split("\n".ToCharArray());
                    string eng = strArr[0].Trim();//获取label中第一行的英文
                    if (eng == s)//若有匹配的则对应碎片消失，文本框清空
                    {
                        con.Dispose();                      
                        textBox1.Clear();
                        IfOver();
                        break;
                    }
                }
            }
        }

        //判断是否挑战成功
        private void IfOver()
        {
            int labelnum=0;
            foreach (Control con in this.Controls)
            {
                if (con is Label)                
                {
                    labelnum++;
                }              
            }
            if((over==1)&&(labelnum==3))
            {
                XP = 10;
                tmGame.Stop();
                MessageBox.Show("闯关成功，获得经验值"+XP );
                c = 0;
                over = 0;
                this.DialogResult = DialogResult.OK;
            }
        }

        //电磁脉冲 5秒内不再出现新单词
        private void button1_Click(object sender, EventArgs e)
        {
            skill1--;
            label1.Text = "电磁脉冲*" + skill1;//更新可使用次数
            if (skill1 == 0)
                button1.Enabled = false;
            tmPause.Start();
            tmWord.Stop();
        }

        //控制电磁脉冲
        private void tmPause_Tick(object sender, EventArgs e)
        {
            tmPause.Stop();
            tmWord.Start();
        }

        //时间鱼雷 画面静止5秒
        private void button2_Click(object sender, EventArgs e)
        {
            skill2--;
            label2.Text = "时间鱼雷*" + skill2;//更新可使用次数
            if (skill2 == 0)
                button2.Enabled = false;
            tmPause2.Start();
            tmWord.Stop();
            tmGame.Stop();
        }

        //控制时间鱼雷
        private void tmPause2_Tick(object sender, EventArgs e)
        {
            tmPause2.Stop();
            tmWord.Start();
            tmGame.Start();
        }
    }
}
