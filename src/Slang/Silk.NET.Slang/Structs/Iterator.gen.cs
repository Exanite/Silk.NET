// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "Iterator")]
    public unsafe partial struct Iterator
    {
        public Iterator
        (
            DeclReflection* parent = null,
            uint? count = null,
            uint? index = null
        ) : this()
        {
            if (parent is not null)
            {
                Parent = parent;
            }

            if (count is not null)
            {
                Count = count.Value;
            }

            if (index is not null)
            {
                Index = index.Value;
            }
        }


        [NativeName("Type", "slang::DeclReflection *")]
        [NativeName("Type.Name", "slang::DeclReflection *")]
        [NativeName("Name", "parent")]
        public DeclReflection* Parent;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "count")]
        public uint Count;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "index")]
        public uint Index;
    }
}
