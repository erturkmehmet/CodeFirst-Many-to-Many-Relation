using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst_MtoMRelation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        UniversityContext db = DbSingleTone.GetInstance();
       
        private void tsmStudent_Click(object sender, EventArgs e)
        {
            FormStudent frm = new FormStudent();
            frm.Show();
        }

        private void tsmTeacher_Click(object sender, EventArgs e)
        {
            FormTeacher frm = new FormTeacher();
            frm.Show();
        }

        private void tsmST_Click(object sender, EventArgs e)
        {
            FormRelation frm = new FormRelation();
            frm.Show();
        }
    }
}
