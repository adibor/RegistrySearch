using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;


namespace SearchForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton2.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchBtn.Text.Equals("Search"))
            {
                searchBtn.Text = "Cancel";
                statusLbl.Text = "Searching...";
                clrBtn.Enabled = false;
                resList.Items.Clear();
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                searchBtn.Text = "Search";
                statusLbl.Text = "";
                clrBtn.Enabled = true;
                backgroundWorker1.CancelAsync();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void resList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string term = termTextBox.Text;
            bool isKey = radioButton2.Checked;
            RegistryHelper rh = new RegistryHelper();
            rh.RecursiveSearchKeysTreeWrapper(isKey, term, backgroundWorker1, e);

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            searchBtn.Text = "Search";
            clrBtn.Enabled = true;
            if (e.Cancelled)
            {
                statusLbl.Text = "The search is cancelled";
            }
            else
            {
                List<RegistryData> rdLst = (List<RegistryData>)e.Result;
                if (rdLst.Count > 0)
                    resList.Items.AddRange(rdLst.ToArray());
                else
                    resList.Items.Add("Not found");

                statusLbl.Text = "The search completed successfully";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            statusLbl.Text = "";
            termTextBox.Text = "";
            resList.Items.Clear();   
        }

    }
}
