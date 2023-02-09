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
    public partial class frmEmpInput : Form
    {
        private EmDB db;
        public frmEmpInput(EmDB db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.AddEmp(new Empl(txtid.Text, txtname.Text, cbosex.Text,
                cboposition.Text, txtsalary.Text));
            //------
            dgEmp.Rows.Add(dgEmp.Rows.Count, txtid.Text, txtname.Text, cbosex.Text,
                cboposition.Text, txtsalary.Text);
        }
    }
}
