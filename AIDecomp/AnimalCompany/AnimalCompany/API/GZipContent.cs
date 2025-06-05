// Decompiled with Xera AI Decompiler
using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace AnimalCompany.API
{
    internal class GZipContent : HttpContent
    {
        [CompilerGenerated]
        private struct <SerializeToStreamAsync>d__2 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder <>t__builder;
            public Stream stream;
            public GZipContent <>4__this;
            private GZipStream <gzip>5__2;
            private TaskAwaiter <>u__1;

            void IAsyncStateMachine.MoveNext()
            {
                int num = <>1__state;
                GZipContent gZipContent = <>4__this;
                try
                {
                    TaskAwaiter awaiter;
                    if (num != 0)
                    {
                        <gzip>5__2 = new GZipStream(stream, CompressionMode.Compress, leaveOpen: true);
                        awaiter = gZipContent._content.CopyToAsync(<gzip>5__2).GetAwaiter();
                        if (!awaiter.IsCompleted)
                        {
                            num = (<>1__state = 0);
                            <>u__1 = awaiter;
                            <>t__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
                            return;
                        }
                    }
                    else
                    {
                        awaiter = <>u__1;
                        <>u__1 = default(TaskAwaiter);
                        num = (<>1__state = -1);
                    }
                    awaiter.GetResult();
                    <gzip>5__2?.Dispose();
                }
                catch (Exception exception)
                {
                    <>1__state = -2;
                    <gzip>5__2 = null;
                    <>t__builder.SetException(exception);
                    return;
                }
                <>1__state = -2;
                <gzip>5__2 = null;
                <>t__builder.SetResult();
            }

            [DebuggerHidden]
            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                <>t__builder.SetStateMachine(stateMachine);
            }
        }

        private readonly HttpContent _content;

        public GZipContent(HttpContent content)
        {
            _content = content ?? throw new ArgumentNullException(nameof(content));
            
            // Copy headers from the original content
            if (content.Headers != null)
            {
                foreach (var header in content.Headers)
                {
                    Headers.TryAddWithoutValidation(header.Key, header.Value);
                }
            }
            
            // Set content encoding to gzip
            Headers.ContentEncoding.Add("gzip");
        }

        [AsyncStateMachine(typeof(<SerializeToStreamAsync>d__2))]
        protected override Task SerializeToStreamAsync(Stream stream, TransportContext context)
        {
            <SerializeToStreamAsync>d__2 stateMachine = default(<SerializeToStreamAsync>d__2);
            stateMachine.<>t__builder = AsyncTaskMethodBuilder.Create();
            stateMachine.stream = stream;
            stateMachine.<>4__this = this;
            stateMachine.<>1__state = -1;
            stateMachine.<>t__builder.Start(ref stateMachine);
            return stateMachine.<>t__builder.Task;
        }

        protected override bool TryComputeLength(out long length)
        {
            length = -1;
            return false;
        }
    }
}