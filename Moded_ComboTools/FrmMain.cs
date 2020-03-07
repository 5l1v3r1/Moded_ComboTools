using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moded_ComboTools
{
    public partial class FrmMain : Form
    {
        private List<String> DC = new List<String>();

        private List<String> usrs = new List<String>();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Btn_loadComboThingsDefault_Click(object sender, EventArgs e)
        {
            var loadLstRes = LoadListFile();

            if (loadLstRes.Item2 != null)
                MessageBox.Show($"There is problem ! {Environment.NewLine}{loadLstRes.Item2.Message}{Environment.NewLine}{loadLstRes.Item2.StackTrace}");
            else if (loadLstRes.Item1.Count > 0)
            {
                DC = new List<String>();
                this.DC = loadLstRes.Item1;
                this.btn_loadComboThingsDefault.Text = "Load Default Combo" + ":" + DC.Count;
                panel1.Enabled = true;
            }

            
        }

        private Tuple<List<String>, Exception> LoadListFile()
        {
            try
            {
                var lst = new List<String>();
                var ofd = new OpenFileDialog() { Filter = "TXT Files (*.txt) |*.txt" };

                if (ofd.ShowDialog() == DialogResult.OK) lst.AddRange(File.ReadAllLines(ofd.FileName));

                return new Tuple<List<String>, Exception>(lst, null);
            }
            catch (Exception ex) { return new Tuple<List<String>, Exception>(null, ex); }
        }

        private void Btn_clearDuplicates_Click(object sender, EventArgs e)
        {
            int d = DC.Count;

            this.DC = this.DC.Distinct().ToList();
            var sfd = new SaveFileDialog() { Filter = "TXT Files (*.txt) |*.txt" };

            if (sfd.ShowDialog() == DialogResult.OK) File.WriteAllLines(sfd.FileName, this.DC.ToArray());
            btn_clearDuplicates.Text = "Clear Duplicates " + ":" + (d - DC.Count).ToString();
        }

        private void Btn_splitLeft_Click(object sender, EventArgs e)
        {
            try
            {
                var lft = new List<String>();
                var ofd = new SaveFileDialog() { Filter = "TXT Files (*.txt) |*.txt" };
                this.DC.ForEach((l) => { lft.Add(l.Split(':')[0]); });

                if (ofd.ShowDialog() == DialogResult.OK) File.WriteAllLines(ofd.FileName, lft.ToArray());
            }
            catch { }
        }

        private void Btn_splitRight_Click(object sender, EventArgs e)
        {
            try
            {
                var right = new List<String>();
                var ofd = new SaveFileDialog() { Filter = "TXT Files (*.txt) |*.txt" };
                this.DC.ForEach((l) => { right.Add(l.Split(':')[1]); });

                if (ofd.ShowDialog() == DialogResult.OK) File.WriteAllLines(ofd.FileName, right.ToArray());
            }
            catch { }
        }

        private void Btn_filterPassword_Click(object sender, EventArgs e)
        {
            try
            {
                var passwords = new List<String>();
                var sfd = new SaveFileDialog() { Filter = "TXT Files (*.txt) |*.txt" };
                this.DC.ForEach((l) =>
                {
                    for (int i = (int)txt_topass.Value; i <= (int)txt_unpass.Value; i++)
                    {
                        if (l.Split(':')[1].Length == i)
                            passwords.Add(l);
                    }
                });

                if (sfd.ShowDialog() == DialogResult.OK) File.WriteAllLines(sfd.FileName, passwords.ToArray());
                btn_filterPassword.Text = "Filtered Password : " + passwords.Count;
            }
            catch { }
        }

        private void Btn_combine_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { Filter = "TXT Files (*.txt) |*.txt" };

            if (sfd.ShowDialog() == DialogResult.OK) File.WriteAllLines(sfd.FileName, this.DC.ToArray());
        }

        private void Btn_usernamesToCombine_Click(object sender, EventArgs e)
        {
            var loadLstRes = LoadListFile();

            if (loadLstRes.Item2 != null)
                MessageBox.Show($"There is problem ! {Environment.NewLine}{loadLstRes.Item2.Message}{Environment.NewLine}{loadLstRes.Item2.StackTrace}");
            else
                this.usrs = loadLstRes.Item1;

            this.btn_usernamesToCombine.Text = btn_usernamesToCombine.Text + ":" + usrs.Count;
        }
        String[] passes = null;
        private void Af_Click(object sender, EventArgs e)
        {
            passes = new String[usrs.Count];
            var rnd = new Random();

            for (int i = 0; i < passes.Count(); i++)
            {
                for (int j = 0; j < rnd.Next(8, 16); j++)
                {
                    passes[i] += rnd.Next(0, 9);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var tmp = new List<String>();
            for (int i = 0; i < usrs.Count; i++)
                tmp.Add(usrs[i] + ":" + passes[i]);
            

            var sfd = new SaveFileDialog() { Filter = "TXT Files (*.txt) |*.txt" };
            if (sfd.ShowDialog() == DialogResult.OK) File.WriteAllLines(sfd.FileName, tmp.ToArray());
            button1.Text = "Combined:" + tmp.Count;
        }
    }
}
