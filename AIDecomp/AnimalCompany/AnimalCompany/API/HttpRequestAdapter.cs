// Decompiled with Xera AI Decompiler
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using Nakama;

namespace AnimalCompany.API
{
    public class HttpRequestAdapter : IHttpAdapter
    {
        [CompilerGenerated]
        private struct <SendAsync>d__12 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<string> <>t__builder;
            public Uri uri;
            public string method;
            public IDictionary<string, string> headers;
            public HttpRequestAdapter <>4__this;
            public byte[] body;
            public int timeout;
            public CancellationToken? userCancelToken;
            private HttpResponseMessage <response>5__2;
            private TaskAwaiter<HttpResponseMessage> <>u__1;
            private TaskAwaiter<string> <>u__2;

            void IAsyncStateMachine.MoveNext()
            {
                int num = <>1__state;
                HttpRequestAdapter httpRequestAdapter = <>4__this;
                string result;
                try
                {
                    TaskAwaiter<HttpResponseMessage> awaiter;
                    TaskAwaiter<string> awaiter2;
                    if (num != 0)
                    {
                        if (num == 1)
                        {
                            awaiter2 = <>u__2;
                            <>u__2 = default(TaskAwaiter<string>);
                            <>1__state = -1;
                            goto IL_0123;
                        }
                        HttpRequestMessage httpRequestMessage = new HttpRequestMessage(new HttpMethod(method), uri);
                        if (headers != null)
                        {
                            foreach (KeyValuePair<string, string> header in headers)
                            {
                                httpRequestMessage.Headers.Add(header.Key, header.Value);
                            }
                        }
                        if (body != null)
                        {
                            httpRequestMessage.Content = new ByteArrayContent(body);
                        }
                        CancellationToken cancellationToken = userCancelToken ?? CancellationToken.None;
                        awaiter = httpRequestAdapter._httpClient.SendAsync(httpRequestMessage, cancellationToken).GetAwaiter();
                        if (!awaiter.IsCompleted)
                        {
                            <>1__state = 0;
                            <>u__1 = awaiter;
                            <>t__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
                            return;
                        }
                    }
                    else
                    {
                        awaiter = <>u__1;
                        <>u__1 = default(TaskAwaiter<HttpResponseMessage>);
                        <>1__state = -1;
                    }
                    <response>5__2 = awaiter.GetResult();
                    awaiter2 = <response>5__2.Content.ReadAsStringAsync().GetAwaiter();
                    if (!awaiter2.IsCompleted)
                    {
                        <>1__state = 1;
                        <>u__2 = awaiter2;
                        <>t__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
                        return;
                    }
                    IL_0123:
                    result = awaiter2.GetResult();
                }
                catch (Exception exception)
                {
                    <>1__state = -2;
                    <>t__builder.SetException(exception);
                    return;
                }
                <>1__state = -2;
                <>t__builder.SetResult(result);
            }

            [DebuggerHidden]
            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                <>t__builder.SetStateMachine(stateMachine);
            }
        }

        private readonly HttpClient _httpClient;

        [CompilerGenerated]
        private ILogger <Logger>k__BackingField;

        [CompilerGenerated]
        private string <ClientAgentHeader>k__BackingField;

        public string ClientAgentHeader
        {
            [CompilerGenerated]
            get { return <ClientAgentHeader>k__BackingField; }
            [CompilerGenerated]
            set { <ClientAgentHeader>k__BackingField = value; }
        }

        public override ILogger Logger
        {
            [CompilerGenerated]
            get { return <Logger>k__BackingField; }
            [CompilerGenerated]
            set { <Logger>k__BackingField = value; }
        }

        public override TransientExceptionDelegate TransientExceptionDelegate
        {
            get { return new TransientExceptionDelegate(IsTransientException); }
        }

        public HttpRequestAdapter(HttpClient httpClient)
        {
            _httpClient = httpClient;
            if (httpClient != null)
            {
                httpClient.Timeout = TimeSpan.FromSeconds(30);
            }
        }

        [CompilerGenerated]
        public string get_ClientAgentHeader()
        {
            return <ClientAgentHeader>k__BackingField;
        }

        [CompilerGenerated]
        public override ILogger get_Logger()
        {
            return <Logger>k__BackingField;
        }

        public override TransientExceptionDelegate get_TransientExceptionDelegate()
        {
            return new TransientExceptionDelegate(IsTransientException);
        }

        private bool IsTransientException(Exception e)
        {
            if (e is HttpRequestException httpRequestException)
            {
                return httpRequestException.Data.Contains("StatusCode") && 
                       (int)httpRequestException.Data["StatusCode"] >= 500;
            }
            return false;
        }

        [AsyncStateMachine(typeof(<SendAsync>d__12))]
        public override Task<string> SendAsync(string method, Uri uri, IDictionary<string, string> headers, byte[] body, int timeout, CancellationToken? userCancelToken)
        {
            <SendAsync>d__12 stateMachine = default(<SendAsync>d__12);
            stateMachine.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
            stateMachine.method = method;
            stateMachine.uri = uri;
            stateMachine.headers = headers;
            stateMachine.<>4__this = this;
            stateMachine.body = body;
            stateMachine.timeout = timeout;
            stateMachine.userCancelToken = userCancelToken;
            stateMachine.<>1__state = -1;
            stateMachine.<>t__builder.Start(ref stateMachine);
            return stateMachine.<>t__builder.Task;
        }

        [CompilerGenerated]
        public void set_ClientAgentHeader(string value)
        {
            <ClientAgentHeader>k__BackingField = value;
        }

        [CompilerGenerated]
        public override void set_Logger(ILogger value)
        {
            <Logger>k__BackingField = value;
        }

        public static HttpRequestAdapter WithGzip(bool decompression = false, bool compression = false)
        {
            HttpClientHandler handler = new HttpClientHandler();
            
            if (handler.SupportsAutomaticDecompression && decompression)
            {
                handler.AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate;
            }

            HttpClient httpClient;
            if (compression)
            {
                var compressionHandler = new System.Net.Http.HttpClientHandler();
                compressionHandler.InnerHandler = handler;
                httpClient = new HttpClient(compressionHandler);
            }
            else
            {
                httpClient = new HttpClient(handler);
            }

            return new HttpRequestAdapter(httpClient);
        }
    }
}