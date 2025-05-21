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
    [NativeName("Name", "ByteCodeRunnerDesc")]
    public unsafe partial struct ByteCodeRunnerDesc
    {
        public ByteCodeRunnerDesc
        (
            nuint? structSize = null
        ) : this()
        {
            if (structSize is not null)
            {
                StructSize = structSize.Value;
            }
        }


        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "structSize")]
        public nuint StructSize;
    }
}
