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
    [NativeName("Name", "FT_ListNodeRec_")]
    public unsafe partial struct ListNodeRec
    {
        public ListNodeRec
        (
            ListNodeRec* prev = null,
            ListNodeRec* next = null,
            void* data = null
        ) : this()
        {
            if (prev is not null)
            {
                Prev = prev;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (data is not null)
            {
                Data = data;
            }
        }


        [NativeName("Type", "FT_ListNode")]
        [NativeName("Type.Name", "FT_ListNode")]
        [NativeName("Name", "prev")]
        public ListNodeRec* Prev;

        [NativeName("Type", "FT_ListNode")]
        [NativeName("Type.Name", "FT_ListNode")]
        [NativeName("Name", "next")]
        public ListNodeRec* Next;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "data")]
        public void* Data;
    }
}
