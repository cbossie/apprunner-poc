using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwsLambdaApplicationNormal;

public class TestService
{
    public string ReverseString(string str)
    {
        return new string(str.ToCharArray().Reverse().ToArray());
    }
}

