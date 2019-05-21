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
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }
        UniversityContext db = DbSingleTone.GetInstance();

        private void FormStudent_Load(object sender, EventArgs e)
        {
            FillStudent();
        }
        private void FillStudent()
        {
            dgStudentList.DataSource = db.Students.Select(x => new
            {
                x.Id,
                x.Name,
                x.Surname
            }).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Name = txtName.Text;
            s.Surname = txtSurname.Text;
            db.Students.Add(s);
            db.SaveChanges();
            FillStudent();
        }
    }
}
