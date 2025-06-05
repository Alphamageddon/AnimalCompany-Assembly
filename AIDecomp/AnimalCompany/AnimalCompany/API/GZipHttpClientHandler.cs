// Decompiled with Xera AI Decompiler
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AnimalCompany.API
{
    internal class GZipHttpClientHandler : DelegatingHandler
    {
        public GZipHttpClientHandler(HttpMessageHandler innerHandler) : base(innerHandler)
        {
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken ct)
        {
            if (request != null)
            {
                if (request.Method == HttpMethod.Post || request.Method == HttpMethod.Put)
                {
                    if (request.Content != null)
                    {
                        request.Content = new GZipContent(request.Content);
                    }
                }
            }

            return await base.SendAsync(request, ct);
        }
    }
}