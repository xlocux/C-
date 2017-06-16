using CodeFluent.Runtime.BinaryServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HideADS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btarget_Click(object sender, EventArgs e)
        {
            DialogResult result = ofd1.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbtar.Text = ofd1.FileName;
                tbads.Text = String.Empty;
                benum.PerformClick();
            
            
            }
        }


        private void bhide_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbtar.Text))
            {
                NtfsAlternateStream.WriteAllText(tbtar.Text + ":" + tbads.Text, rtbin.Text);
                MessageBox.Show("Done!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbtar.Text))
            {
                try
                {
                    rtbout.Text = NtfsAlternateStream.ReadAllText(tbtar.Text + ":" + tbads.Text);
                }
                catch
                {
                    MessageBox.Show("Invalid ADS Name!");
                }
            }
        }

        private void benum_Click(object sender, EventArgs e)
        {
            rtbout.Clear();
            tbads.Items.Clear();
            IEnumerable adsStreams = NtfsAlternateStream.EnumerateStreams(tbtar.Text);
            try
            {
                foreach (NtfsAlternateStream ads in adsStreams)
                {
                    rtbout.Text += (ads.Name) + Environment.NewLine;
                    if (!string.IsNullOrWhiteSpace(ads.Name))
                        tbads.Items.Add(ads.Name.Replace(":","").Replace("$DATA", ""));
                }
                if (tbads.Items.Count > 0)
                    tbads.Text = (tbads.Items[0]).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bdel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbtar.Text))
            {
                try
                {
                    NtfsAlternateStream.Delete(tbtar.Text + ":" + tbads.Text);
                    MessageBox.Show("ADS Erased!");
                    benum.PerformClick();
                }
                catch
                {
                    MessageBox.Show("ADS Not Found");
                }
            }
        }

        private void bclear_Click(object sender, EventArgs e)
        {
            rtbin.Clear();
        }


    }

}