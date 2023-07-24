using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Testing;

public class TestBase
{

    protected DataContext BuildContext(string nameDb)
    {
        var options = new DbContextOptionsBuilder<DataContext>()
            .UseInMemoryDatabase(nameDb).Options;

        var dbContext = new DataContext(options);

        return dbContext;
    }
    
}