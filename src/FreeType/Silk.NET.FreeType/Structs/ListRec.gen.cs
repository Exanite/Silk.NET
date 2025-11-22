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
    [NativeName("Name", "FT_ListRec_")]
    public unsafe partial struct ListRec
    {
        public ListRec
        (
            ListNodeRec* head = null,
            ListNodeRec* tail = null
        ) : this()
        {
            if (head is not null)
            {
                Head = head;
            }

            if (tail is not null)
            {
                Tail = tail;
            }
        }


        [NativeName("Type", "FT_ListNode")]
        [NativeName("Type.Name", "FT_ListNode")]
        [NativeName("Name", "head")]
        public ListNodeRec* Head;

        [NativeName("Type", "FT_ListNode")]
        [NativeName("Type.Name", "FT_ListNode")]
        [NativeName("Name", "tail")]
        public ListNodeRec* Tail;
    }
}
