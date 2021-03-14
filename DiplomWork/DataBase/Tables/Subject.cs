using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DiplomWork.DataBase.Tables
{
    public class Subject
    {
        public int Id { get; set; }
        [Required] public string Name { get; set; }
    }
}
