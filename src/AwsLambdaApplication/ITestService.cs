using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwsLambdaApplication;

public interface ITestService
{
    string ReverseString(string str);
}

