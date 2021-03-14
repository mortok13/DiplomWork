using DiplomWork.DataBase.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
namespace DiplomWork.DataBase
{
   public class UserContext : DbContext
    {

        public UserContext() : base(@"Data Source=DESKTOP-HS40QFM\SQLEXPRESS;Initial Catalog=TestsDataBase;Integrated Security=True") { }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Value> Values { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
