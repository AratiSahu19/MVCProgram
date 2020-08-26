using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mk_project.Models
{
    public class Usercontext:DbContext
    {
        public DbSet <UserModel> UsersModels { get; set; }
    }
}