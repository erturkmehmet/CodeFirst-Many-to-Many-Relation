namespace CodeFirst_MtoMRelation
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class UniversityContext : DbContext
    {
        // Your context has been configured to use a 'UniversityContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CodeFirst_MtoMRelation.UniversityContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'UniversityContext' 
        // connection string in the application configuration file.
        public UniversityContext()
            : base("name=UniversityContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        public virtual DbSet<Student> Students { get; set; } 
        public virtual DbSet<Teacher> Teachers{ get; set; }
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }
    public class Student
    {
        public Student()
        {
            this.teachers = new HashSet<Teacher>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual ICollection<Teacher> teachers { get; set; }
    }

   public class Teacher
    {
        public Teacher()
        {
            this.students = new HashSet<Student>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual ICollection<Student> students { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}


}