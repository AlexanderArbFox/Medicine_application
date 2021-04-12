using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_medicine
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            new PatientForm().Show();
        }

        private void btnSpec_Click(object sender, EventArgs e)
        {
            new SpecForm().Show();
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            new PosForm().Show();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            new QueryForm().Show();
        }
    }
}
