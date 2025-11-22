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

namespace Silk.NET.HarfBuzz
{
    [NativeName("Name", "hb_user_data_key_t")]
    public unsafe partial struct UserDataKeyT
    {
        public UserDataKeyT
        (
            byte? unused = null
        ) : this()
        {
            if (unused is not null)
            {
                Unused = unused.Value;
            }
        }


        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "unused")]
        public byte Unused;
    }
}
