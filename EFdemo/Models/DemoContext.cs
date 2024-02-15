using System;
using Microsoft.EntityFrameworkCore;

namespace EFdemo.Models
{
	public class DemoContext : DbContext 
	{
		public DbSet<UserModel> Users { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder options)
			=> options.UseSqlite("Data Source=/Users/jerodbrackin/TEST.db");
	}
}

