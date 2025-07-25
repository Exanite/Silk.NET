// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    public static HResult D3DSetObjectNameA<TDXGIObject>(TDXGIObject* pObject, sbyte* pName)
        where TDXGIObject : unmanaged, IdxgiObject.Interface
    {
        return D3DSetObjectNameNA(pObject, (uint)lstrlenA(pName), pName);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult D3DSetObjectNameA<TDXGIObject>(Ref<TDXGIObject> pObject, Ref<sbyte> pName)
        where TDXGIObject : unmanaged, IdxgiObject.Interface
    {
        fixed (sbyte* __dsl_pName = pName)
        fixed (TDXGIObject* __dsl_pObject = pObject)
        {
            return (HResult)D3DSetObjectNameA(__dsl_pObject, __dsl_pName);
        }
    }

    public static HResult D3DSetObjectNameNA<TDXGIObject>(
        TDXGIObject* pObject,
        uint Chars,
        sbyte* pName
    )
        where TDXGIObject : unmanaged, IdxgiObject.Interface
    {
        var guid = WkpdidD3DDebugObjectName;
        return pObject->SetPrivateData(&guid, Chars, pName);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult D3DSetObjectNameNA<TDXGIObject>(
        Ref<TDXGIObject> pObject,
        uint Chars,
        Ref<sbyte> pName
    )
        where TDXGIObject : unmanaged, IdxgiObject.Interface
    {
        fixed (sbyte* __dsl_pName = pName)
        fixed (TDXGIObject* __dsl_pObject = pObject)
        {
            return (HResult)D3DSetObjectNameNA(__dsl_pObject, Chars, __dsl_pName);
        }
    }

    public static HResult D3DSetObjectNameNW<TDXGIObject>(
        TDXGIObject* pObject,
        uint Chars,
        char* pName
    )
        where TDXGIObject : unmanaged, IdxgiObject.Interface
    {
        var guid = WkpdidD3DDebugObjectNameW;
        return pObject->SetPrivateData(&guid, Chars * 2, pName);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult D3DSetObjectNameNW<TDXGIObject>(
        Ref<TDXGIObject> pObject,
        uint Chars,
        Ref<char> pName
    )
        where TDXGIObject : unmanaged, IdxgiObject.Interface
    {
        fixed (char* __dsl_pName = pName)
        fixed (TDXGIObject* __dsl_pObject = pObject)
        {
            return (HResult)D3DSetObjectNameNW(__dsl_pObject, Chars, __dsl_pName);
        }
    }

    public static HResult D3DSetObjectNameW<TDXGIObject>(TDXGIObject* pObject, char* pName)
        where TDXGIObject : unmanaged, IdxgiObject.Interface
    {
        return D3DSetObjectNameNW(pObject, (uint)lstrlenW(pName), pName);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult D3DSetObjectNameW<TDXGIObject>(Ref<TDXGIObject> pObject, Ref<char> pName)
        where TDXGIObject : unmanaged, IdxgiObject.Interface
    {
        fixed (char* __dsl_pName = pName)
        fixed (TDXGIObject* __dsl_pObject = pObject)
        {
            return (HResult)D3DSetObjectNameW(__dsl_pObject, __dsl_pName);
        }
    }
}
