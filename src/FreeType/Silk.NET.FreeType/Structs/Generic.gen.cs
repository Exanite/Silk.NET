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
    [NativeName("Name", "FT_Generic_")]
    public unsafe partial struct Generic
    {
        public Generic
        (
            void* data = null,
            PfnGenericFinalizer? finalizer = null
        ) : this()
        {
            if (data is not null)
            {
                Data = data;
            }

            if (finalizer is not null)
            {
                Finalizer = finalizer.Value;
            }
        }


        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "data")]
        public void* Data;

        [NativeName("Type", "FT_Generic_Finalizer")]
        [NativeName("Type.Name", "FT_Generic_Finalizer")]
        [NativeName("Name", "finalizer")]
        public PfnGenericFinalizer Finalizer;
    }
}
