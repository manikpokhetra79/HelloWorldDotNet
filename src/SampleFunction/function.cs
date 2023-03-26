using System.Collections.Generic;
using Amazon.Lambda.Core;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]
namespace SampleFunction
{
  public class Function
  {
    public string FunctionHandler(ILambdaContext context)
    {
      return "Hello World!";
    }
  }

}
