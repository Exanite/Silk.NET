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
    [NativeName("Name", "ByteCodeFuncInfo")]
    public unsafe partial struct ByteCodeFuncInfo
    {
        public ByteCodeFuncInfo
        (
            uint? parameterCount = null,
            uint? returnValueSize = null
        ) : this()
        {
            if (parameterCount is not null)
            {
                ParameterCount = parameterCount.Value;
            }

            if (returnValueSize is not null)
            {
                ReturnValueSize = returnValueSize.Value;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "parameterCount")]
        public uint ParameterCount;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "returnValueSize")]
        public uint ReturnValueSize;
    }
}
