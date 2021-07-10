﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.VisualStudio.Text.Tagging;

namespace Roslyn.Hosting.Diagnostics.VenusMargin
{
    internal class ProjectionSpanTag : TextMarkerTag
    {
        public const string TagId = "ProjectionTag";

        public static readonly ProjectionSpanTag Instance = new ProjectionSpanTag();

        public ProjectionSpanTag()
            : base(TagId)
        {
        }
    }
}
