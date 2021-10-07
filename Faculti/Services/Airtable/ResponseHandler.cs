using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Faculti.Services.Airtable
{
    internal class ResponseHandler : DelegatingHandler
    {
        private readonly Dictionary<string, MethodAndResponse> responses = new Dictionary<string, MethodAndResponse>();

        internal class MethodAndResponse
        {
            public HttpMethod Method { get; set; }
            public HttpResponseMessage Response { get; set; }
        }

        internal void AddResponse(string uri, HttpMethod method, HttpResponseMessage response)
        {
            responses.Add(uri, new MethodAndResponse { Method = method, Response = response });
        }

        protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {
            if (responses.ContainsKey(request.RequestUri.AbsoluteUri))
            {
                if (responses[request.RequestUri.AbsoluteUri].Method == request.Method)
                {
                    return responses[request.RequestUri.AbsoluteUri].Response;
                }
            }
            return new HttpResponseMessage(HttpStatusCode.NotFound) { RequestMessage = request };
        }
    }
}
