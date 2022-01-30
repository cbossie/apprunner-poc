using Amazon.Lambda.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwsLambdaApplication;

public class Lambda
{
    [LambdaFunction(Name = "ReverseFunction", PackageType = LambdaPackageType.Image)]
    public Casing AnnotatedHandler(string input, [FromServices] ITestService svc)
    {
        var rev = svc.ReverseString(input);
        return new Casing(rev?.ToLower(), rev?.ToUpper());
    }
}
public record Casing(string Lower, string Upper);
