using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.userManage
{
    public partial class role : Form
    {
        public role()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void role_Load(object sender, EventArgs e)
        {
            string sql = "select id as 编号, rolename as 角色名称 from roleTable";
            SqlHelper.setGDV(sql, dataGridView1);
        }

        // 打开操作管理
        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        // 关闭操作管理
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            groupBox1.Visible = false;
        }

        // 新增/修改角色
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into roleTable values('" + textBox1.Text + "','" + textBox2.Text + "')";
                SqlHelper.ExecuteNonQuery(sql);
            }
            catch
            {
                string sql1 = "update roleTable set rolename = '" + textBox2.Text + "' where id = '" + textBox1.Text + "'";
                SqlHelper.ExecuteNonQuery(sql1);
            }
            MessageBox.Show("成功");
            SqlHelper.setGDV("select id as 编号, rolename as 角色名称 from roleTable", dataGridView1);
        }

        // 修改角色
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                string rolename = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                groupBox1.Visible = true;
                textBox1.Text = id;
                textBox2.Text = rolename;
            }
        }

        // 删除角色
        private void button2_Click(object sender, EventArgs e)
        {
            string id = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            string rolename = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            SqlHelper.ExecuteNonQuery("delete from roleTable where id = '"+id+"'");
            MessageBox.Show("删除角色成功");
            SqlHelper.setGDV("select id as 编号, rolename as 角色名称 from roleTable", dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
