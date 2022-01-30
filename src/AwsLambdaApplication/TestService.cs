using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwsLambdaApplication;

public class TestService : ITestService
{
    public string ReverseString(string str)
    {
        return new string(str.ToCharArray().Reverse().ToArray());
    }
}

