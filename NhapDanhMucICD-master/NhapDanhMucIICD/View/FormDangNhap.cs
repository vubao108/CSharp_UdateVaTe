﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhapDanhMucIICD
{
    public partial class FormDangNhap : UserControl
    {
        public delegate int DelDangNhap(string id, string password);
        // return 0 if success,  -1 fall
        private string id;
        public string ID
        {
            get
            {
                return id;
            }
        }
        public DelDangNhap DangNhapHandler;
       


        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void dangnhap_Click(object sender, EventArgs e)
        {
            if ((tbID.Text.Length > 0) && (tbMatKhau.Text.Length) > 0 && (DangNhapHandler != null))

            {
                if (DangNhapHandler(tbID.Text, tbMatKhau.Text) == 0)
                {
                    lbState.Text = "Ok, dang nhap thanh cong";
                    id = tbID.Text;
                }
                else
                {
                    lbState.Text = "Sai, mat khau hoac id";
                }
            }
        }

        private void lbState_Click(object sender, EventArgs e)
        {

        }
    }
}
