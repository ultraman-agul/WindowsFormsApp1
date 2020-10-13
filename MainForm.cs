using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using WindowsFormsApp1.userManage;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "你好！" + global.username + ",欢迎登录系统   ";
            toolStripStatusLabel2.Text = "  |  当前时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel3.Text = "  |  X:" + e.X.ToString() + "  |  Y:" + e.Y.ToString();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void 角色管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(global.role == "管理员")
            {
                userManage.role rr = new userManage.role();
                rr.Show();
            }
            else
            {
                MessageBox.Show("您没有该权限");
            }
        }

        private void 创建用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user uu = new user();
            uu.Show();
        }

        private void 用户管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (global.role == "管理员")
            {
                userManage.role rr = new userManage.role();
                rr.Show();
            }
            else
            {
                MessageBox.Show("您没有该权限");
            }
        }
    }
}
