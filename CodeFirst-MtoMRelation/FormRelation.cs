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
    public partial class FormRelation : Form
    {
        public FormRelation()
        {
            InitializeComponent();
        }
        UniversityContext db = DbSingleTone.GetInstance();

        private void FormRelation_Load(object sender, EventArgs e)
        {
            FillLb();
            FillCombo();
            lbStudent.MultiColumn = true;
            lbStudent.SelectionMode = SelectionMode.MultiExtended;
         
                

            //2.yol
            //lbStudent.DisplayMember = "Name";
            //lbStudent.DataSource = db.Students.ToList();

            //cmbTeacher.DisplayMember = "Name";
            //cmbTeacher.DataSource = db.Teachers.ToList();
        }

        private void FillCombo()
        {
            var cmb = db.Teachers.Select(x => new 
            {
                FullName = x.Name + " " + x.Surname,
                TeacherId=x.Id
            }).ToList();

            cmbTeacher.DisplayMember = "FullName";
            cmbTeacher.ValueMember = "TeacherId";
            cmbTeacher.DataSource = cmb;
        }

        private void FillLb()
            { 
            lbStudent.DataSource = db.Students.Select(x => new MyEntry
            {
                FullName = x.Name + x.Surname,
                StudentId=x.Id
            }).ToList();
            lbStudent.DisplayMember = "FullName";
            lbStudent.ValueMember = "StudentId";
            lbStudent.SelectedIndex = -1;
        }
        
        private void btnRelate_Click(object sender, EventArgs e)
        {
            //Teacher t = cmbTeacher.SelectedItem as Teacher;
            //var teacher = db.Teachers.Find(t);
            ////2.yol
            ////Teacher teacher = db.Teachers.Find(t); 
            ////3.yol
            ////t = db.Teachers.Find(t);
            //foreach (Student item in lbStudent.SelectedItems)
            //{
            //    teacher.students.Add(item);
            //}
            //db.SaveChanges();
            //lbStudent.SelectedItems.Clear();
            //dgRelateList.DataSource = teacher.students.ToList();  

            //////////////////////////
            //////////
            int chosenTeacherId = Convert.ToInt32(cmbTeacher.SelectedValue);
            Teacher teacher = db.Teachers.Find(chosenTeacherId);
            foreach (MyEntry item in lbStudent.SelectedItems)
            {
                Student stuSelected = db.Students.Find(item.StudentId);
                teacher.students.Add(stuSelected);
            }
           
            db.SaveChanges();
            lbStudent.SelectedItems.Clear();
            dgRelateList.DataSource = teacher.students.ToList();

        }

        private void cmbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Teacher t = cmbTeacher.SelectedItem as Teacher;
            //var egitmeninOgrencileri = db.Teachers.Find(t.Id).students.ToList();
            ////2.yol
            //// t = db.Teachers.Find(t.Id).students.ToList();
            ////3.yol
            ////List<Student> egitmeninOgrencileri = db.Teachers.Find(t.Id).students.ToList();
            //dgRelateList.DataSource = egitmeninOgrencileri;


            ///////////////////////////////
            
                int chosenTeacherId = Convert.ToInt32(cmbTeacher.SelectedValue);
                Teacher teacher = db.Teachers.Find(chosenTeacherId);
                dgRelateList.DataSource = teacher.students.ToList();
            dgRelateList.DataSource = chosenTeacherId;
        }
    }
}
