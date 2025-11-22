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

namespace Silk.NET.FreeType
{
    [NativeName("Name", "FT_MemoryRec_")]
    public unsafe partial struct MemoryRec
    {
        public MemoryRec
        (
            void* user = null,
            PfnAllocFunc? alloc = null,
            PfnFreeFunc? free = null,
            PfnReallocFunc? realloc = null
        ) : this()
        {
            if (user is not null)
            {
                User = user;
            }

            if (alloc is not null)
            {
                Alloc = alloc.Value;
            }

            if (free is not null)
            {
                Free = free.Value;
            }

            if (realloc is not null)
            {
                Realloc = realloc.Value;
            }
        }


        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "user")]
        public void* User;

        [NativeName("Type", "FT_Alloc_Func")]
        [NativeName("Type.Name", "FT_Alloc_Func")]
        [NativeName("Name", "alloc")]
        public PfnAllocFunc Alloc;

        [NativeName("Type", "FT_Free_Func")]
        [NativeName("Type.Name", "FT_Free_Func")]
        [NativeName("Name", "free")]
        public PfnFreeFunc Free;

        [NativeName("Type", "FT_Realloc_Func")]
        [NativeName("Type.Name", "FT_Realloc_Func")]
        [NativeName("Name", "realloc")]
        public PfnReallocFunc Realloc;
    }
}
