﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GetThePageRank.Client.Windows
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnOneByOne_Click(object sender, EventArgs e)
        {
            var form = new PageRankSingle();
            form.Show();
        }

        private void txtBatch_Click(object sender, EventArgs e)
        {
            var form = new PageRankBatch();
            form.Show();
        }
    }
}
