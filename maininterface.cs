using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Media;


////////////////////////////////////////金凯瑞完成前261行代码5.9////////////////////////////////////////
////////////////////////////////////////从262行到最后的代码均由李兴旺完成5.9////////////////////////////
namespace the_Sea_of_Words
{
    public partial class maininterface : Form
    {
        public string userID;              //用户账号
        string Con = @"Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Application.StartupPath + "\\the Sea of Words.mdb";   //定义数据库路径
        int nextword;                      //下一关卡用到的单词中第一个单词的序号
        int userprogress;                  //用户的进度
        int userdictionary;                //用户所选择的词库
        string usernextkind;               //下一个关卡的类型
        public int userxp;                 //用户的经验值
        int userlevel;                     //用户的等级
        int userplan;                      //用户的计划
        string aircraftname;               //用户战机的名称
        string levelname;                  //用户等级对应的军衔
        public maininterface()
        {
            InitializeComponent();
        }

        //主界面刷新，用于每次用户数据发生变化之后实时刷新主界面的数据
        public void refreshmain()
        {
            string dictionaryname="";                  //词库的名称

            using (OleDbConnection dbconn = new OleDbConnection(Con))                    //从数据库中提取数据
            {
                string openprogress = "SELECT Progress,Nextkind,XP,LEVELS,DictionaryID,Plan FROM USERS WHERE ID=\"" + userID + "\"";
                OleDbDataAdapter progressdata = new OleDbDataAdapter(openprogress, dbconn);
                DataSet progressdataset = new DataSet();
                progressdata.Fill(progressdataset);
                userprogress  = Convert.ToInt16(progressdataset.Tables[0].Rows[0]["Progress"]);
                userdictionary =Convert.ToInt16(progressdataset.Tables[0].Rows[0]["DictionaryID"]);
                usernextkind = progressdataset.Tables[0].Rows[0]["Nextkind"].ToString();
                userxp =Convert.ToInt16(progressdataset.Tables[0].Rows[0]["XP"]);
                userlevel = Convert.ToInt16(progressdataset.Tables[0].Rows[0]["LEVELS"]); 
                userplan = Convert.ToInt16(progressdataset.Tables[0].Rows[0]["Plan"]); 
            }

            switch (userdictionary)                  //根据用户所选择的字典以及进度，确定下一关卡用到的单词中第一个单词的序号，以及词库名称
            {
                case 1:
                    nextword = userprogress;
                    dictionaryname = "CET-4";
                    break;
                case 2:
                    nextword = 35 + userprogress;
                    dictionaryname = "CET-6";
                    break;
                case 3:
                    nextword = 70 + userprogress;
                    dictionaryname = "IELTS";
                    break;
                case 4:
                    nextword = 100 + userprogress;
                    dictionaryname = "TOEFL";
                    break;
            }

            double xpbar=userxp ;                    //经验值条的长度的变量
            string aircraft=@"1.png";                //存储战机图片的变量

            switch (userlevel)                       //根据用户等级和经验确定（经验值条的长度、战机名称、军衔、战机图片）
            {
                case 1:
                    xpbar = xpbar * 340 / 150;
                    aircraftname = "鹘鹰";
                    levelname = "一等兵";
                    aircraft = @"\1.png";
                    break;
                case 2:
                    xpbar = xpbar * 340 / 300;
                    aircraftname = "火鸟";
                    levelname = "少尉";
                    aircraft = @"\2.png";
                    break;
                case 3:
                    xpbar = xpbar * 340 / 1500;
                    aircraftname = "飞鲨";
                    levelname = "少校";
                    aircraft = @"\3.png";
                    break;
                case 4:
                    xpbar = 340;
                    aircraftname = "飞豹";
                    levelname = "少将";
                    aircraft = @"\4.png";
                    break;
                case 5:
                    xpbar = 340;
                    aircraftname = "威龙";
                    levelname = "大将";
                    aircraft = @"\5.png";
                    break;                     
            }

                                                     //更新主界面所显示的（账号、经验值/经验值条、等级、军衔、进度、下个关卡、词库、每日任务、战机名称/图片）
            ID.Text = "您的账号：" + userID;
            XPlabel.Text = "您的经验值：" + userxp;
            LEVELlabel.Text = "您的等级：Lv" + userlevel + " 军衔：" + levelname;
            Progresslabel.Text = "您已学习单词：" + (userprogress - 1) * 10;
            NEXTlabel.Text = "下个关卡：" + usernextkind;
            DIClabel.Text = "您的词库：" + dictionaryname;
            PLANlabel.Text = "每日任务：" + userplan;
            aircaftNamelabel.Text = "您的战机：" + aircraftname;
            pictureBox3.Width =Convert .ToInt16 ( xpbar);
            pictureBox2.Width = 345;
            playeraircraft .Image =Image .FromFile (Application.StartupPath + aircraft );
        }

        //根据usernextkind变量打开相应的游戏界面（如果没有确定词库和进度则不能开始）
        private void button1_Click(object sender, EventArgs e)
        {
            if ((userdictionary == 0) || (userplan == 0))
            {
                MessageBox.Show("您还没有设置词库和进度，请点击主界面-词库/计划按钮");
            }
            else
            {
                if (usernextkind == "打字关卡")
                {
                    ENGgame game = new ENGgame();
                    this.Hide();
                    ENGgamebegin(game);
                    this.Show();
                }
                else
                {
                    if (usernextkind == "汉译关卡")
                    {
                        CHNgame game = new CHNgame();
                        this.Hide();
                        CHNgamebegin(game);
                        this.Show();
                    }
                    else
                    {
                        if (usernextkind == "BOSS关卡")
                        {
                            BOSSgame game = new BOSSgame();
                            BOSSgamebegin(game);
                        }
                        else
                        {
                            MessageBox.Show("系统故障，请您重新启动");
                        }
                    }
                }
            }
        }

        //打字关卡启动
        public void ENGgamebegin(ENGgame game)
        {
            //定义数据库命令字符串变量（根据nextword，即下一关卡用到的单词中第一个单词的序号，提取对应的单词和汉译）
            string command = "SELECT WordID,ENG,CHN FROM WORD WHERE WordID>" + ((nextword - 1) * 10) + " AND WordID<" + ((nextword * 10) + 1);    
            using (OleDbConnection dbconn = new OleDbConnection(Con))             //连接数据库，将数据库中的单词的英文和汉译赋值给游戏窗口
            {
                OleDbDataAdapter words = new OleDbDataAdapter(command, dbconn);
                DataSet wordb = new DataSet();
                words.Fill(wordb);
                for (int i = 0; i < 10; i++)
                {
                    game.ENG[i] = wordb.Tables[0].Rows[i]["ENG"].ToString();
                    game.CHN[i] = wordb.Tables[0].Rows[i]["CHN"].ToString();
                }
            }

            game.level = userlevel;                          //将玩家等级信息传递给窗口
            game.XP = userxp;                                //将玩家经验值信息传递给窗口

            if (game.ShowDialog() == DialogResult.OK)        //令窗口显示，若结果为OK则更新玩家数据
            {
                MessageBox.Show("XP=" + game.XP);
                userdataupdate(game.XP);
            }
        }

        //汉译关卡启动
        public void CHNgamebegin(CHNgame game)
        {
            //定义数据库命令字符串变量（根据nextword，即下一关卡用到的单词中第一个单词的序号，提取对应的单词和汉译）
            string command = "SELECT WordID,ENG,CHN FROM WORD WHERE WordID>" + ((nextword - 1) * 10) + " AND WordID<" + ((nextword * 10) + 1);
            using (OleDbConnection dbconn = new OleDbConnection(Con))             //连接数据库，将数据库中的单词的英文和汉译赋值给游戏窗口
            {
                OleDbDataAdapter words = new OleDbDataAdapter(command, dbconn);
                DataSet wordb = new DataSet();
                words.Fill(wordb);
                for (int i = 0; i < 10; i++)
                {
                    game.ENG[i] = wordb.Tables[0].Rows[i]["ENG"].ToString();
                    game.CHN[i] = wordb.Tables[0].Rows[i]["CHN"].ToString();
                }
            }

            if (game.ShowDialog() == DialogResult.OK)                //令窗口显示，若结果为OK则更新玩家数据
            {
                MessageBox.Show("XP=" + game.XP);
                userdataupdate(game.XP);
            }
        }

        //BOSS关卡启动
        public void BOSSgamebegin(BOSSgame game)
        {
            //定义数据库命令字符串变量（根据nextword，即下一关卡用到的单词中第一个单词的序号，提取对应的单词和汉译）
            string command = "SELECT WordID,ENG,Sentence FROM WORD WHERE WordID>" + ((nextword - 5) * 10) + " AND WordID<" + ((nextword * 10) + 1);
            //定义一个整数组值为0-49，打乱后前15个的值为所选择的单词
            int[] chooseword = new int[50];
            for (int i = 0; i < 50; i++)
            {
                chooseword[i] = i;
            }
            chooseword = GetRandomNum(chooseword);                         //打乱数组

            using (OleDbConnection dbconn = new OleDbConnection(Con))      //连接数据库，将数据库中的单词的英文和句子赋值给游戏窗口
            {
                OleDbDataAdapter words = new OleDbDataAdapter(command, dbconn);
                DataSet wordb = new DataSet();
                words.Fill(wordb);
                for (int i = 0; i < 15; i++)
                {
                    game.ENG[i] = wordb.Tables[0].Rows[chooseword[i]]["ENG"].ToString();
                    game.SENTENCE[i] = wordb.Tables[0].Rows[chooseword[i]]["Sentence"].ToString();
                }
            }

            if (game.ShowDialog() == DialogResult.OK)                      //令窗口显示，若结果为OK则更新玩家数据
            {
                MessageBox.Show("XP=" + game.XP);
                userdataupdate(game.XP);
            }
        }
        //打乱一个数组（用于BOSS关卡启动）
        public int[] GetRandomNum(int[] num)
        {
            Random r = new Random();                             //创建随机类对象，定义引用变量为r
            for (int i = 0; i < num.Length; i++)
            {
                int index = r.Next(num.Length);                 //随机获得0（包括0）到num.Length（不包括num.Length）的索引
                int temp = num[i];                              //当前元素和随机元素交换位置
                num[i] = num[index];
                num[index] = temp;
            }
            return num;
        }


        //玩家数据更新
        public void userdataupdate(int XP)
        {
            int userXP=0;                  //用户经验值
            int userlevel=0;               //用户等级
            int nextword;                  //下一组单词的序号
            string useropen = "SELECT * FROM USERS WHERE ID=\""+userID+ "\"";  //提取数的数据库命令的字符串
            string userupdate ;            //
            using (OleDbConnection dbconn = new OleDbConnection(Con))
            {
                //经验值、等级更新
                OleDbDataAdapter users = new OleDbDataAdapter(useropen, dbconn);
                DataSet userdata = new DataSet();
                users.Fill(userdata);
                userXP = Convert.ToInt32(userdata .Tables [0].Rows [0]["XP"]);        //提取经验值
                userlevel = Convert.ToInt16(userdata.Tables[0].Rows[0]["LEVELS"]);    //提取等级
                nextword = Convert.ToInt16(userdata.Tables[0].Rows[0]["Progress"]);   //提取进度
                userXP = userXP + XP;    //为经验值赋新值

                switch (userlevel)     //根据玩家等级和经验值判断是否升级
                {
                    case 1:
                        if (userXP >= 150)
                        {
                            userlevel++;
                            userXP = userXP - 150;
                        }
                        break;
                    case 2:
                        if (userXP >= 300)
                        {
                            userlevel++;
                            userXP = userXP - 300;
                        }
                        break;
                    case 3:
                        if (userXP >= 1500)
                        {
                            userlevel++;
                            userXP = userXP - 1500;
                        }
                        break;
                }
                if (nextword >= 300)     //如果玩家完成某一词库（即nextword为300，因为任一词库均为300*10个单词），则升级为最高级-5级
                {
                    userlevel = 5;
                }

                //进度变量更新（根据现在的"下个关卡"，确定下一个"下个关卡"）
                if (usernextkind == "打字关卡")           //对于任意10个单词玩家都必须先通过打字关卡，再通过汉译关卡。每50个单词遇到一个BOSS关卡
                {
                    usernextkind = "汉译关卡";
                }
                else
                {
                    if (usernextkind == "汉译关卡")
                    {
                        if (nextword % 5 != 0)
                        {
                            usernextkind = "打字关卡";
                            nextword++;
                        }
                        else
                        {
                            usernextkind = "BOSS关卡";
                        }
                    }
                    else
                    {
                        usernextkind = "打字关卡";
                        nextword++;
                    }
                }
                //定义数据库更新语句的字符串
                userupdate = "UPDATE USERS SET XP=" + userXP + ",LEVELS=" + userlevel + ",Progress=" + nextword  + ",Nextkind=\"" + usernextkind  + "\" WHERE ID=\"" + userID + "\"";
                OleDbCommand dataupdate = new OleDbCommand(userupdate  , dbconn);
                try
                {
                    dbconn.Open();
                    int number = dataupdate.ExecuteNonQuery();
                    MessageBox.Show(string.Format("存档成功", number));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("存档失败:{0}", ex.Message));
                }
            }
            //更新完所有数据之后刷新主界面
            refreshmain();
        }

        //加载窗口启动大小，并循环播放背景音乐
        private void maininterface_Load(object sender, EventArgs e)
        {
            this.Width = 844;
            this.Height = 500;
            refreshmain();
            SoundPlayer sp = new SoundPlayer(Application.StartupPath + "\\music.wav");
            sp.PlayLooping();
        }

        //开启背景音乐
        private void music_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(Application.StartupPath + "\\music.wav");
            sp.PlayLooping();
        }
        //关闭背景音乐
        private void musicclose_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(Application.StartupPath + "\\music.wav");
            sp.Stop();
        }

        //退出游戏
        private void qutigame_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        //进行词库及进度设置
        private void button1_Click_1(object sender, EventArgs e)
        {
            Dic_Plan choose = new Dic_Plan();
            choose.userID = userID;
            if (choose.ShowDialog ()== DialogResult.OK)
            {
                refreshmain ();
            }
        }
    }
}
