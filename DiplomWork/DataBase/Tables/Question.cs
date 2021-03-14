using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DiplomWork.DataBase.Tables
{
    public class Question
    {
        public int Id { get; set; }
        public int Questiontype { get; set; }
        public float Value { get; set; }

        public Test Test { get; set; }
    }
}
