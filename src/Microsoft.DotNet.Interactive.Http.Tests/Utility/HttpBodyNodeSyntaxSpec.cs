﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using Microsoft.DotNet.Interactive.Http.Parsing;
using Microsoft.DotNet.Interactive.Parsing.Tests.Utility;

namespace Microsoft.DotNet.Interactive.Http.Tests.Utility;

internal class HttpMethodNodeSyntaxSpec : SyntaxSpecBase<HttpMethodNode>
{
    public HttpMethodNodeSyntaxSpec(string text, params Action<HttpMethodNode>[] assertions) : base(text, assertions)
    {
    }
}

internal class HttpUrlNodeSyntaxSpec : SyntaxSpecBase<HttpUrlNode>
{
    public HttpUrlNodeSyntaxSpec(string text, params Action<HttpUrlNode>[] assertions) : base(text, assertions)
    {
    }
}

internal class HttpVersionNodeSyntaxSpec : SyntaxSpecBase<HttpVersionNode>
{
    public HttpVersionNodeSyntaxSpec(string text, params Action<HttpVersionNode>[] assertions) : base(text, assertions)
    {
    }
}

internal class HttpBodyNodeSyntaxSpec : SyntaxSpecBase<HttpBodyNode>
{
    public HttpBodyNodeSyntaxSpec(string text, params Action<HttpBodyNode>[] assertions) : base(text, assertions)
    {
    }
}

internal class HttpHeadersNodeSyntaxSpec : SyntaxSpecBase<HttpHeadersNode>
{
    public HttpHeadersNodeSyntaxSpec(string text, params Action<HttpHeadersNode>[] assertions) : base(text, assertions)
    {
    }
}