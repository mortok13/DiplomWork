using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DiplomWork.DataBase.Tables
{
    public class Value
    {
        public int Id { get; set; }
        public float Testvalue { get; set; }
        [Required] public int UserId { get; set; }
        [Required] public User User { get; set; }

        public Test Test { get; set; }
        public Subject Subject { get; set; }
    }
}
