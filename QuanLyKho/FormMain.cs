using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace QuanLyKho
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private int typeOfEmployees;
        private int idEmployees;
        private string passWord;
        private string nameEmployees;

        public int TypeOfEmployees
        {
            get
            {
                return typeOfEmployees;
            }

            set
            {
                typeOfEmployees = value;
            }
        }

        public int IdEmployees
        {
            get
            {
                return idEmployees;
            }

            set
            {
                idEmployees = value;
            }
        }

        public string PassWord
        {
            get
            {
                return passWord;
            }

            set
            {
                passWord = value;
            }
        }

        public string NameEmployees
        {
            get
            {
                return nameEmployees;
            }

            set
            {
                nameEmployees = value;
            }
        }
        public void init(int _typeOfEmployees, int _idEmployees, string _passWord, string _name)
        {
            TypeOfEmployees = _typeOfEmployees;
            IdEmployees = _idEmployees;
            passWord = _passWord;
            nameEmployees = _name;
        }
        private void VisibleRpg(bool e)
        {
            rpgEmployees.Visible = e;
            rpgStock.Visible = e;

        }
        private void EnabledBtn(bool e)
        {
            btnAcountInfo.Enabled = e;
            btnLogout.Enabled = e;
            btnPrivilege.Enabled = e;
        }
        //private void load(int _type)
        //{

        //    VisibleRpg(false);

        //    if (_type == 0)
        //    {
        //        rpgStock.Visible = true;

        //    }
        //    if (_type == 1)
        //    {
        //        rpgEmployees.Visible = true;
        //    }
        //}
        private void showFormChild(Form f)
        {
            if (!isOpened(f))
            {
                f.MdiParent = this;
                f.Show();
            }
        }
        private bool isOpened(Form f)
        {
            bool isOpened = false;
            if (MdiChildren.Count() > 0)
            {
                foreach (var item in MdiChildren)
                {
                    if (f.Name == item.Name)
                    {
                        xtmm.Pages[item].MdiChild.Activate();
                        isOpened = true;
                    }
                }
            }
            return isOpened;
        }

        private void login_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnLogin.Enabled = false;
            LOGIN login = new LOGIN();
            login.ShowDialog();
            this.Hide();
        }

        private void thongtin_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThongTinTK info = new ThongTinTK();
            info.init(idEmployees, passWord);
            showFormChild(info);
        }

        private void phanquyen_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void dangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn đăng xuất?", "Xác minh", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
                Application.Exit();
        }

        private void qlmh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Item_Store item = new Item_Store();
            item.init(typeOfEmployees, idEmployees);
            item.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //load(typeOfEmployees);
        }

        private void hdthemmh_ItemClick(object sender, ItemClickEventArgs e)
        {
            helpThemMH hp = new helpThemMH();
            hp.Show();
        }

        private void bntdndx_ItemClick(object sender, ItemClickEventArgs e)
        {
            helpDN_DX hp = new helpDN_DX();
            hp.Show();
        }

        private void tonkho_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void dspn_ItemClick(object sender, ItemClickEventArgs e)
        {
            ListReceipt_Vou h = new ListReceipt_Vou();
            h.Show();
        }

        private void dspx_ItemClick(object sender, ItemClickEventArgs e)
        {
            ListIssue_Vou k = new ListIssue_Vou();
            k.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            PhieuNhap info = new PhieuNhap();

            info.InitData(NameEmployees, idEmployees);
            showFormChild(info);
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {
          //  Application.Exit();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            Item_Store info = new Item_Store();
            info.init(typeOfEmployees, idEmployees);
            showFormChild(info);
        }

        private void qlkh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Customer_Store info = new Customer_Store();
            showFormChild(info);
        }

        private void qlncc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Supplier_Store info = new Supplier_Store();
            showFormChild(info);
        }

        private void qlnv_ItemClick(object sender, ItemClickEventArgs e)
        {
            Employees_Store info = new Employees_Store();
            showFormChild(info);
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            Help_phieu info = new Help_phieu();
            showFormChild(info);

        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            Help_NhanVien info = new Help_NhanVien();
            showFormChild(info);
        }

          private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
          {
               Issue_Vou info = new Issue_Vou();
               info.InitData(NameEmployees, idEmployees);
               showFormChild(info);
          }
     }
}