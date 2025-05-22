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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "SlangReflectionGenericArg")]
    public unsafe partial struct ReflectionGenericArg
    {
        public ReflectionGenericArg
        (
            ReflectionType* typeVal = null,
            long? intVal = null,
            bool? boolVal = null
        ) : this()
        {
            if (typeVal is not null)
            {
                TypeVal = typeVal;
            }

            if (intVal is not null)
            {
                IntVal = intVal.Value;
            }

            if (boolVal is not null)
            {
                BoolVal = boolVal.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "SlangReflectionType *")]
        [NativeName("Type.Name", "SlangReflectionType *")]
        [NativeName("Name", "typeVal")]
        public ReflectionType* TypeVal;

        [FieldOffset(0)]
        [NativeName("Type", "int64_t")]
        [NativeName("Type.Name", "int64_t")]
        [NativeName("Name", "intVal")]
        public long IntVal;

        [FieldOffset(0)]
        [NativeName("Type", "bool")]
        [NativeName("Type.Name", "bool")]
        [NativeName("Name", "boolVal")]
        public bool BoolVal;
    }
}
