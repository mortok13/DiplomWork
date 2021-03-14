using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using DiplomWork.DataBase.Tables;

namespace DiplomWork.DataBase
{
    public class User
    {
        public int Id { get; set; }
        [Required] public string Login { get; set; }
        [Required] public string Password { get; set; }
        [Required] public string Name { get; set; }
        [Required] public string Surename { get; set; }
        public string Adress { get; set; }
        public string Birthdate { get; set; }
        [Required] public int Status { get; set; }

       // public int GroupId { get; set; }
        public Group Group { get; set; }

    }
}
