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
    public partial class LoginForm : Sunny.UI.UIForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uiButton2_Click_1(object sender, EventArgs e)
        {
            string pwd = SqlHelper.MD5Hash(uiTextBox2.Text);
            string sql = "select role from adminTable where username = '" + uiTextBox1.Text + "' and pwd = '" + pwd + "'";
            object result = SqlHelper.ExecuteScalar(sql);
            if (result!=null)
            {
                global.username = uiTextBox1.Text;
                global.role = result.ToString();
                new MainForm().Show();
                this.Visible = false;
            }
            else{
                MessageBox.Show("用户名或密码错误");
            }
        }

        private void uiTextBox2_Click(object sender, EventArgs e)
        {
            this.uiSymbolLabel2.Symbol = 61758;
        }

        private void uiTextBox2_TextChanged(object sender, EventArgs e)
        {
            this.uiSymbolLabel2.Symbol = 61758;
        }
    }
}
