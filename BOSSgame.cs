using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;


//////////////////////////////////////该代码由李智远完成5.9/////////////////////////////

namespace the_Sea_of_Words
{
    public partial class BOSSgame : Form
    {
        int i = 0;
        int chance = 3;//超过3次错误就闯关失败
        int jump_chance = 3;//有3次跳过不会的单词的机会
        int countdown=150;//游戏时间为150秒
        public int XP = 0;//答对单词获得的经验值计数
        public string[] ENG = new string[15];//存储本关卡的英语单词
        public string[] SENTENCE = new string[15];//存储英语单词对应的句子
        
        public BOSSgame()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 844;
            this.Height = 500;

            label1.Text = SENTENCE[i];//把英语句子label1放在一个panel里，autosize设置为false,dock设置为fill，就可实现适应游戏窗口换行。
            label2.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string strtxt = textBox1.Text.ToString();//获取textbox中输入的单词
            if (strtxt == ENG [i])
            {
                XP += 1;
                label2.Text = "XP:"+XP.ToString();//答对了label2显示当前获得的经验值
                label4.Visible = false;
            }
            else
            {
                chance--;
                label4.Text = ENG[i];//答错了label4显示该句子中汉意对应的的英语单词
                label4.Visible = true;
            }
            if (i < 14&&chance >=1)
            {
                textBox1.Clear();
                i++;                      //i的最大值为14，0~14总共15个单词
                label1.Text = SENTENCE[i];//答完一个单词更新输入框和句子
            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false;
                if (XP >= 12)              //通过BOSS关卡后有30%的概率产生随机娱乐小游戏
                {
                    
                    Random r = new Random();
                    if (r.Next(0, 100) < 30)      //通过boss关卡且概率小于30%
                    {
                        SPECIALgame gamerandom = new SPECIALgame();
                        if (gamerandom.ShowDialog() == DialogResult.OK)
                        {
                            XP = gamerandom.XP+XP ;
                            MessageBox.Show("随机游戏结束");
                        }
                    }
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("闯关成功，获得经验值"+XP);
                }
                else                     //如果闯关失败，则需要重新闯关，所以经验值清零
                {
                    XP = 0;
                    MessageBox.Show("您的单词掌握还不够熟练，本次闯关失败！");
                }             
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countdown = countdown - 1;
            label3.Text = ("还剩" + countdown + "秒");
            if (countdown <= 0)
            {
                timer1.Enabled = false;
                this.Visible = false;
                //通过BOSS关卡后有30%的概率产生随机娱乐小游戏
                
                if (XP >= 12)//通过boss关卡
                {
                    Random r = new Random();
                    if (r.Next(0, 100) < 30)  //且概率小于30%
                    {
                        SPECIALgame gamerandom = new SPECIALgame();
                        if (gamerandom.ShowDialog() == DialogResult.OK)
                        {
                            XP = gamerandom.XP + XP;
                            MessageBox.Show("随机游戏结束");
                        }
                    }
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("闯关成功，获得经验值" + XP);
                }

                //如果闯关失败，则需要重新闯关，所以经验值清零                
                else if (XP < 12)
                {
                    XP = 0;
                    MessageBox.Show("您的单词掌握还不够熟练，本次闯关失败！");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = ENG[i];
            label4.Visible = true;
            jump_chance--;
            textBox1.Clear();
            i++;
            label1.Text = SENTENCE[i];            
            if (jump_chance == 0)
                button1.Enabled = false;
            
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                button5_Click(sender, e);
                
            }
            if ((Keys)e.KeyChar == Keys.Space&&jump_chance>0)
            {
                button1_Click(sender, e);
                
            }
        }
    }
}
