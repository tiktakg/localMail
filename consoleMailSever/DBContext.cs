using consoleMailSever.entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;



namespace consoleMailSever
{
    public class DBContext : DbContext
    {
        public DBContext() : base()
        {
        }

        public DbSet<users> allUsers { get; set; } = null;
        public DbSet<usersData> AllUsersData { get; set; } = null;
        public DbSet<msg> msg { get; set; } = null;

    }
}
