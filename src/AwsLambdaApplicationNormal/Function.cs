using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AwsLambdaApplicationNormal
{
    public class Function
    {
        
        /// <summary>
        /// A simple function that takes a string and returns both the upper and lower case version of the string.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public Casing FunctionHandler(string input, ILambdaContext context)
        {
            var svc = new TestService();
            var data = svc.ReverseString(input);

            return new Casing(data?.ToLower(), data?.ToUpper());
        }

        public int AnnotatedHandlerAdd(Add addends, ILambdaContext context)
        {
            return addends.addend1 + addends.addend2;
        }


    }

    public record Casing(string Lower, string Upper);
    public record Add(int addend1, int addend2);
}
