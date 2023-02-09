using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employ
{
    public partial class frmUpdate : Form
    {
        private EmDB db;
        private Empl em;
        public frmUpdate(EmDB db, Empl em)
        {
            InitializeComponent();
            this.db = db;
            this.em = em;
        }

        private void frmUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            txtid.Text = em.getId();
            txtname.Text = em.getName();
            cbosex.Text = em.getSex();
            cboposition.Text = em.getPosition();
            txtsalary.Text = em.getSalary();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Update Record","",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(rs == DialogResult.Yes)
            {
                db.UpdatEmp(new Empl(txtid.Text, txtname.Text,
                    cbosex.Text, cboposition.Text, txtsalary.Text),txtid.Text);    
            }
            frmView.instand.RefreshEmp();
            this.Dispose();
        }
    }
}
