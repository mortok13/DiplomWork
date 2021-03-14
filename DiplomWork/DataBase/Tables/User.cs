using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DiplomWork.DataBase
{
    public class User
    {
        public int Id { get; set; }
        [Required] public string Login { get; set; }
        [Required] public string Password { get; set; }
        public string Name { get; set; }
        public string Surename { get; set; }
        public string Adress { get; set; }
        public string Birthdate { get; set; }
        public string Group { get; set; }
        [Required] public int Status { get; set; }
    }
}
