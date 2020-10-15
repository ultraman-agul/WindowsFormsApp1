using FontAwesome.Sharp;
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
    public partial class MainForm : Sunny.UI.UIForm
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
            icon_welcome.Text = "你好！" + global.username + ",欢迎登录系统   ";
            icon_time.Text = " 当前时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // 切换子窗体时，填充到父窗体中
        private void addForm(Form childForm)
        {
            this.splitContainer1.Panel2.Controls.Clear();
            childForm.FormBorderStyle = FormBorderStyle.None; //隐藏子窗体边框（去除最小花，最大化，关闭等按钮）
            childForm.TopLevel = false; //指示子窗体非顶级窗体
            this.splitContainer1.Panel2.Controls.Add(childForm);//将子窗体载入panel
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
        }

        // 商品管理
        private void iconButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void splitContainer1_Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            icon_xy.Text = "    X:" + e.X.ToString() + "  |  Y:" + e.Y.ToString();
        }

        // 用户管理
        private void icon_user_Click(object sender, EventArgs e)
        {
            if (global.role == "管理员")
            {
                userManage.user userform = new user();
                addForm(userform);
            }
            else
            {
                MessageBox.Show("您没有该权限");
            }
        }

        // 鼠标移动到iconbutton上
        private void icon_goods_MouseMove(object sender, MouseEventArgs e)
        {
            IconButton senderIconButton = (IconButton)sender;
            senderIconButton.BackColor = Color.FromArgb(255, 128, 128);
        }

        // 鼠标在iconbutton上移开
        private void icon_goods_MouseLeave(object sender, EventArgs e)
        {
            IconButton senderIconButton = (IconButton)sender;
            senderIconButton.BackColor = Color.FromArgb(128, 128, 255);
        }

        // 角色管理
        private void icon_role_Click(object sender, EventArgs e)
        {
            if (global.role == "管理员")
            {
                userManage.role rr = new userManage.role();
                addForm(rr);
            }
            else
            {
                MessageBox.Show("您没有该权限");
            }
        }

        // 退出系统
        private void icon_out_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void icon_updatepwd_Click(object sender, EventArgs e)
        {
            updatepwd up = new updatepwd();
            addForm(up);
        }

        private void icon_Buy_Click(object sender, EventArgs e)
        {
            new buy.buyOrder().Show();
        }
    }
}
