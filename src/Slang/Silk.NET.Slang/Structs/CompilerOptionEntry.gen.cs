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
    [NativeName("Name", "CompilerOptionEntry")]
    public unsafe partial struct CompilerOptionEntry
    {
        public CompilerOptionEntry
        (
            CompilerOptionName? name = null,
            CompilerOptionValue? value = null
        ) : this()
        {
            if (name is not null)
            {
                Name = name.Value;
            }

            if (value is not null)
            {
                Value = value.Value;
            }
        }


        [NativeName("Type", "slang::CompilerOptionName")]
        [NativeName("Type.Name", "slang::CompilerOptionName")]
        [NativeName("Name", "name")]
        public CompilerOptionName Name;

        [NativeName("Type", "slang::CompilerOptionValue")]
        [NativeName("Type.Name", "slang::CompilerOptionValue")]
        [NativeName("Name", "value")]
        public CompilerOptionValue Value;
    }
}
