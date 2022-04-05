using Catalog.Repository.Context;
using Catalog.Repository.Extensions;
using Microsoft.EntityFrameworkCore;

var options = new DbContextOptionsBuilder<CatalogContext>()
                .UseSqlServer("Data Source=localhost;Initial Catalog=BarterUp.Catalog;Persist Security Info=True;User ID=sa;Password=Pass@word")
                .Options;
var context = new CatalogContext(options);

context.LogSQLToCarrinhoConsole();


var list = await context.ProductCategories
    .ToListAsync();

Console.WriteLine("Hello, World!");
