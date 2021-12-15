﻿using System;
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
    public partial class ThongTinTK : Form
    {
        public ThongTinTK()
        {
            InitializeComponent();
            //load();
        }
        private int id;
        private string pass;
       
        public void init(int _idEmployees,string _pass)
        {
            id = _idEmployees;
            pass = _pass;
        }
       private void load()
        {       
            Enable(true);
            
           
                DataTable dt = AcountInfoControler.Instance.DataSource_GetEmployeesByID(id);
                tbUserName.Text = dt.Rows[0]["UserName"].ToString();
                tbID.Text = dt.Rows[0]["MANV"].ToString();
                tbName.Text = dt.Rows[0]["TENNV"].ToString();
                tbSalary.Text = dt.Rows[0]["HSLUONG"].ToString();
                tbTelephoneNumber.Text = dt.Rows[0]["SDT"].ToString();
                tbCountry.Text = dt.Rows[0]["QUEQUAN"].ToString();
                dtpkDateOfBirth.Value = Convert.ToDateTime(dt.Rows[0]["NGAYSINH"].ToString());
                cbbSex.Text = dt.Rows[0]["GIOITINH"].ToString();

    }
        private void Enable(bool e)
        {
            tbID.ReadOnly = e;
            tbName.ReadOnly = e;
            tbUserName.ReadOnly = e;
            tbSalary.ReadOnly = e;
            tbCountry.ReadOnly = e;
            dtpkDateOfBirth.Enabled = !e;
            tbTelephoneNumber.ReadOnly = e;
            cbbSex.Enabled = !e;

            btnChangeInfo.Enabled = e;
            btnChangePass.Enabled = e;
            btnSave.Enabled = !e;
            btnCancel.Enabled = !e;

        }

        private int ChangeInfo()
        {
            int _id = Convert.ToInt32(tbID.Text.Trim(' '));
            DateTime _dateOfBirth = dtpkDateOfBirth.Value;
            string _name = tbName.Text.Trim(' ');
            string _userName = tbUserName.Text.Trim(' ');
            int _sex;
            if (cbbSex.Text == "Nam") _sex = 1;
            else _sex = 0;
            float _salary = (float)Convert.ToDouble(tbSalary.Text);
            string _telephoneNumber = tbTelephoneNumber.Text.Trim(' ');
            string _country = tbCountry.Text.Trim(' ');
            return AcountInfoControler.Instance.ChangeAcount(_id, _name, _dateOfBirth, _sex, _userName, _country, _telephoneNumber);
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {

            ChangePass change = new ChangePass();
            change.init(id, pass);
            change.ShowDialog();
        }

        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            tbCountry.ReadOnly = false;
            dtpkDateOfBirth.Enabled = true;
            tbTelephoneNumber.ReadOnly = false;
            cbbSex.Enabled = true;

            btnChangePass.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ChangeInfo() == 1)
            {
                MessageBox.Show("Thành công!");
            }
            load();
        }

        private void ThongTinTK_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
