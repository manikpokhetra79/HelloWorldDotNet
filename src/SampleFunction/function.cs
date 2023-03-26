using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]
namespace SampleFunction
{
  public class Function
  {
    public async Task<APIGatewayProxyResponse> FunctionHandler(APIGatewayProxyRequest request, ILambdaContext context)
    {
      string responseBody = "Hello, World!";
      var response = new APIGatewayProxyResponse
      {
        StatusCode = 200,
        Headers = new Dictionary<string, string> { { "Content-Type", "text/plain" } },
        Body = responseBody
      };
      return response;
    }
  }

}
