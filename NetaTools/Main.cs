﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetaTools
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Hide();
            //CreateTableSqlScript form = new CreateTableSqlScript();
            //form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            ReplaceFiles form = new ReplaceFiles();
            form.ShowDialog();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            ReleaseBiliDown form = new ReleaseBiliDown();
            form.ShowDialog();
        }
    }
}
