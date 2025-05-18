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

namespace Silk.NET.Vulkan.Vma
{
    [NativeName("Name", "VmaDefragmentationPassMoveInfo")]
    public unsafe partial struct DefragmentationPassMoveInfo
    {
        public DefragmentationPassMoveInfo
        (
            uint? moveCount = null,
            DefragmentationMove* pMoves = null
        ) : this()
        {
            if (moveCount is not null)
            {
                MoveCount = moveCount.Value;
            }

            if (pMoves is not null)
            {
                PMoves = pMoves;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "moveCount")]
        public uint MoveCount;

        [NativeName("Type", "VmaDefragmentationMove * _Nullable")]
        [NativeName("Type.Name", "VmaDefragmentationMove * _Nullable")]
        [NativeName("Name", "pMoves")]
        public DefragmentationMove* PMoves;
    }
}
