using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DiplomWork.DataBase
{
   public class UserContext : DbContext
    {
        public UserContext() : base(@"Data Source=DESKTOP-HS40QFM\SQLEXPRESS;Initial Catalog=TestsDataBase;Integrated Security=True") { }
    }
}
