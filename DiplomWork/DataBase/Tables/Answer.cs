﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DiplomWork.DataBase.Tables
{
   public class Answer
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Rightanswer { get; set; }

        public Question Question { get; set; }
    }
}
