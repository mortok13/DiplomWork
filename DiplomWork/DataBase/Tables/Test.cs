using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DiplomWork.DataBase.Tables
{
    public class Test
    {
        public Test()
        {
            this.Groups = new HashSet<Group>();
        }

        public int Id { get; set; }
       [Required] public string Name { get; set; }
        public int Counteroftries { get; set; }
        public int Time { get; set; }

        public virtual ICollection<Group> Groups { get; set; }
    }
}
