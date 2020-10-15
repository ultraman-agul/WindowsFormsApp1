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

namespace WindowsFormsApp1.buy
{
    public partial class orederEdit : Sunny.UI.UIForm
    {
        public string flag;
        public string Flag
        {
            get { return flag; }
            set { flag = value; }
        }
        public orederEdit()
        {
            InitializeComponent();
        }

        private void orederEdit_Load(object sender, EventArgs e)
        {
            string[] str = this.flag.Split('|');
            if(str[0] == "insert")
            {
                this.Text = "新增订单";
            }
            if(str[0] == "update")
            {
                this.Text = "修改订单";
            }
        }

        // 结束每个单元格时统计订单总金额
        private void uiDataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            decimal sum = 0;
            for(int i = 0; i < uiDataGridView1.RowCount - 1; i++)
            {
                try
                {
                    sum += Convert.ToDecimal(uiDataGridView1.Rows[i].Cells[1].Value) * Convert.ToDecimal(uiDataGridView1.Rows[i].Cells[2].Value);
                }
                catch { }
            }
            uiTBsum.Text = sum.ToString();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            if(this.Text == "新增订单")
            {
                // 写入采购单上部分
                string sql = "insert into buyOrder(date,time,totalMoney,originAddress) values('" + uiDatetimePicker1.Value.ToString("yyyy/MM/dd") + "','" + uiTimePicker1.Text + "','" + uiTBsum.Text + "','" + uiTBaddress.Text + "')";
                SqlHelper.ExecuteNonQuery(sql);

                // 写入下部分
                string sql1 = "";
                for(int i = 0; i < uiDataGridView1.Rows.Count - 1; i++)
                {
                    string commodity = uiDataGridView1.Rows[i].Cells[0].Value.ToString();
                    string unitPrice = uiDataGridView1.Rows[i].Cells[1].Value.ToString();
                    string amount = uiDataGridView1.Rows[i].Cells[2].Value.ToString();
                    string Price = (Convert.ToDecimal(unitPrice) * Convert.ToDecimal(amount)).ToString();
                    sql1 += "insert into buyDetail(orderID,commodity,unitPrice,amount,Price,state) values((select top 1 id from buyOrder order by id desc), '" + commodity + "','" + unitPrice + "','" + amount + "','" + Price + "', '未入仓')";  
                }
                SqlHelper.ExecuteNonQuery(sql1);
                UIMessageBox.Show("新增采购表成功");
            }
        }
    }
}
