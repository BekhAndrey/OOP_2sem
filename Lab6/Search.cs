using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace Lab5
{
    public partial class Search : Form
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Account>));
        public List<Account> searchacc = new List<Account>();
        int SearchBY = 1;
        private List<Account> accounts;
        private List<Form2.Owner> owners;
        public Search(List<Account> acclist, List<Form2.Owner> ownlist)
        {
            InitializeComponent();
            this.accounts = acclist;
            this.owners = ownlist;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            switch(SearchBY)
            {
                case 1:
                    Regex regex1 = new Regex($"^{SearchTextBox.Text}$");
                    SearchResultBox.Clear();
                    searchacc.Clear();
                    foreach (Account acc in accounts)
                    {
                        MatchCollection match = regex1.Matches(acc.Number);
                        if (match.Count > 0)
                        {
                            SearchResultBox.Text += acc.ToString();
                            searchacc.Add(acc);
                        }
                    }
                    SearchResultBox.Update();
                    break;
                case 2:
                    Regex regex2 = new Regex($"^{SearchTextBox.Text}$");
                    SearchResultBox.Clear();
                    searchacc.Clear();
                    foreach (Form2.Owner owner in owners)
                    {
                        MatchCollection match = regex2.Matches(owner.FIO);
                        if (match.Count > 0)
                        {
                            foreach(Account acc in accounts)
                            {
                                if(owner.FIO==acc.Owner)
                                {
                                    SearchResultBox.Text += acc.ToString();
                                    searchacc.Add(acc);
                                }
                            }
                        }
                    }
                    SearchResultBox.Update();
                    break;
                case 3:
                    Regex regex3 = new Regex($"^{SearchTextBox.Text}$");
                    SearchResultBox.Clear();
                    searchacc.Clear();
                    foreach (Account acc in accounts)
                    {
                        int x = acc.Balance.Length - 1;
                        MatchCollection match = regex3.Matches(acc.Balance.Remove(x));
                        if (match.Count > 0)
                        {
                            SearchResultBox.Text += acc.ToString();
                            searchacc.Add(acc);
                        }

                    }
                    SearchResultBox.Update();
                    break;
                case 4:
                    Regex regex4 = new Regex($"^{SearchTextBox.Text}$");
                    SearchResultBox.Clear();
                    searchacc.Clear();
                    foreach (Account acc in accounts)
                    {
                        MatchCollection match = regex4.Matches(acc.Type);
                        if (match.Count > 0)
                        {
                            SearchResultBox.Text += acc.ToString();
                            searchacc.Add(acc);
                        }
                    }
                    SearchResultBox.Update();
                    break;

            }
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void SearchByNumber_CheckedChanged(object sender, EventArgs e)
        {
            SearchResultBox.Clear();
            SearchBY = 1;
        }

        private void SearchByFIO_CheckedChanged(object sender, EventArgs e)
        {
            SearchResultBox.Clear();
            SearchBY = 2;
        }

        private void SearchByBalance_CheckedChanged(object sender, EventArgs e)
        {
            SearchResultBox.Clear();
            SearchBY = 3;
        }

        private void SearchByType_CheckedChanged(object sender, EventArgs e)
        {
            SearchResultBox.Clear();
            SearchBY = 4;
        }

        private void CreationDateSort_Click(object sender, EventArgs e)
        {
            var sort = searchacc.OrderByDescending(acc => acc.CreationDate);
            SearchResultBox.Clear();
            foreach (Account acc in sort)
            {
                SearchResultBox.Text += acc.ToString();
            }
            SearchResultBox.Update();
        }

        private void TypeSort_Click(object sender, EventArgs e)
        {
            var sort = searchacc.OrderByDescending(acc => acc.Type);
            SearchResultBox.Clear();
            foreach (Account acc in sort)
            {
                SearchResultBox.Text += acc.ToString();
            }
            SearchResultBox.Update();
        }

        private void SerializeButton_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("searchandsort.xml", FileMode.Create))
            {
                serializer.Serialize(fs, searchacc);
            }
        }
    }
}
