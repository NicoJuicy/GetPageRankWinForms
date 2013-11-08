using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GetThePageRank.DLL;
using System.Text.RegularExpressions;

namespace GetThePageRank.Client.Windows
{
    public partial class PageRankBatch : Form
    {
        public List<string> BannedDomains { get; set; }

        public PageRankBatch()
        {
            InitializeComponent();
            chkListType.SelectedIndex = 0;
            txtData.Focus();
            FillBannedDomains();
        }
        private void FillBannedDomains() {
            BannedDomains = new List<string>();
            BannedDomains.Add("skynet.be");
            BannedDomains.Add("gmail.com");
            BannedDomains.Add("hotmail.com");
            BannedDomains.Add("live.be");
            BannedDomains.Add("outlook.com");
            BannedDomains.Add("telenet.be");
            BannedDomains.Add("pandora.be");
            BannedDomains.Add("scarlet.be");
            BannedDomains.Add("belgacom.net");
            BannedDomains.Add("base.be");
            BannedDomains.Add("busmail.net");
        }

        private void ChangeData(object sender, EventArgs e)
        {
            DataChanged();
        }
        private void DataChanged()
        {


            string Data = txtData.Text;
            string split = txtSplit.Text;

            //char[] SplitChar ={char.Parse("\r"),char.Parse("\n")};
            if (string.IsNullOrEmpty(split))
            {
                split ="\r\n";
            }

            switch (chkListType.Text)
            {
                case "Email":
                    dataChangedEmail(Data, split);
                    break;
                case "URL":
                    dataChangedURL(Data, split);
                    break;
                default:
                    break;
            }
        }

        private void dataChangedEmail(string DataText, string SplitChar)
        {
           // List<ViewModels.KeyValue> data = new List<ViewModels.KeyValue>();
            Dictionary<string, int> data = new Dictionary<string, int>();
            string[] items = Regex.Split(DataText, SplitChar);

            DateTime before = DateTime.Now;

            foreach (string item in items)
            {
               //  int rank = GooglePR.MyPageRankFromMail(item);
                int rank = -1;

                string[] parts = item.Split(char.Parse("@")).ToArray();
                if (parts.Count() == 2)
                {
                    var domainname = parts[1].ToLower();
                    if (!string.IsNullOrEmpty(item) && !data.ContainsKey(domainname))
                    {

                        if (!string.IsNullOrEmpty(item) && !data.ContainsKey(domainname) && !BannedDomains.Contains(domainname))
                        {
                            rank = GooglePR.MyPageRank(domainname); //,"http://72.64.146.136:8080"
                            data.Add(domainname, rank);
                            System.Threading.Thread.Sleep(100);
                        }
                      
                    }
                }
            }

            TimeSpan diff = new TimeSpan(DateTime.Now.Ticks - before.Ticks);
            setDuration(diff);

            SetResult(data);
        }

        private void setDuration(TimeSpan duration)
        {
            lblDuration.Text = string.Format("in {0:ss} s", duration);
        }

        private void dataChangedURL(string DataText, string SplitChar)
        {
            Dictionary<string, int> data = new Dictionary<string, int>();
            string[] items = Regex.Split(DataText, SplitChar);
            
            DateTime before = DateTime.Now;

            foreach (string item in items)
            {

                if (!string.IsNullOrEmpty(item) && !data.ContainsKey(item) && !BannedDomains.Contains(item))
                {
                    int rank = GooglePR.MyPageRank(item);//,"http://72.64.146.136:8080"
                    data.Add( item, rank );
                    System.Threading.Thread.Sleep(10);
                }
            }
            TimeSpan diff = new TimeSpan(DateTime.Now.Ticks - before.Ticks);
            setDuration(diff);
            SetResult(data);
        }



        private void SetResult(Dictionary<string, int> values)
        {

            lblCurrent.Text = values.Count().ToString();
            bindingSource1.Clear();

            List<ViewModels.KeyValue> list = values
                .OrderByDescending(el => el.Value)
                .Select(el => new ViewModels.KeyValue {
                    Key = el.Key, 
                    Value = el.Value 
                }).ToList();

            bindingSource1.DataSource = list;//values.OrderByDescending(el => el.Value).ToList();
            
        }

        private void PageRankBatch_Load(object sender, EventArgs e)
        {

        }
    }
}
