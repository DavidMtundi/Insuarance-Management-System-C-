using Insuarance;
using Insuarance.InsuaranceForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;                                                                                                                                                      
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microsoft_Store_Design_Concept
{
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

         
        }

        private void SecondForm_Load(object sender, EventArgs e)
        {
    
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //open the 
            Manage_PersonsForm pf = new Manage_PersonsForm();
            pf.ShowDialog();
        }

        private void btnclientclaim_Click(object sender, EventArgs e)
        {
            RequestClaimForm pf = new RequestClaimForm();
            pf.ShowDialog();
        }

        private void guna2Panel8_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void guna2Panel8_Click(object sender, EventArgs e)
        {
            ViewAllClients va = new ViewAllClients();
            va.ShowDialog();
            
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            UserLogsForm usl = new UserLogsForm();
            usl.ShowDialog();
        }

        private void guna2ImageButton8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2Panel3_DoubleClick(object sender, EventArgs e)
        {
            EditPersonForm perf = new EditPersonForm();
            perf.ShowDialog();
        }

        private void guna2GradientPanel1_Click(object sender, EventArgs e)
        {
            SalesmadeForm sales = new SalesmadeForm();
            sales.ShowDialog();
        }
    }
}
