﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPF1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ขอมลพนกงานToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new WPF1.Employee.UI.Employeelist().ShowDialog();
        }
    }
}
