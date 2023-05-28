using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace Loba.Infrastructure.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            //Usado para a criação de migrations

            var optionsbuilder = new DbContextOptionsBuilder<MyContext>();
            //MySQL
            var connectionString = "Server=localhost;Port=3306;Database=lobaAPI;Uid=root;Pwd=1234";
            optionsbuilder.UseMySql(connectionString);

            return new MyContext(optionsbuilder.Options);
        }
    }
}
