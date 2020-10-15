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
    public partial class buyOrder : Sunny.UI.UIForm
    {
        public buyOrder()
        {
            InitializeComponent();
        }

        private void buyOrder_Load(object sender, EventArgs e)
        {
            setUIDataGV();
        }

        private void setUIDataGV()
        {
            string sql1 = "select id, date as 日期, time as 时间, totalMoney as 总金额, originAddress as 发货地址 from buyOrder order by date desc, time desc";
            //string sql2 = "select id, commodity as 商品名称, unitPrice as 单价, amount as 数量, Price 总金额, state as 状态";
            SqlHelper.setGDV(sql1, uiDataGridView1);
            uiDataGridView1.Columns[0].Visible = false;
            //SqlHelper.setGDV(sql2, uiDataGridView2);
        }

        private void uiSinsert_Click(object sender, EventArgs e)
        {
            buy.orederEdit orderedit = new orederEdit();
            orderedit.Flag = "insert";
            // 是否正常打开窗口
            if(orderedit.ShowDialog() == DialogResult.OK)
            {
                setUIDataGV();
            }
        }

        private void uiSupdate_Click(object sender, EventArgs e)
        {
            if(uiDataGridView1.SelectedRows.Count > 0)
            {
                string id = uiDataGridView1[0,uiDataGridView1.CurrentCell.RowIndex].Value.ToString();
                buy.orederEdit orderedit = new orederEdit();
                orderedit.Flag = "update|" + id;
                // 是否正常打开窗口
                if (orderedit.ShowDialog() == DialogResult.OK)
                {
                    setUIDataGV();
                }
            }   
        }

        private void uiSdelete_Click(object sender, EventArgs e)
        {
            if (uiDataGridView1.SelectedRows.Count > 0)
            {
                string id = uiDataGridView1[0, uiDataGridView1.CurrentCell.RowIndex].Value.ToString();
                // 需要判断是否已经进仓才能决定删除
            }
        }
    }
}
