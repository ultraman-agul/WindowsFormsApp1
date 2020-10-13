using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pwd = SqlHelper.MD5Hash(textBox2.Text);
            string sql = "select role from adminTable where username = '" + textBox1.Text + "' and pwd = '" + pwd + "'";
            object result = SqlHelper.ExecuteScalar(sql);
            if (result!=null)
            {
                global.username = textBox1.Text;
                global.role = result.ToString();
                new MainForm().Show();
                this.Visible = false;
            }
            else{
                MessageBox.Show("用户名或密码错误");
            }
        }
    }
}
