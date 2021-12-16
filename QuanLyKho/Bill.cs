using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Collections.Generic;

namespace QuanLyKho
{
     public partial class Bill : DevExpress.XtraReports.UI.XtraReport
     {
          public Bill()
          {
               InitializeComponent();
          }
          public void InitData(string _customerName, string _employeesName,
                          int _totalPriceBill, DateTime _dateOfBill, int _customerGive, int _employeesGive, List<IssueVouDetailMod> list)
          {
              CustomerGive.Value = _customerGive;
              EmployeesGive.Value = _employeesGive;
              CustomerName.Value = _customerName;
              EmployeesName.Value = _employeesName;
              TotalPriceBill.Value = _totalPriceBill;
              DateOfBill.Value = _dateOfBill;
              objectDataSource1.DataSource = list;
          }
     }
}
