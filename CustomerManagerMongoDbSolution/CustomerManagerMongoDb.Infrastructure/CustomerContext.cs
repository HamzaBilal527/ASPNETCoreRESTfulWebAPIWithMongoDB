using CustomerManagerMongoDb.Infrastructure.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagerMongoDb.Infrastructure
{
    public class CustomerContext : ICustomerContext
    {
        private readonly IMongoDatabase mongoDatabase;
        public CustomerContext(IOptions<Settings> settings)
        {
            var mongoClient = new MongoClient(settings.Value.ConnectionString);
            mongoDatabase = mongoClient.GetDatabase(settings.Value.DatabaseName);
        }
        public IMongoCollection<Customer> customersCollection => mongoDatabase.GetCollection<Customer>("Customers"); 
    }

    public interface ICustomerContext
    {
        IMongoCollection<Customer> customersCollection { get; }

    }
}
