using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList mijnOverzichtLijst = new ArrayList();

        private void btnInlezen_Click(object sender, EventArgs e)
        {
            mijnOverzichtLijst.AddRange(File.ReadAllLines("Les 16.2 - Dieren.txt"));
            UitSchrijven();
        }
        void UitSchrijven()
        {
            lbOverzicht.DataSource = null;
            lbOverzicht.DataSource = mijnOverzichtLijst;
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDierToevoegen.Text))
            {
                MessageBox.Show("U heeft niets ingevuld. ", " Dier. ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                mijnOverzichtLijst.Add(txtDierToevoegen.Text);
                UitSchrijven();
            }
            //txtDierToevoegen.Text;
        }

        private void btnWissen_Click(object sender, EventArgs e)
        {
            lbOverzicht.DataSource = null;
        }

        private void btnSorteren_Click(object sender, EventArgs e)
        {
            mijnOverzichtLijst.Sort();
            UitSchrijven();
        }
    }
}
