﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Sinav
{
    public partial class UserPanel : Form
    {
        public UserPanel()
        {
            InitializeComponent();
        }


        private void ButtonSettings(bool set)
        {
            btnAdd.Enabled = set;
            btnUpdate.Enabled = !set;
            btnDelete.Enabled = !set;
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            ButtonSettings(true);
        }
    }
}
