﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Threading;
using ShaderTools.CodeAnalysis.Host;
using ShaderTools.CodeAnalysis.Text;

namespace ShaderTools.CodeAnalysis.Editor.Implementation.CommentSelection
{
    internal interface ICommentUncommentService : ILanguageService
    {
        string SingleLineCommentString { get; }
        bool SupportsBlockComment { get; }
        string BlockCommentStartString { get; }
        string BlockCommentEndString { get; }

        Document Format(Document document, IEnumerable<TextSpan> changes, CancellationToken cancellationToken);
    }
}
