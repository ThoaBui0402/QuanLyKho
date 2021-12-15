﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace QuanLyKho
{
    class AcountInfoControler
    {
        private static AcountInfoControler instance;

        public static AcountInfoControler Instance
        {
            get
            {
                if (instance == null)
                    instance = new AcountInfoControler();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private AcountInfoControler() { }

        public DataTable DataSource_GetEmployeesByID(int id)
        {
          
            string query = @"exec SP_getEmployeesByID @id";
         
            return DataProvider.Instances.ExecuteQuery(query, new object[] { @id });
        }
        //string _id, DateTime _dateOfBirth, string _name=null, string _userName = null, string _pass = null,  bool _sex = true, float _salary = 0, string _telephoneNumber = null, string _type= null
        public int ChangeAcount(int _id, string _name, DateTime _dateOfBirth, int _sex, string _userName, string _country, string _telephoneNumber)
        {
            string query = @"exec SP_ChangeAcountInfo @id, @dateOfBirth , @sex, @userName, @country, @telephonNunber";
            try
            {
                return DataProvider.Instances.ExecuteNonQuery(query, new object[] { _id, _dateOfBirth, _sex, _userName, _country, _telephoneNumber });
            }
            catch
            {
                MessageBox.Show("sai");
                return 0;
            }
        }
    }
}
