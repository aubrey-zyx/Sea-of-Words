using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


//////////////////////////////////该窗口由金凯瑞完成5.9//////////////////////////////////////////
namespace the_Sea_of_Words
{
    public partial class CHNgame : Form
    {
        public string[] ENG =new string[10] ;   //定义字符串用来保存单词的英文拼写ENG和汉译CHN
        public string[] CHN = new string[10];  
        int countdown = 120;                    //倒计时
        int outnumber = 0;                      //已完成单词的个数
        int firstID = 0;                        //先点击的按钮的单词ID
        int secondID = 0;                       //后点击的按钮的单词ID
        public int XP = 0;                      //玩家获得的经验值
        public wordbutton firstbut=new wordbutton ();          //定义首先点击的按钮
        int[] layoutnumber = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };           //该变量对应20个位置给按钮，每个数字代表一个位置
        public CHNgame()
        {
            InitializeComponent();
        }

        //用于打乱数组的函数
        public int[] GetRandomNum(int[] num)
        {
            Random r = new Random();                        //创建随机类对象，定义引用变量为r
            for (int i = 0; i < num.Length; i++)
            {
                int index = r.Next(num.Length);             //随机获得0（包括0）到num.Length（不包括num.Length）的索引
                int temp = num[i];                          //当前元素和随机元素交换位置
                num[i] = num[index];
                num[index] = temp;
            }
            return num;
        }

        //根据layoutnumber的值，安排每个按钮的位置
        public void layoutbut(wordbutton belayout,int i)
        {
            int number = layoutnumber[i];
            int x = 72 + ((number-1)%5) * 150;
            int y = 50+ ((number-1) /5) * 100;
            belayout.Location = new System.Drawing.Point(x, y); ;
        }

        //将按钮根据英文和含义成对的编码，并根据打乱的数组给按钮分配位置
        public void Textassignment(wordbutton ENGbutton, wordbutton CHNbutton, int ENGnumber, int CHNnumber)
        {
            ENGbutton.wordID = ENGnumber / 2 + 1; ENGbutton.Text = ENG[ENGnumber / 2];
            CHNbutton.wordID = CHNnumber / 2 + 1; CHNbutton.Text = CHN[ENGnumber / 2];
            layoutbut(ENGbutton, ENGnumber); layoutbut(CHNbutton, CHNnumber);

        }

        //窗口加载项，为10对按钮定义Text，并安排位置
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 844;
            this.Height = 500;
            layoutnumber = GetRandomNum(layoutnumber);
            Textassignment(wordbutton1, wordbutton2, 0, 1);
            Textassignment(wordbutton3, wordbutton4, 2, 3);
            Textassignment(wordbutton5, wordbutton6, 4, 5);
            Textassignment(wordbutton7, wordbutton8, 6, 7);
            Textassignment(wordbutton9, wordbutton10, 8, 9);
            Textassignment(wordbutton11, wordbutton12, 10, 11);
            Textassignment(wordbutton13, wordbutton14, 12, 13);
            Textassignment(wordbutton15, wordbutton16, 14, 15);
            Textassignment(wordbutton17, wordbutton18, 16, 17);
            Textassignment(wordbutton19, wordbutton20, 18, 19);
        }

        //判断所选择的一对单词是否正确，并且判断闯关是否成功
        public void judge(wordbutton bechoosed)
        {
            secondID = firstID;
            firstID = bechoosed.wordID;
            bechoosed.BackColor = System.Drawing.Color.Blue;
            if (firstbut.wordID  == bechoosed .wordID  && firstbut !=null )     //如果先点击的与后点击按钮的wordID相匹配且为非空则正确，让对应的按钮消失，并记录一次正确
            {
                firstbut.Visible = false;
                bechoosed.Visible = false;
                outnumber = outnumber + 1;
            }
            else
            {
                if (firstbut != null)                                           //若两个按钮的wordID不匹配，则取消对先点击按钮的记录，并用后点击的按钮替代先点击的按钮
                {
                    firstbut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
                firstbut = bechoosed;
                }
                else                                                            //若先点击的按钮为空（第一次点击），则让本次被点中的按钮变为先点击的按钮
                {
                    firstbut = bechoosed;
                }
            }
            if (outnumber == 10)                                                //如果成功十次，则闯关成功
            {
                timer1.Enabled = false;
                XP=countdown/3 ;
                MessageBox.Show("闯关成功，获得经验值" + XP);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        //当每个按钮被点击时都会进行上述的判断
        private void wordbutton1_Click_1(object sender, EventArgs e)
        {
            judge(wordbutton1);
        }

        private void wordbutton6_Click(object sender, EventArgs e)
        {
            judge(wordbutton6);
        }

        private void wordbutton3_Click(object sender, EventArgs e)
        {
            judge(wordbutton3);
        }

        private void wordbutton5_Click(object sender, EventArgs e)
        {
            judge(wordbutton5);
        }

        private void wordbutton4_Click(object sender, EventArgs e)
        {
            judge(wordbutton4);
        }

        private void wordbutton2_Click(object sender, EventArgs e)
        {
            judge(wordbutton2);
        }

        private void wordbutton7_Click(object sender, EventArgs e)
        {
            judge(wordbutton7);
        }

        private void wordbutton8_Click(object sender, EventArgs e)
        {
            judge(wordbutton8);
        }

        private void wordbutton9_Click(object sender, EventArgs e)
        {
            judge(wordbutton9);
        }

        private void wordbutton10_Click(object sender, EventArgs e)
        {
            judge(wordbutton10);
        }

        private void wordbutton11_Click(object sender, EventArgs e)
        {
            judge(wordbutton11);
        }

        private void wordbutton12_Click(object sender, EventArgs e)
        {
            judge(wordbutton12);
        }

        private void wordbutton13_Click(object sender, EventArgs e)
        {
            judge(wordbutton13);
        }

        private void wordbutton14_Click(object sender, EventArgs e)
        {
            judge(wordbutton14);
        }

        private void wordbutton15_Click(object sender, EventArgs e)
        {
            judge(wordbutton15);
        }

        private void wordbutton16_Click(object sender, EventArgs e)
        {
            judge(wordbutton16);
        }

        private void wordbutton17_Click(object sender, EventArgs e)
        {
            judge(wordbutton17);
        }

        private void wordbutton18_Click(object sender, EventArgs e)
        {
            judge(wordbutton18);
        }

        private void wordbutton19_Click(object sender, EventArgs e)
        {
            judge(wordbutton19);
        }

        private void wordbutton20_Click(object sender, EventArgs e)
        {
            judge(wordbutton20);
        }

        //实时进行计时，当只剩10秒时，变红提醒
        private void timer1_Tick(object sender, EventArgs e)
        {
            countdown = countdown - 1;
            label1 .Text =("还剩"+countdown+"秒" );
            if (countdown <10)
            {
                label1.ForeColor = System.Drawing.Color.Red;
            }
            if (countdown <= 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("闯关失败！");
                this.Close();
            }
        }
    }

    //为方便判断英文/汉译按钮之间的对应关系，在button空间的基础上，增加一个wordID属性，新建一个类
    public class wordbutton : Button
    {
        public int wordID = 0;
    }
}
