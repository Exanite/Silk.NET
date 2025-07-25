// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class FS
{
    [NativeTypeName(
        "#define FS_BPIO_OUTPUT_ENABLE_SIZE (RTL_SIZEOF_THROUGH_FIELD(FS_BPIO_OUTPUT,Enable))"
    )]
    public static uint EnableSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out FS_BPIO_OUTPUT tmp);
            return ((uint)(&tmp.Anonymous.Enable) - (uint)(&tmp)) + (uint)(sizeof(FS_BPIO_RESULTS));
        }
    }

    [NativeTypeName(
        "#define FS_BPIO_OUTPUT_QUERY_SIZE (RTL_SIZEOF_THROUGH_FIELD(FS_BPIO_OUTPUT,Query))"
    )]
    public static uint QuerySize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out FS_BPIO_OUTPUT tmp);
            return ((uint)(&tmp.Anonymous.Query) - (uint)(&tmp)) + (uint)(sizeof(FS_BPIO_RESULTS));
        }
    }

    [NativeTypeName(
        "#define FS_BPIO_OUTPUT_DISABLE_SIZE ((size_t)FIELD_OFFSET(FS_BPIO_OUTPUT, Enable))"
    )]
    public static nuint DisableSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out FS_BPIO_OUTPUT tmp);
            return ((uint)(&tmp.Anonymous.Enable) - (uint)(&tmp)) + (uint)(sizeof(FS_BPIO_RESULTS));
        }
    }

    [NativeTypeName(
        "#define FS_BPIO_OUTPUT_VOLUME_STACK_PAUSE_SIZE ((size_t)FIELD_OFFSET(FS_BPIO_OUTPUT, Enable))"
    )]
    public static nuint VolumeStackPauseSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out FS_BPIO_OUTPUT tmp);
            return ((uint)(&tmp.Anonymous.Enable) - (uint)(&tmp)) + (uint)(sizeof(FS_BPIO_RESULTS));
        }
    }

    [NativeTypeName(
        "#define FS_BPIO_OUTPUT_VOLUME_STACK_RESUME_SIZE (RTL_SIZEOF_THROUGH_FIELD(FS_BPIO_OUTPUT,VolumeStackResume))"
    )]
    public static uint VolumeStackResumeSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out FS_BPIO_OUTPUT tmp);
            return ((uint)(&tmp.Anonymous.VolumeStackResume) - (uint)(&tmp))
                + (uint)(sizeof(FS_BPIO_RESULTS));
        }
    }

    [NativeTypeName(
        "#define FS_BPIO_OUTPUT_STREAM_PAUSE_SIZE ((size_t)FIELD_OFFSET(FS_BPIO_OUTPUT, Enable))"
    )]
    public static nuint StreamPauseSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out FS_BPIO_OUTPUT tmp);
            return ((uint)(&tmp.Anonymous.Enable) - (uint)(&tmp)) + (uint)(sizeof(FS_BPIO_RESULTS));
        }
    }

    [NativeTypeName(
        "#define FS_BPIO_OUTPUT_STREAM_RESUME_SIZE (RTL_SIZEOF_THROUGH_FIELD(FS_BPIO_OUTPUT,StreamResume))"
    )]
    public static uint StreamResumeSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out FS_BPIO_OUTPUT tmp);
            return ((uint)(&tmp.Anonymous.StreamResume) - (uint)(&tmp))
                + (uint)(sizeof(FS_BPIO_RESULTS));
        }
    }

    [NativeTypeName(
        "#define FS_BPIO_OUTPUT_GET_INFO_SIZE (RTL_SIZEOF_THROUGH_FIELD(FS_BPIO_OUTPUT,GetInfo))"
    )]
    public static uint GetInfoSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out FS_BPIO_OUTPUT tmp);
            return ((uint)(&tmp.Anonymous.GetInfo) - (uint)(&tmp)) + (uint)(sizeof(FS_BPIO_INFO));
        }
    }
}
