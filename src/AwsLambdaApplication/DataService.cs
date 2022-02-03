using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwsLambdaApplication;

public class DataService : IDataService
{
    static Random random = new Random();
    public async Task<string> GetData(string data)
    {
        var next = random.Next();
        return await Task.FromResult($"{data}{next}");
    }
}


public interface IDataService
{
    Task<string> GetData(string data);
}