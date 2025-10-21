using System;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic;

namespace Remp.DataAccess;

public class RempDbContextFactory : IDesignTimeDbContextFactory<RempDbContext>
{
    public RempDbContext CreateDbContext(string[] args)
	{
		var optionBuilder = new DbContextOptionsBuilder<RempDbContext>();

		var configuration = new ConfigurationBuilder()
		.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "..", "Remp.API"))
		.AddJsonFile("appsettings.json", optional: false)
		.AddJsonFile("appsettings.Development.json", optional: false)
		.Build();

		var connectionString = configuration.GetConnectionString("Remp-SQLSERVER");

		optionBuilder.UseSqlServer(connectionString);
		return new RempDbContext(optionBuilder.Options);
	}
}