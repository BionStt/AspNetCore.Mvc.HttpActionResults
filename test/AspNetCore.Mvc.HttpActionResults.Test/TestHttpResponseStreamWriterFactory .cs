﻿namespace AspNetCore.Mvc.HttpActionResults.Test
{
    using System.IO;
    using System.Text;

    using Microsoft.AspNetCore.Mvc.Internal;
    using Microsoft.AspNetCore.WebUtilities;

    public class TestHttpResponseStreamWriterFactory : IHttpResponseStreamWriterFactory
    {
        public TextWriter CreateWriter(Stream stream, Encoding encoding)
        {
            return new HttpResponseStreamWriter(stream, encoding);
        }
    }
}
