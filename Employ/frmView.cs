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
    public partial class frmView : Form
    {
        private EmDB db;
        public static frmView instand;
        public frmView(EmDB db)
        {
            InitializeComponent();
            this.db = db;
            instand = this;
        }

        private void frmView_Load(object sender, EventArgs e)
        {
            dgEmp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgEmp.MultiSelect = false;

            ViewEmp(db.GetAllEmployee(), dgEmp);
        }
        //-------------------
        private void ViewEmp(List<Empl>l, DataGridView dg)
        {
            dg.Rows.Clear();
            foreach(Empl e in l)
            {
                dg.Rows.Add(dg.Rows.Count, e.getId(), e.getName(), e.getSex(),
                    e.getPosition(), e.getSalary());
            }
        }// end function

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ViewEmp( db.filterId(textBox1.Text),dgEmp);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ViewEmp(db.filerName(textBox2.Text),dgEmp);
        }
        int index;
        private void dgEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void btDelet_Click(object sender, EventArgs e)
        {
            string id = dgEmp.Rows[index].Cells[1].Value.ToString();
            DialogResult rs = MessageBox.Show("Delet Emp : "+id,"Form Delet ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(rs == DialogResult.Yes)         
                db.DeletEmp(id);
            
            ViewEmp( db.GetAllEmployee(),dgEmp);
        }// end button delet

        private void btUpdate_Click(object sender, EventArgs e)
        {
            string id = dgEmp.Rows[index].Cells[1].Value.ToString();
            new frmUpdate(db,db.getEmpById(id)).Show();
        }
        public void RefreshEmp()
        {
            ViewEmp(db.GetAllEmployee(), dgEmp);
        }
    }
}
