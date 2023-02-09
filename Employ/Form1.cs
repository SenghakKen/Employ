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
    public partial class Form1 : Form
    {
        private bool back = false;
        private Form active;
        private EmDB db = new EmDB();
        //--------------------
        private void LoadForm(Form f)
        {
            if (active != null) active.Close();
            active = f;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pContainer.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        
        
        public Form1()
        {
            InitializeComponent();
        }



        private void btback_Click(object sender, EventArgs e)
        {
            if (back == false)
            {
                pNavigation.Size = new Size(40, this.Height);
                back = true;
                
            }
            else
            {
                pNavigation.Size = new Size(150, this.Height);
                back = false;
            }
        }// end button back

        private void button1_Click(object sender, EventArgs e)
        {
            LoadForm(new frmEmpInput(db));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadForm(new frmView(db));
        }
    }
}
  