using MongoDB.Driver;

namespace TemplateRepoTestDotnetBackend.Data;

public interface IMongoDbClientFactory
{
    protected IMongoClient CreateClient();

    IMongoCollection<T> GetCollection<T>(string collection);
}