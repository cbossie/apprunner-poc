using Amazon.Lambda.Annotations;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwsLambdaApplication;

[LambdaStartup]
public class LambdaStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<ITestService, TestService>();
    }
}
