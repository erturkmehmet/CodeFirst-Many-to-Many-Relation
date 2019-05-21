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
    public partial class FormTeacher : Form
    {
        public FormTeacher()
        {
            InitializeComponent();
        }
        UniversityContext db = DbSingleTone.GetInstance();

        private void FormTeacher_Load(object sender, EventArgs e)
        {
            FillTeacher();
        }
        private void FillTeacher()
        {
            dgTeacherList.DataSource = db.Teachers.Select(x => new
            {
                x.Id,
                x.Name,
                x.Surname
            }).ToList();
        }

        private void btnAddT_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.Name = txtNameT.Text;
            t.Surname = txtSurnameT.Text;
            db.Teachers.Add(t);
            db.SaveChanges();
            FillTeacher();
        }
    }
}
