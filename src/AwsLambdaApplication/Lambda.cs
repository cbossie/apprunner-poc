﻿using Amazon.Lambda.Annotations;
using Amazon.Lambda.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AwsLambdaApplication;

public class Lambda
{
    [LambdaFunction(Name = "ReverseFunction", PackageType = LambdaPackageType.Image)]
    public Casing AnnotatedHandler(string input, [FromServices] ITestService svc)
    {
        var rev = svc.ReverseString(input);
        return new Casing(rev?.ToLower(), rev?.ToUpper());
    }

    [LambdaFunction(Name = "AddFunction", PackageType = LambdaPackageType.Image)]
    public int AnnotatedHandlerAdd(Add addends)
    {
        return addends.addend1 + addends.addend2;
    }


}
public record Casing(string Lower, string Upper);
public record Add(int addend1, int addend2);