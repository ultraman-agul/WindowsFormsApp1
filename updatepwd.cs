using Sunny.UI;
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
    public partial class updatepwd : Sunny.UI.UIForm
    {
        public updatepwd()
        {
            InitializeComponent();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            
            string pwd = SqlHelper.MD5Hash(uiTextBox1.Text);
            //UIMessageBox.Show(SqlHelper.MD5Hash(uiTextBox1.Text));
            string sql = "select * from adminTable where pwd = '" + pwd + "' and username = '" + global.username + "'";
            if(uiTextBox2.Text != uiTextBox3.Text)
            {
                UIMessageBox.Show("新密码不一致");
                return;
            }
            if (SqlHelper.ExecuteScalar(sql) != null)
            {
                try
                {
                    string newpwd = SqlHelper.MD5Hash(uiTextBox2.Text);
                    SqlHelper.ExecuteNonQuery("update adminTable set pwd = '" + newpwd + "' where username = '" + global.username + "'");
                }
                catch { }
                UIMessageBox.Show("修改成功");
            }
        }
    }
}
