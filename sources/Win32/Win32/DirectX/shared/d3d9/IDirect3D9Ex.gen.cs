// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='IDirect3D9Ex.xml' path='doc/member[@name="IDirect3D9Ex"]/*'/>
[Guid("02177241-69FC-400C-8FF1-93A44DF6861D")]
[NativeTypeName("struct IDirect3D9Ex : IDirect3D9")]
[NativeInheritance("IDirect3D9")]
public unsafe partial struct IDirect3D9Ex : IDirect3D9Ex.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDirect3D9Ex));

    public interface Interface : IDirect3D9.Interface
    {
        [VtblIndex(20)]
        HResult CreateDeviceEx(uint Adapter, D3Ddevtype DeviceType, HWND hFocusWindow, [NativeTypeName("DWORD")] uint BehaviorFlags, D3DpresentParameters* pPresentationParameters, D3Ddisplaymodeex* pFullscreenDisplayMode, IDirect3DDevice9Ex* ppReturnedDeviceInterface);
        [VtblIndex(20)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateDeviceEx(uint Adapter, D3Ddevtype DeviceType, HWND hFocusWindow, [NativeTypeName("DWORD")] uint BehaviorFlags, Ref<D3DpresentParameters> pPresentationParameters, Ref<D3Ddisplaymodeex> pFullscreenDisplayMode, Ref<IDirect3DDevice9Ex> ppReturnedDeviceInterface);
        [VtblIndex(18)]
        HResult EnumAdapterModesEx(uint Adapter, [NativeTypeName("const D3DDISPLAYMODEFILTER *")] D3Ddisplaymodefilter* pFilter, uint Mode, D3Ddisplaymodeex* pMode);
        [VtblIndex(18)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult EnumAdapterModesEx(uint Adapter, [NativeTypeName("const D3DDISPLAYMODEFILTER *")] Ref<D3Ddisplaymodefilter> pFilter, uint Mode, Ref<D3Ddisplaymodeex> pMode);
        [VtblIndex(19)]
        HResult GetAdapterDisplayModeEx(uint Adapter, D3Ddisplaymodeex* pMode, D3Ddisplayrotation* pRotation);
        [VtblIndex(19)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetAdapterDisplayModeEx(uint Adapter, Ref<D3Ddisplaymodeex> pMode, Ref<D3Ddisplayrotation> pRotation);
        [VtblIndex(21)]
        HResult GetAdapterLUID(uint Adapter, LUID* pLUID);
        [VtblIndex(21)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetAdapterLUID(uint Adapter, Ref<LUID> pLUID);
        [VtblIndex(17)]
        uint GetAdapterModeCountEx(uint Adapter, [NativeTypeName("const D3DDISPLAYMODEFILTER *")] D3Ddisplaymodefilter* pFilter);
        [VtblIndex(17)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        uint GetAdapterModeCountEx(uint Adapter, [NativeTypeName("const D3DDISPLAYMODEFILTER *")] Ref<D3Ddisplaymodefilter> pFilter);
    }

    /// <include file='IDirect3D9Ex.xml' path='doc/member[@name="IDirect3D9Ex"]/*'/>
    [Guid("02177241-69FC-400C-8FF1-93A44DF6861D")]
    [NativeTypeName("struct IDirect3D9Ex : IDirect3D9")]
    [NativeInheritance("IDirect3D9")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDirect3D9Ex));

        public void** lpVtbl;
        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void**, HResult> QueryInterface;
            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> AddRef;
            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> Release;
            [NativeTypeName("HRESULT (void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void*, HResult> RegisterSoftwareDevice;
            [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> GetAdapterCount;
            [NativeTypeName("HRESULT (UINT, DWORD, D3DADAPTER_IDENTIFIER9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, D3DadapterIdentifier9*, HResult> GetAdapterIdentifier;
            [NativeTypeName("UINT (UINT, D3DFORMAT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3Dformat, uint> GetAdapterModeCount;
            [NativeTypeName("HRESULT (UINT, D3DFORMAT, UINT, D3DDISPLAYMODE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3Dformat, uint, D3Ddisplaymode*, HResult> EnumAdapterModes;
            [NativeTypeName("HRESULT (UINT, D3DDISPLAYMODE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3Ddisplaymode*, HResult> GetAdapterDisplayMode;
            [NativeTypeName("HRESULT (UINT, D3DDEVTYPE, D3DFORMAT, D3DFORMAT, BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3Ddevtype, D3Dformat, D3Dformat, MaybeBool<int>, HResult> CheckDeviceType;
            [NativeTypeName("HRESULT (UINT, D3DDEVTYPE, D3DFORMAT, DWORD, D3DRESOURCETYPE, D3DFORMAT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3Ddevtype, D3Dformat, uint, D3Dresourcetype, D3Dformat, HResult> CheckDeviceFormat;
            [NativeTypeName("HRESULT (UINT, D3DDEVTYPE, D3DFORMAT, BOOL, D3DMULTISAMPLE_TYPE, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3Ddevtype, D3Dformat, MaybeBool<int>, D3DmultisampleType, uint*, HResult> CheckDeviceMultiSampleType;
            [NativeTypeName("HRESULT (UINT, D3DDEVTYPE, D3DFORMAT, D3DFORMAT, D3DFORMAT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3Ddevtype, D3Dformat, D3Dformat, D3Dformat, HResult> CheckDepthStencilMatch;
            [NativeTypeName("HRESULT (UINT, D3DDEVTYPE, D3DFORMAT, D3DFORMAT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3Ddevtype, D3Dformat, D3Dformat, HResult> CheckDeviceFormatConversion;
            [NativeTypeName("HRESULT (UINT, D3DDEVTYPE, D3DCAPS9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3Ddevtype, D3Dcaps9*, HResult> GetDeviceCaps;
            [NativeTypeName("HMONITOR (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, void*> GetAdapterMonitor;
            [NativeTypeName("HRESULT (UINT, D3DDEVTYPE, HWND, DWORD, D3DPRESENT_PARAMETERS *, IDirect3DDevice9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3Ddevtype, HWND, uint, D3DpresentParameters*, IDirect3DDevice9.Native**, HResult> CreateDevice;
            [NativeTypeName("UINT (UINT, const D3DDISPLAYMODEFILTER *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3Ddisplaymodefilter*, uint> GetAdapterModeCountEx;
            [NativeTypeName("HRESULT (UINT, const D3DDISPLAYMODEFILTER *, UINT, D3DDISPLAYMODEEX *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3Ddisplaymodefilter*, uint, D3Ddisplaymodeex*, HResult> EnumAdapterModesEx;
            [NativeTypeName("HRESULT (UINT, D3DDISPLAYMODEEX *, D3DDISPLAYROTATION *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3Ddisplaymodeex*, D3Ddisplayrotation*, HResult> GetAdapterDisplayModeEx;
            [NativeTypeName("HRESULT (UINT, D3DDEVTYPE, HWND, DWORD, D3DPRESENT_PARAMETERS *, D3DDISPLAYMODEEX *, IDirect3DDevice9Ex **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3Ddevtype, HWND, uint, D3DpresentParameters*, D3Ddisplaymodeex*, IDirect3DDevice9Ex.Native**, HResult> CreateDeviceEx;
            [NativeTypeName("HRESULT (UINT, LUID *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, LUID*, HResult> GetAdapterLUID;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3D9Ex.Native*, uint> )(lpVtbl[1]))((IDirect3D9Ex.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IDirect3D9.CheckDepthStencilMatch"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HResult CheckDepthStencilMatch(uint Adapter, D3Ddevtype DeviceType, D3Dformat AdapterFormat, D3Dformat RenderTargetFormat, D3Dformat DepthStencilFormat)
        {
            return ((delegate* unmanaged<IDirect3D9Ex.Native*, uint, D3Ddevtype, D3Dformat, D3Dformat, D3Dformat, HResult> )(lpVtbl[12]))((IDirect3D9Ex.Native*)Unsafe.AsPointer(ref this), Adapter, DeviceType, AdapterFormat, RenderTargetFormat, DepthStencilFormat);
        }

        /// <inheritdoc cref = "IDirect3D9.CheckDeviceFormat"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HResult CheckDeviceFormat(uint Adapter, D3Ddevtype DeviceType, D3Dformat AdapterFormat, [NativeTypeName("DWORD")] uint Usage, D3Dresourcetype RType, D3Dformat CheckFormat)
        {
            return ((delegate* unmanaged<IDirect3D9Ex.Native*, uint, D3Ddevtype, D3Dformat, uint, D3Dresourcetype, D3Dformat, HResult> )(lpVtbl[10]))((IDirect3D9Ex.Native*)Unsafe.AsPointer(ref this), Adapter, DeviceType, AdapterFormat, Usage, RType, CheckFormat);
        }

        /// <inheritdoc cref = "IDirect3D9.CheckDeviceFormatConversion"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HResult CheckDeviceFormatConversion(uint Adapter, D3Ddevtype DeviceType, D3Dformat SourceFormat, D3Dformat TargetFormat)
        {
            return ((delegate* unmanaged<IDirect3D9Ex.Native*, uint, D3Ddevtype, D3Dformat, D3Dformat, HResult> )(lpVtbl[13]))((IDirect3D9Ex.Native*)Unsafe.AsPointer(ref this), Adapter, DeviceType, SourceFormat, TargetFormat);
        }

        /// <inheritdoc cref = "IDirect3D9.CheckDeviceMultiSampleType"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HResult CheckDeviceMultiSampleType(uint Adapter, D3Ddevtype DeviceType, D3Dformat SurfaceFormat, [NativeTypeName("BOOL")] MaybeBool<int> Windowed, D3DmultisampleType MultiSampleType, [NativeTypeName("DWORD *")] uint* pQualityLevels)
        {
            return ((delegate* unmanaged<IDirect3D9Ex.Native*, uint, D3Ddevtype, D3Dformat, MaybeBool<int>, D3DmultisampleType, uint*, HResult> )(lpVtbl[11]))((IDirect3D9Ex.Native*)Unsafe.AsPointer(ref this), Adapter, DeviceType, SurfaceFormat, Windowed, MultiSampleType, pQualityLevels);
        }

        [VtblIndex(11)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CheckDeviceMultiSampleType(uint Adapter, D3Ddevtype DeviceType, D3Dformat SurfaceFormat, [NativeTypeName("BOOL")] MaybeBool<int> Windowed, D3DmultisampleType MultiSampleType, [NativeTypeName("DWORD *")] Ref<uint> pQualityLevels)
        {
            fixed (uint* __dsl_pQualityLevels = pQualityLevels)
            {
                return (HResult)CheckDeviceMultiSampleType(Adapter, DeviceType, SurfaceFormat, Windowed, MultiSampleType, __dsl_pQualityLevels);
            }
        }

        /// <inheritdoc cref = "IDirect3D9.CheckDeviceType"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult CheckDeviceType(uint Adapter, D3Ddevtype DevType, D3Dformat AdapterFormat, D3Dformat BackBufferFormat, [NativeTypeName("BOOL")] MaybeBool<int> bWindowed)
        {
            return ((delegate* unmanaged<IDirect3D9Ex.Native*, uint, D3Ddevtype, D3Dformat, D3Dformat, MaybeBool<int>, HResult> )(lpVtbl[9]))((IDirect3D9Ex.Native*)Unsafe.AsPointer(ref this), Adapter, DevType, AdapterFormat, BackBufferFormat, bWindowed);
        }

        /// <inheritdoc cref = "IDirect3D9.CreateDevice"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HResult CreateDevice(uint Adapter, D3Ddevtype DeviceType, HWND hFocusWindow, [NativeTypeName("DWORD")] uint BehaviorFlags, D3DpresentParameters* pPresentationParameters, IDirect3DDevice9* ppReturnedDeviceInterface)
        {
            return ((delegate* unmanaged<IDirect3D9Ex.Native*, uint, D3Ddevtype, HWND, uint, D3DpresentParameters*, IDirect3DDevice9.Native**, HResult> )(lpVtbl[16]))((IDirect3D9Ex.Native*)Unsafe.AsPointer(ref this), Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, &ppReturnedDeviceInterface->LpVtbl);
        }

        [VtblIndex(16)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateDevice(uint Adapter, D3Ddevtype DeviceType, HWND hFocusWindow, [NativeTypeName("DWORD")] uint BehaviorFlags, Ref<D3DpresentParameters> pPresentationParameters, Ref<IDirect3DDevice9> ppReturnedDeviceInterface)
        {
            fixed (IDirect3DDevice9* __dsl_ppReturnedDeviceInterface = ppReturnedDeviceInterface)
            fixed (D3DpresentParameters* __dsl_pPresentationParameters = pPresentationParameters)
            {
                return (HResult)CreateDevice(Adapter, DeviceType, hFocusWindow, BehaviorFlags, __dsl_pPresentationParameters, __dsl_ppReturnedDeviceInterface);
            }
        }

        /// <include file='IDirect3D9Ex.xml' path='doc/member[@name="IDirect3D9Ex.CreateDeviceEx"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HResult CreateDeviceEx(uint Adapter, D3Ddevtype DeviceType, HWND hFocusWindow, [NativeTypeName("DWORD")] uint BehaviorFlags, D3DpresentParameters* pPresentationParameters, D3Ddisplaymodeex* pFullscreenDisplayMode, IDirect3DDevice9Ex* ppReturnedDeviceInterface)
        {
            return ((delegate* unmanaged<IDirect3D9Ex.Native*, uint, D3Ddevtype, HWND, uint, D3DpresentParameters*, D3Ddisplaymodeex*, IDirect3DDevice9Ex.Native**, HResult> )(lpVtbl[20]))((IDirect3D9Ex.Native*)Unsafe.AsPointer(ref this), Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, pFullscreenDisplayMode, &ppReturnedDeviceInterface->LpVtbl);
        }

        [VtblIndex(20)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateDeviceEx(uint Adapter, D3Ddevtype DeviceType, HWND hFocusWindow, [NativeTypeName("DWORD")] uint BehaviorFlags, Ref<D3DpresentParameters> pPresentationParameters, Ref<D3Ddisplaymodeex> pFullscreenDisplayMode, Ref<IDirect3DDevice9Ex> ppReturnedDeviceInterface)
        {
            fixed (IDirect3DDevice9Ex* __dsl_ppReturnedDeviceInterface = ppReturnedDeviceInterface)
            fixed (D3Ddisplaymodeex* __dsl_pFullscreenDisplayMode = pFullscreenDisplayMode)
            fixed (D3DpresentParameters* __dsl_pPresentationParameters = pPresentationParameters)
            {
                return (HResult)CreateDeviceEx(Adapter, DeviceType, hFocusWindow, BehaviorFlags, __dsl_pPresentationParameters, __dsl_pFullscreenDisplayMode, __dsl_ppReturnedDeviceInterface);
            }
        }

        /// <inheritdoc cref = "IDirect3D9.EnumAdapterModes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult EnumAdapterModes(uint Adapter, D3Dformat Format, uint Mode, D3Ddisplaymode* pMode)
        {
            return ((delegate* unmanaged<IDirect3D9Ex.Native*, uint, D3Dformat, uint, D3Ddisplaymode*, HResult> )(lpVtbl[7]))((IDirect3D9Ex.Native*)Unsafe.AsPointer(ref this), Adapter, Format, Mode, pMode);
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult EnumAdapterModes(uint Adapter, D3Dformat Format, uint Mode, Ref<D3Ddisplaymode> pMode)
        {
            fixed (D3Ddisplaymode* __dsl_pMode = pMode)
            {
                return (HResult)EnumAdapterModes(Adapter, Format, Mode, __dsl_pMode);
            }
        }

        /// <include file='IDirect3D9Ex.xml' path='doc/member[@name="IDirect3D9Ex.EnumAdapterModesEx"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HResult EnumAdapterModesEx(uint Adapter, [NativeTypeName("const D3DDISPLAYMODEFILTER *")] D3Ddisplaymodefilter* pFilter, uint Mode, D3Ddisplaymodeex* pMode)
        {
            return ((delegate* unmanaged<IDirect3D9Ex.Native*, uint, D3Ddisplaymodefilter*, uint, D3Ddisplaymodeex*, HResult> )(lpVtbl[18]))((IDirect3D9Ex.Native*)Unsafe.AsPointer(ref this), Adapter, pFilter, Mode, pMode);
        }

        [VtblIndex(18)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult EnumAdapterModesEx(uint Adapter, [NativeTypeName("const D3DDISPLAYMODEFILTER *")] Ref<D3Ddisplaymodefilter> pFilter, uint Mode, Ref<D3Ddisplaymodeex> pMode)
        {
            fixed (D3Ddisplaymodeex* __dsl_pMode = pMode)
            fixed (D3Ddisplaymodefilter* __dsl_pFilter = pFilter)
            {
                return (HResult)EnumAdapterModesEx(Adapter, __dsl_pFilter, Mode, __dsl_pMode);
            }
        }

        /// <inheritdoc cref = "IDirect3D9.GetAdapterCount"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public uint GetAdapterCount()
        {
            return ((delegate* unmanaged<IDirect3D9Ex.Native*, uint> )(lpVtbl[4]))((IDirect3D9Ex.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IDirect3D9.GetAdapterDisplayMode"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HResult GetAdapterDisplayMode(uint Adapter, D3Ddisplaymode* pMode)
        {
            return ((delegate* unmanaged<IDirect3D9Ex.Native*, uint, D3Ddisplaymode*, HResult> )(lpVtbl[8]))((IDirect3D9Ex.Native*)Unsafe.AsPointer(ref this), Adapter, pMode);
        }

        [VtblIndex(8)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetAdapterDisplayMode(uint Adapter, Ref<D3Ddisplaymode> pMode)
        {
            fixed (D3Ddisplaymode* __dsl_pMode = pMode)
            {
                return (HResult)GetAdapterDisplayMode(Adapter, __dsl_pMode);
            }
        }

        /// <include file='IDirect3D9Ex.xml' path='doc/member[@name="IDirect3D9Ex.GetAdapterDisplayModeEx"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HResult GetAdapterDisplayModeEx(uint Adapter, D3Ddisplaymodeex* pMode, D3Ddisplayrotation* pRotation)
        {
            return ((delegate* unmanaged<IDirect3D9Ex.Native*, uint, D3Ddisplaymodeex*, D3Ddisplayrotation*, HResult> )(lpVtbl[19]))((IDirect3D9Ex.Native*)Unsafe.AsPointer(ref this), Adapter, pMode, pRotation);
        }

        [VtblIndex(19)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetAdapterDisplayModeEx(uint Adapter, Ref<D3Ddisplaymodeex> pMode, Ref<D3Ddisplayrotation> pRotation)
        {
            fixed (D3Ddisplayrotation* __dsl_pRotation = pRotation)
            fixed (D3Ddisplaymodeex* __dsl_pMode = pMode)
            {
                return (HResult)GetAdapterDisplayModeEx(Adapter, __dsl_pMode, __dsl_pRotation);
            }
        }

        /// <inheritdoc cref = "IDirect3D9.GetAdapterIdentifier"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult GetAdapterIdentifier(uint Adapter, [NativeTypeName("DWORD")] uint Flags, D3DadapterIdentifier9* pIdentifier)
        {
            return ((delegate* unmanaged<IDirect3D9Ex.Native*, uint, uint, D3DadapterIdentifier9*, HResult> )(lpVtbl[5]))((IDirect3D9Ex.Native*)Unsafe.AsPointer(ref this), Adapter, Flags, pIdentifier);
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetAdapterIdentifier(uint Adapter, [NativeTypeName("DWORD")] uint Flags, Ref<D3DadapterIdentifier9> pIdentifier)
        {
            fixed (D3DadapterIdentifier9* __dsl_pIdentifier = pIdentifier)
            {
                return (HResult)GetAdapterIdentifier(Adapter, Flags, __dsl_pIdentifier);
            }
        }

        /// <include file='IDirect3D9Ex.xml' path='doc/member[@name="IDirect3D9Ex.GetAdapterLUID"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HResult GetAdapterLUID(uint Adapter, LUID* pLUID)
        {
            return ((delegate* unmanaged<IDirect3D9Ex.Native*, uint, LUID*, HResult> )(lpVtbl[21]))((IDirect3D9Ex.Native*)Unsafe.AsPointer(ref this), Adapter, pLUID);
        }

        [VtblIndex(21)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetAdapterLUID(uint Adapter, Ref<LUID> pLUID)
        {
            fixed (LUID* __dsl_pLUID = pLUID)
            {
                return (HResult)GetAdapterLUID(Adapter, __dsl_pLUID);
            }
        }

        /// <inheritdoc cref = "IDirect3D9.GetAdapterModeCount"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public uint GetAdapterModeCount(uint Adapter, D3Dformat Format)
        {
            return ((delegate* unmanaged<IDirect3D9Ex.Native*, uint, D3Dformat, uint> )(lpVtbl[6]))((IDirect3D9Ex.Native*)Unsafe.AsPointer(ref this), Adapter, Format);
        }

        /// <include file='IDirect3D9Ex.xml' path='doc/member[@name="IDirect3D9Ex.GetAdapterModeCountEx"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public uint GetAdapterModeCountEx(uint Adapter, [NativeTypeName("const D3DDISPLAYMODEFILTER *")] D3Ddisplaymodefilter* pFilter)
        {
            return ((delegate* unmanaged<IDirect3D9Ex.Native*, uint, D3Ddisplaymodefilter*, uint> )(lpVtbl[17]))((IDirect3D9Ex.Native*)Unsafe.AsPointer(ref this), Adapter, pFilter);
        }

        [VtblIndex(17)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public uint GetAdapterModeCountEx(uint Adapter, [NativeTypeName("const D3DDISPLAYMODEFILTER *")] Ref<D3Ddisplaymodefilter> pFilter)
        {
            fixed (D3Ddisplaymodefilter* __dsl_pFilter = pFilter)
            {
                return (uint)GetAdapterModeCountEx(Adapter, __dsl_pFilter);
            }
        }

        /// <inheritdoc cref = "IDirect3D9.GetAdapterMonitor"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HMONITOR GetAdapterMonitor(uint Adapter)
        {
            return ((HMONITOR)(((delegate* unmanaged<IDirect3D9Ex.Native*, uint, void*> )(lpVtbl[15]))((IDirect3D9Ex.Native*)Unsafe.AsPointer(ref this), Adapter)));
        }

        /// <inheritdoc cref = "IDirect3D9.GetDeviceCaps"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HResult GetDeviceCaps(uint Adapter, D3Ddevtype DeviceType, D3Dcaps9* pCaps)
        {
            return ((delegate* unmanaged<IDirect3D9Ex.Native*, uint, D3Ddevtype, D3Dcaps9*, HResult> )(lpVtbl[14]))((IDirect3D9Ex.Native*)Unsafe.AsPointer(ref this), Adapter, DeviceType, pCaps);
        }

        [VtblIndex(14)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetDeviceCaps(uint Adapter, D3Ddevtype DeviceType, Ref<D3Dcaps9> pCaps)
        {
            fixed (D3Dcaps9* __dsl_pCaps = pCaps)
            {
                return (HResult)GetDeviceCaps(Adapter, DeviceType, __dsl_pCaps);
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3D9Ex.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((IDirect3D9Ex.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [VtblIndex(0)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvObject)
        {
            fixed (void** __dsl_ppvObject = ppvObject)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)QueryInterface(__dsl_riid, __dsl_ppvObject);
            }
        }

        [VtblIndex(0)]
        [Transformed]
        public HResult QueryInterface<TCom>(out TCom ppvObject)
            where TCom : unmanaged, IComVtbl
        {
            ppvObject = default;
            return QueryInterface(TCom.NativeGuid, ppvObject.GetAddressOf());
        }

        /// <inheritdoc cref = "IDirect3D9.RegisterSoftwareDevice"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult RegisterSoftwareDevice(void* pInitializeFunction)
        {
            return ((delegate* unmanaged<IDirect3D9Ex.Native*, void*, HResult> )(lpVtbl[3]))((IDirect3D9Ex.Native*)Unsafe.AsPointer(ref this), pInitializeFunction);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult RegisterSoftwareDevice(Ref pInitializeFunction)
        {
            fixed (void* __dsl_pInitializeFunction = pInitializeFunction)
            {
                return (HResult)RegisterSoftwareDevice(__dsl_pInitializeFunction);
            }
        }

        /// <inheritdoc cref = "IUnknown.Release"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirect3D9Ex.Native*, uint> )(lpVtbl[2]))((IDirect3D9Ex.Native*)Unsafe.AsPointer(ref this));
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirect3D9Ex"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3D9Ex(Ptr3D vtbl) => LpVtbl = (IDirect3D9Ex.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "IDirect3D9Ex"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3D9Ex(Ptr<IDirect3D9Ex.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "IDirect3D9Ex.Native"/> to <see cref = "IDirect3D9Ex"/>.</summary>
    /// <param name = "value">The <see cref = "IDirect3D9Ex.Native"/> instance to be converted </param>
    public static implicit operator IDirect3D9Ex(IDirect3D9Ex.Native* value) => new IDirect3D9Ex((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDirect3D9Ex"/> to <see cref = "IDirect3D9Ex.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IDirect3D9Ex"/> instance to be converted </param>
    public static implicit operator IDirect3D9Ex.Native*(IDirect3D9Ex value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IDirect3D9Ex"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator IDirect3D9Ex(Ptr3D value) => new IDirect3D9Ex(value);
    /// <summary>casts <see cref = "IDirect3D9Ex"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3D9Ex"/> instance to be converted </param>
    public static implicit operator Ptr3D(IDirect3D9Ex value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IDirect3D9Ex"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator IDirect3D9Ex(Ptr<IDirect3D9Ex.Native> value) => new IDirect3D9Ex(value);
    /// <summary>casts <see cref = "IDirect3D9Ex"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3D9Ex"/> instance to be converted </param>
    public static implicit operator Ptr<IDirect3D9Ex.Native>(IDirect3D9Ex value) => (Ptr<IDirect3D9Ex.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "IDirect3D9Ex"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator IDirect3D9Ex(void*** value) => new IDirect3D9Ex((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDirect3D9Ex"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IDirect3D9Ex"/> instance to be converted </param>
    public static implicit operator void***(IDirect3D9Ex value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "IDirect3D9Ex"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator IDirect3D9Ex(nuint value) => new IDirect3D9Ex((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "IDirect3D9Ex"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3D9Ex"/> instance to be converted </param>
    public static implicit operator nuint(IDirect3D9Ex value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <inheritdoc cref = "IDirect3D9.CheckDepthStencilMatch"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HResult CheckDepthStencilMatch(uint Adapter, D3Ddevtype DeviceType, D3Dformat AdapterFormat, D3Dformat RenderTargetFormat, D3Dformat DepthStencilFormat) => LpVtbl->CheckDepthStencilMatch(Adapter, DeviceType, AdapterFormat, RenderTargetFormat, DepthStencilFormat);
    /// <inheritdoc cref = "IDirect3D9.CheckDeviceFormat"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HResult CheckDeviceFormat(uint Adapter, D3Ddevtype DeviceType, D3Dformat AdapterFormat, [NativeTypeName("DWORD")] uint Usage, D3Dresourcetype RType, D3Dformat CheckFormat) => LpVtbl->CheckDeviceFormat(Adapter, DeviceType, AdapterFormat, Usage, RType, CheckFormat);
    /// <inheritdoc cref = "IDirect3D9.CheckDeviceFormatConversion"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HResult CheckDeviceFormatConversion(uint Adapter, D3Ddevtype DeviceType, D3Dformat SourceFormat, D3Dformat TargetFormat) => LpVtbl->CheckDeviceFormatConversion(Adapter, DeviceType, SourceFormat, TargetFormat);
    /// <inheritdoc cref = "IDirect3D9.CheckDeviceMultiSampleType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HResult CheckDeviceMultiSampleType(uint Adapter, D3Ddevtype DeviceType, D3Dformat SurfaceFormat, [NativeTypeName("BOOL")] MaybeBool<int> Windowed, D3DmultisampleType MultiSampleType, [NativeTypeName("DWORD *")] uint* pQualityLevels) => LpVtbl->CheckDeviceMultiSampleType(Adapter, DeviceType, SurfaceFormat, Windowed, MultiSampleType, pQualityLevels);
    [VtblIndex(11)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CheckDeviceMultiSampleType(uint Adapter, D3Ddevtype DeviceType, D3Dformat SurfaceFormat, [NativeTypeName("BOOL")] MaybeBool<int> Windowed, D3DmultisampleType MultiSampleType, [NativeTypeName("DWORD *")] Ref<uint> pQualityLevels)
    {
        fixed (uint* __dsl_pQualityLevels = pQualityLevels)
        {
            return (HResult)CheckDeviceMultiSampleType(Adapter, DeviceType, SurfaceFormat, Windowed, MultiSampleType, __dsl_pQualityLevels);
        }
    }

    /// <inheritdoc cref = "IDirect3D9.CheckDeviceType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HResult CheckDeviceType(uint Adapter, D3Ddevtype DevType, D3Dformat AdapterFormat, D3Dformat BackBufferFormat, [NativeTypeName("BOOL")] MaybeBool<int> bWindowed) => LpVtbl->CheckDeviceType(Adapter, DevType, AdapterFormat, BackBufferFormat, bWindowed);
    /// <inheritdoc cref = "IDirect3D9.CreateDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HResult CreateDevice(uint Adapter, D3Ddevtype DeviceType, HWND hFocusWindow, [NativeTypeName("DWORD")] uint BehaviorFlags, D3DpresentParameters* pPresentationParameters, IDirect3DDevice9* ppReturnedDeviceInterface) => LpVtbl->CreateDevice(Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, ppReturnedDeviceInterface);
    [VtblIndex(16)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateDevice(uint Adapter, D3Ddevtype DeviceType, HWND hFocusWindow, [NativeTypeName("DWORD")] uint BehaviorFlags, Ref<D3DpresentParameters> pPresentationParameters, Ref<IDirect3DDevice9> ppReturnedDeviceInterface)
    {
        fixed (IDirect3DDevice9* __dsl_ppReturnedDeviceInterface = ppReturnedDeviceInterface)
        fixed (D3DpresentParameters* __dsl_pPresentationParameters = pPresentationParameters)
        {
            return (HResult)CreateDevice(Adapter, DeviceType, hFocusWindow, BehaviorFlags, __dsl_pPresentationParameters, __dsl_ppReturnedDeviceInterface);
        }
    }

    /// <include file='IDirect3D9Ex.xml' path='doc/member[@name="IDirect3D9Ex.CreateDeviceEx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HResult CreateDeviceEx(uint Adapter, D3Ddevtype DeviceType, HWND hFocusWindow, [NativeTypeName("DWORD")] uint BehaviorFlags, D3DpresentParameters* pPresentationParameters, D3Ddisplaymodeex* pFullscreenDisplayMode, IDirect3DDevice9Ex* ppReturnedDeviceInterface) => LpVtbl->CreateDeviceEx(Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, pFullscreenDisplayMode, ppReturnedDeviceInterface);
    [VtblIndex(20)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateDeviceEx(uint Adapter, D3Ddevtype DeviceType, HWND hFocusWindow, [NativeTypeName("DWORD")] uint BehaviorFlags, Ref<D3DpresentParameters> pPresentationParameters, Ref<D3Ddisplaymodeex> pFullscreenDisplayMode, Ref<IDirect3DDevice9Ex> ppReturnedDeviceInterface)
    {
        fixed (IDirect3DDevice9Ex* __dsl_ppReturnedDeviceInterface = ppReturnedDeviceInterface)
        fixed (D3Ddisplaymodeex* __dsl_pFullscreenDisplayMode = pFullscreenDisplayMode)
        fixed (D3DpresentParameters* __dsl_pPresentationParameters = pPresentationParameters)
        {
            return (HResult)CreateDeviceEx(Adapter, DeviceType, hFocusWindow, BehaviorFlags, __dsl_pPresentationParameters, __dsl_pFullscreenDisplayMode, __dsl_ppReturnedDeviceInterface);
        }
    }

    /// <inheritdoc cref = "IDirect3D9.EnumAdapterModes"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult EnumAdapterModes(uint Adapter, D3Dformat Format, uint Mode, D3Ddisplaymode* pMode) => LpVtbl->EnumAdapterModes(Adapter, Format, Mode, pMode);
    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult EnumAdapterModes(uint Adapter, D3Dformat Format, uint Mode, Ref<D3Ddisplaymode> pMode)
    {
        fixed (D3Ddisplaymode* __dsl_pMode = pMode)
        {
            return (HResult)EnumAdapterModes(Adapter, Format, Mode, __dsl_pMode);
        }
    }

    /// <include file='IDirect3D9Ex.xml' path='doc/member[@name="IDirect3D9Ex.EnumAdapterModesEx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HResult EnumAdapterModesEx(uint Adapter, [NativeTypeName("const D3DDISPLAYMODEFILTER *")] D3Ddisplaymodefilter* pFilter, uint Mode, D3Ddisplaymodeex* pMode) => LpVtbl->EnumAdapterModesEx(Adapter, pFilter, Mode, pMode);
    [VtblIndex(18)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult EnumAdapterModesEx(uint Adapter, [NativeTypeName("const D3DDISPLAYMODEFILTER *")] Ref<D3Ddisplaymodefilter> pFilter, uint Mode, Ref<D3Ddisplaymodeex> pMode)
    {
        fixed (D3Ddisplaymodeex* __dsl_pMode = pMode)
        fixed (D3Ddisplaymodefilter* __dsl_pFilter = pFilter)
        {
            return (HResult)EnumAdapterModesEx(Adapter, __dsl_pFilter, Mode, __dsl_pMode);
        }
    }

    /// <inheritdoc cref = "IDirect3D9.GetAdapterCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public uint GetAdapterCount() => LpVtbl->GetAdapterCount();
    /// <inheritdoc cref = "IDirect3D9.GetAdapterDisplayMode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HResult GetAdapterDisplayMode(uint Adapter, D3Ddisplaymode* pMode) => LpVtbl->GetAdapterDisplayMode(Adapter, pMode);
    [VtblIndex(8)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetAdapterDisplayMode(uint Adapter, Ref<D3Ddisplaymode> pMode)
    {
        fixed (D3Ddisplaymode* __dsl_pMode = pMode)
        {
            return (HResult)GetAdapterDisplayMode(Adapter, __dsl_pMode);
        }
    }

    /// <include file='IDirect3D9Ex.xml' path='doc/member[@name="IDirect3D9Ex.GetAdapterDisplayModeEx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HResult GetAdapterDisplayModeEx(uint Adapter, D3Ddisplaymodeex* pMode, D3Ddisplayrotation* pRotation) => LpVtbl->GetAdapterDisplayModeEx(Adapter, pMode, pRotation);
    [VtblIndex(19)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetAdapterDisplayModeEx(uint Adapter, Ref<D3Ddisplaymodeex> pMode, Ref<D3Ddisplayrotation> pRotation)
    {
        fixed (D3Ddisplayrotation* __dsl_pRotation = pRotation)
        fixed (D3Ddisplaymodeex* __dsl_pMode = pMode)
        {
            return (HResult)GetAdapterDisplayModeEx(Adapter, __dsl_pMode, __dsl_pRotation);
        }
    }

    /// <inheritdoc cref = "IDirect3D9.GetAdapterIdentifier"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult GetAdapterIdentifier(uint Adapter, [NativeTypeName("DWORD")] uint Flags, D3DadapterIdentifier9* pIdentifier) => LpVtbl->GetAdapterIdentifier(Adapter, Flags, pIdentifier);
    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetAdapterIdentifier(uint Adapter, [NativeTypeName("DWORD")] uint Flags, Ref<D3DadapterIdentifier9> pIdentifier)
    {
        fixed (D3DadapterIdentifier9* __dsl_pIdentifier = pIdentifier)
        {
            return (HResult)GetAdapterIdentifier(Adapter, Flags, __dsl_pIdentifier);
        }
    }

    /// <include file='IDirect3D9Ex.xml' path='doc/member[@name="IDirect3D9Ex.GetAdapterLUID"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HResult GetAdapterLUID(uint Adapter, LUID* pLUID) => LpVtbl->GetAdapterLUID(Adapter, pLUID);
    [VtblIndex(21)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetAdapterLUID(uint Adapter, Ref<LUID> pLUID)
    {
        fixed (LUID* __dsl_pLUID = pLUID)
        {
            return (HResult)GetAdapterLUID(Adapter, __dsl_pLUID);
        }
    }

    /// <inheritdoc cref = "IDirect3D9.GetAdapterModeCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public uint GetAdapterModeCount(uint Adapter, D3Dformat Format) => LpVtbl->GetAdapterModeCount(Adapter, Format);
    /// <include file='IDirect3D9Ex.xml' path='doc/member[@name="IDirect3D9Ex.GetAdapterModeCountEx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public uint GetAdapterModeCountEx(uint Adapter, [NativeTypeName("const D3DDISPLAYMODEFILTER *")] D3Ddisplaymodefilter* pFilter) => LpVtbl->GetAdapterModeCountEx(Adapter, pFilter);
    [VtblIndex(17)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public uint GetAdapterModeCountEx(uint Adapter, [NativeTypeName("const D3DDISPLAYMODEFILTER *")] Ref<D3Ddisplaymodefilter> pFilter)
    {
        fixed (D3Ddisplaymodefilter* __dsl_pFilter = pFilter)
        {
            return (uint)GetAdapterModeCountEx(Adapter, __dsl_pFilter);
        }
    }

    /// <inheritdoc cref = "IDirect3D9.GetAdapterMonitor"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HMONITOR GetAdapterMonitor(uint Adapter) => LpVtbl->GetAdapterMonitor(Adapter);
    /// <inheritdoc cref = "IDirect3D9.GetDeviceCaps"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HResult GetDeviceCaps(uint Adapter, D3Ddevtype DeviceType, D3Dcaps9* pCaps) => LpVtbl->GetDeviceCaps(Adapter, DeviceType, pCaps);
    [VtblIndex(14)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDeviceCaps(uint Adapter, D3Ddevtype DeviceType, Ref<D3Dcaps9> pCaps)
    {
        fixed (D3Dcaps9* __dsl_pCaps = pCaps)
        {
            return (HResult)GetDeviceCaps(Adapter, DeviceType, __dsl_pCaps);
        }
    }

    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject) => LpVtbl->QueryInterface(riid, ppvObject);
    [VtblIndex(0)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult QueryInterface([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvObject)
    {
        fixed (void** __dsl_ppvObject = ppvObject)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)QueryInterface(__dsl_riid, __dsl_ppvObject);
        }
    }

    [VtblIndex(0)]
    [Transformed]
    public HResult QueryInterface<TCom>(out TCom ppvObject)
        where TCom : unmanaged, IComVtbl
    {
        ppvObject = default;
        return QueryInterface(TCom.NativeGuid, ppvObject.GetAddressOf());
    }

    /// <inheritdoc cref = "IDirect3D9.RegisterSoftwareDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult RegisterSoftwareDevice(void* pInitializeFunction) => LpVtbl->RegisterSoftwareDevice(pInitializeFunction);
    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult RegisterSoftwareDevice(Ref pInitializeFunction)
    {
        fixed (void* __dsl_pInitializeFunction = pInitializeFunction)
        {
            return (HResult)RegisterSoftwareDevice(__dsl_pInitializeFunction);
        }
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release() => LpVtbl->Release();
}