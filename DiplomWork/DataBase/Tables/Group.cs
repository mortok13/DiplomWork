using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DiplomWork.DataBase.Tables
{
   public class Group
    {
        public Group()
        {
            this.Tests = new HashSet<Test>();
        }
            
        public string Id { get; set; }
        public string Sign { get; set; }

        public virtual ICollection<Test> Tests { get; set; }
    }
}
