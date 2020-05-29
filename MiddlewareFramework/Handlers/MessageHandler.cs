using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MiddlewareFramework.Handlers
{
    public class MessageHandler : DelegatingHandler
    {
        protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            Debug.WriteLine("Process request");

            var response = await base.SendAsync(request, cancellationToken);

            response.Headers.Add("X-Custom-Header", "Custom Header");

            Debug.WriteLine("Process response");

            return response;
        }
    }
}