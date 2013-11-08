using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GetThePageRank.Client.Windows
{
    public partial class PageRankSingle : Form
    {
        public PageRankSingle()
        {
            InitializeComponent();
        }

        #region Events

          public void changeEmail(object sender, EventArgs e)
        {
            ChangeEmail();
        }

        public void changeURL(object sender, EventArgs e)
        {
            ChangeURL();
        }
        #endregion
        #region functions
        
        private void ChangeEmail() {
            string Email = txtEmail.Text;
            int Result = GetThePageRank.DLL.GooglePR.MyPageRankFromMail(Email);
            SetResult(Result, Email);
        }
        private void ChangeURL() {
            string URL = txtURL.Text;
            int Result = GetThePageRank.DLL.GooglePR.MyPageRank(URL);
            SetResult(Result, URL);
            
        }
        private void SetResult(int Rank, string label)
        {
            lblResultInfo.Text = label;
            lblResultPageRank.Text = Rank.ToString();

            if (chkCopyResultsToClipboard.Checked)
                System.Windows.Forms.Clipboard.SetText(Rank.ToString());
        }
        #endregion


    }
}
