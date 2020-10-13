using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.userManage
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        // 修改用户
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string username = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                string rolename = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                groupBox1.Visible = true;
                textBox1.Text = username;
                comboBox1.Text = rolename;
            }
        }

        // 关闭操作管理
        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

        }

        // 插入/ 修改用户
        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void filldgv()
        {
            SqlHelper.setGDV("select username as 用户名, roleTable.rolename as 角色 from adminTable,roleTable where adminTable.role <> '管理员' and adminTable.role = roleTable.id", dataGridView1);
        }

        private void user_Load(object sender, EventArgs e)
        {
            SqlHelper.setCBB("select id +'|'+ rolename as good from roleTable","good",comboBox1);
            filldgv();
        }

        // 保存
        private void button6_Click(object sender, EventArgs e)
        {
            string pwd = SqlHelper.MD5Hash(textBox2.Text);
            string[] str = comboBox1.Text.Split('|');
            try
            {
                SqlHelper.ExecuteNonQuery("insert into adminTable(username, pwd,role) values('" + textBox1.Text + "','" + pwd + "','" + str[0] + "')");
            }
            catch
            {
                SqlHelper.ExecuteNonQuery("update adminTable set role = '" + str[0] + "' where username='" + textBox1.Text + "'");
            }
            MessageBox.Show("成功！");
            filldgv();
        }

        // 删除用户
        private void button2_Click(object sender, EventArgs e)
        {
            string username = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            //string rolename = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            SqlHelper.ExecuteNonQuery("delete from adminTable where username = '" + username + "'");
            MessageBox.Show("删除用户成功");
            filldgv();
        }
    }
}
