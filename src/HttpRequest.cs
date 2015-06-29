using System;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace HttpContextAlike
{
    public class HttpRequest : IHttpRequest
    {
        public HttpRequest()
        {
        }

        public HttpRequest(HttpRequestMessage request)
        {
            Inner = request;
        }

        public object Inner { get; private set; }

        // a hack to use this with any request type
        public void setInner(object i) { this.Inner = i; }
    }
}