using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class Item_Store : DevExpress.XtraEditors.XtraForm
    {
        private int idEmployees;
        private int staff = 2;
        private int action = 1;
        public Item_Store()
        {
            InitializeComponent();
        }

        private void Item_Store_Load(object sender, EventArgs e)
        {
            readOnly(true);
            EnabledBtn(true);
            load();
            
        }
        public void init(int _staff, int _idEmployees)
        {
            staff = _staff;
            idEmployees = _idEmployees;

        }
        private void clear()
        {
            tbItemID.Clear();
            tbItemName.Clear();
            tbOnce.Clear();
            tbPriceIn.Clear();
            nudStored.Value = 0;
        }

        private void readOnly(bool e)
        {
            tbItemID.ReadOnly = e;
            tbItemName.ReadOnly = e;
            tbOnce.ReadOnly = e;
            tbPriceIn.ReadOnly = e;
            nudStored.ReadOnly = e;
        }
        private void EnabledBtn(bool e)
        {
            btnAddNew.Enabled = e;
            btnAdd.Enabled = e;
            btnSave.Enabled = !e;
            btnCancel.Enabled = !e;
        }
        private void load()
        {
            if (staff == 1)//là nhân viên
            {
                try
                {
                    gctListItem.DataSource = ItemControl.Instance.DataSource_GetItem();
                }
                catch { }
                pnlBtn.Hide();
                //pnlPriceIn.Hide();
                readOnly(true);
            }
            if (staff == 0)//là boss
            {
                try
                {
                    gctListItem.DataSource = ItemControl.Instance.DataSource_GetItem();
                }
                catch { }
                readOnly(true);
            }

        }
        
     
        private void GetItemInfo()
        {
            //string _id = tbItemID.Text.Trim(' ');
            try
            {
                DataTable dt = ItemControl.Instance.DataSource_GetItemByIdItem(Convert.ToInt32(tbItemID.Text.Trim(' ')));
                tbItemName.Text = dt.Rows[0]["Tên"].ToString();
                tbOnce.Text = dt.Rows[0]["Đơn vị"].ToString();
                tbPriceIn.Text = dt.Rows[0]["Giá hàng"].ToString();
                nudStored.Text = dt.Rows[0]["Tồn kho"].ToString();
            }
            catch
            {

            }

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            gctListItem.DataSource = ItemControl.Instance.DataSource_GetItem();
        }

        private void txtTimKiemHH_TextChanged(object sender, EventArgs e)
        {
            string str = txtTimKiemHH.Text;
            if (str != "")
                gctListItem.DataSource = ItemControl.Instance.DataSource_GetItemByName(str);
            else gctListItem.DataSource = ItemControl.Instance.DataSource_GetItem();
        }
    }
}
