// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex"]/*'/>
[Guid("B18B10CE-2649-405A-870F-95F777D4313A")]
[NativeTypeName("struct IDirect3DDevice9Ex : IDirect3DDevice9")]
[NativeInheritance("IDirect3DDevice9")]
public unsafe partial struct IDirect3DDevice9Ex : IDirect3DDevice9Ex.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDirect3DDevice9Ex));

    public interface Interface : IDirect3DDevice9.Interface
    {
        [VtblIndex(128)]
        HResult CheckDeviceState(HWND hDestinationWindow);
        [VtblIndex(125)]
        HResult CheckResourceResidency(IDirect3DResource9* pResourceArray, [NativeTypeName("UINT32")] uint NumResources);
        [VtblIndex(125)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CheckResourceResidency(Ref<IDirect3DResource9> pResourceArray, [NativeTypeName("UINT32")] uint NumResources);
        [VtblIndex(120)]
        HResult ComposeRects(IDirect3DSurface9 pSrc, IDirect3DSurface9 pDst, IDirect3DVertexBuffer9 pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9 pDstRectDescs, D3Dcomposerectsop Operation, int Xoffset, int Yoffset);
        [VtblIndex(131)]
        HResult CreateDepthStencilSurfaceEx(uint Width, uint Height, D3Dformat Format, D3DmultisampleType MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] MaybeBool<int> Discard, IDirect3DSurface9* ppSurface, Handle* pSharedHandle, [NativeTypeName("DWORD")] uint Usage);
        [VtblIndex(131)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateDepthStencilSurfaceEx(uint Width, uint Height, D3Dformat Format, D3DmultisampleType MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] MaybeBool<int> Discard, Ref<IDirect3DSurface9> ppSurface, Ref<Handle> pSharedHandle, [NativeTypeName("DWORD")] uint Usage);
        [VtblIndex(130)]
        HResult CreateOffscreenPlainSurfaceEx(uint Width, uint Height, D3Dformat Format, D3Dpool Pool, IDirect3DSurface9* ppSurface, Handle* pSharedHandle, [NativeTypeName("DWORD")] uint Usage);
        [VtblIndex(130)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateOffscreenPlainSurfaceEx(uint Width, uint Height, D3Dformat Format, D3Dpool Pool, Ref<IDirect3DSurface9> ppSurface, Ref<Handle> pSharedHandle, [NativeTypeName("DWORD")] uint Usage);
        [VtblIndex(129)]
        HResult CreateRenderTargetEx(uint Width, uint Height, D3Dformat Format, D3DmultisampleType MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] MaybeBool<int> Lockable, IDirect3DSurface9* ppSurface, Handle* pSharedHandle, [NativeTypeName("DWORD")] uint Usage);
        [VtblIndex(129)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateRenderTargetEx(uint Width, uint Height, D3Dformat Format, D3DmultisampleType MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] MaybeBool<int> Lockable, Ref<IDirect3DSurface9> ppSurface, Ref<Handle> pSharedHandle, [NativeTypeName("DWORD")] uint Usage);
        [VtblIndex(133)]
        HResult GetDisplayModeEx(uint iSwapChain, D3Ddisplaymodeex* pMode, D3Ddisplayrotation* pRotation);
        [VtblIndex(133)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetDisplayModeEx(uint iSwapChain, Ref<D3Ddisplaymodeex> pMode, Ref<D3Ddisplayrotation> pRotation);
        [VtblIndex(122)]
        HResult GetGPUThreadPriority(int* pPriority);
        [VtblIndex(122)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetGPUThreadPriority(Ref<int> pPriority);
        [VtblIndex(127)]
        HResult GetMaximumFrameLatency(uint* pMaxLatency);
        [VtblIndex(127)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetMaximumFrameLatency(Ref<uint> pMaxLatency);
        [VtblIndex(121)]
        HResult PresentEx([NativeTypeName("const RECT *")] RECT* pSourceRect, [NativeTypeName("const RECT *")] RECT* pDestRect, HWND hDestWindowOverride, [NativeTypeName("const RGNDATA *")] RGNDATA* pDirtyRegion, [NativeTypeName("DWORD")] uint dwFlags);
        [VtblIndex(121)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult PresentEx([NativeTypeName("const RECT *")] Ref<RECT> pSourceRect, [NativeTypeName("const RECT *")] Ref<RECT> pDestRect, HWND hDestWindowOverride, [NativeTypeName("const RGNDATA *")] Ref<RGNDATA> pDirtyRegion, [NativeTypeName("DWORD")] uint dwFlags);
        [VtblIndex(132)]
        HResult ResetEx(D3DpresentParameters* pPresentationParameters, D3Ddisplaymodeex* pFullscreenDisplayMode);
        [VtblIndex(132)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult ResetEx(Ref<D3DpresentParameters> pPresentationParameters, Ref<D3Ddisplaymodeex> pFullscreenDisplayMode);
        [VtblIndex(119)]
        HResult SetConvolutionMonoKernel(uint width, uint height, float* rows, float* columns);
        [VtblIndex(119)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult SetConvolutionMonoKernel(uint width, uint height, Ref<float> rows, Ref<float> columns);
        [VtblIndex(123)]
        HResult SetGPUThreadPriority(int Priority);
        [VtblIndex(126)]
        HResult SetMaximumFrameLatency(uint MaxLatency);
        [VtblIndex(124)]
        HResult WaitForVBlank(uint iSwapChain);
    }

    /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex"]/*'/>
    [Guid("B18B10CE-2649-405A-870F-95F777D4313A")]
    [NativeTypeName("struct IDirect3DDevice9Ex : IDirect3DDevice9")]
    [NativeInheritance("IDirect3DDevice9")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDirect3DDevice9Ex));

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
            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HResult> TestCooperativeLevel;
            [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> GetAvailableTextureMem;
            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HResult> EvictManagedResources;
            [NativeTypeName("HRESULT (IDirect3D9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IDirect3D9.Native**, HResult> GetDirect3D;
            [NativeTypeName("HRESULT (D3DCAPS9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3Dcaps9*, HResult> GetDeviceCaps;
            [NativeTypeName("HRESULT (UINT, D3DDISPLAYMODE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3Ddisplaymode*, HResult> GetDisplayMode;
            [NativeTypeName("HRESULT (D3DDEVICE_CREATION_PARAMETERS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3DdeviceCreationParameters*, HResult> GetCreationParameters;
            [NativeTypeName("HRESULT (UINT, UINT, IDirect3DSurface9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, IDirect3DSurface9.Native*, HResult> SetCursorProperties;
            [NativeTypeName("void (int, int, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, int, int, uint, void> SetCursorPosition;
            [NativeTypeName("BOOL (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, MaybeBool<int>, MaybeBool<int>> ShowCursor;
            [NativeTypeName("HRESULT (D3DPRESENT_PARAMETERS *, IDirect3DSwapChain9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3DpresentParameters*, IDirect3DSwapChain9.Native**, HResult> CreateAdditionalSwapChain;
            [NativeTypeName("HRESULT (UINT, IDirect3DSwapChain9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, IDirect3DSwapChain9.Native**, HResult> GetSwapChain;
            [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> GetNumberOfSwapChains;
            [NativeTypeName("HRESULT (D3DPRESENT_PARAMETERS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3DpresentParameters*, HResult> Reset;
            [NativeTypeName("HRESULT (const RECT *, const RECT *, HWND, const RGNDATA *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, RECT*, RECT*, HWND, RGNDATA*, HResult> Present;
            [NativeTypeName("HRESULT (UINT, UINT, D3DBACKBUFFER_TYPE, IDirect3DSurface9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, D3DbackbufferType, IDirect3DSurface9.Native**, HResult> GetBackBuffer;
            [NativeTypeName("HRESULT (UINT, D3DRASTER_STATUS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3DrasterStatus*, HResult> GetRasterStatus;
            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, MaybeBool<int>, HResult> SetDialogBoxMode;
            [NativeTypeName("void (UINT, DWORD, const D3DGAMMARAMP *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, D3Dgammaramp*, void> SetGammaRamp;
            [NativeTypeName("void (UINT, D3DGAMMARAMP *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3Dgammaramp*, void> GetGammaRamp;
            [NativeTypeName("HRESULT (UINT, UINT, UINT, DWORD, D3DFORMAT, D3DPOOL, IDirect3DTexture9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, uint, uint, D3Dformat, D3Dpool, IDirect3DTexture9.Native**, Handle*, HResult> CreateTexture;
            [NativeTypeName("HRESULT (UINT, UINT, UINT, UINT, DWORD, D3DFORMAT, D3DPOOL, IDirect3DVolumeTexture9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, uint, uint, uint, D3Dformat, D3Dpool, IDirect3DVolumeTexture9.Native**, Handle*, HResult> CreateVolumeTexture;
            [NativeTypeName("HRESULT (UINT, UINT, DWORD, D3DFORMAT, D3DPOOL, IDirect3DCubeTexture9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, uint, D3Dformat, D3Dpool, IDirect3DCubeTexture9.Native**, Handle*, HResult> CreateCubeTexture;
            [NativeTypeName("HRESULT (UINT, DWORD, DWORD, D3DPOOL, IDirect3DVertexBuffer9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, uint, D3Dpool, IDirect3DVertexBuffer9.Native**, Handle*, HResult> CreateVertexBuffer;
            [NativeTypeName("HRESULT (UINT, DWORD, D3DFORMAT, D3DPOOL, IDirect3DIndexBuffer9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, D3Dformat, D3Dpool, IDirect3DIndexBuffer9.Native**, Handle*, HResult> CreateIndexBuffer;
            [NativeTypeName("HRESULT (UINT, UINT, D3DFORMAT, D3DMULTISAMPLE_TYPE, DWORD, BOOL, IDirect3DSurface9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, D3Dformat, D3DmultisampleType, uint, MaybeBool<int>, IDirect3DSurface9.Native**, Handle*, HResult> CreateRenderTarget;
            [NativeTypeName("HRESULT (UINT, UINT, D3DFORMAT, D3DMULTISAMPLE_TYPE, DWORD, BOOL, IDirect3DSurface9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, D3Dformat, D3DmultisampleType, uint, MaybeBool<int>, IDirect3DSurface9.Native**, Handle*, HResult> CreateDepthStencilSurface;
            [NativeTypeName("HRESULT (IDirect3DSurface9 *, const RECT *, IDirect3DSurface9 *, const POINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IDirect3DSurface9.Native*, RECT*, IDirect3DSurface9.Native*, Point*, HResult> UpdateSurface;
            [NativeTypeName("HRESULT (IDirect3DBaseTexture9 *, IDirect3DBaseTexture9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IDirect3DBaseTexture9.Native*, IDirect3DBaseTexture9.Native*, HResult> UpdateTexture;
            [NativeTypeName("HRESULT (IDirect3DSurface9 *, IDirect3DSurface9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IDirect3DSurface9.Native*, IDirect3DSurface9.Native*, HResult> GetRenderTargetData;
            [NativeTypeName("HRESULT (UINT, IDirect3DSurface9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, IDirect3DSurface9.Native*, HResult> GetFrontBufferData;
            [NativeTypeName("HRESULT (IDirect3DSurface9 *, const RECT *, IDirect3DSurface9 *, const RECT *, D3DTEXTUREFILTERTYPE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IDirect3DSurface9.Native*, RECT*, IDirect3DSurface9.Native*, RECT*, D3Dtexturefiltertype, HResult> StretchRect;
            [NativeTypeName("HRESULT (IDirect3DSurface9 *, const RECT *, D3DCOLOR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IDirect3DSurface9.Native*, RECT*, uint, HResult> ColorFill;
            [NativeTypeName("HRESULT (UINT, UINT, D3DFORMAT, D3DPOOL, IDirect3DSurface9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, D3Dformat, D3Dpool, IDirect3DSurface9.Native**, Handle*, HResult> CreateOffscreenPlainSurface;
            [NativeTypeName("HRESULT (DWORD, IDirect3DSurface9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, IDirect3DSurface9.Native*, HResult> SetRenderTarget;
            [NativeTypeName("HRESULT (DWORD, IDirect3DSurface9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, IDirect3DSurface9.Native**, HResult> GetRenderTarget;
            [NativeTypeName("HRESULT (IDirect3DSurface9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IDirect3DSurface9.Native*, HResult> SetDepthStencilSurface;
            [NativeTypeName("HRESULT (IDirect3DSurface9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IDirect3DSurface9.Native**, HResult> GetDepthStencilSurface;
            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HResult> BeginScene;
            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HResult> EndScene;
            [NativeTypeName("HRESULT (DWORD, const D3DRECT *, DWORD, D3DCOLOR, float, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3Drect*, uint, uint, float, uint, HResult> Clear;
            [NativeTypeName("HRESULT (D3DTRANSFORMSTATETYPE, const D3DMATRIX *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3Dtransformstatetype, D2DMatrix4X4F*, HResult> SetTransform;
            [NativeTypeName("HRESULT (D3DTRANSFORMSTATETYPE, D3DMATRIX *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3Dtransformstatetype, D2DMatrix4X4F*, HResult> GetTransform;
            [NativeTypeName("HRESULT (D3DTRANSFORMSTATETYPE, const D3DMATRIX *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3Dtransformstatetype, D2DMatrix4X4F*, HResult> MultiplyTransform;
            [NativeTypeName("HRESULT (const D3DVIEWPORT9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3Dviewport9*, HResult> SetViewport;
            [NativeTypeName("HRESULT (D3DVIEWPORT9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3Dviewport9*, HResult> GetViewport;
            [NativeTypeName("HRESULT (const D3DMATERIAL9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3Dmaterial9*, HResult> SetMaterial;
            [NativeTypeName("HRESULT (D3DMATERIAL9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3Dmaterial9*, HResult> GetMaterial;
            [NativeTypeName("HRESULT (DWORD, const D3DLIGHT9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3Dlight9*, HResult> SetLight;
            [NativeTypeName("HRESULT (DWORD, D3DLIGHT9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3Dlight9*, HResult> GetLight;
            [NativeTypeName("HRESULT (DWORD, BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, MaybeBool<int>, HResult> LightEnable;
            [NativeTypeName("HRESULT (DWORD, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, MaybeBool<int>*, HResult> GetLightEnable;
            [NativeTypeName("HRESULT (DWORD, const float *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, float*, HResult> SetClipPlane;
            [NativeTypeName("HRESULT (DWORD, float *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, float*, HResult> GetClipPlane;
            [NativeTypeName("HRESULT (D3DRENDERSTATETYPE, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3Drenderstatetype, uint, HResult> SetRenderState;
            [NativeTypeName("HRESULT (D3DRENDERSTATETYPE, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3Drenderstatetype, uint*, HResult> GetRenderState;
            [NativeTypeName("HRESULT (D3DSTATEBLOCKTYPE, IDirect3DStateBlock9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3Dstateblocktype, IDirect3DStateBlock9.Native**, HResult> CreateStateBlock;
            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HResult> BeginStateBlock;
            [NativeTypeName("HRESULT (IDirect3DStateBlock9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IDirect3DStateBlock9.Native**, HResult> EndStateBlock;
            [NativeTypeName("HRESULT (const D3DCLIPSTATUS9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3Dclipstatus9*, HResult> SetClipStatus;
            [NativeTypeName("HRESULT (D3DCLIPSTATUS9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3Dclipstatus9*, HResult> GetClipStatus;
            [NativeTypeName("HRESULT (DWORD, IDirect3DBaseTexture9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, IDirect3DBaseTexture9.Native**, HResult> GetTexture;
            [NativeTypeName("HRESULT (DWORD, IDirect3DBaseTexture9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, IDirect3DBaseTexture9.Native*, HResult> SetTexture;
            [NativeTypeName("HRESULT (DWORD, D3DTEXTURESTAGESTATETYPE, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3Dtexturestagestatetype, uint*, HResult> GetTextureStageState;
            [NativeTypeName("HRESULT (DWORD, D3DTEXTURESTAGESTATETYPE, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3Dtexturestagestatetype, uint, HResult> SetTextureStageState;
            [NativeTypeName("HRESULT (DWORD, D3DSAMPLERSTATETYPE, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3Dsamplerstatetype, uint*, HResult> GetSamplerState;
            [NativeTypeName("HRESULT (DWORD, D3DSAMPLERSTATETYPE, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3Dsamplerstatetype, uint, HResult> SetSamplerState;
            [NativeTypeName("HRESULT (DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint*, HResult> ValidateDevice;
            [NativeTypeName("HRESULT (UINT, const PALETTEENTRY *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, PALETTEENTRY*, HResult> SetPaletteEntries;
            [NativeTypeName("HRESULT (UINT, PALETTEENTRY *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, PALETTEENTRY*, HResult> GetPaletteEntries;
            [NativeTypeName("HRESULT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, HResult> SetCurrentTexturePalette;
            [NativeTypeName("HRESULT (UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint*, HResult> GetCurrentTexturePalette;
            [NativeTypeName("HRESULT (const RECT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, RECT*, HResult> SetScissorRect;
            [NativeTypeName("HRESULT (RECT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, RECT*, HResult> GetScissorRect;
            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, MaybeBool<int>, HResult> SetSoftwareVertexProcessing;
            [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, MaybeBool<int>> GetSoftwareVertexProcessing;
            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, float, HResult> SetNPatchMode;
            [NativeTypeName("float () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, float> GetNPatchMode;
            [NativeTypeName("HRESULT (D3DPRIMITIVETYPE, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3Dprimitivetype, uint, uint, HResult> DrawPrimitive;
            [NativeTypeName("HRESULT (D3DPRIMITIVETYPE, INT, UINT, UINT, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3Dprimitivetype, int, uint, uint, uint, uint, HResult> DrawIndexedPrimitive;
            [NativeTypeName("HRESULT (D3DPRIMITIVETYPE, UINT, const void *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3Dprimitivetype, uint, void*, uint, HResult> DrawPrimitiveUP;
            [NativeTypeName("HRESULT (D3DPRIMITIVETYPE, UINT, UINT, UINT, const void *, D3DFORMAT, const void *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3Dprimitivetype, uint, uint, uint, void*, D3Dformat, void*, uint, HResult> DrawIndexedPrimitiveUP;
            [NativeTypeName("HRESULT (UINT, UINT, UINT, IDirect3DVertexBuffer9 *, IDirect3DVertexDeclaration9 *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, uint, IDirect3DVertexBuffer9.Native*, IDirect3DVertexDeclaration9.Native*, uint, HResult> ProcessVertices;
            [NativeTypeName("HRESULT (const D3DVERTEXELEMENT9 *, IDirect3DVertexDeclaration9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3Dvertexelement9*, IDirect3DVertexDeclaration9.Native**, HResult> CreateVertexDeclaration;
            [NativeTypeName("HRESULT (IDirect3DVertexDeclaration9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IDirect3DVertexDeclaration9.Native*, HResult> SetVertexDeclaration;
            [NativeTypeName("HRESULT (IDirect3DVertexDeclaration9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IDirect3DVertexDeclaration9.Native**, HResult> GetVertexDeclaration;
            [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, HResult> SetFVF;
            [NativeTypeName("HRESULT (DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint*, HResult> GetFVF;
            [NativeTypeName("HRESULT (const DWORD *, IDirect3DVertexShader9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint*, IDirect3DVertexShader9.Native**, HResult> CreateVertexShader;
            [NativeTypeName("HRESULT (IDirect3DVertexShader9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IDirect3DVertexShader9.Native*, HResult> SetVertexShader;
            [NativeTypeName("HRESULT (IDirect3DVertexShader9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IDirect3DVertexShader9.Native**, HResult> GetVertexShader;
            [NativeTypeName("HRESULT (UINT, const float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, float*, uint, HResult> SetVertexShaderConstantF;
            [NativeTypeName("HRESULT (UINT, float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, float*, uint, HResult> GetVertexShaderConstantF;
            [NativeTypeName("HRESULT (UINT, const int *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, int*, uint, HResult> SetVertexShaderConstantI;
            [NativeTypeName("HRESULT (UINT, int *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, int*, uint, HResult> GetVertexShaderConstantI;
            [NativeTypeName("HRESULT (UINT, const BOOL *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, MaybeBool<int>*, uint, HResult> SetVertexShaderConstantB;
            [NativeTypeName("HRESULT (UINT, BOOL *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, MaybeBool<int>*, uint, HResult> GetVertexShaderConstantB;
            [NativeTypeName("HRESULT (UINT, IDirect3DVertexBuffer9 *, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, IDirect3DVertexBuffer9.Native*, uint, uint, HResult> SetStreamSource;
            [NativeTypeName("HRESULT (UINT, IDirect3DVertexBuffer9 **, UINT *, UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, IDirect3DVertexBuffer9.Native**, uint*, uint*, HResult> GetStreamSource;
            [NativeTypeName("HRESULT (UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, HResult> SetStreamSourceFreq;
            [NativeTypeName("HRESULT (UINT, UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint*, HResult> GetStreamSourceFreq;
            [NativeTypeName("HRESULT (IDirect3DIndexBuffer9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IDirect3DIndexBuffer9.Native*, HResult> SetIndices;
            [NativeTypeName("HRESULT (IDirect3DIndexBuffer9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IDirect3DIndexBuffer9.Native**, HResult> GetIndices;
            [NativeTypeName("HRESULT (const DWORD *, IDirect3DPixelShader9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint*, IDirect3DPixelShader9.Native**, HResult> CreatePixelShader;
            [NativeTypeName("HRESULT (IDirect3DPixelShader9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IDirect3DPixelShader9.Native*, HResult> SetPixelShader;
            [NativeTypeName("HRESULT (IDirect3DPixelShader9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IDirect3DPixelShader9.Native**, HResult> GetPixelShader;
            [NativeTypeName("HRESULT (UINT, const float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, float*, uint, HResult> SetPixelShaderConstantF;
            [NativeTypeName("HRESULT (UINT, float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, float*, uint, HResult> GetPixelShaderConstantF;
            [NativeTypeName("HRESULT (UINT, const int *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, int*, uint, HResult> SetPixelShaderConstantI;
            [NativeTypeName("HRESULT (UINT, int *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, int*, uint, HResult> GetPixelShaderConstantI;
            [NativeTypeName("HRESULT (UINT, const BOOL *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, MaybeBool<int>*, uint, HResult> SetPixelShaderConstantB;
            [NativeTypeName("HRESULT (UINT, BOOL *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, MaybeBool<int>*, uint, HResult> GetPixelShaderConstantB;
            [NativeTypeName("HRESULT (UINT, const float *, const D3DRECTPATCH_INFO *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, float*, D3DrectpatchInfo*, HResult> DrawRectPatch;
            [NativeTypeName("HRESULT (UINT, const float *, const D3DTRIPATCH_INFO *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, float*, D3DtripatchInfo*, HResult> DrawTriPatch;
            [NativeTypeName("HRESULT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, HResult> DeletePatch;
            [NativeTypeName("HRESULT (D3DQUERYTYPE, IDirect3DQuery9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3Dquerytype, IDirect3DQuery9.Native**, HResult> CreateQuery;
            [NativeTypeName("HRESULT (UINT, UINT, float *, float *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, float*, float*, HResult> SetConvolutionMonoKernel;
            [NativeTypeName("HRESULT (IDirect3DSurface9 *, IDirect3DSurface9 *, IDirect3DVertexBuffer9 *, UINT, IDirect3DVertexBuffer9 *, D3DCOMPOSERECTSOP, int, int) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IDirect3DSurface9.Native*, IDirect3DSurface9.Native*, IDirect3DVertexBuffer9.Native*, uint, IDirect3DVertexBuffer9.Native*, D3Dcomposerectsop, int, int, HResult> ComposeRects;
            [NativeTypeName("HRESULT (const RECT *, const RECT *, HWND, const RGNDATA *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, RECT*, RECT*, HWND, RGNDATA*, uint, HResult> PresentEx;
            [NativeTypeName("HRESULT (INT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, int*, HResult> GetGPUThreadPriority;
            [NativeTypeName("HRESULT (INT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, int, HResult> SetGPUThreadPriority;
            [NativeTypeName("HRESULT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, HResult> WaitForVBlank;
            [NativeTypeName("HRESULT (IDirect3DResource9 **, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IDirect3DResource9.Native**, uint, HResult> CheckResourceResidency;
            [NativeTypeName("HRESULT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, HResult> SetMaximumFrameLatency;
            [NativeTypeName("HRESULT (UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint*, HResult> GetMaximumFrameLatency;
            [NativeTypeName("HRESULT (HWND) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HWND, HResult> CheckDeviceState;
            [NativeTypeName("HRESULT (UINT, UINT, D3DFORMAT, D3DMULTISAMPLE_TYPE, DWORD, BOOL, IDirect3DSurface9 **, HANDLE *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, D3Dformat, D3DmultisampleType, uint, MaybeBool<int>, IDirect3DSurface9.Native**, Handle*, uint, HResult> CreateRenderTargetEx;
            [NativeTypeName("HRESULT (UINT, UINT, D3DFORMAT, D3DPOOL, IDirect3DSurface9 **, HANDLE *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, D3Dformat, D3Dpool, IDirect3DSurface9.Native**, Handle*, uint, HResult> CreateOffscreenPlainSurfaceEx;
            [NativeTypeName("HRESULT (UINT, UINT, D3DFORMAT, D3DMULTISAMPLE_TYPE, DWORD, BOOL, IDirect3DSurface9 **, HANDLE *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, D3Dformat, D3DmultisampleType, uint, MaybeBool<int>, IDirect3DSurface9.Native**, Handle*, uint, HResult> CreateDepthStencilSurfaceEx;
            [NativeTypeName("HRESULT (D3DPRESENT_PARAMETERS *, D3DDISPLAYMODEEX *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3DpresentParameters*, D3Ddisplaymodeex*, HResult> ResetEx;
            [NativeTypeName("HRESULT (UINT, D3DDISPLAYMODEEX *, D3DDISPLAYROTATION *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3Ddisplaymodeex*, D3Ddisplayrotation*, HResult> GetDisplayModeEx;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint> )(lpVtbl[1]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IDirect3DDevice9.BeginScene"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HResult BeginScene()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, HResult> )(lpVtbl[41]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IDirect3DDevice9.BeginStateBlock"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        public HResult BeginStateBlock()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, HResult> )(lpVtbl[60]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.CheckDeviceState"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(128)]
        public HResult CheckDeviceState(HWND hDestinationWindow)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, HWND, HResult> )(lpVtbl[128]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), hDestinationWindow);
        }

        /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.CheckResourceResidency"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(125)]
        public HResult CheckResourceResidency(IDirect3DResource9* pResourceArray, [NativeTypeName("UINT32")] uint NumResources)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, IDirect3DResource9.Native**, uint, HResult> )(lpVtbl[125]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), &pResourceArray->LpVtbl, NumResources);
        }

        [VtblIndex(125)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CheckResourceResidency(Ref<IDirect3DResource9> pResourceArray, [NativeTypeName("UINT32")] uint NumResources)
        {
            fixed (IDirect3DResource9* __dsl_pResourceArray = pResourceArray)
            {
                return (HResult)CheckResourceResidency(__dsl_pResourceArray, NumResources);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.Clear"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HResult Clear([NativeTypeName("DWORD")] uint Count, [NativeTypeName("const D3DRECT *")] D3Drect* pRects, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("D3DCOLOR")] uint Color, float Z, [NativeTypeName("DWORD")] uint Stencil)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, D3Drect*, uint, uint, float, uint, HResult> )(lpVtbl[43]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), Count, pRects, Flags, Color, Z, Stencil);
        }

        [VtblIndex(43)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult Clear([NativeTypeName("DWORD")] uint Count, [NativeTypeName("const D3DRECT *")] Ref<D3Drect> pRects, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("D3DCOLOR")] uint Color, float Z, [NativeTypeName("DWORD")] uint Stencil)
        {
            fixed (D3Drect* __dsl_pRects = pRects)
            {
                return (HResult)Clear(Count, __dsl_pRects, Flags, Color, Z, Stencil);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.ColorFill"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HResult ColorFill(IDirect3DSurface9 pSurface, [NativeTypeName("const RECT *")] RECT* pRect, [NativeTypeName("D3DCOLOR")] uint color)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, IDirect3DSurface9.Native*, RECT*, uint, HResult> )(lpVtbl[35]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pSurface.LpVtbl, pRect, color);
        }

        [VtblIndex(35)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult ColorFill(IDirect3DSurface9 pSurface, [NativeTypeName("const RECT *")] Ref<RECT> pRect, [NativeTypeName("D3DCOLOR")] uint color)
        {
            fixed (RECT* __dsl_pRect = pRect)
            {
                return (HResult)ColorFill(pSurface, __dsl_pRect, color);
            }
        }

        /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.ComposeRects"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(120)]
        public HResult ComposeRects(IDirect3DSurface9 pSrc, IDirect3DSurface9 pDst, IDirect3DVertexBuffer9 pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9 pDstRectDescs, D3Dcomposerectsop Operation, int Xoffset, int Yoffset)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, IDirect3DSurface9.Native*, IDirect3DSurface9.Native*, IDirect3DVertexBuffer9.Native*, uint, IDirect3DVertexBuffer9.Native*, D3Dcomposerectsop, int, int, HResult> )(lpVtbl[120]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pSrc.LpVtbl, pDst.LpVtbl, pSrcRectDescs.LpVtbl, NumRects, pDstRectDescs.LpVtbl, Operation, Xoffset, Yoffset);
        }

        /// <inheritdoc cref = "IDirect3DDevice9.CreateAdditionalSwapChain"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HResult CreateAdditionalSwapChain(D3DpresentParameters* pPresentationParameters, IDirect3DSwapChain9* pSwapChain)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, D3DpresentParameters*, IDirect3DSwapChain9.Native**, HResult> )(lpVtbl[13]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pPresentationParameters, &pSwapChain->LpVtbl);
        }

        [VtblIndex(13)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateAdditionalSwapChain(Ref<D3DpresentParameters> pPresentationParameters, Ref<IDirect3DSwapChain9> pSwapChain)
        {
            fixed (IDirect3DSwapChain9* __dsl_pSwapChain = pSwapChain)
            fixed (D3DpresentParameters* __dsl_pPresentationParameters = pPresentationParameters)
            {
                return (HResult)CreateAdditionalSwapChain(__dsl_pPresentationParameters, __dsl_pSwapChain);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.CreateCubeTexture"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HResult CreateCubeTexture(uint EdgeLength, uint Levels, [NativeTypeName("DWORD")] uint Usage, D3Dformat Format, D3Dpool Pool, IDirect3DCubeTexture9* ppCubeTexture, Handle* pSharedHandle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, uint, uint, D3Dformat, D3Dpool, IDirect3DCubeTexture9.Native**, Handle*, HResult> )(lpVtbl[25]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), EdgeLength, Levels, Usage, Format, Pool, &ppCubeTexture->LpVtbl, pSharedHandle);
        }

        [VtblIndex(25)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateCubeTexture(uint EdgeLength, uint Levels, [NativeTypeName("DWORD")] uint Usage, D3Dformat Format, D3Dpool Pool, Ref<IDirect3DCubeTexture9> ppCubeTexture, Ref<Handle> pSharedHandle)
        {
            fixed (Handle* __dsl_pSharedHandle = pSharedHandle)
            fixed (IDirect3DCubeTexture9* __dsl_ppCubeTexture = ppCubeTexture)
            {
                return (HResult)CreateCubeTexture(EdgeLength, Levels, Usage, Format, Pool, __dsl_ppCubeTexture, __dsl_pSharedHandle);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.CreateDepthStencilSurface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HResult CreateDepthStencilSurface(uint Width, uint Height, D3Dformat Format, D3DmultisampleType MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] MaybeBool<int> Discard, IDirect3DSurface9* ppSurface, Handle* pSharedHandle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, uint, D3Dformat, D3DmultisampleType, uint, MaybeBool<int>, IDirect3DSurface9.Native**, Handle*, HResult> )(lpVtbl[29]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), Width, Height, Format, MultiSample, MultisampleQuality, Discard, &ppSurface->LpVtbl, pSharedHandle);
        }

        [VtblIndex(29)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateDepthStencilSurface(uint Width, uint Height, D3Dformat Format, D3DmultisampleType MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] MaybeBool<int> Discard, Ref<IDirect3DSurface9> ppSurface, Ref<Handle> pSharedHandle)
        {
            fixed (Handle* __dsl_pSharedHandle = pSharedHandle)
            fixed (IDirect3DSurface9* __dsl_ppSurface = ppSurface)
            {
                return (HResult)CreateDepthStencilSurface(Width, Height, Format, MultiSample, MultisampleQuality, Discard, __dsl_ppSurface, __dsl_pSharedHandle);
            }
        }

        /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.CreateDepthStencilSurfaceEx"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(131)]
        public HResult CreateDepthStencilSurfaceEx(uint Width, uint Height, D3Dformat Format, D3DmultisampleType MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] MaybeBool<int> Discard, IDirect3DSurface9* ppSurface, Handle* pSharedHandle, [NativeTypeName("DWORD")] uint Usage)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, uint, D3Dformat, D3DmultisampleType, uint, MaybeBool<int>, IDirect3DSurface9.Native**, Handle*, uint, HResult> )(lpVtbl[131]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), Width, Height, Format, MultiSample, MultisampleQuality, Discard, &ppSurface->LpVtbl, pSharedHandle, Usage);
        }

        [VtblIndex(131)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateDepthStencilSurfaceEx(uint Width, uint Height, D3Dformat Format, D3DmultisampleType MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] MaybeBool<int> Discard, Ref<IDirect3DSurface9> ppSurface, Ref<Handle> pSharedHandle, [NativeTypeName("DWORD")] uint Usage)
        {
            fixed (Handle* __dsl_pSharedHandle = pSharedHandle)
            fixed (IDirect3DSurface9* __dsl_ppSurface = ppSurface)
            {
                return (HResult)CreateDepthStencilSurfaceEx(Width, Height, Format, MultiSample, MultisampleQuality, Discard, __dsl_ppSurface, __dsl_pSharedHandle, Usage);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.CreateIndexBuffer"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HResult CreateIndexBuffer(uint Length, [NativeTypeName("DWORD")] uint Usage, D3Dformat Format, D3Dpool Pool, IDirect3DIndexBuffer9* ppIndexBuffer, Handle* pSharedHandle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, uint, D3Dformat, D3Dpool, IDirect3DIndexBuffer9.Native**, Handle*, HResult> )(lpVtbl[27]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), Length, Usage, Format, Pool, &ppIndexBuffer->LpVtbl, pSharedHandle);
        }

        [VtblIndex(27)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateIndexBuffer(uint Length, [NativeTypeName("DWORD")] uint Usage, D3Dformat Format, D3Dpool Pool, Ref<IDirect3DIndexBuffer9> ppIndexBuffer, Ref<Handle> pSharedHandle)
        {
            fixed (Handle* __dsl_pSharedHandle = pSharedHandle)
            fixed (IDirect3DIndexBuffer9* __dsl_ppIndexBuffer = ppIndexBuffer)
            {
                return (HResult)CreateIndexBuffer(Length, Usage, Format, Pool, __dsl_ppIndexBuffer, __dsl_pSharedHandle);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.CreateOffscreenPlainSurface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HResult CreateOffscreenPlainSurface(uint Width, uint Height, D3Dformat Format, D3Dpool Pool, IDirect3DSurface9* ppSurface, Handle* pSharedHandle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, uint, D3Dformat, D3Dpool, IDirect3DSurface9.Native**, Handle*, HResult> )(lpVtbl[36]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), Width, Height, Format, Pool, &ppSurface->LpVtbl, pSharedHandle);
        }

        [VtblIndex(36)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateOffscreenPlainSurface(uint Width, uint Height, D3Dformat Format, D3Dpool Pool, Ref<IDirect3DSurface9> ppSurface, Ref<Handle> pSharedHandle)
        {
            fixed (Handle* __dsl_pSharedHandle = pSharedHandle)
            fixed (IDirect3DSurface9* __dsl_ppSurface = ppSurface)
            {
                return (HResult)CreateOffscreenPlainSurface(Width, Height, Format, Pool, __dsl_ppSurface, __dsl_pSharedHandle);
            }
        }

        /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.CreateOffscreenPlainSurfaceEx"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(130)]
        public HResult CreateOffscreenPlainSurfaceEx(uint Width, uint Height, D3Dformat Format, D3Dpool Pool, IDirect3DSurface9* ppSurface, Handle* pSharedHandle, [NativeTypeName("DWORD")] uint Usage)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, uint, D3Dformat, D3Dpool, IDirect3DSurface9.Native**, Handle*, uint, HResult> )(lpVtbl[130]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), Width, Height, Format, Pool, &ppSurface->LpVtbl, pSharedHandle, Usage);
        }

        [VtblIndex(130)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateOffscreenPlainSurfaceEx(uint Width, uint Height, D3Dformat Format, D3Dpool Pool, Ref<IDirect3DSurface9> ppSurface, Ref<Handle> pSharedHandle, [NativeTypeName("DWORD")] uint Usage)
        {
            fixed (Handle* __dsl_pSharedHandle = pSharedHandle)
            fixed (IDirect3DSurface9* __dsl_ppSurface = ppSurface)
            {
                return (HResult)CreateOffscreenPlainSurfaceEx(Width, Height, Format, Pool, __dsl_ppSurface, __dsl_pSharedHandle, Usage);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.CreatePixelShader"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(106)]
        public HResult CreatePixelShader([NativeTypeName("const DWORD *")] uint* pFunction, IDirect3DPixelShader9* ppShader)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint*, IDirect3DPixelShader9.Native**, HResult> )(lpVtbl[106]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pFunction, &ppShader->LpVtbl);
        }

        [VtblIndex(106)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreatePixelShader([NativeTypeName("const DWORD *")] Ref<uint> pFunction, Ref<IDirect3DPixelShader9> ppShader)
        {
            fixed (IDirect3DPixelShader9* __dsl_ppShader = ppShader)
            fixed (uint* __dsl_pFunction = pFunction)
            {
                return (HResult)CreatePixelShader(__dsl_pFunction, __dsl_ppShader);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.CreateQuery"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(118)]
        public HResult CreateQuery(D3Dquerytype Type, IDirect3DQuery9* ppQuery)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, D3Dquerytype, IDirect3DQuery9.Native**, HResult> )(lpVtbl[118]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), Type, &ppQuery->LpVtbl);
        }

        [VtblIndex(118)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateQuery(D3Dquerytype Type, Ref<IDirect3DQuery9> ppQuery)
        {
            fixed (IDirect3DQuery9* __dsl_ppQuery = ppQuery)
            {
                return (HResult)CreateQuery(Type, __dsl_ppQuery);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.CreateRenderTarget"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HResult CreateRenderTarget(uint Width, uint Height, D3Dformat Format, D3DmultisampleType MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] MaybeBool<int> Lockable, IDirect3DSurface9* ppSurface, Handle* pSharedHandle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, uint, D3Dformat, D3DmultisampleType, uint, MaybeBool<int>, IDirect3DSurface9.Native**, Handle*, HResult> )(lpVtbl[28]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), Width, Height, Format, MultiSample, MultisampleQuality, Lockable, &ppSurface->LpVtbl, pSharedHandle);
        }

        [VtblIndex(28)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateRenderTarget(uint Width, uint Height, D3Dformat Format, D3DmultisampleType MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] MaybeBool<int> Lockable, Ref<IDirect3DSurface9> ppSurface, Ref<Handle> pSharedHandle)
        {
            fixed (Handle* __dsl_pSharedHandle = pSharedHandle)
            fixed (IDirect3DSurface9* __dsl_ppSurface = ppSurface)
            {
                return (HResult)CreateRenderTarget(Width, Height, Format, MultiSample, MultisampleQuality, Lockable, __dsl_ppSurface, __dsl_pSharedHandle);
            }
        }

        /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.CreateRenderTargetEx"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(129)]
        public HResult CreateRenderTargetEx(uint Width, uint Height, D3Dformat Format, D3DmultisampleType MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] MaybeBool<int> Lockable, IDirect3DSurface9* ppSurface, Handle* pSharedHandle, [NativeTypeName("DWORD")] uint Usage)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, uint, D3Dformat, D3DmultisampleType, uint, MaybeBool<int>, IDirect3DSurface9.Native**, Handle*, uint, HResult> )(lpVtbl[129]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), Width, Height, Format, MultiSample, MultisampleQuality, Lockable, &ppSurface->LpVtbl, pSharedHandle, Usage);
        }

        [VtblIndex(129)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateRenderTargetEx(uint Width, uint Height, D3Dformat Format, D3DmultisampleType MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] MaybeBool<int> Lockable, Ref<IDirect3DSurface9> ppSurface, Ref<Handle> pSharedHandle, [NativeTypeName("DWORD")] uint Usage)
        {
            fixed (Handle* __dsl_pSharedHandle = pSharedHandle)
            fixed (IDirect3DSurface9* __dsl_ppSurface = ppSurface)
            {
                return (HResult)CreateRenderTargetEx(Width, Height, Format, MultiSample, MultisampleQuality, Lockable, __dsl_ppSurface, __dsl_pSharedHandle, Usage);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.CreateStateBlock"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        public HResult CreateStateBlock(D3Dstateblocktype Type, IDirect3DStateBlock9* ppSB)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, D3Dstateblocktype, IDirect3DStateBlock9.Native**, HResult> )(lpVtbl[59]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), Type, &ppSB->LpVtbl);
        }

        [VtblIndex(59)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateStateBlock(D3Dstateblocktype Type, Ref<IDirect3DStateBlock9> ppSB)
        {
            fixed (IDirect3DStateBlock9* __dsl_ppSB = ppSB)
            {
                return (HResult)CreateStateBlock(Type, __dsl_ppSB);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.CreateTexture"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HResult CreateTexture(uint Width, uint Height, uint Levels, [NativeTypeName("DWORD")] uint Usage, D3Dformat Format, D3Dpool Pool, IDirect3DTexture9* ppTexture, Handle* pSharedHandle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, uint, uint, uint, D3Dformat, D3Dpool, IDirect3DTexture9.Native**, Handle*, HResult> )(lpVtbl[23]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), Width, Height, Levels, Usage, Format, Pool, &ppTexture->LpVtbl, pSharedHandle);
        }

        [VtblIndex(23)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateTexture(uint Width, uint Height, uint Levels, [NativeTypeName("DWORD")] uint Usage, D3Dformat Format, D3Dpool Pool, Ref<IDirect3DTexture9> ppTexture, Ref<Handle> pSharedHandle)
        {
            fixed (Handle* __dsl_pSharedHandle = pSharedHandle)
            fixed (IDirect3DTexture9* __dsl_ppTexture = ppTexture)
            {
                return (HResult)CreateTexture(Width, Height, Levels, Usage, Format, Pool, __dsl_ppTexture, __dsl_pSharedHandle);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.CreateVertexBuffer"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HResult CreateVertexBuffer(uint Length, [NativeTypeName("DWORD")] uint Usage, [NativeTypeName("DWORD")] uint FVF, D3Dpool Pool, IDirect3DVertexBuffer9* ppVertexBuffer, Handle* pSharedHandle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, uint, uint, D3Dpool, IDirect3DVertexBuffer9.Native**, Handle*, HResult> )(lpVtbl[26]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), Length, Usage, FVF, Pool, &ppVertexBuffer->LpVtbl, pSharedHandle);
        }

        [VtblIndex(26)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVertexBuffer(uint Length, [NativeTypeName("DWORD")] uint Usage, [NativeTypeName("DWORD")] uint FVF, D3Dpool Pool, Ref<IDirect3DVertexBuffer9> ppVertexBuffer, Ref<Handle> pSharedHandle)
        {
            fixed (Handle* __dsl_pSharedHandle = pSharedHandle)
            fixed (IDirect3DVertexBuffer9* __dsl_ppVertexBuffer = ppVertexBuffer)
            {
                return (HResult)CreateVertexBuffer(Length, Usage, FVF, Pool, __dsl_ppVertexBuffer, __dsl_pSharedHandle);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.CreateVertexDeclaration"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(86)]
        public HResult CreateVertexDeclaration([NativeTypeName("const D3DVERTEXELEMENT9 *")] D3Dvertexelement9* pVertexElements, IDirect3DVertexDeclaration9* ppDecl)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, D3Dvertexelement9*, IDirect3DVertexDeclaration9.Native**, HResult> )(lpVtbl[86]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pVertexElements, &ppDecl->LpVtbl);
        }

        [VtblIndex(86)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVertexDeclaration([NativeTypeName("const D3DVERTEXELEMENT9 *")] Ref<D3Dvertexelement9> pVertexElements, Ref<IDirect3DVertexDeclaration9> ppDecl)
        {
            fixed (IDirect3DVertexDeclaration9* __dsl_ppDecl = ppDecl)
            fixed (D3Dvertexelement9* __dsl_pVertexElements = pVertexElements)
            {
                return (HResult)CreateVertexDeclaration(__dsl_pVertexElements, __dsl_ppDecl);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.CreateVertexShader"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(91)]
        public HResult CreateVertexShader([NativeTypeName("const DWORD *")] uint* pFunction, IDirect3DVertexShader9* ppShader)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint*, IDirect3DVertexShader9.Native**, HResult> )(lpVtbl[91]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pFunction, &ppShader->LpVtbl);
        }

        [VtblIndex(91)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVertexShader([NativeTypeName("const DWORD *")] Ref<uint> pFunction, Ref<IDirect3DVertexShader9> ppShader)
        {
            fixed (IDirect3DVertexShader9* __dsl_ppShader = ppShader)
            fixed (uint* __dsl_pFunction = pFunction)
            {
                return (HResult)CreateVertexShader(__dsl_pFunction, __dsl_ppShader);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.CreateVolumeTexture"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HResult CreateVolumeTexture(uint Width, uint Height, uint Depth, uint Levels, [NativeTypeName("DWORD")] uint Usage, D3Dformat Format, D3Dpool Pool, IDirect3DVolumeTexture9* ppVolumeTexture, Handle* pSharedHandle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, uint, uint, uint, uint, D3Dformat, D3Dpool, IDirect3DVolumeTexture9.Native**, Handle*, HResult> )(lpVtbl[24]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), Width, Height, Depth, Levels, Usage, Format, Pool, &ppVolumeTexture->LpVtbl, pSharedHandle);
        }

        [VtblIndex(24)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVolumeTexture(uint Width, uint Height, uint Depth, uint Levels, [NativeTypeName("DWORD")] uint Usage, D3Dformat Format, D3Dpool Pool, Ref<IDirect3DVolumeTexture9> ppVolumeTexture, Ref<Handle> pSharedHandle)
        {
            fixed (Handle* __dsl_pSharedHandle = pSharedHandle)
            fixed (IDirect3DVolumeTexture9* __dsl_ppVolumeTexture = ppVolumeTexture)
            {
                return (HResult)CreateVolumeTexture(Width, Height, Depth, Levels, Usage, Format, Pool, __dsl_ppVolumeTexture, __dsl_pSharedHandle);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.DeletePatch"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(117)]
        public HResult DeletePatch(uint Handle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, HResult> )(lpVtbl[117]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), Handle);
        }

        /// <inheritdoc cref = "IDirect3DDevice9.DrawIndexedPrimitive"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        public HResult DrawIndexedPrimitive(D3Dprimitivetype param0, int BaseVertexIndex, uint MinVertexIndex, uint NumVertices, uint startIndex, uint primCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, D3Dprimitivetype, int, uint, uint, uint, uint, HResult> )(lpVtbl[82]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), param0, BaseVertexIndex, MinVertexIndex, NumVertices, startIndex, primCount);
        }

        /// <inheritdoc cref = "IDirect3DDevice9.DrawIndexedPrimitiveUP"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        public HResult DrawIndexedPrimitiveUP(D3Dprimitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, [NativeTypeName("const void *")] void* pIndexData, D3Dformat IndexDataFormat, [NativeTypeName("const void *")] void* pVertexStreamZeroData, uint VertexStreamZeroStride)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, D3Dprimitivetype, uint, uint, uint, void*, D3Dformat, void*, uint, HResult> )(lpVtbl[84]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexData, IndexDataFormat, pVertexStreamZeroData, VertexStreamZeroStride);
        }

        [VtblIndex(84)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult DrawIndexedPrimitiveUP(D3Dprimitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, [NativeTypeName("const void *")] Ref pIndexData, D3Dformat IndexDataFormat, [NativeTypeName("const void *")] Ref pVertexStreamZeroData, uint VertexStreamZeroStride)
        {
            fixed (void* __dsl_pVertexStreamZeroData = pVertexStreamZeroData)
            fixed (void* __dsl_pIndexData = pIndexData)
            {
                return (HResult)DrawIndexedPrimitiveUP(PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, __dsl_pIndexData, IndexDataFormat, __dsl_pVertexStreamZeroData, VertexStreamZeroStride);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.DrawPrimitive"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        public HResult DrawPrimitive(D3Dprimitivetype PrimitiveType, uint StartVertex, uint PrimitiveCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, D3Dprimitivetype, uint, uint, HResult> )(lpVtbl[81]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), PrimitiveType, StartVertex, PrimitiveCount);
        }

        /// <inheritdoc cref = "IDirect3DDevice9.DrawPrimitiveUP"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        public HResult DrawPrimitiveUP(D3Dprimitivetype PrimitiveType, uint PrimitiveCount, [NativeTypeName("const void *")] void* pVertexStreamZeroData, uint VertexStreamZeroStride)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, D3Dprimitivetype, uint, void*, uint, HResult> )(lpVtbl[83]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), PrimitiveType, PrimitiveCount, pVertexStreamZeroData, VertexStreamZeroStride);
        }

        [VtblIndex(83)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult DrawPrimitiveUP(D3Dprimitivetype PrimitiveType, uint PrimitiveCount, [NativeTypeName("const void *")] Ref pVertexStreamZeroData, uint VertexStreamZeroStride)
        {
            fixed (void* __dsl_pVertexStreamZeroData = pVertexStreamZeroData)
            {
                return (HResult)DrawPrimitiveUP(PrimitiveType, PrimitiveCount, __dsl_pVertexStreamZeroData, VertexStreamZeroStride);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.DrawRectPatch"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(115)]
        public HResult DrawRectPatch(uint Handle, [NativeTypeName("const float *")] float* pNumSegs, [NativeTypeName("const D3DRECTPATCH_INFO *")] D3DrectpatchInfo* pRectPatchInfo)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, float*, D3DrectpatchInfo*, HResult> )(lpVtbl[115]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), Handle, pNumSegs, pRectPatchInfo);
        }

        [VtblIndex(115)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult DrawRectPatch(uint Handle, [NativeTypeName("const float *")] Ref<float> pNumSegs, [NativeTypeName("const D3DRECTPATCH_INFO *")] Ref<D3DrectpatchInfo> pRectPatchInfo)
        {
            fixed (D3DrectpatchInfo* __dsl_pRectPatchInfo = pRectPatchInfo)
            fixed (float* __dsl_pNumSegs = pNumSegs)
            {
                return (HResult)DrawRectPatch(Handle, __dsl_pNumSegs, __dsl_pRectPatchInfo);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.DrawTriPatch"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(116)]
        public HResult DrawTriPatch(uint Handle, [NativeTypeName("const float *")] float* pNumSegs, [NativeTypeName("const D3DTRIPATCH_INFO *")] D3DtripatchInfo* pTriPatchInfo)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, float*, D3DtripatchInfo*, HResult> )(lpVtbl[116]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), Handle, pNumSegs, pTriPatchInfo);
        }

        [VtblIndex(116)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult DrawTriPatch(uint Handle, [NativeTypeName("const float *")] Ref<float> pNumSegs, [NativeTypeName("const D3DTRIPATCH_INFO *")] Ref<D3DtripatchInfo> pTriPatchInfo)
        {
            fixed (D3DtripatchInfo* __dsl_pTriPatchInfo = pTriPatchInfo)
            fixed (float* __dsl_pNumSegs = pNumSegs)
            {
                return (HResult)DrawTriPatch(Handle, __dsl_pNumSegs, __dsl_pTriPatchInfo);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.EndScene"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HResult EndScene()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, HResult> )(lpVtbl[42]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IDirect3DDevice9.EndStateBlock"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        public HResult EndStateBlock(IDirect3DStateBlock9* ppSB)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, IDirect3DStateBlock9.Native**, HResult> )(lpVtbl[61]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), &ppSB->LpVtbl);
        }

        [VtblIndex(61)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult EndStateBlock(Ref<IDirect3DStateBlock9> ppSB)
        {
            fixed (IDirect3DStateBlock9* __dsl_ppSB = ppSB)
            {
                return (HResult)EndStateBlock(__dsl_ppSB);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.EvictManagedResources"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult EvictManagedResources()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, HResult> )(lpVtbl[5]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetAvailableTextureMem"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public uint GetAvailableTextureMem()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint> )(lpVtbl[4]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetBackBuffer"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HResult GetBackBuffer(uint iSwapChain, uint iBackBuffer, D3DbackbufferType Type, IDirect3DSurface9* ppBackBuffer)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, uint, D3DbackbufferType, IDirect3DSurface9.Native**, HResult> )(lpVtbl[18]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), iSwapChain, iBackBuffer, Type, &ppBackBuffer->LpVtbl);
        }

        [VtblIndex(18)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetBackBuffer(uint iSwapChain, uint iBackBuffer, D3DbackbufferType Type, Ref<IDirect3DSurface9> ppBackBuffer)
        {
            fixed (IDirect3DSurface9* __dsl_ppBackBuffer = ppBackBuffer)
            {
                return (HResult)GetBackBuffer(iSwapChain, iBackBuffer, Type, __dsl_ppBackBuffer);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetClipPlane"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        public HResult GetClipPlane([NativeTypeName("DWORD")] uint Index, float* pPlane)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, float*, HResult> )(lpVtbl[56]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), Index, pPlane);
        }

        [VtblIndex(56)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetClipPlane([NativeTypeName("DWORD")] uint Index, Ref<float> pPlane)
        {
            fixed (float* __dsl_pPlane = pPlane)
            {
                return (HResult)GetClipPlane(Index, __dsl_pPlane);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetClipStatus"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        public HResult GetClipStatus(D3Dclipstatus9* pClipStatus)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, D3Dclipstatus9*, HResult> )(lpVtbl[63]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pClipStatus);
        }

        [VtblIndex(63)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetClipStatus(Ref<D3Dclipstatus9> pClipStatus)
        {
            fixed (D3Dclipstatus9* __dsl_pClipStatus = pClipStatus)
            {
                return (HResult)GetClipStatus(__dsl_pClipStatus);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetCreationParameters"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult GetCreationParameters(D3DdeviceCreationParameters* pParameters)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, D3DdeviceCreationParameters*, HResult> )(lpVtbl[9]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pParameters);
        }

        [VtblIndex(9)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetCreationParameters(Ref<D3DdeviceCreationParameters> pParameters)
        {
            fixed (D3DdeviceCreationParameters* __dsl_pParameters = pParameters)
            {
                return (HResult)GetCreationParameters(__dsl_pParameters);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetCurrentTexturePalette"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        public HResult GetCurrentTexturePalette(uint* PaletteNumber)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint*, HResult> )(lpVtbl[74]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), PaletteNumber);
        }

        [VtblIndex(74)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetCurrentTexturePalette(Ref<uint> PaletteNumber)
        {
            fixed (uint* __dsl_PaletteNumber = PaletteNumber)
            {
                return (HResult)GetCurrentTexturePalette(__dsl_PaletteNumber);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetDepthStencilSurface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HResult GetDepthStencilSurface(IDirect3DSurface9* ppZStencilSurface)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, IDirect3DSurface9.Native**, HResult> )(lpVtbl[40]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), &ppZStencilSurface->LpVtbl);
        }

        [VtblIndex(40)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetDepthStencilSurface(Ref<IDirect3DSurface9> ppZStencilSurface)
        {
            fixed (IDirect3DSurface9* __dsl_ppZStencilSurface = ppZStencilSurface)
            {
                return (HResult)GetDepthStencilSurface(__dsl_ppZStencilSurface);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetDeviceCaps"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult GetDeviceCaps(D3Dcaps9* pCaps)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, D3Dcaps9*, HResult> )(lpVtbl[7]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pCaps);
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetDeviceCaps(Ref<D3Dcaps9> pCaps)
        {
            fixed (D3Dcaps9* __dsl_pCaps = pCaps)
            {
                return (HResult)GetDeviceCaps(__dsl_pCaps);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetDirect3D"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult GetDirect3D(IDirect3D9* ppD3D9)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, IDirect3D9.Native**, HResult> )(lpVtbl[6]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), &ppD3D9->LpVtbl);
        }

        [VtblIndex(6)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetDirect3D(Ref<IDirect3D9> ppD3D9)
        {
            fixed (IDirect3D9* __dsl_ppD3D9 = ppD3D9)
            {
                return (HResult)GetDirect3D(__dsl_ppD3D9);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetDisplayMode"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HResult GetDisplayMode(uint iSwapChain, D3Ddisplaymode* pMode)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, D3Ddisplaymode*, HResult> )(lpVtbl[8]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), iSwapChain, pMode);
        }

        [VtblIndex(8)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetDisplayMode(uint iSwapChain, Ref<D3Ddisplaymode> pMode)
        {
            fixed (D3Ddisplaymode* __dsl_pMode = pMode)
            {
                return (HResult)GetDisplayMode(iSwapChain, __dsl_pMode);
            }
        }

        /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.GetDisplayModeEx"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(133)]
        public HResult GetDisplayModeEx(uint iSwapChain, D3Ddisplaymodeex* pMode, D3Ddisplayrotation* pRotation)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, D3Ddisplaymodeex*, D3Ddisplayrotation*, HResult> )(lpVtbl[133]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), iSwapChain, pMode, pRotation);
        }

        [VtblIndex(133)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetDisplayModeEx(uint iSwapChain, Ref<D3Ddisplaymodeex> pMode, Ref<D3Ddisplayrotation> pRotation)
        {
            fixed (D3Ddisplayrotation* __dsl_pRotation = pRotation)
            fixed (D3Ddisplaymodeex* __dsl_pMode = pMode)
            {
                return (HResult)GetDisplayModeEx(iSwapChain, __dsl_pMode, __dsl_pRotation);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetFrontBufferData"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HResult GetFrontBufferData(uint iSwapChain, IDirect3DSurface9 pDestSurface)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, IDirect3DSurface9.Native*, HResult> )(lpVtbl[33]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), iSwapChain, pDestSurface.LpVtbl);
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetFVF"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(90)]
        public HResult GetFVF([NativeTypeName("DWORD *")] uint* pFVF)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint*, HResult> )(lpVtbl[90]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pFVF);
        }

        [VtblIndex(90)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetFVF([NativeTypeName("DWORD *")] Ref<uint> pFVF)
        {
            fixed (uint* __dsl_pFVF = pFVF)
            {
                return (HResult)GetFVF(__dsl_pFVF);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetGammaRamp"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public void GetGammaRamp(uint iSwapChain, D3Dgammaramp* pRamp)
        {
            ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, D3Dgammaramp*, void> )(lpVtbl[22]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), iSwapChain, pRamp);
        }

        [VtblIndex(22)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void GetGammaRamp(uint iSwapChain, Ref<D3Dgammaramp> pRamp)
        {
            fixed (D3Dgammaramp* __dsl_pRamp = pRamp)
            {
                GetGammaRamp(iSwapChain, __dsl_pRamp);
            }
        }

        /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.GetGPUThreadPriority"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(122)]
        public HResult GetGPUThreadPriority(int* pPriority)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, int*, HResult> )(lpVtbl[122]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pPriority);
        }

        [VtblIndex(122)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetGPUThreadPriority(Ref<int> pPriority)
        {
            fixed (int* __dsl_pPriority = pPriority)
            {
                return (HResult)GetGPUThreadPriority(__dsl_pPriority);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetIndices"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(105)]
        public HResult GetIndices(IDirect3DIndexBuffer9* ppIndexData)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, IDirect3DIndexBuffer9.Native**, HResult> )(lpVtbl[105]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), &ppIndexData->LpVtbl);
        }

        [VtblIndex(105)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetIndices(Ref<IDirect3DIndexBuffer9> ppIndexData)
        {
            fixed (IDirect3DIndexBuffer9* __dsl_ppIndexData = ppIndexData)
            {
                return (HResult)GetIndices(__dsl_ppIndexData);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetLight"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public HResult GetLight([NativeTypeName("DWORD")] uint Index, D3Dlight9* param1)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, D3Dlight9*, HResult> )(lpVtbl[52]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), Index, param1);
        }

        [VtblIndex(52)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetLight([NativeTypeName("DWORD")] uint Index, Ref<D3Dlight9> param1)
        {
            fixed (D3Dlight9* __dsl_param1 = param1)
            {
                return (HResult)GetLight(Index, __dsl_param1);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetLightEnable"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public HResult GetLightEnable([NativeTypeName("DWORD")] uint Index, [NativeTypeName("BOOL *")] MaybeBool<int>* pEnable)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, MaybeBool<int>*, HResult> )(lpVtbl[54]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), Index, pEnable);
        }

        [VtblIndex(54)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetLightEnable([NativeTypeName("DWORD")] uint Index, [NativeTypeName("BOOL *")] Ref<MaybeBool<int>> pEnable)
        {
            fixed (MaybeBool<int>* __dsl_pEnable = pEnable)
            {
                return (HResult)GetLightEnable(Index, __dsl_pEnable);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetMaterial"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public HResult GetMaterial(D3Dmaterial9* pMaterial)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, D3Dmaterial9*, HResult> )(lpVtbl[50]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pMaterial);
        }

        [VtblIndex(50)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetMaterial(Ref<D3Dmaterial9> pMaterial)
        {
            fixed (D3Dmaterial9* __dsl_pMaterial = pMaterial)
            {
                return (HResult)GetMaterial(__dsl_pMaterial);
            }
        }

        /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.GetMaximumFrameLatency"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(127)]
        public HResult GetMaximumFrameLatency(uint* pMaxLatency)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint*, HResult> )(lpVtbl[127]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pMaxLatency);
        }

        [VtblIndex(127)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetMaximumFrameLatency(Ref<uint> pMaxLatency)
        {
            fixed (uint* __dsl_pMaxLatency = pMaxLatency)
            {
                return (HResult)GetMaximumFrameLatency(__dsl_pMaxLatency);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetNPatchMode"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        public float GetNPatchMode()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, float> )(lpVtbl[80]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetNumberOfSwapChains"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public uint GetNumberOfSwapChains()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint> )(lpVtbl[15]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetPaletteEntries"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        public HResult GetPaletteEntries(uint PaletteNumber, PALETTEENTRY* pEntries)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, PALETTEENTRY*, HResult> )(lpVtbl[72]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), PaletteNumber, pEntries);
        }

        [VtblIndex(72)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetPaletteEntries(uint PaletteNumber, Ref<PALETTEENTRY> pEntries)
        {
            fixed (PALETTEENTRY* __dsl_pEntries = pEntries)
            {
                return (HResult)GetPaletteEntries(PaletteNumber, __dsl_pEntries);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetPixelShader"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(108)]
        public HResult GetPixelShader(IDirect3DPixelShader9* ppShader)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, IDirect3DPixelShader9.Native**, HResult> )(lpVtbl[108]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), &ppShader->LpVtbl);
        }

        [VtblIndex(108)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetPixelShader(Ref<IDirect3DPixelShader9> ppShader)
        {
            fixed (IDirect3DPixelShader9* __dsl_ppShader = ppShader)
            {
                return (HResult)GetPixelShader(__dsl_ppShader);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetPixelShaderConstantB"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(114)]
        public HResult GetPixelShaderConstantB(uint StartRegister, [NativeTypeName("BOOL *")] MaybeBool<int>* pConstantData, uint BoolCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, MaybeBool<int>*, uint, HResult> )(lpVtbl[114]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, BoolCount);
        }

        [VtblIndex(114)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetPixelShaderConstantB(uint StartRegister, [NativeTypeName("BOOL *")] Ref<MaybeBool<int>> pConstantData, uint BoolCount)
        {
            fixed (MaybeBool<int>* __dsl_pConstantData = pConstantData)
            {
                return (HResult)GetPixelShaderConstantB(StartRegister, __dsl_pConstantData, BoolCount);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetPixelShaderConstantF"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(110)]
        public HResult GetPixelShaderConstantF(uint StartRegister, float* pConstantData, uint Vector4fCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, float*, uint, HResult> )(lpVtbl[110]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4fCount);
        }

        [VtblIndex(110)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetPixelShaderConstantF(uint StartRegister, Ref<float> pConstantData, uint Vector4fCount)
        {
            fixed (float* __dsl_pConstantData = pConstantData)
            {
                return (HResult)GetPixelShaderConstantF(StartRegister, __dsl_pConstantData, Vector4fCount);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetPixelShaderConstantI"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(112)]
        public HResult GetPixelShaderConstantI(uint StartRegister, int* pConstantData, uint Vector4iCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, int*, uint, HResult> )(lpVtbl[112]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4iCount);
        }

        [VtblIndex(112)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetPixelShaderConstantI(uint StartRegister, Ref<int> pConstantData, uint Vector4iCount)
        {
            fixed (int* __dsl_pConstantData = pConstantData)
            {
                return (HResult)GetPixelShaderConstantI(StartRegister, __dsl_pConstantData, Vector4iCount);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetRasterStatus"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HResult GetRasterStatus(uint iSwapChain, D3DrasterStatus* pRasterStatus)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, D3DrasterStatus*, HResult> )(lpVtbl[19]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), iSwapChain, pRasterStatus);
        }

        [VtblIndex(19)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetRasterStatus(uint iSwapChain, Ref<D3DrasterStatus> pRasterStatus)
        {
            fixed (D3DrasterStatus* __dsl_pRasterStatus = pRasterStatus)
            {
                return (HResult)GetRasterStatus(iSwapChain, __dsl_pRasterStatus);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetRenderState"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        public HResult GetRenderState(D3Drenderstatetype State, [NativeTypeName("DWORD *")] uint* pValue)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, D3Drenderstatetype, uint*, HResult> )(lpVtbl[58]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), State, pValue);
        }

        [VtblIndex(58)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetRenderState(D3Drenderstatetype State, [NativeTypeName("DWORD *")] Ref<uint> pValue)
        {
            fixed (uint* __dsl_pValue = pValue)
            {
                return (HResult)GetRenderState(State, __dsl_pValue);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetRenderTarget"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HResult GetRenderTarget([NativeTypeName("DWORD")] uint RenderTargetIndex, IDirect3DSurface9* ppRenderTarget)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, IDirect3DSurface9.Native**, HResult> )(lpVtbl[38]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), RenderTargetIndex, &ppRenderTarget->LpVtbl);
        }

        [VtblIndex(38)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetRenderTarget([NativeTypeName("DWORD")] uint RenderTargetIndex, Ref<IDirect3DSurface9> ppRenderTarget)
        {
            fixed (IDirect3DSurface9* __dsl_ppRenderTarget = ppRenderTarget)
            {
                return (HResult)GetRenderTarget(RenderTargetIndex, __dsl_ppRenderTarget);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetRenderTargetData"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HResult GetRenderTargetData(IDirect3DSurface9 pRenderTarget, IDirect3DSurface9 pDestSurface)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, IDirect3DSurface9.Native*, IDirect3DSurface9.Native*, HResult> )(lpVtbl[32]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pRenderTarget.LpVtbl, pDestSurface.LpVtbl);
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetSamplerState"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        public HResult GetSamplerState([NativeTypeName("DWORD")] uint Sampler, D3Dsamplerstatetype Type, [NativeTypeName("DWORD *")] uint* pValue)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, D3Dsamplerstatetype, uint*, HResult> )(lpVtbl[68]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), Sampler, Type, pValue);
        }

        [VtblIndex(68)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetSamplerState([NativeTypeName("DWORD")] uint Sampler, D3Dsamplerstatetype Type, [NativeTypeName("DWORD *")] Ref<uint> pValue)
        {
            fixed (uint* __dsl_pValue = pValue)
            {
                return (HResult)GetSamplerState(Sampler, Type, __dsl_pValue);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetScissorRect"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        public HResult GetScissorRect(RECT* pRect)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, RECT*, HResult> )(lpVtbl[76]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pRect);
        }

        [VtblIndex(76)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetScissorRect(Ref<RECT> pRect)
        {
            fixed (RECT* __dsl_pRect = pRect)
            {
                return (HResult)GetScissorRect(__dsl_pRect);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetSoftwareVertexProcessing"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        [return: NativeTypeName("BOOL")]
        public MaybeBool<int> GetSoftwareVertexProcessing()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, MaybeBool<int>> )(lpVtbl[78]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetStreamSource"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(101)]
        public HResult GetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9* ppStreamData, uint* pOffsetInBytes, uint* pStride)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, IDirect3DVertexBuffer9.Native**, uint*, uint*, HResult> )(lpVtbl[101]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), StreamNumber, &ppStreamData->LpVtbl, pOffsetInBytes, pStride);
        }

        [VtblIndex(101)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetStreamSource(uint StreamNumber, Ref<IDirect3DVertexBuffer9> ppStreamData, Ref<uint> pOffsetInBytes, Ref<uint> pStride)
        {
            fixed (uint* __dsl_pStride = pStride)
            fixed (uint* __dsl_pOffsetInBytes = pOffsetInBytes)
            fixed (IDirect3DVertexBuffer9* __dsl_ppStreamData = ppStreamData)
            {
                return (HResult)GetStreamSource(StreamNumber, __dsl_ppStreamData, __dsl_pOffsetInBytes, __dsl_pStride);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetStreamSourceFreq"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(103)]
        public HResult GetStreamSourceFreq(uint StreamNumber, uint* pSetting)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, uint*, HResult> )(lpVtbl[103]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), StreamNumber, pSetting);
        }

        [VtblIndex(103)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetStreamSourceFreq(uint StreamNumber, Ref<uint> pSetting)
        {
            fixed (uint* __dsl_pSetting = pSetting)
            {
                return (HResult)GetStreamSourceFreq(StreamNumber, __dsl_pSetting);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetSwapChain"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HResult GetSwapChain(uint iSwapChain, IDirect3DSwapChain9* pSwapChain)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, IDirect3DSwapChain9.Native**, HResult> )(lpVtbl[14]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), iSwapChain, &pSwapChain->LpVtbl);
        }

        [VtblIndex(14)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetSwapChain(uint iSwapChain, Ref<IDirect3DSwapChain9> pSwapChain)
        {
            fixed (IDirect3DSwapChain9* __dsl_pSwapChain = pSwapChain)
            {
                return (HResult)GetSwapChain(iSwapChain, __dsl_pSwapChain);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetTexture"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        public HResult GetTexture([NativeTypeName("DWORD")] uint Stage, IDirect3DBaseTexture9* ppTexture)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, IDirect3DBaseTexture9.Native**, HResult> )(lpVtbl[64]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), Stage, &ppTexture->LpVtbl);
        }

        [VtblIndex(64)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetTexture([NativeTypeName("DWORD")] uint Stage, Ref<IDirect3DBaseTexture9> ppTexture)
        {
            fixed (IDirect3DBaseTexture9* __dsl_ppTexture = ppTexture)
            {
                return (HResult)GetTexture(Stage, __dsl_ppTexture);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetTextureStageState"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        public HResult GetTextureStageState([NativeTypeName("DWORD")] uint Stage, D3Dtexturestagestatetype Type, [NativeTypeName("DWORD *")] uint* pValue)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, D3Dtexturestagestatetype, uint*, HResult> )(lpVtbl[66]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), Stage, Type, pValue);
        }

        [VtblIndex(66)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetTextureStageState([NativeTypeName("DWORD")] uint Stage, D3Dtexturestagestatetype Type, [NativeTypeName("DWORD *")] Ref<uint> pValue)
        {
            fixed (uint* __dsl_pValue = pValue)
            {
                return (HResult)GetTextureStageState(Stage, Type, __dsl_pValue);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetTransform"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HResult GetTransform(D3Dtransformstatetype State, [NativeTypeName("D3DMATRIX *")] D2DMatrix4X4F* pMatrix)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, D3Dtransformstatetype, D2DMatrix4X4F*, HResult> )(lpVtbl[45]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), State, pMatrix);
        }

        [VtblIndex(45)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetTransform(D3Dtransformstatetype State, [NativeTypeName("D3DMATRIX *")] Ref<D2DMatrix4X4F> pMatrix)
        {
            fixed (D2DMatrix4X4F* __dsl_pMatrix = pMatrix)
            {
                return (HResult)GetTransform(State, __dsl_pMatrix);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetVertexDeclaration"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(88)]
        public HResult GetVertexDeclaration(IDirect3DVertexDeclaration9* ppDecl)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, IDirect3DVertexDeclaration9.Native**, HResult> )(lpVtbl[88]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), &ppDecl->LpVtbl);
        }

        [VtblIndex(88)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetVertexDeclaration(Ref<IDirect3DVertexDeclaration9> ppDecl)
        {
            fixed (IDirect3DVertexDeclaration9* __dsl_ppDecl = ppDecl)
            {
                return (HResult)GetVertexDeclaration(__dsl_ppDecl);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetVertexShader"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(93)]
        public HResult GetVertexShader(IDirect3DVertexShader9* ppShader)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, IDirect3DVertexShader9.Native**, HResult> )(lpVtbl[93]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), &ppShader->LpVtbl);
        }

        [VtblIndex(93)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetVertexShader(Ref<IDirect3DVertexShader9> ppShader)
        {
            fixed (IDirect3DVertexShader9* __dsl_ppShader = ppShader)
            {
                return (HResult)GetVertexShader(__dsl_ppShader);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetVertexShaderConstantB"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(99)]
        public HResult GetVertexShaderConstantB(uint StartRegister, [NativeTypeName("BOOL *")] MaybeBool<int>* pConstantData, uint BoolCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, MaybeBool<int>*, uint, HResult> )(lpVtbl[99]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, BoolCount);
        }

        [VtblIndex(99)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetVertexShaderConstantB(uint StartRegister, [NativeTypeName("BOOL *")] Ref<MaybeBool<int>> pConstantData, uint BoolCount)
        {
            fixed (MaybeBool<int>* __dsl_pConstantData = pConstantData)
            {
                return (HResult)GetVertexShaderConstantB(StartRegister, __dsl_pConstantData, BoolCount);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetVertexShaderConstantF"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(95)]
        public HResult GetVertexShaderConstantF(uint StartRegister, float* pConstantData, uint Vector4fCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, float*, uint, HResult> )(lpVtbl[95]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4fCount);
        }

        [VtblIndex(95)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetVertexShaderConstantF(uint StartRegister, Ref<float> pConstantData, uint Vector4fCount)
        {
            fixed (float* __dsl_pConstantData = pConstantData)
            {
                return (HResult)GetVertexShaderConstantF(StartRegister, __dsl_pConstantData, Vector4fCount);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetVertexShaderConstantI"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(97)]
        public HResult GetVertexShaderConstantI(uint StartRegister, int* pConstantData, uint Vector4iCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, int*, uint, HResult> )(lpVtbl[97]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4iCount);
        }

        [VtblIndex(97)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetVertexShaderConstantI(uint StartRegister, Ref<int> pConstantData, uint Vector4iCount)
        {
            fixed (int* __dsl_pConstantData = pConstantData)
            {
                return (HResult)GetVertexShaderConstantI(StartRegister, __dsl_pConstantData, Vector4iCount);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.GetViewport"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public HResult GetViewport(D3Dviewport9* pViewport)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, D3Dviewport9*, HResult> )(lpVtbl[48]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pViewport);
        }

        [VtblIndex(48)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetViewport(Ref<D3Dviewport9> pViewport)
        {
            fixed (D3Dviewport9* __dsl_pViewport = pViewport)
            {
                return (HResult)GetViewport(__dsl_pViewport);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.LightEnable"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public HResult LightEnable([NativeTypeName("DWORD")] uint Index, [NativeTypeName("BOOL")] MaybeBool<int> Enable)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, MaybeBool<int>, HResult> )(lpVtbl[53]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), Index, Enable);
        }

        /// <inheritdoc cref = "IDirect3DDevice9.MultiplyTransform"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public HResult MultiplyTransform(D3Dtransformstatetype param0, [NativeTypeName("const D3DMATRIX *")] D2DMatrix4X4F* param1)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, D3Dtransformstatetype, D2DMatrix4X4F*, HResult> )(lpVtbl[46]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [VtblIndex(46)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult MultiplyTransform(D3Dtransformstatetype param0, [NativeTypeName("const D3DMATRIX *")] Ref<D2DMatrix4X4F> param1)
        {
            fixed (D2DMatrix4X4F* __dsl_param1 = param1)
            {
                return (HResult)MultiplyTransform(param0, __dsl_param1);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.Present"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HResult Present([NativeTypeName("const RECT *")] RECT* pSourceRect, [NativeTypeName("const RECT *")] RECT* pDestRect, HWND hDestWindowOverride, [NativeTypeName("const RGNDATA *")] RGNDATA* pDirtyRegion)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, RECT*, RECT*, HWND, RGNDATA*, HResult> )(lpVtbl[17]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion);
        }

        [VtblIndex(17)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult Present([NativeTypeName("const RECT *")] Ref<RECT> pSourceRect, [NativeTypeName("const RECT *")] Ref<RECT> pDestRect, HWND hDestWindowOverride, [NativeTypeName("const RGNDATA *")] Ref<RGNDATA> pDirtyRegion)
        {
            fixed (RGNDATA* __dsl_pDirtyRegion = pDirtyRegion)
            fixed (RECT* __dsl_pDestRect = pDestRect)
            fixed (RECT* __dsl_pSourceRect = pSourceRect)
            {
                return (HResult)Present(__dsl_pSourceRect, __dsl_pDestRect, hDestWindowOverride, __dsl_pDirtyRegion);
            }
        }

        /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.PresentEx"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(121)]
        public HResult PresentEx([NativeTypeName("const RECT *")] RECT* pSourceRect, [NativeTypeName("const RECT *")] RECT* pDestRect, HWND hDestWindowOverride, [NativeTypeName("const RGNDATA *")] RGNDATA* pDirtyRegion, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, RECT*, RECT*, HWND, RGNDATA*, uint, HResult> )(lpVtbl[121]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
        }

        [VtblIndex(121)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult PresentEx([NativeTypeName("const RECT *")] Ref<RECT> pSourceRect, [NativeTypeName("const RECT *")] Ref<RECT> pDestRect, HWND hDestWindowOverride, [NativeTypeName("const RGNDATA *")] Ref<RGNDATA> pDirtyRegion, [NativeTypeName("DWORD")] uint dwFlags)
        {
            fixed (RGNDATA* __dsl_pDirtyRegion = pDirtyRegion)
            fixed (RECT* __dsl_pDestRect = pDestRect)
            fixed (RECT* __dsl_pSourceRect = pSourceRect)
            {
                return (HResult)PresentEx(__dsl_pSourceRect, __dsl_pDestRect, hDestWindowOverride, __dsl_pDirtyRegion, dwFlags);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.ProcessVertices"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(85)]
        public HResult ProcessVertices(uint SrcStartIndex, uint DestIndex, uint VertexCount, IDirect3DVertexBuffer9 pDestBuffer, IDirect3DVertexDeclaration9 pVertexDecl, [NativeTypeName("DWORD")] uint Flags)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, uint, uint, IDirect3DVertexBuffer9.Native*, IDirect3DVertexDeclaration9.Native*, uint, HResult> )(lpVtbl[85]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), SrcStartIndex, DestIndex, VertexCount, pDestBuffer.LpVtbl, pVertexDecl.LpVtbl, Flags);
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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

        /// <inheritdoc cref = "IUnknown.Release"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint> )(lpVtbl[2]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IDirect3DDevice9.Reset"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HResult Reset(D3DpresentParameters* pPresentationParameters)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, D3DpresentParameters*, HResult> )(lpVtbl[16]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pPresentationParameters);
        }

        [VtblIndex(16)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult Reset(Ref<D3DpresentParameters> pPresentationParameters)
        {
            fixed (D3DpresentParameters* __dsl_pPresentationParameters = pPresentationParameters)
            {
                return (HResult)Reset(__dsl_pPresentationParameters);
            }
        }

        /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.ResetEx"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(132)]
        public HResult ResetEx(D3DpresentParameters* pPresentationParameters, D3Ddisplaymodeex* pFullscreenDisplayMode)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, D3DpresentParameters*, D3Ddisplaymodeex*, HResult> )(lpVtbl[132]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pPresentationParameters, pFullscreenDisplayMode);
        }

        [VtblIndex(132)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult ResetEx(Ref<D3DpresentParameters> pPresentationParameters, Ref<D3Ddisplaymodeex> pFullscreenDisplayMode)
        {
            fixed (D3Ddisplaymodeex* __dsl_pFullscreenDisplayMode = pFullscreenDisplayMode)
            fixed (D3DpresentParameters* __dsl_pPresentationParameters = pPresentationParameters)
            {
                return (HResult)ResetEx(__dsl_pPresentationParameters, __dsl_pFullscreenDisplayMode);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetClipPlane"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public HResult SetClipPlane([NativeTypeName("DWORD")] uint Index, [NativeTypeName("const float *")] float* pPlane)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, float*, HResult> )(lpVtbl[55]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), Index, pPlane);
        }

        [VtblIndex(55)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult SetClipPlane([NativeTypeName("DWORD")] uint Index, [NativeTypeName("const float *")] Ref<float> pPlane)
        {
            fixed (float* __dsl_pPlane = pPlane)
            {
                return (HResult)SetClipPlane(Index, __dsl_pPlane);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetClipStatus"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        public HResult SetClipStatus([NativeTypeName("const D3DCLIPSTATUS9 *")] D3Dclipstatus9* pClipStatus)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, D3Dclipstatus9*, HResult> )(lpVtbl[62]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pClipStatus);
        }

        [VtblIndex(62)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult SetClipStatus([NativeTypeName("const D3DCLIPSTATUS9 *")] Ref<D3Dclipstatus9> pClipStatus)
        {
            fixed (D3Dclipstatus9* __dsl_pClipStatus = pClipStatus)
            {
                return (HResult)SetClipStatus(__dsl_pClipStatus);
            }
        }

        /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.SetConvolutionMonoKernel"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(119)]
        public HResult SetConvolutionMonoKernel(uint width, uint height, float* rows, float* columns)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, uint, float*, float*, HResult> )(lpVtbl[119]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), width, height, rows, columns);
        }

        [VtblIndex(119)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult SetConvolutionMonoKernel(uint width, uint height, Ref<float> rows, Ref<float> columns)
        {
            fixed (float* __dsl_columns = columns)
            fixed (float* __dsl_rows = rows)
            {
                return (HResult)SetConvolutionMonoKernel(width, height, __dsl_rows, __dsl_columns);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetCurrentTexturePalette"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        public HResult SetCurrentTexturePalette(uint PaletteNumber)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, HResult> )(lpVtbl[73]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), PaletteNumber);
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetCursorPosition"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public void SetCursorPosition(int X, int Y, [NativeTypeName("DWORD")] uint Flags)
        {
            ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, int, int, uint, void> )(lpVtbl[11]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), X, Y, Flags);
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetCursorProperties"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HResult SetCursorProperties(uint XHotSpot, uint YHotSpot, IDirect3DSurface9 pCursorBitmap)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, uint, IDirect3DSurface9.Native*, HResult> )(lpVtbl[10]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), XHotSpot, YHotSpot, pCursorBitmap.LpVtbl);
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetDepthStencilSurface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HResult SetDepthStencilSurface(IDirect3DSurface9 pNewZStencil)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, IDirect3DSurface9.Native*, HResult> )(lpVtbl[39]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pNewZStencil.LpVtbl);
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetDialogBoxMode"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HResult SetDialogBoxMode([NativeTypeName("BOOL")] MaybeBool<int> bEnableDialogs)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, MaybeBool<int>, HResult> )(lpVtbl[20]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), bEnableDialogs);
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetFVF"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(89)]
        public HResult SetFVF([NativeTypeName("DWORD")] uint FVF)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, HResult> )(lpVtbl[89]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), FVF);
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetGammaRamp"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public void SetGammaRamp(uint iSwapChain, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("const D3DGAMMARAMP *")] D3Dgammaramp* pRamp)
        {
            ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, uint, D3Dgammaramp*, void> )(lpVtbl[21]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), iSwapChain, Flags, pRamp);
        }

        [VtblIndex(21)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void SetGammaRamp(uint iSwapChain, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("const D3DGAMMARAMP *")] Ref<D3Dgammaramp> pRamp)
        {
            fixed (D3Dgammaramp* __dsl_pRamp = pRamp)
            {
                SetGammaRamp(iSwapChain, Flags, __dsl_pRamp);
            }
        }

        /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.SetGPUThreadPriority"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(123)]
        public HResult SetGPUThreadPriority(int Priority)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, int, HResult> )(lpVtbl[123]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), Priority);
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetIndices"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(104)]
        public HResult SetIndices(IDirect3DIndexBuffer9 pIndexData)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, IDirect3DIndexBuffer9.Native*, HResult> )(lpVtbl[104]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pIndexData.LpVtbl);
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetLight"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public HResult SetLight([NativeTypeName("DWORD")] uint Index, [NativeTypeName("const D3DLIGHT9 *")] D3Dlight9* param1)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, D3Dlight9*, HResult> )(lpVtbl[51]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), Index, param1);
        }

        [VtblIndex(51)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult SetLight([NativeTypeName("DWORD")] uint Index, [NativeTypeName("const D3DLIGHT9 *")] Ref<D3Dlight9> param1)
        {
            fixed (D3Dlight9* __dsl_param1 = param1)
            {
                return (HResult)SetLight(Index, __dsl_param1);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetMaterial"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public HResult SetMaterial([NativeTypeName("const D3DMATERIAL9 *")] D3Dmaterial9* pMaterial)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, D3Dmaterial9*, HResult> )(lpVtbl[49]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pMaterial);
        }

        [VtblIndex(49)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult SetMaterial([NativeTypeName("const D3DMATERIAL9 *")] Ref<D3Dmaterial9> pMaterial)
        {
            fixed (D3Dmaterial9* __dsl_pMaterial = pMaterial)
            {
                return (HResult)SetMaterial(__dsl_pMaterial);
            }
        }

        /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.SetMaximumFrameLatency"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(126)]
        public HResult SetMaximumFrameLatency(uint MaxLatency)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, HResult> )(lpVtbl[126]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), MaxLatency);
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetNPatchMode"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        public HResult SetNPatchMode(float nSegments)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, float, HResult> )(lpVtbl[79]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), nSegments);
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetPaletteEntries"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        public HResult SetPaletteEntries(uint PaletteNumber, [NativeTypeName("const PALETTEENTRY *")] PALETTEENTRY* pEntries)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, PALETTEENTRY*, HResult> )(lpVtbl[71]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), PaletteNumber, pEntries);
        }

        [VtblIndex(71)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult SetPaletteEntries(uint PaletteNumber, [NativeTypeName("const PALETTEENTRY *")] Ref<PALETTEENTRY> pEntries)
        {
            fixed (PALETTEENTRY* __dsl_pEntries = pEntries)
            {
                return (HResult)SetPaletteEntries(PaletteNumber, __dsl_pEntries);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetPixelShader"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(107)]
        public HResult SetPixelShader(IDirect3DPixelShader9 pShader)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, IDirect3DPixelShader9.Native*, HResult> )(lpVtbl[107]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pShader.LpVtbl);
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetPixelShaderConstantB"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(113)]
        public HResult SetPixelShaderConstantB(uint StartRegister, [NativeTypeName("const BOOL *")] MaybeBool<int>* pConstantData, uint BoolCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, MaybeBool<int>*, uint, HResult> )(lpVtbl[113]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, BoolCount);
        }

        [VtblIndex(113)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult SetPixelShaderConstantB(uint StartRegister, [NativeTypeName("const BOOL *")] Ref<MaybeBool<int>> pConstantData, uint BoolCount)
        {
            fixed (MaybeBool<int>* __dsl_pConstantData = pConstantData)
            {
                return (HResult)SetPixelShaderConstantB(StartRegister, __dsl_pConstantData, BoolCount);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetPixelShaderConstantF"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(109)]
        public HResult SetPixelShaderConstantF(uint StartRegister, [NativeTypeName("const float *")] float* pConstantData, uint Vector4fCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, float*, uint, HResult> )(lpVtbl[109]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4fCount);
        }

        [VtblIndex(109)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult SetPixelShaderConstantF(uint StartRegister, [NativeTypeName("const float *")] Ref<float> pConstantData, uint Vector4fCount)
        {
            fixed (float* __dsl_pConstantData = pConstantData)
            {
                return (HResult)SetPixelShaderConstantF(StartRegister, __dsl_pConstantData, Vector4fCount);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetPixelShaderConstantI"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(111)]
        public HResult SetPixelShaderConstantI(uint StartRegister, [NativeTypeName("const int *")] int* pConstantData, uint Vector4iCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, int*, uint, HResult> )(lpVtbl[111]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4iCount);
        }

        [VtblIndex(111)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult SetPixelShaderConstantI(uint StartRegister, [NativeTypeName("const int *")] Ref<int> pConstantData, uint Vector4iCount)
        {
            fixed (int* __dsl_pConstantData = pConstantData)
            {
                return (HResult)SetPixelShaderConstantI(StartRegister, __dsl_pConstantData, Vector4iCount);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetRenderState"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        public HResult SetRenderState(D3Drenderstatetype State, [NativeTypeName("DWORD")] uint Value)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, D3Drenderstatetype, uint, HResult> )(lpVtbl[57]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), State, Value);
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetRenderTarget"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HResult SetRenderTarget([NativeTypeName("DWORD")] uint RenderTargetIndex, IDirect3DSurface9 pRenderTarget)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, IDirect3DSurface9.Native*, HResult> )(lpVtbl[37]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), RenderTargetIndex, pRenderTarget.LpVtbl);
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetSamplerState"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        public HResult SetSamplerState([NativeTypeName("DWORD")] uint Sampler, D3Dsamplerstatetype Type, [NativeTypeName("DWORD")] uint Value)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, D3Dsamplerstatetype, uint, HResult> )(lpVtbl[69]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), Sampler, Type, Value);
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetScissorRect"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        public HResult SetScissorRect([NativeTypeName("const RECT *")] RECT* pRect)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, RECT*, HResult> )(lpVtbl[75]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pRect);
        }

        [VtblIndex(75)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult SetScissorRect([NativeTypeName("const RECT *")] Ref<RECT> pRect)
        {
            fixed (RECT* __dsl_pRect = pRect)
            {
                return (HResult)SetScissorRect(__dsl_pRect);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetSoftwareVertexProcessing"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        public HResult SetSoftwareVertexProcessing([NativeTypeName("BOOL")] MaybeBool<int> bSoftware)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, MaybeBool<int>, HResult> )(lpVtbl[77]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), bSoftware);
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetStreamSource"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(100)]
        public HResult SetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9 pStreamData, uint OffsetInBytes, uint Stride)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, IDirect3DVertexBuffer9.Native*, uint, uint, HResult> )(lpVtbl[100]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), StreamNumber, pStreamData.LpVtbl, OffsetInBytes, Stride);
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetStreamSourceFreq"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(102)]
        public HResult SetStreamSourceFreq(uint StreamNumber, uint Setting)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, uint, HResult> )(lpVtbl[102]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), StreamNumber, Setting);
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetTexture"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        public HResult SetTexture([NativeTypeName("DWORD")] uint Stage, IDirect3DBaseTexture9 pTexture)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, IDirect3DBaseTexture9.Native*, HResult> )(lpVtbl[65]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), Stage, pTexture.LpVtbl);
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetTextureStageState"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        public HResult SetTextureStageState([NativeTypeName("DWORD")] uint Stage, D3Dtexturestagestatetype Type, [NativeTypeName("DWORD")] uint Value)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, D3Dtexturestagestatetype, uint, HResult> )(lpVtbl[67]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), Stage, Type, Value);
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetTransform"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HResult SetTransform(D3Dtransformstatetype State, [NativeTypeName("const D3DMATRIX *")] D2DMatrix4X4F* pMatrix)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, D3Dtransformstatetype, D2DMatrix4X4F*, HResult> )(lpVtbl[44]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), State, pMatrix);
        }

        [VtblIndex(44)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult SetTransform(D3Dtransformstatetype State, [NativeTypeName("const D3DMATRIX *")] Ref<D2DMatrix4X4F> pMatrix)
        {
            fixed (D2DMatrix4X4F* __dsl_pMatrix = pMatrix)
            {
                return (HResult)SetTransform(State, __dsl_pMatrix);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetVertexDeclaration"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(87)]
        public HResult SetVertexDeclaration(IDirect3DVertexDeclaration9 pDecl)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, IDirect3DVertexDeclaration9.Native*, HResult> )(lpVtbl[87]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pDecl.LpVtbl);
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetVertexShader"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(92)]
        public HResult SetVertexShader(IDirect3DVertexShader9 pShader)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, IDirect3DVertexShader9.Native*, HResult> )(lpVtbl[92]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pShader.LpVtbl);
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetVertexShaderConstantB"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(98)]
        public HResult SetVertexShaderConstantB(uint StartRegister, [NativeTypeName("const BOOL *")] MaybeBool<int>* pConstantData, uint BoolCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, MaybeBool<int>*, uint, HResult> )(lpVtbl[98]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, BoolCount);
        }

        [VtblIndex(98)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult SetVertexShaderConstantB(uint StartRegister, [NativeTypeName("const BOOL *")] Ref<MaybeBool<int>> pConstantData, uint BoolCount)
        {
            fixed (MaybeBool<int>* __dsl_pConstantData = pConstantData)
            {
                return (HResult)SetVertexShaderConstantB(StartRegister, __dsl_pConstantData, BoolCount);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetVertexShaderConstantF"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(94)]
        public HResult SetVertexShaderConstantF(uint StartRegister, [NativeTypeName("const float *")] float* pConstantData, uint Vector4fCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, float*, uint, HResult> )(lpVtbl[94]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4fCount);
        }

        [VtblIndex(94)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult SetVertexShaderConstantF(uint StartRegister, [NativeTypeName("const float *")] Ref<float> pConstantData, uint Vector4fCount)
        {
            fixed (float* __dsl_pConstantData = pConstantData)
            {
                return (HResult)SetVertexShaderConstantF(StartRegister, __dsl_pConstantData, Vector4fCount);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetVertexShaderConstantI"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(96)]
        public HResult SetVertexShaderConstantI(uint StartRegister, [NativeTypeName("const int *")] int* pConstantData, uint Vector4iCount)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, int*, uint, HResult> )(lpVtbl[96]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4iCount);
        }

        [VtblIndex(96)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult SetVertexShaderConstantI(uint StartRegister, [NativeTypeName("const int *")] Ref<int> pConstantData, uint Vector4iCount)
        {
            fixed (int* __dsl_pConstantData = pConstantData)
            {
                return (HResult)SetVertexShaderConstantI(StartRegister, __dsl_pConstantData, Vector4iCount);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.SetViewport"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public HResult SetViewport([NativeTypeName("const D3DVIEWPORT9 *")] D3Dviewport9* pViewport)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, D3Dviewport9*, HResult> )(lpVtbl[47]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pViewport);
        }

        [VtblIndex(47)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult SetViewport([NativeTypeName("const D3DVIEWPORT9 *")] Ref<D3Dviewport9> pViewport)
        {
            fixed (D3Dviewport9* __dsl_pViewport = pViewport)
            {
                return (HResult)SetViewport(__dsl_pViewport);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.ShowCursor"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("BOOL")]
        public MaybeBool<int> ShowCursor([NativeTypeName("BOOL")] MaybeBool<int> bShow)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, MaybeBool<int>, MaybeBool<int>> )(lpVtbl[12]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), bShow);
        }

        /// <inheritdoc cref = "IDirect3DDevice9.StretchRect"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HResult StretchRect(IDirect3DSurface9 pSourceSurface, [NativeTypeName("const RECT *")] RECT* pSourceRect, IDirect3DSurface9 pDestSurface, [NativeTypeName("const RECT *")] RECT* pDestRect, D3Dtexturefiltertype Filter)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, IDirect3DSurface9.Native*, RECT*, IDirect3DSurface9.Native*, RECT*, D3Dtexturefiltertype, HResult> )(lpVtbl[34]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pSourceSurface.LpVtbl, pSourceRect, pDestSurface.LpVtbl, pDestRect, Filter);
        }

        [VtblIndex(34)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult StretchRect(IDirect3DSurface9 pSourceSurface, [NativeTypeName("const RECT *")] Ref<RECT> pSourceRect, IDirect3DSurface9 pDestSurface, [NativeTypeName("const RECT *")] Ref<RECT> pDestRect, D3Dtexturefiltertype Filter)
        {
            fixed (RECT* __dsl_pDestRect = pDestRect)
            fixed (RECT* __dsl_pSourceRect = pSourceRect)
            {
                return (HResult)StretchRect(pSourceSurface, __dsl_pSourceRect, pDestSurface, __dsl_pDestRect, Filter);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.TestCooperativeLevel"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult TestCooperativeLevel()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, HResult> )(lpVtbl[3]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IDirect3DDevice9.UpdateSurface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HResult UpdateSurface(IDirect3DSurface9 pSourceSurface, [NativeTypeName("const RECT *")] RECT* pSourceRect, IDirect3DSurface9 pDestinationSurface, [NativeTypeName("const POINT *")] Point* pDestPoint)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, IDirect3DSurface9.Native*, RECT*, IDirect3DSurface9.Native*, Point*, HResult> )(lpVtbl[30]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pSourceSurface.LpVtbl, pSourceRect, pDestinationSurface.LpVtbl, pDestPoint);
        }

        [VtblIndex(30)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult UpdateSurface(IDirect3DSurface9 pSourceSurface, [NativeTypeName("const RECT *")] Ref<RECT> pSourceRect, IDirect3DSurface9 pDestinationSurface, [NativeTypeName("const POINT *")] Ref<Point> pDestPoint)
        {
            fixed (Point* __dsl_pDestPoint = pDestPoint)
            fixed (RECT* __dsl_pSourceRect = pSourceRect)
            {
                return (HResult)UpdateSurface(pSourceSurface, __dsl_pSourceRect, pDestinationSurface, __dsl_pDestPoint);
            }
        }

        /// <inheritdoc cref = "IDirect3DDevice9.UpdateTexture"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HResult UpdateTexture(IDirect3DBaseTexture9 pSourceTexture, IDirect3DBaseTexture9 pDestinationTexture)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, IDirect3DBaseTexture9.Native*, IDirect3DBaseTexture9.Native*, HResult> )(lpVtbl[31]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pSourceTexture.LpVtbl, pDestinationTexture.LpVtbl);
        }

        /// <inheritdoc cref = "IDirect3DDevice9.ValidateDevice"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        public HResult ValidateDevice([NativeTypeName("DWORD *")] uint* pNumPasses)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint*, HResult> )(lpVtbl[70]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), pNumPasses);
        }

        [VtblIndex(70)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult ValidateDevice([NativeTypeName("DWORD *")] Ref<uint> pNumPasses)
        {
            fixed (uint* __dsl_pNumPasses = pNumPasses)
            {
                return (HResult)ValidateDevice(__dsl_pNumPasses);
            }
        }

        /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.WaitForVBlank"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(124)]
        public HResult WaitForVBlank(uint iSwapChain)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Ex.Native*, uint, HResult> )(lpVtbl[124]))((IDirect3DDevice9Ex.Native*)Unsafe.AsPointer(ref this), iSwapChain);
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirect3DDevice9Ex"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DDevice9Ex(Ptr3D vtbl) => LpVtbl = (IDirect3DDevice9Ex.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "IDirect3DDevice9Ex"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DDevice9Ex(Ptr<IDirect3DDevice9Ex.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "IDirect3DDevice9Ex.Native"/> to <see cref = "IDirect3DDevice9Ex"/>.</summary>
    /// <param name = "value">The <see cref = "IDirect3DDevice9Ex.Native"/> instance to be converted </param>
    public static implicit operator IDirect3DDevice9Ex(IDirect3DDevice9Ex.Native* value) => new IDirect3DDevice9Ex((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDirect3DDevice9Ex"/> to <see cref = "IDirect3DDevice9Ex.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IDirect3DDevice9Ex"/> instance to be converted </param>
    public static implicit operator IDirect3DDevice9Ex.Native*(IDirect3DDevice9Ex value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IDirect3DDevice9Ex"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator IDirect3DDevice9Ex(Ptr3D value) => new IDirect3DDevice9Ex(value);
    /// <summary>casts <see cref = "IDirect3DDevice9Ex"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DDevice9Ex"/> instance to be converted </param>
    public static implicit operator Ptr3D(IDirect3DDevice9Ex value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IDirect3DDevice9Ex"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator IDirect3DDevice9Ex(Ptr<IDirect3DDevice9Ex.Native> value) => new IDirect3DDevice9Ex(value);
    /// <summary>casts <see cref = "IDirect3DDevice9Ex"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DDevice9Ex"/> instance to be converted </param>
    public static implicit operator Ptr<IDirect3DDevice9Ex.Native>(IDirect3DDevice9Ex value) => (Ptr<IDirect3DDevice9Ex.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "IDirect3DDevice9Ex"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator IDirect3DDevice9Ex(void*** value) => new IDirect3DDevice9Ex((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDirect3DDevice9Ex"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IDirect3DDevice9Ex"/> instance to be converted </param>
    public static implicit operator void***(IDirect3DDevice9Ex value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "IDirect3DDevice9Ex"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator IDirect3DDevice9Ex(nuint value) => new IDirect3DDevice9Ex((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "IDirect3DDevice9Ex"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DDevice9Ex"/> instance to be converted </param>
    public static implicit operator nuint(IDirect3DDevice9Ex value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <inheritdoc cref = "IDirect3DDevice9.BeginScene"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HResult BeginScene() => LpVtbl->BeginScene();
    /// <inheritdoc cref = "IDirect3DDevice9.BeginStateBlock"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HResult BeginStateBlock() => LpVtbl->BeginStateBlock();
    /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.CheckDeviceState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(128)]
    public HResult CheckDeviceState(HWND hDestinationWindow) => LpVtbl->CheckDeviceState(hDestinationWindow);
    /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.CheckResourceResidency"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(125)]
    public HResult CheckResourceResidency(IDirect3DResource9* pResourceArray, [NativeTypeName("UINT32")] uint NumResources) => LpVtbl->CheckResourceResidency(pResourceArray, NumResources);
    [VtblIndex(125)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CheckResourceResidency(Ref<IDirect3DResource9> pResourceArray, [NativeTypeName("UINT32")] uint NumResources)
    {
        fixed (IDirect3DResource9* __dsl_pResourceArray = pResourceArray)
        {
            return (HResult)CheckResourceResidency(__dsl_pResourceArray, NumResources);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.Clear"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HResult Clear([NativeTypeName("DWORD")] uint Count, [NativeTypeName("const D3DRECT *")] D3Drect* pRects, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("D3DCOLOR")] uint Color, float Z, [NativeTypeName("DWORD")] uint Stencil) => LpVtbl->Clear(Count, pRects, Flags, Color, Z, Stencil);
    [VtblIndex(43)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult Clear([NativeTypeName("DWORD")] uint Count, [NativeTypeName("const D3DRECT *")] Ref<D3Drect> pRects, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("D3DCOLOR")] uint Color, float Z, [NativeTypeName("DWORD")] uint Stencil)
    {
        fixed (D3Drect* __dsl_pRects = pRects)
        {
            return (HResult)Clear(Count, __dsl_pRects, Flags, Color, Z, Stencil);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.ColorFill"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HResult ColorFill(IDirect3DSurface9 pSurface, [NativeTypeName("const RECT *")] RECT* pRect, [NativeTypeName("D3DCOLOR")] uint color) => LpVtbl->ColorFill(pSurface, pRect, color);
    [VtblIndex(35)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult ColorFill(IDirect3DSurface9 pSurface, [NativeTypeName("const RECT *")] Ref<RECT> pRect, [NativeTypeName("D3DCOLOR")] uint color)
    {
        fixed (RECT* __dsl_pRect = pRect)
        {
            return (HResult)ColorFill(pSurface, __dsl_pRect, color);
        }
    }

    /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.ComposeRects"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(120)]
    public HResult ComposeRects(IDirect3DSurface9 pSrc, IDirect3DSurface9 pDst, IDirect3DVertexBuffer9 pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9 pDstRectDescs, D3Dcomposerectsop Operation, int Xoffset, int Yoffset) => LpVtbl->ComposeRects(pSrc, pDst, pSrcRectDescs, NumRects, pDstRectDescs, Operation, Xoffset, Yoffset);
    /// <inheritdoc cref = "IDirect3DDevice9.CreateAdditionalSwapChain"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HResult CreateAdditionalSwapChain(D3DpresentParameters* pPresentationParameters, IDirect3DSwapChain9* pSwapChain) => LpVtbl->CreateAdditionalSwapChain(pPresentationParameters, pSwapChain);
    [VtblIndex(13)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateAdditionalSwapChain(Ref<D3DpresentParameters> pPresentationParameters, Ref<IDirect3DSwapChain9> pSwapChain)
    {
        fixed (IDirect3DSwapChain9* __dsl_pSwapChain = pSwapChain)
        fixed (D3DpresentParameters* __dsl_pPresentationParameters = pPresentationParameters)
        {
            return (HResult)CreateAdditionalSwapChain(__dsl_pPresentationParameters, __dsl_pSwapChain);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.CreateCubeTexture"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HResult CreateCubeTexture(uint EdgeLength, uint Levels, [NativeTypeName("DWORD")] uint Usage, D3Dformat Format, D3Dpool Pool, IDirect3DCubeTexture9* ppCubeTexture, Handle* pSharedHandle) => LpVtbl->CreateCubeTexture(EdgeLength, Levels, Usage, Format, Pool, ppCubeTexture, pSharedHandle);
    [VtblIndex(25)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateCubeTexture(uint EdgeLength, uint Levels, [NativeTypeName("DWORD")] uint Usage, D3Dformat Format, D3Dpool Pool, Ref<IDirect3DCubeTexture9> ppCubeTexture, Ref<Handle> pSharedHandle)
    {
        fixed (Handle* __dsl_pSharedHandle = pSharedHandle)
        fixed (IDirect3DCubeTexture9* __dsl_ppCubeTexture = ppCubeTexture)
        {
            return (HResult)CreateCubeTexture(EdgeLength, Levels, Usage, Format, Pool, __dsl_ppCubeTexture, __dsl_pSharedHandle);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.CreateDepthStencilSurface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HResult CreateDepthStencilSurface(uint Width, uint Height, D3Dformat Format, D3DmultisampleType MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] MaybeBool<int> Discard, IDirect3DSurface9* ppSurface, Handle* pSharedHandle) => LpVtbl->CreateDepthStencilSurface(Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurface, pSharedHandle);
    [VtblIndex(29)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateDepthStencilSurface(uint Width, uint Height, D3Dformat Format, D3DmultisampleType MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] MaybeBool<int> Discard, Ref<IDirect3DSurface9> ppSurface, Ref<Handle> pSharedHandle)
    {
        fixed (Handle* __dsl_pSharedHandle = pSharedHandle)
        fixed (IDirect3DSurface9* __dsl_ppSurface = ppSurface)
        {
            return (HResult)CreateDepthStencilSurface(Width, Height, Format, MultiSample, MultisampleQuality, Discard, __dsl_ppSurface, __dsl_pSharedHandle);
        }
    }

    /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.CreateDepthStencilSurfaceEx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(131)]
    public HResult CreateDepthStencilSurfaceEx(uint Width, uint Height, D3Dformat Format, D3DmultisampleType MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] MaybeBool<int> Discard, IDirect3DSurface9* ppSurface, Handle* pSharedHandle, [NativeTypeName("DWORD")] uint Usage) => LpVtbl->CreateDepthStencilSurfaceEx(Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurface, pSharedHandle, Usage);
    [VtblIndex(131)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateDepthStencilSurfaceEx(uint Width, uint Height, D3Dformat Format, D3DmultisampleType MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] MaybeBool<int> Discard, Ref<IDirect3DSurface9> ppSurface, Ref<Handle> pSharedHandle, [NativeTypeName("DWORD")] uint Usage)
    {
        fixed (Handle* __dsl_pSharedHandle = pSharedHandle)
        fixed (IDirect3DSurface9* __dsl_ppSurface = ppSurface)
        {
            return (HResult)CreateDepthStencilSurfaceEx(Width, Height, Format, MultiSample, MultisampleQuality, Discard, __dsl_ppSurface, __dsl_pSharedHandle, Usage);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.CreateIndexBuffer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HResult CreateIndexBuffer(uint Length, [NativeTypeName("DWORD")] uint Usage, D3Dformat Format, D3Dpool Pool, IDirect3DIndexBuffer9* ppIndexBuffer, Handle* pSharedHandle) => LpVtbl->CreateIndexBuffer(Length, Usage, Format, Pool, ppIndexBuffer, pSharedHandle);
    [VtblIndex(27)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateIndexBuffer(uint Length, [NativeTypeName("DWORD")] uint Usage, D3Dformat Format, D3Dpool Pool, Ref<IDirect3DIndexBuffer9> ppIndexBuffer, Ref<Handle> pSharedHandle)
    {
        fixed (Handle* __dsl_pSharedHandle = pSharedHandle)
        fixed (IDirect3DIndexBuffer9* __dsl_ppIndexBuffer = ppIndexBuffer)
        {
            return (HResult)CreateIndexBuffer(Length, Usage, Format, Pool, __dsl_ppIndexBuffer, __dsl_pSharedHandle);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.CreateOffscreenPlainSurface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HResult CreateOffscreenPlainSurface(uint Width, uint Height, D3Dformat Format, D3Dpool Pool, IDirect3DSurface9* ppSurface, Handle* pSharedHandle) => LpVtbl->CreateOffscreenPlainSurface(Width, Height, Format, Pool, ppSurface, pSharedHandle);
    [VtblIndex(36)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateOffscreenPlainSurface(uint Width, uint Height, D3Dformat Format, D3Dpool Pool, Ref<IDirect3DSurface9> ppSurface, Ref<Handle> pSharedHandle)
    {
        fixed (Handle* __dsl_pSharedHandle = pSharedHandle)
        fixed (IDirect3DSurface9* __dsl_ppSurface = ppSurface)
        {
            return (HResult)CreateOffscreenPlainSurface(Width, Height, Format, Pool, __dsl_ppSurface, __dsl_pSharedHandle);
        }
    }

    /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.CreateOffscreenPlainSurfaceEx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(130)]
    public HResult CreateOffscreenPlainSurfaceEx(uint Width, uint Height, D3Dformat Format, D3Dpool Pool, IDirect3DSurface9* ppSurface, Handle* pSharedHandle, [NativeTypeName("DWORD")] uint Usage) => LpVtbl->CreateOffscreenPlainSurfaceEx(Width, Height, Format, Pool, ppSurface, pSharedHandle, Usage);
    [VtblIndex(130)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateOffscreenPlainSurfaceEx(uint Width, uint Height, D3Dformat Format, D3Dpool Pool, Ref<IDirect3DSurface9> ppSurface, Ref<Handle> pSharedHandle, [NativeTypeName("DWORD")] uint Usage)
    {
        fixed (Handle* __dsl_pSharedHandle = pSharedHandle)
        fixed (IDirect3DSurface9* __dsl_ppSurface = ppSurface)
        {
            return (HResult)CreateOffscreenPlainSurfaceEx(Width, Height, Format, Pool, __dsl_ppSurface, __dsl_pSharedHandle, Usage);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.CreatePixelShader"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(106)]
    public HResult CreatePixelShader([NativeTypeName("const DWORD *")] uint* pFunction, IDirect3DPixelShader9* ppShader) => LpVtbl->CreatePixelShader(pFunction, ppShader);
    [VtblIndex(106)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreatePixelShader([NativeTypeName("const DWORD *")] Ref<uint> pFunction, Ref<IDirect3DPixelShader9> ppShader)
    {
        fixed (IDirect3DPixelShader9* __dsl_ppShader = ppShader)
        fixed (uint* __dsl_pFunction = pFunction)
        {
            return (HResult)CreatePixelShader(__dsl_pFunction, __dsl_ppShader);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.CreateQuery"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(118)]
    public HResult CreateQuery(D3Dquerytype Type, IDirect3DQuery9* ppQuery) => LpVtbl->CreateQuery(Type, ppQuery);
    [VtblIndex(118)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateQuery(D3Dquerytype Type, Ref<IDirect3DQuery9> ppQuery)
    {
        fixed (IDirect3DQuery9* __dsl_ppQuery = ppQuery)
        {
            return (HResult)CreateQuery(Type, __dsl_ppQuery);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.CreateRenderTarget"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HResult CreateRenderTarget(uint Width, uint Height, D3Dformat Format, D3DmultisampleType MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] MaybeBool<int> Lockable, IDirect3DSurface9* ppSurface, Handle* pSharedHandle) => LpVtbl->CreateRenderTarget(Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurface, pSharedHandle);
    [VtblIndex(28)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateRenderTarget(uint Width, uint Height, D3Dformat Format, D3DmultisampleType MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] MaybeBool<int> Lockable, Ref<IDirect3DSurface9> ppSurface, Ref<Handle> pSharedHandle)
    {
        fixed (Handle* __dsl_pSharedHandle = pSharedHandle)
        fixed (IDirect3DSurface9* __dsl_ppSurface = ppSurface)
        {
            return (HResult)CreateRenderTarget(Width, Height, Format, MultiSample, MultisampleQuality, Lockable, __dsl_ppSurface, __dsl_pSharedHandle);
        }
    }

    /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.CreateRenderTargetEx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(129)]
    public HResult CreateRenderTargetEx(uint Width, uint Height, D3Dformat Format, D3DmultisampleType MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] MaybeBool<int> Lockable, IDirect3DSurface9* ppSurface, Handle* pSharedHandle, [NativeTypeName("DWORD")] uint Usage) => LpVtbl->CreateRenderTargetEx(Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurface, pSharedHandle, Usage);
    [VtblIndex(129)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateRenderTargetEx(uint Width, uint Height, D3Dformat Format, D3DmultisampleType MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] MaybeBool<int> Lockable, Ref<IDirect3DSurface9> ppSurface, Ref<Handle> pSharedHandle, [NativeTypeName("DWORD")] uint Usage)
    {
        fixed (Handle* __dsl_pSharedHandle = pSharedHandle)
        fixed (IDirect3DSurface9* __dsl_ppSurface = ppSurface)
        {
            return (HResult)CreateRenderTargetEx(Width, Height, Format, MultiSample, MultisampleQuality, Lockable, __dsl_ppSurface, __dsl_pSharedHandle, Usage);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.CreateStateBlock"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HResult CreateStateBlock(D3Dstateblocktype Type, IDirect3DStateBlock9* ppSB) => LpVtbl->CreateStateBlock(Type, ppSB);
    [VtblIndex(59)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateStateBlock(D3Dstateblocktype Type, Ref<IDirect3DStateBlock9> ppSB)
    {
        fixed (IDirect3DStateBlock9* __dsl_ppSB = ppSB)
        {
            return (HResult)CreateStateBlock(Type, __dsl_ppSB);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.CreateTexture"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HResult CreateTexture(uint Width, uint Height, uint Levels, [NativeTypeName("DWORD")] uint Usage, D3Dformat Format, D3Dpool Pool, IDirect3DTexture9* ppTexture, Handle* pSharedHandle) => LpVtbl->CreateTexture(Width, Height, Levels, Usage, Format, Pool, ppTexture, pSharedHandle);
    [VtblIndex(23)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateTexture(uint Width, uint Height, uint Levels, [NativeTypeName("DWORD")] uint Usage, D3Dformat Format, D3Dpool Pool, Ref<IDirect3DTexture9> ppTexture, Ref<Handle> pSharedHandle)
    {
        fixed (Handle* __dsl_pSharedHandle = pSharedHandle)
        fixed (IDirect3DTexture9* __dsl_ppTexture = ppTexture)
        {
            return (HResult)CreateTexture(Width, Height, Levels, Usage, Format, Pool, __dsl_ppTexture, __dsl_pSharedHandle);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.CreateVertexBuffer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HResult CreateVertexBuffer(uint Length, [NativeTypeName("DWORD")] uint Usage, [NativeTypeName("DWORD")] uint FVF, D3Dpool Pool, IDirect3DVertexBuffer9* ppVertexBuffer, Handle* pSharedHandle) => LpVtbl->CreateVertexBuffer(Length, Usage, FVF, Pool, ppVertexBuffer, pSharedHandle);
    [VtblIndex(26)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVertexBuffer(uint Length, [NativeTypeName("DWORD")] uint Usage, [NativeTypeName("DWORD")] uint FVF, D3Dpool Pool, Ref<IDirect3DVertexBuffer9> ppVertexBuffer, Ref<Handle> pSharedHandle)
    {
        fixed (Handle* __dsl_pSharedHandle = pSharedHandle)
        fixed (IDirect3DVertexBuffer9* __dsl_ppVertexBuffer = ppVertexBuffer)
        {
            return (HResult)CreateVertexBuffer(Length, Usage, FVF, Pool, __dsl_ppVertexBuffer, __dsl_pSharedHandle);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.CreateVertexDeclaration"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(86)]
    public HResult CreateVertexDeclaration([NativeTypeName("const D3DVERTEXELEMENT9 *")] D3Dvertexelement9* pVertexElements, IDirect3DVertexDeclaration9* ppDecl) => LpVtbl->CreateVertexDeclaration(pVertexElements, ppDecl);
    [VtblIndex(86)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVertexDeclaration([NativeTypeName("const D3DVERTEXELEMENT9 *")] Ref<D3Dvertexelement9> pVertexElements, Ref<IDirect3DVertexDeclaration9> ppDecl)
    {
        fixed (IDirect3DVertexDeclaration9* __dsl_ppDecl = ppDecl)
        fixed (D3Dvertexelement9* __dsl_pVertexElements = pVertexElements)
        {
            return (HResult)CreateVertexDeclaration(__dsl_pVertexElements, __dsl_ppDecl);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.CreateVertexShader"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(91)]
    public HResult CreateVertexShader([NativeTypeName("const DWORD *")] uint* pFunction, IDirect3DVertexShader9* ppShader) => LpVtbl->CreateVertexShader(pFunction, ppShader);
    [VtblIndex(91)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVertexShader([NativeTypeName("const DWORD *")] Ref<uint> pFunction, Ref<IDirect3DVertexShader9> ppShader)
    {
        fixed (IDirect3DVertexShader9* __dsl_ppShader = ppShader)
        fixed (uint* __dsl_pFunction = pFunction)
        {
            return (HResult)CreateVertexShader(__dsl_pFunction, __dsl_ppShader);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.CreateVolumeTexture"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HResult CreateVolumeTexture(uint Width, uint Height, uint Depth, uint Levels, [NativeTypeName("DWORD")] uint Usage, D3Dformat Format, D3Dpool Pool, IDirect3DVolumeTexture9* ppVolumeTexture, Handle* pSharedHandle) => LpVtbl->CreateVolumeTexture(Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexture, pSharedHandle);
    [VtblIndex(24)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVolumeTexture(uint Width, uint Height, uint Depth, uint Levels, [NativeTypeName("DWORD")] uint Usage, D3Dformat Format, D3Dpool Pool, Ref<IDirect3DVolumeTexture9> ppVolumeTexture, Ref<Handle> pSharedHandle)
    {
        fixed (Handle* __dsl_pSharedHandle = pSharedHandle)
        fixed (IDirect3DVolumeTexture9* __dsl_ppVolumeTexture = ppVolumeTexture)
        {
            return (HResult)CreateVolumeTexture(Width, Height, Depth, Levels, Usage, Format, Pool, __dsl_ppVolumeTexture, __dsl_pSharedHandle);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.DeletePatch"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(117)]
    public HResult DeletePatch(uint Handle) => LpVtbl->DeletePatch(Handle);
    /// <inheritdoc cref = "IDirect3DDevice9.DrawIndexedPrimitive"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(82)]
    public HResult DrawIndexedPrimitive(D3Dprimitivetype param0, int BaseVertexIndex, uint MinVertexIndex, uint NumVertices, uint startIndex, uint primCount) => LpVtbl->DrawIndexedPrimitive(param0, BaseVertexIndex, MinVertexIndex, NumVertices, startIndex, primCount);
    /// <inheritdoc cref = "IDirect3DDevice9.DrawIndexedPrimitiveUP"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(84)]
    public HResult DrawIndexedPrimitiveUP(D3Dprimitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, [NativeTypeName("const void *")] void* pIndexData, D3Dformat IndexDataFormat, [NativeTypeName("const void *")] void* pVertexStreamZeroData, uint VertexStreamZeroStride) => LpVtbl->DrawIndexedPrimitiveUP(PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexData, IndexDataFormat, pVertexStreamZeroData, VertexStreamZeroStride);
    [VtblIndex(84)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult DrawIndexedPrimitiveUP(D3Dprimitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, [NativeTypeName("const void *")] Ref pIndexData, D3Dformat IndexDataFormat, [NativeTypeName("const void *")] Ref pVertexStreamZeroData, uint VertexStreamZeroStride)
    {
        fixed (void* __dsl_pVertexStreamZeroData = pVertexStreamZeroData)
        fixed (void* __dsl_pIndexData = pIndexData)
        {
            return (HResult)DrawIndexedPrimitiveUP(PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, __dsl_pIndexData, IndexDataFormat, __dsl_pVertexStreamZeroData, VertexStreamZeroStride);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.DrawPrimitive"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(81)]
    public HResult DrawPrimitive(D3Dprimitivetype PrimitiveType, uint StartVertex, uint PrimitiveCount) => LpVtbl->DrawPrimitive(PrimitiveType, StartVertex, PrimitiveCount);
    /// <inheritdoc cref = "IDirect3DDevice9.DrawPrimitiveUP"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(83)]
    public HResult DrawPrimitiveUP(D3Dprimitivetype PrimitiveType, uint PrimitiveCount, [NativeTypeName("const void *")] void* pVertexStreamZeroData, uint VertexStreamZeroStride) => LpVtbl->DrawPrimitiveUP(PrimitiveType, PrimitiveCount, pVertexStreamZeroData, VertexStreamZeroStride);
    [VtblIndex(83)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult DrawPrimitiveUP(D3Dprimitivetype PrimitiveType, uint PrimitiveCount, [NativeTypeName("const void *")] Ref pVertexStreamZeroData, uint VertexStreamZeroStride)
    {
        fixed (void* __dsl_pVertexStreamZeroData = pVertexStreamZeroData)
        {
            return (HResult)DrawPrimitiveUP(PrimitiveType, PrimitiveCount, __dsl_pVertexStreamZeroData, VertexStreamZeroStride);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.DrawRectPatch"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(115)]
    public HResult DrawRectPatch(uint Handle, [NativeTypeName("const float *")] float* pNumSegs, [NativeTypeName("const D3DRECTPATCH_INFO *")] D3DrectpatchInfo* pRectPatchInfo) => LpVtbl->DrawRectPatch(Handle, pNumSegs, pRectPatchInfo);
    [VtblIndex(115)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult DrawRectPatch(uint Handle, [NativeTypeName("const float *")] Ref<float> pNumSegs, [NativeTypeName("const D3DRECTPATCH_INFO *")] Ref<D3DrectpatchInfo> pRectPatchInfo)
    {
        fixed (D3DrectpatchInfo* __dsl_pRectPatchInfo = pRectPatchInfo)
        fixed (float* __dsl_pNumSegs = pNumSegs)
        {
            return (HResult)DrawRectPatch(Handle, __dsl_pNumSegs, __dsl_pRectPatchInfo);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.DrawTriPatch"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(116)]
    public HResult DrawTriPatch(uint Handle, [NativeTypeName("const float *")] float* pNumSegs, [NativeTypeName("const D3DTRIPATCH_INFO *")] D3DtripatchInfo* pTriPatchInfo) => LpVtbl->DrawTriPatch(Handle, pNumSegs, pTriPatchInfo);
    [VtblIndex(116)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult DrawTriPatch(uint Handle, [NativeTypeName("const float *")] Ref<float> pNumSegs, [NativeTypeName("const D3DTRIPATCH_INFO *")] Ref<D3DtripatchInfo> pTriPatchInfo)
    {
        fixed (D3DtripatchInfo* __dsl_pTriPatchInfo = pTriPatchInfo)
        fixed (float* __dsl_pNumSegs = pNumSegs)
        {
            return (HResult)DrawTriPatch(Handle, __dsl_pNumSegs, __dsl_pTriPatchInfo);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.EndScene"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HResult EndScene() => LpVtbl->EndScene();
    /// <inheritdoc cref = "IDirect3DDevice9.EndStateBlock"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HResult EndStateBlock(IDirect3DStateBlock9* ppSB) => LpVtbl->EndStateBlock(ppSB);
    [VtblIndex(61)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult EndStateBlock(Ref<IDirect3DStateBlock9> ppSB)
    {
        fixed (IDirect3DStateBlock9* __dsl_ppSB = ppSB)
        {
            return (HResult)EndStateBlock(__dsl_ppSB);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.EvictManagedResources"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult EvictManagedResources() => LpVtbl->EvictManagedResources();
    /// <inheritdoc cref = "IDirect3DDevice9.GetAvailableTextureMem"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public uint GetAvailableTextureMem() => LpVtbl->GetAvailableTextureMem();
    /// <inheritdoc cref = "IDirect3DDevice9.GetBackBuffer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HResult GetBackBuffer(uint iSwapChain, uint iBackBuffer, D3DbackbufferType Type, IDirect3DSurface9* ppBackBuffer) => LpVtbl->GetBackBuffer(iSwapChain, iBackBuffer, Type, ppBackBuffer);
    [VtblIndex(18)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetBackBuffer(uint iSwapChain, uint iBackBuffer, D3DbackbufferType Type, Ref<IDirect3DSurface9> ppBackBuffer)
    {
        fixed (IDirect3DSurface9* __dsl_ppBackBuffer = ppBackBuffer)
        {
            return (HResult)GetBackBuffer(iSwapChain, iBackBuffer, Type, __dsl_ppBackBuffer);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetClipPlane"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HResult GetClipPlane([NativeTypeName("DWORD")] uint Index, float* pPlane) => LpVtbl->GetClipPlane(Index, pPlane);
    [VtblIndex(56)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetClipPlane([NativeTypeName("DWORD")] uint Index, Ref<float> pPlane)
    {
        fixed (float* __dsl_pPlane = pPlane)
        {
            return (HResult)GetClipPlane(Index, __dsl_pPlane);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetClipStatus"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HResult GetClipStatus(D3Dclipstatus9* pClipStatus) => LpVtbl->GetClipStatus(pClipStatus);
    [VtblIndex(63)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetClipStatus(Ref<D3Dclipstatus9> pClipStatus)
    {
        fixed (D3Dclipstatus9* __dsl_pClipStatus = pClipStatus)
        {
            return (HResult)GetClipStatus(__dsl_pClipStatus);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetCreationParameters"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HResult GetCreationParameters(D3DdeviceCreationParameters* pParameters) => LpVtbl->GetCreationParameters(pParameters);
    [VtblIndex(9)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetCreationParameters(Ref<D3DdeviceCreationParameters> pParameters)
    {
        fixed (D3DdeviceCreationParameters* __dsl_pParameters = pParameters)
        {
            return (HResult)GetCreationParameters(__dsl_pParameters);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetCurrentTexturePalette"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public HResult GetCurrentTexturePalette(uint* PaletteNumber) => LpVtbl->GetCurrentTexturePalette(PaletteNumber);
    [VtblIndex(74)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetCurrentTexturePalette(Ref<uint> PaletteNumber)
    {
        fixed (uint* __dsl_PaletteNumber = PaletteNumber)
        {
            return (HResult)GetCurrentTexturePalette(__dsl_PaletteNumber);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetDepthStencilSurface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HResult GetDepthStencilSurface(IDirect3DSurface9* ppZStencilSurface) => LpVtbl->GetDepthStencilSurface(ppZStencilSurface);
    [VtblIndex(40)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDepthStencilSurface(Ref<IDirect3DSurface9> ppZStencilSurface)
    {
        fixed (IDirect3DSurface9* __dsl_ppZStencilSurface = ppZStencilSurface)
        {
            return (HResult)GetDepthStencilSurface(__dsl_ppZStencilSurface);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetDeviceCaps"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult GetDeviceCaps(D3Dcaps9* pCaps) => LpVtbl->GetDeviceCaps(pCaps);
    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDeviceCaps(Ref<D3Dcaps9> pCaps)
    {
        fixed (D3Dcaps9* __dsl_pCaps = pCaps)
        {
            return (HResult)GetDeviceCaps(__dsl_pCaps);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetDirect3D"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult GetDirect3D(IDirect3D9* ppD3D9) => LpVtbl->GetDirect3D(ppD3D9);
    [VtblIndex(6)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDirect3D(Ref<IDirect3D9> ppD3D9)
    {
        fixed (IDirect3D9* __dsl_ppD3D9 = ppD3D9)
        {
            return (HResult)GetDirect3D(__dsl_ppD3D9);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetDisplayMode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HResult GetDisplayMode(uint iSwapChain, D3Ddisplaymode* pMode) => LpVtbl->GetDisplayMode(iSwapChain, pMode);
    [VtblIndex(8)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDisplayMode(uint iSwapChain, Ref<D3Ddisplaymode> pMode)
    {
        fixed (D3Ddisplaymode* __dsl_pMode = pMode)
        {
            return (HResult)GetDisplayMode(iSwapChain, __dsl_pMode);
        }
    }

    /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.GetDisplayModeEx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(133)]
    public HResult GetDisplayModeEx(uint iSwapChain, D3Ddisplaymodeex* pMode, D3Ddisplayrotation* pRotation) => LpVtbl->GetDisplayModeEx(iSwapChain, pMode, pRotation);
    [VtblIndex(133)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDisplayModeEx(uint iSwapChain, Ref<D3Ddisplaymodeex> pMode, Ref<D3Ddisplayrotation> pRotation)
    {
        fixed (D3Ddisplayrotation* __dsl_pRotation = pRotation)
        fixed (D3Ddisplaymodeex* __dsl_pMode = pMode)
        {
            return (HResult)GetDisplayModeEx(iSwapChain, __dsl_pMode, __dsl_pRotation);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetFrontBufferData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HResult GetFrontBufferData(uint iSwapChain, IDirect3DSurface9 pDestSurface) => LpVtbl->GetFrontBufferData(iSwapChain, pDestSurface);
    /// <inheritdoc cref = "IDirect3DDevice9.GetFVF"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(90)]
    public HResult GetFVF([NativeTypeName("DWORD *")] uint* pFVF) => LpVtbl->GetFVF(pFVF);
    [VtblIndex(90)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetFVF([NativeTypeName("DWORD *")] Ref<uint> pFVF)
    {
        fixed (uint* __dsl_pFVF = pFVF)
        {
            return (HResult)GetFVF(__dsl_pFVF);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetGammaRamp"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public void GetGammaRamp(uint iSwapChain, D3Dgammaramp* pRamp) => LpVtbl->GetGammaRamp(iSwapChain, pRamp);
    [VtblIndex(22)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void GetGammaRamp(uint iSwapChain, Ref<D3Dgammaramp> pRamp)
    {
        fixed (D3Dgammaramp* __dsl_pRamp = pRamp)
        {
            GetGammaRamp(iSwapChain, __dsl_pRamp);
        }
    }

    /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.GetGPUThreadPriority"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(122)]
    public HResult GetGPUThreadPriority(int* pPriority) => LpVtbl->GetGPUThreadPriority(pPriority);
    [VtblIndex(122)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetGPUThreadPriority(Ref<int> pPriority)
    {
        fixed (int* __dsl_pPriority = pPriority)
        {
            return (HResult)GetGPUThreadPriority(__dsl_pPriority);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetIndices"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(105)]
    public HResult GetIndices(IDirect3DIndexBuffer9* ppIndexData) => LpVtbl->GetIndices(ppIndexData);
    [VtblIndex(105)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetIndices(Ref<IDirect3DIndexBuffer9> ppIndexData)
    {
        fixed (IDirect3DIndexBuffer9* __dsl_ppIndexData = ppIndexData)
        {
            return (HResult)GetIndices(__dsl_ppIndexData);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetLight"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HResult GetLight([NativeTypeName("DWORD")] uint Index, D3Dlight9* param1) => LpVtbl->GetLight(Index, param1);
    [VtblIndex(52)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetLight([NativeTypeName("DWORD")] uint Index, Ref<D3Dlight9> param1)
    {
        fixed (D3Dlight9* __dsl_param1 = param1)
        {
            return (HResult)GetLight(Index, __dsl_param1);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetLightEnable"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HResult GetLightEnable([NativeTypeName("DWORD")] uint Index, [NativeTypeName("BOOL *")] MaybeBool<int>* pEnable) => LpVtbl->GetLightEnable(Index, pEnable);
    [VtblIndex(54)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetLightEnable([NativeTypeName("DWORD")] uint Index, [NativeTypeName("BOOL *")] Ref<MaybeBool<int>> pEnable)
    {
        fixed (MaybeBool<int>* __dsl_pEnable = pEnable)
        {
            return (HResult)GetLightEnable(Index, __dsl_pEnable);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetMaterial"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HResult GetMaterial(D3Dmaterial9* pMaterial) => LpVtbl->GetMaterial(pMaterial);
    [VtblIndex(50)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetMaterial(Ref<D3Dmaterial9> pMaterial)
    {
        fixed (D3Dmaterial9* __dsl_pMaterial = pMaterial)
        {
            return (HResult)GetMaterial(__dsl_pMaterial);
        }
    }

    /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.GetMaximumFrameLatency"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(127)]
    public HResult GetMaximumFrameLatency(uint* pMaxLatency) => LpVtbl->GetMaximumFrameLatency(pMaxLatency);
    [VtblIndex(127)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetMaximumFrameLatency(Ref<uint> pMaxLatency)
    {
        fixed (uint* __dsl_pMaxLatency = pMaxLatency)
        {
            return (HResult)GetMaximumFrameLatency(__dsl_pMaxLatency);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetNPatchMode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(80)]
    public float GetNPatchMode() => LpVtbl->GetNPatchMode();
    /// <inheritdoc cref = "IDirect3DDevice9.GetNumberOfSwapChains"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public uint GetNumberOfSwapChains() => LpVtbl->GetNumberOfSwapChains();
    /// <inheritdoc cref = "IDirect3DDevice9.GetPaletteEntries"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public HResult GetPaletteEntries(uint PaletteNumber, PALETTEENTRY* pEntries) => LpVtbl->GetPaletteEntries(PaletteNumber, pEntries);
    [VtblIndex(72)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetPaletteEntries(uint PaletteNumber, Ref<PALETTEENTRY> pEntries)
    {
        fixed (PALETTEENTRY* __dsl_pEntries = pEntries)
        {
            return (HResult)GetPaletteEntries(PaletteNumber, __dsl_pEntries);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetPixelShader"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(108)]
    public HResult GetPixelShader(IDirect3DPixelShader9* ppShader) => LpVtbl->GetPixelShader(ppShader);
    [VtblIndex(108)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetPixelShader(Ref<IDirect3DPixelShader9> ppShader)
    {
        fixed (IDirect3DPixelShader9* __dsl_ppShader = ppShader)
        {
            return (HResult)GetPixelShader(__dsl_ppShader);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetPixelShaderConstantB"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(114)]
    public HResult GetPixelShaderConstantB(uint StartRegister, [NativeTypeName("BOOL *")] MaybeBool<int>* pConstantData, uint BoolCount) => LpVtbl->GetPixelShaderConstantB(StartRegister, pConstantData, BoolCount);
    [VtblIndex(114)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetPixelShaderConstantB(uint StartRegister, [NativeTypeName("BOOL *")] Ref<MaybeBool<int>> pConstantData, uint BoolCount)
    {
        fixed (MaybeBool<int>* __dsl_pConstantData = pConstantData)
        {
            return (HResult)GetPixelShaderConstantB(StartRegister, __dsl_pConstantData, BoolCount);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetPixelShaderConstantF"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(110)]
    public HResult GetPixelShaderConstantF(uint StartRegister, float* pConstantData, uint Vector4fCount) => LpVtbl->GetPixelShaderConstantF(StartRegister, pConstantData, Vector4fCount);
    [VtblIndex(110)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetPixelShaderConstantF(uint StartRegister, Ref<float> pConstantData, uint Vector4fCount)
    {
        fixed (float* __dsl_pConstantData = pConstantData)
        {
            return (HResult)GetPixelShaderConstantF(StartRegister, __dsl_pConstantData, Vector4fCount);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetPixelShaderConstantI"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(112)]
    public HResult GetPixelShaderConstantI(uint StartRegister, int* pConstantData, uint Vector4iCount) => LpVtbl->GetPixelShaderConstantI(StartRegister, pConstantData, Vector4iCount);
    [VtblIndex(112)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetPixelShaderConstantI(uint StartRegister, Ref<int> pConstantData, uint Vector4iCount)
    {
        fixed (int* __dsl_pConstantData = pConstantData)
        {
            return (HResult)GetPixelShaderConstantI(StartRegister, __dsl_pConstantData, Vector4iCount);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetRasterStatus"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HResult GetRasterStatus(uint iSwapChain, D3DrasterStatus* pRasterStatus) => LpVtbl->GetRasterStatus(iSwapChain, pRasterStatus);
    [VtblIndex(19)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetRasterStatus(uint iSwapChain, Ref<D3DrasterStatus> pRasterStatus)
    {
        fixed (D3DrasterStatus* __dsl_pRasterStatus = pRasterStatus)
        {
            return (HResult)GetRasterStatus(iSwapChain, __dsl_pRasterStatus);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetRenderState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HResult GetRenderState(D3Drenderstatetype State, [NativeTypeName("DWORD *")] uint* pValue) => LpVtbl->GetRenderState(State, pValue);
    [VtblIndex(58)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetRenderState(D3Drenderstatetype State, [NativeTypeName("DWORD *")] Ref<uint> pValue)
    {
        fixed (uint* __dsl_pValue = pValue)
        {
            return (HResult)GetRenderState(State, __dsl_pValue);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetRenderTarget"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HResult GetRenderTarget([NativeTypeName("DWORD")] uint RenderTargetIndex, IDirect3DSurface9* ppRenderTarget) => LpVtbl->GetRenderTarget(RenderTargetIndex, ppRenderTarget);
    [VtblIndex(38)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetRenderTarget([NativeTypeName("DWORD")] uint RenderTargetIndex, Ref<IDirect3DSurface9> ppRenderTarget)
    {
        fixed (IDirect3DSurface9* __dsl_ppRenderTarget = ppRenderTarget)
        {
            return (HResult)GetRenderTarget(RenderTargetIndex, __dsl_ppRenderTarget);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetRenderTargetData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HResult GetRenderTargetData(IDirect3DSurface9 pRenderTarget, IDirect3DSurface9 pDestSurface) => LpVtbl->GetRenderTargetData(pRenderTarget, pDestSurface);
    /// <inheritdoc cref = "IDirect3DDevice9.GetSamplerState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HResult GetSamplerState([NativeTypeName("DWORD")] uint Sampler, D3Dsamplerstatetype Type, [NativeTypeName("DWORD *")] uint* pValue) => LpVtbl->GetSamplerState(Sampler, Type, pValue);
    [VtblIndex(68)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetSamplerState([NativeTypeName("DWORD")] uint Sampler, D3Dsamplerstatetype Type, [NativeTypeName("DWORD *")] Ref<uint> pValue)
    {
        fixed (uint* __dsl_pValue = pValue)
        {
            return (HResult)GetSamplerState(Sampler, Type, __dsl_pValue);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetScissorRect"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(76)]
    public HResult GetScissorRect(RECT* pRect) => LpVtbl->GetScissorRect(pRect);
    [VtblIndex(76)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetScissorRect(Ref<RECT> pRect)
    {
        fixed (RECT* __dsl_pRect = pRect)
        {
            return (HResult)GetScissorRect(__dsl_pRect);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetSoftwareVertexProcessing"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(78)]
    [return: NativeTypeName("BOOL")]
    public MaybeBool<int> GetSoftwareVertexProcessing() => LpVtbl->GetSoftwareVertexProcessing();
    /// <inheritdoc cref = "IDirect3DDevice9.GetStreamSource"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(101)]
    public HResult GetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9* ppStreamData, uint* pOffsetInBytes, uint* pStride) => LpVtbl->GetStreamSource(StreamNumber, ppStreamData, pOffsetInBytes, pStride);
    [VtblIndex(101)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetStreamSource(uint StreamNumber, Ref<IDirect3DVertexBuffer9> ppStreamData, Ref<uint> pOffsetInBytes, Ref<uint> pStride)
    {
        fixed (uint* __dsl_pStride = pStride)
        fixed (uint* __dsl_pOffsetInBytes = pOffsetInBytes)
        fixed (IDirect3DVertexBuffer9* __dsl_ppStreamData = ppStreamData)
        {
            return (HResult)GetStreamSource(StreamNumber, __dsl_ppStreamData, __dsl_pOffsetInBytes, __dsl_pStride);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetStreamSourceFreq"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(103)]
    public HResult GetStreamSourceFreq(uint StreamNumber, uint* pSetting) => LpVtbl->GetStreamSourceFreq(StreamNumber, pSetting);
    [VtblIndex(103)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetStreamSourceFreq(uint StreamNumber, Ref<uint> pSetting)
    {
        fixed (uint* __dsl_pSetting = pSetting)
        {
            return (HResult)GetStreamSourceFreq(StreamNumber, __dsl_pSetting);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetSwapChain"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HResult GetSwapChain(uint iSwapChain, IDirect3DSwapChain9* pSwapChain) => LpVtbl->GetSwapChain(iSwapChain, pSwapChain);
    [VtblIndex(14)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetSwapChain(uint iSwapChain, Ref<IDirect3DSwapChain9> pSwapChain)
    {
        fixed (IDirect3DSwapChain9* __dsl_pSwapChain = pSwapChain)
        {
            return (HResult)GetSwapChain(iSwapChain, __dsl_pSwapChain);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetTexture"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HResult GetTexture([NativeTypeName("DWORD")] uint Stage, IDirect3DBaseTexture9* ppTexture) => LpVtbl->GetTexture(Stage, ppTexture);
    [VtblIndex(64)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetTexture([NativeTypeName("DWORD")] uint Stage, Ref<IDirect3DBaseTexture9> ppTexture)
    {
        fixed (IDirect3DBaseTexture9* __dsl_ppTexture = ppTexture)
        {
            return (HResult)GetTexture(Stage, __dsl_ppTexture);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetTextureStageState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HResult GetTextureStageState([NativeTypeName("DWORD")] uint Stage, D3Dtexturestagestatetype Type, [NativeTypeName("DWORD *")] uint* pValue) => LpVtbl->GetTextureStageState(Stage, Type, pValue);
    [VtblIndex(66)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetTextureStageState([NativeTypeName("DWORD")] uint Stage, D3Dtexturestagestatetype Type, [NativeTypeName("DWORD *")] Ref<uint> pValue)
    {
        fixed (uint* __dsl_pValue = pValue)
        {
            return (HResult)GetTextureStageState(Stage, Type, __dsl_pValue);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetTransform"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HResult GetTransform(D3Dtransformstatetype State, [NativeTypeName("D3DMATRIX *")] D2DMatrix4X4F* pMatrix) => LpVtbl->GetTransform(State, pMatrix);
    [VtblIndex(45)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetTransform(D3Dtransformstatetype State, [NativeTypeName("D3DMATRIX *")] Ref<D2DMatrix4X4F> pMatrix)
    {
        fixed (D2DMatrix4X4F* __dsl_pMatrix = pMatrix)
        {
            return (HResult)GetTransform(State, __dsl_pMatrix);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetVertexDeclaration"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(88)]
    public HResult GetVertexDeclaration(IDirect3DVertexDeclaration9* ppDecl) => LpVtbl->GetVertexDeclaration(ppDecl);
    [VtblIndex(88)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetVertexDeclaration(Ref<IDirect3DVertexDeclaration9> ppDecl)
    {
        fixed (IDirect3DVertexDeclaration9* __dsl_ppDecl = ppDecl)
        {
            return (HResult)GetVertexDeclaration(__dsl_ppDecl);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetVertexShader"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(93)]
    public HResult GetVertexShader(IDirect3DVertexShader9* ppShader) => LpVtbl->GetVertexShader(ppShader);
    [VtblIndex(93)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetVertexShader(Ref<IDirect3DVertexShader9> ppShader)
    {
        fixed (IDirect3DVertexShader9* __dsl_ppShader = ppShader)
        {
            return (HResult)GetVertexShader(__dsl_ppShader);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetVertexShaderConstantB"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(99)]
    public HResult GetVertexShaderConstantB(uint StartRegister, [NativeTypeName("BOOL *")] MaybeBool<int>* pConstantData, uint BoolCount) => LpVtbl->GetVertexShaderConstantB(StartRegister, pConstantData, BoolCount);
    [VtblIndex(99)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetVertexShaderConstantB(uint StartRegister, [NativeTypeName("BOOL *")] Ref<MaybeBool<int>> pConstantData, uint BoolCount)
    {
        fixed (MaybeBool<int>* __dsl_pConstantData = pConstantData)
        {
            return (HResult)GetVertexShaderConstantB(StartRegister, __dsl_pConstantData, BoolCount);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetVertexShaderConstantF"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(95)]
    public HResult GetVertexShaderConstantF(uint StartRegister, float* pConstantData, uint Vector4fCount) => LpVtbl->GetVertexShaderConstantF(StartRegister, pConstantData, Vector4fCount);
    [VtblIndex(95)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetVertexShaderConstantF(uint StartRegister, Ref<float> pConstantData, uint Vector4fCount)
    {
        fixed (float* __dsl_pConstantData = pConstantData)
        {
            return (HResult)GetVertexShaderConstantF(StartRegister, __dsl_pConstantData, Vector4fCount);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetVertexShaderConstantI"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(97)]
    public HResult GetVertexShaderConstantI(uint StartRegister, int* pConstantData, uint Vector4iCount) => LpVtbl->GetVertexShaderConstantI(StartRegister, pConstantData, Vector4iCount);
    [VtblIndex(97)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetVertexShaderConstantI(uint StartRegister, Ref<int> pConstantData, uint Vector4iCount)
    {
        fixed (int* __dsl_pConstantData = pConstantData)
        {
            return (HResult)GetVertexShaderConstantI(StartRegister, __dsl_pConstantData, Vector4iCount);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.GetViewport"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HResult GetViewport(D3Dviewport9* pViewport) => LpVtbl->GetViewport(pViewport);
    [VtblIndex(48)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetViewport(Ref<D3Dviewport9> pViewport)
    {
        fixed (D3Dviewport9* __dsl_pViewport = pViewport)
        {
            return (HResult)GetViewport(__dsl_pViewport);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.LightEnable"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HResult LightEnable([NativeTypeName("DWORD")] uint Index, [NativeTypeName("BOOL")] MaybeBool<int> Enable) => LpVtbl->LightEnable(Index, Enable);
    /// <inheritdoc cref = "IDirect3DDevice9.MultiplyTransform"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HResult MultiplyTransform(D3Dtransformstatetype param0, [NativeTypeName("const D3DMATRIX *")] D2DMatrix4X4F* param1) => LpVtbl->MultiplyTransform(param0, param1);
    [VtblIndex(46)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult MultiplyTransform(D3Dtransformstatetype param0, [NativeTypeName("const D3DMATRIX *")] Ref<D2DMatrix4X4F> param1)
    {
        fixed (D2DMatrix4X4F* __dsl_param1 = param1)
        {
            return (HResult)MultiplyTransform(param0, __dsl_param1);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.Present"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HResult Present([NativeTypeName("const RECT *")] RECT* pSourceRect, [NativeTypeName("const RECT *")] RECT* pDestRect, HWND hDestWindowOverride, [NativeTypeName("const RGNDATA *")] RGNDATA* pDirtyRegion) => LpVtbl->Present(pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion);
    [VtblIndex(17)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult Present([NativeTypeName("const RECT *")] Ref<RECT> pSourceRect, [NativeTypeName("const RECT *")] Ref<RECT> pDestRect, HWND hDestWindowOverride, [NativeTypeName("const RGNDATA *")] Ref<RGNDATA> pDirtyRegion)
    {
        fixed (RGNDATA* __dsl_pDirtyRegion = pDirtyRegion)
        fixed (RECT* __dsl_pDestRect = pDestRect)
        fixed (RECT* __dsl_pSourceRect = pSourceRect)
        {
            return (HResult)Present(__dsl_pSourceRect, __dsl_pDestRect, hDestWindowOverride, __dsl_pDirtyRegion);
        }
    }

    /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.PresentEx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(121)]
    public HResult PresentEx([NativeTypeName("const RECT *")] RECT* pSourceRect, [NativeTypeName("const RECT *")] RECT* pDestRect, HWND hDestWindowOverride, [NativeTypeName("const RGNDATA *")] RGNDATA* pDirtyRegion, [NativeTypeName("DWORD")] uint dwFlags) => LpVtbl->PresentEx(pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
    [VtblIndex(121)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult PresentEx([NativeTypeName("const RECT *")] Ref<RECT> pSourceRect, [NativeTypeName("const RECT *")] Ref<RECT> pDestRect, HWND hDestWindowOverride, [NativeTypeName("const RGNDATA *")] Ref<RGNDATA> pDirtyRegion, [NativeTypeName("DWORD")] uint dwFlags)
    {
        fixed (RGNDATA* __dsl_pDirtyRegion = pDirtyRegion)
        fixed (RECT* __dsl_pDestRect = pDestRect)
        fixed (RECT* __dsl_pSourceRect = pSourceRect)
        {
            return (HResult)PresentEx(__dsl_pSourceRect, __dsl_pDestRect, hDestWindowOverride, __dsl_pDirtyRegion, dwFlags);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.ProcessVertices"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(85)]
    public HResult ProcessVertices(uint SrcStartIndex, uint DestIndex, uint VertexCount, IDirect3DVertexBuffer9 pDestBuffer, IDirect3DVertexDeclaration9 pVertexDecl, [NativeTypeName("DWORD")] uint Flags) => LpVtbl->ProcessVertices(SrcStartIndex, DestIndex, VertexCount, pDestBuffer, pVertexDecl, Flags);
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

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release() => LpVtbl->Release();
    /// <inheritdoc cref = "IDirect3DDevice9.Reset"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HResult Reset(D3DpresentParameters* pPresentationParameters) => LpVtbl->Reset(pPresentationParameters);
    [VtblIndex(16)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult Reset(Ref<D3DpresentParameters> pPresentationParameters)
    {
        fixed (D3DpresentParameters* __dsl_pPresentationParameters = pPresentationParameters)
        {
            return (HResult)Reset(__dsl_pPresentationParameters);
        }
    }

    /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.ResetEx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(132)]
    public HResult ResetEx(D3DpresentParameters* pPresentationParameters, D3Ddisplaymodeex* pFullscreenDisplayMode) => LpVtbl->ResetEx(pPresentationParameters, pFullscreenDisplayMode);
    [VtblIndex(132)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult ResetEx(Ref<D3DpresentParameters> pPresentationParameters, Ref<D3Ddisplaymodeex> pFullscreenDisplayMode)
    {
        fixed (D3Ddisplaymodeex* __dsl_pFullscreenDisplayMode = pFullscreenDisplayMode)
        fixed (D3DpresentParameters* __dsl_pPresentationParameters = pPresentationParameters)
        {
            return (HResult)ResetEx(__dsl_pPresentationParameters, __dsl_pFullscreenDisplayMode);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.SetClipPlane"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HResult SetClipPlane([NativeTypeName("DWORD")] uint Index, [NativeTypeName("const float *")] float* pPlane) => LpVtbl->SetClipPlane(Index, pPlane);
    [VtblIndex(55)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetClipPlane([NativeTypeName("DWORD")] uint Index, [NativeTypeName("const float *")] Ref<float> pPlane)
    {
        fixed (float* __dsl_pPlane = pPlane)
        {
            return (HResult)SetClipPlane(Index, __dsl_pPlane);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.SetClipStatus"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HResult SetClipStatus([NativeTypeName("const D3DCLIPSTATUS9 *")] D3Dclipstatus9* pClipStatus) => LpVtbl->SetClipStatus(pClipStatus);
    [VtblIndex(62)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetClipStatus([NativeTypeName("const D3DCLIPSTATUS9 *")] Ref<D3Dclipstatus9> pClipStatus)
    {
        fixed (D3Dclipstatus9* __dsl_pClipStatus = pClipStatus)
        {
            return (HResult)SetClipStatus(__dsl_pClipStatus);
        }
    }

    /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.SetConvolutionMonoKernel"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(119)]
    public HResult SetConvolutionMonoKernel(uint width, uint height, float* rows, float* columns) => LpVtbl->SetConvolutionMonoKernel(width, height, rows, columns);
    [VtblIndex(119)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetConvolutionMonoKernel(uint width, uint height, Ref<float> rows, Ref<float> columns)
    {
        fixed (float* __dsl_columns = columns)
        fixed (float* __dsl_rows = rows)
        {
            return (HResult)SetConvolutionMonoKernel(width, height, __dsl_rows, __dsl_columns);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.SetCurrentTexturePalette"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public HResult SetCurrentTexturePalette(uint PaletteNumber) => LpVtbl->SetCurrentTexturePalette(PaletteNumber);
    /// <inheritdoc cref = "IDirect3DDevice9.SetCursorPosition"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void SetCursorPosition(int X, int Y, [NativeTypeName("DWORD")] uint Flags) => LpVtbl->SetCursorPosition(X, Y, Flags);
    /// <inheritdoc cref = "IDirect3DDevice9.SetCursorProperties"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HResult SetCursorProperties(uint XHotSpot, uint YHotSpot, IDirect3DSurface9 pCursorBitmap) => LpVtbl->SetCursorProperties(XHotSpot, YHotSpot, pCursorBitmap);
    /// <inheritdoc cref = "IDirect3DDevice9.SetDepthStencilSurface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HResult SetDepthStencilSurface(IDirect3DSurface9 pNewZStencil) => LpVtbl->SetDepthStencilSurface(pNewZStencil);
    /// <inheritdoc cref = "IDirect3DDevice9.SetDialogBoxMode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HResult SetDialogBoxMode([NativeTypeName("BOOL")] MaybeBool<int> bEnableDialogs) => LpVtbl->SetDialogBoxMode(bEnableDialogs);
    /// <inheritdoc cref = "IDirect3DDevice9.SetFVF"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(89)]
    public HResult SetFVF([NativeTypeName("DWORD")] uint FVF) => LpVtbl->SetFVF(FVF);
    /// <inheritdoc cref = "IDirect3DDevice9.SetGammaRamp"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public void SetGammaRamp(uint iSwapChain, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("const D3DGAMMARAMP *")] D3Dgammaramp* pRamp) => LpVtbl->SetGammaRamp(iSwapChain, Flags, pRamp);
    [VtblIndex(21)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void SetGammaRamp(uint iSwapChain, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("const D3DGAMMARAMP *")] Ref<D3Dgammaramp> pRamp)
    {
        fixed (D3Dgammaramp* __dsl_pRamp = pRamp)
        {
            SetGammaRamp(iSwapChain, Flags, __dsl_pRamp);
        }
    }

    /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.SetGPUThreadPriority"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(123)]
    public HResult SetGPUThreadPriority(int Priority) => LpVtbl->SetGPUThreadPriority(Priority);
    /// <inheritdoc cref = "IDirect3DDevice9.SetIndices"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(104)]
    public HResult SetIndices(IDirect3DIndexBuffer9 pIndexData) => LpVtbl->SetIndices(pIndexData);
    /// <inheritdoc cref = "IDirect3DDevice9.SetLight"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HResult SetLight([NativeTypeName("DWORD")] uint Index, [NativeTypeName("const D3DLIGHT9 *")] D3Dlight9* param1) => LpVtbl->SetLight(Index, param1);
    [VtblIndex(51)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetLight([NativeTypeName("DWORD")] uint Index, [NativeTypeName("const D3DLIGHT9 *")] Ref<D3Dlight9> param1)
    {
        fixed (D3Dlight9* __dsl_param1 = param1)
        {
            return (HResult)SetLight(Index, __dsl_param1);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.SetMaterial"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HResult SetMaterial([NativeTypeName("const D3DMATERIAL9 *")] D3Dmaterial9* pMaterial) => LpVtbl->SetMaterial(pMaterial);
    [VtblIndex(49)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetMaterial([NativeTypeName("const D3DMATERIAL9 *")] Ref<D3Dmaterial9> pMaterial)
    {
        fixed (D3Dmaterial9* __dsl_pMaterial = pMaterial)
        {
            return (HResult)SetMaterial(__dsl_pMaterial);
        }
    }

    /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.SetMaximumFrameLatency"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(126)]
    public HResult SetMaximumFrameLatency(uint MaxLatency) => LpVtbl->SetMaximumFrameLatency(MaxLatency);
    /// <inheritdoc cref = "IDirect3DDevice9.SetNPatchMode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(79)]
    public HResult SetNPatchMode(float nSegments) => LpVtbl->SetNPatchMode(nSegments);
    /// <inheritdoc cref = "IDirect3DDevice9.SetPaletteEntries"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public HResult SetPaletteEntries(uint PaletteNumber, [NativeTypeName("const PALETTEENTRY *")] PALETTEENTRY* pEntries) => LpVtbl->SetPaletteEntries(PaletteNumber, pEntries);
    [VtblIndex(71)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetPaletteEntries(uint PaletteNumber, [NativeTypeName("const PALETTEENTRY *")] Ref<PALETTEENTRY> pEntries)
    {
        fixed (PALETTEENTRY* __dsl_pEntries = pEntries)
        {
            return (HResult)SetPaletteEntries(PaletteNumber, __dsl_pEntries);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.SetPixelShader"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(107)]
    public HResult SetPixelShader(IDirect3DPixelShader9 pShader) => LpVtbl->SetPixelShader(pShader);
    /// <inheritdoc cref = "IDirect3DDevice9.SetPixelShaderConstantB"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(113)]
    public HResult SetPixelShaderConstantB(uint StartRegister, [NativeTypeName("const BOOL *")] MaybeBool<int>* pConstantData, uint BoolCount) => LpVtbl->SetPixelShaderConstantB(StartRegister, pConstantData, BoolCount);
    [VtblIndex(113)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetPixelShaderConstantB(uint StartRegister, [NativeTypeName("const BOOL *")] Ref<MaybeBool<int>> pConstantData, uint BoolCount)
    {
        fixed (MaybeBool<int>* __dsl_pConstantData = pConstantData)
        {
            return (HResult)SetPixelShaderConstantB(StartRegister, __dsl_pConstantData, BoolCount);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.SetPixelShaderConstantF"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(109)]
    public HResult SetPixelShaderConstantF(uint StartRegister, [NativeTypeName("const float *")] float* pConstantData, uint Vector4fCount) => LpVtbl->SetPixelShaderConstantF(StartRegister, pConstantData, Vector4fCount);
    [VtblIndex(109)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetPixelShaderConstantF(uint StartRegister, [NativeTypeName("const float *")] Ref<float> pConstantData, uint Vector4fCount)
    {
        fixed (float* __dsl_pConstantData = pConstantData)
        {
            return (HResult)SetPixelShaderConstantF(StartRegister, __dsl_pConstantData, Vector4fCount);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.SetPixelShaderConstantI"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(111)]
    public HResult SetPixelShaderConstantI(uint StartRegister, [NativeTypeName("const int *")] int* pConstantData, uint Vector4iCount) => LpVtbl->SetPixelShaderConstantI(StartRegister, pConstantData, Vector4iCount);
    [VtblIndex(111)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetPixelShaderConstantI(uint StartRegister, [NativeTypeName("const int *")] Ref<int> pConstantData, uint Vector4iCount)
    {
        fixed (int* __dsl_pConstantData = pConstantData)
        {
            return (HResult)SetPixelShaderConstantI(StartRegister, __dsl_pConstantData, Vector4iCount);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.SetRenderState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HResult SetRenderState(D3Drenderstatetype State, [NativeTypeName("DWORD")] uint Value) => LpVtbl->SetRenderState(State, Value);
    /// <inheritdoc cref = "IDirect3DDevice9.SetRenderTarget"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HResult SetRenderTarget([NativeTypeName("DWORD")] uint RenderTargetIndex, IDirect3DSurface9 pRenderTarget) => LpVtbl->SetRenderTarget(RenderTargetIndex, pRenderTarget);
    /// <inheritdoc cref = "IDirect3DDevice9.SetSamplerState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HResult SetSamplerState([NativeTypeName("DWORD")] uint Sampler, D3Dsamplerstatetype Type, [NativeTypeName("DWORD")] uint Value) => LpVtbl->SetSamplerState(Sampler, Type, Value);
    /// <inheritdoc cref = "IDirect3DDevice9.SetScissorRect"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public HResult SetScissorRect([NativeTypeName("const RECT *")] RECT* pRect) => LpVtbl->SetScissorRect(pRect);
    [VtblIndex(75)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetScissorRect([NativeTypeName("const RECT *")] Ref<RECT> pRect)
    {
        fixed (RECT* __dsl_pRect = pRect)
        {
            return (HResult)SetScissorRect(__dsl_pRect);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.SetSoftwareVertexProcessing"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(77)]
    public HResult SetSoftwareVertexProcessing([NativeTypeName("BOOL")] MaybeBool<int> bSoftware) => LpVtbl->SetSoftwareVertexProcessing(bSoftware);
    /// <inheritdoc cref = "IDirect3DDevice9.SetStreamSource"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(100)]
    public HResult SetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9 pStreamData, uint OffsetInBytes, uint Stride) => LpVtbl->SetStreamSource(StreamNumber, pStreamData, OffsetInBytes, Stride);
    /// <inheritdoc cref = "IDirect3DDevice9.SetStreamSourceFreq"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(102)]
    public HResult SetStreamSourceFreq(uint StreamNumber, uint Setting) => LpVtbl->SetStreamSourceFreq(StreamNumber, Setting);
    /// <inheritdoc cref = "IDirect3DDevice9.SetTexture"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HResult SetTexture([NativeTypeName("DWORD")] uint Stage, IDirect3DBaseTexture9 pTexture) => LpVtbl->SetTexture(Stage, pTexture);
    /// <inheritdoc cref = "IDirect3DDevice9.SetTextureStageState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HResult SetTextureStageState([NativeTypeName("DWORD")] uint Stage, D3Dtexturestagestatetype Type, [NativeTypeName("DWORD")] uint Value) => LpVtbl->SetTextureStageState(Stage, Type, Value);
    /// <inheritdoc cref = "IDirect3DDevice9.SetTransform"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HResult SetTransform(D3Dtransformstatetype State, [NativeTypeName("const D3DMATRIX *")] D2DMatrix4X4F* pMatrix) => LpVtbl->SetTransform(State, pMatrix);
    [VtblIndex(44)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetTransform(D3Dtransformstatetype State, [NativeTypeName("const D3DMATRIX *")] Ref<D2DMatrix4X4F> pMatrix)
    {
        fixed (D2DMatrix4X4F* __dsl_pMatrix = pMatrix)
        {
            return (HResult)SetTransform(State, __dsl_pMatrix);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.SetVertexDeclaration"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(87)]
    public HResult SetVertexDeclaration(IDirect3DVertexDeclaration9 pDecl) => LpVtbl->SetVertexDeclaration(pDecl);
    /// <inheritdoc cref = "IDirect3DDevice9.SetVertexShader"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(92)]
    public HResult SetVertexShader(IDirect3DVertexShader9 pShader) => LpVtbl->SetVertexShader(pShader);
    /// <inheritdoc cref = "IDirect3DDevice9.SetVertexShaderConstantB"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(98)]
    public HResult SetVertexShaderConstantB(uint StartRegister, [NativeTypeName("const BOOL *")] MaybeBool<int>* pConstantData, uint BoolCount) => LpVtbl->SetVertexShaderConstantB(StartRegister, pConstantData, BoolCount);
    [VtblIndex(98)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetVertexShaderConstantB(uint StartRegister, [NativeTypeName("const BOOL *")] Ref<MaybeBool<int>> pConstantData, uint BoolCount)
    {
        fixed (MaybeBool<int>* __dsl_pConstantData = pConstantData)
        {
            return (HResult)SetVertexShaderConstantB(StartRegister, __dsl_pConstantData, BoolCount);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.SetVertexShaderConstantF"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(94)]
    public HResult SetVertexShaderConstantF(uint StartRegister, [NativeTypeName("const float *")] float* pConstantData, uint Vector4fCount) => LpVtbl->SetVertexShaderConstantF(StartRegister, pConstantData, Vector4fCount);
    [VtblIndex(94)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetVertexShaderConstantF(uint StartRegister, [NativeTypeName("const float *")] Ref<float> pConstantData, uint Vector4fCount)
    {
        fixed (float* __dsl_pConstantData = pConstantData)
        {
            return (HResult)SetVertexShaderConstantF(StartRegister, __dsl_pConstantData, Vector4fCount);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.SetVertexShaderConstantI"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(96)]
    public HResult SetVertexShaderConstantI(uint StartRegister, [NativeTypeName("const int *")] int* pConstantData, uint Vector4iCount) => LpVtbl->SetVertexShaderConstantI(StartRegister, pConstantData, Vector4iCount);
    [VtblIndex(96)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetVertexShaderConstantI(uint StartRegister, [NativeTypeName("const int *")] Ref<int> pConstantData, uint Vector4iCount)
    {
        fixed (int* __dsl_pConstantData = pConstantData)
        {
            return (HResult)SetVertexShaderConstantI(StartRegister, __dsl_pConstantData, Vector4iCount);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.SetViewport"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HResult SetViewport([NativeTypeName("const D3DVIEWPORT9 *")] D3Dviewport9* pViewport) => LpVtbl->SetViewport(pViewport);
    [VtblIndex(47)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetViewport([NativeTypeName("const D3DVIEWPORT9 *")] Ref<D3Dviewport9> pViewport)
    {
        fixed (D3Dviewport9* __dsl_pViewport = pViewport)
        {
            return (HResult)SetViewport(__dsl_pViewport);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.ShowCursor"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [return: NativeTypeName("BOOL")]
    public MaybeBool<int> ShowCursor([NativeTypeName("BOOL")] MaybeBool<int> bShow) => LpVtbl->ShowCursor(bShow);
    /// <inheritdoc cref = "IDirect3DDevice9.StretchRect"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HResult StretchRect(IDirect3DSurface9 pSourceSurface, [NativeTypeName("const RECT *")] RECT* pSourceRect, IDirect3DSurface9 pDestSurface, [NativeTypeName("const RECT *")] RECT* pDestRect, D3Dtexturefiltertype Filter) => LpVtbl->StretchRect(pSourceSurface, pSourceRect, pDestSurface, pDestRect, Filter);
    [VtblIndex(34)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult StretchRect(IDirect3DSurface9 pSourceSurface, [NativeTypeName("const RECT *")] Ref<RECT> pSourceRect, IDirect3DSurface9 pDestSurface, [NativeTypeName("const RECT *")] Ref<RECT> pDestRect, D3Dtexturefiltertype Filter)
    {
        fixed (RECT* __dsl_pDestRect = pDestRect)
        fixed (RECT* __dsl_pSourceRect = pSourceRect)
        {
            return (HResult)StretchRect(pSourceSurface, __dsl_pSourceRect, pDestSurface, __dsl_pDestRect, Filter);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.TestCooperativeLevel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult TestCooperativeLevel() => LpVtbl->TestCooperativeLevel();
    /// <inheritdoc cref = "IDirect3DDevice9.UpdateSurface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HResult UpdateSurface(IDirect3DSurface9 pSourceSurface, [NativeTypeName("const RECT *")] RECT* pSourceRect, IDirect3DSurface9 pDestinationSurface, [NativeTypeName("const POINT *")] Point* pDestPoint) => LpVtbl->UpdateSurface(pSourceSurface, pSourceRect, pDestinationSurface, pDestPoint);
    [VtblIndex(30)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult UpdateSurface(IDirect3DSurface9 pSourceSurface, [NativeTypeName("const RECT *")] Ref<RECT> pSourceRect, IDirect3DSurface9 pDestinationSurface, [NativeTypeName("const POINT *")] Ref<Point> pDestPoint)
    {
        fixed (Point* __dsl_pDestPoint = pDestPoint)
        fixed (RECT* __dsl_pSourceRect = pSourceRect)
        {
            return (HResult)UpdateSurface(pSourceSurface, __dsl_pSourceRect, pDestinationSurface, __dsl_pDestPoint);
        }
    }

    /// <inheritdoc cref = "IDirect3DDevice9.UpdateTexture"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HResult UpdateTexture(IDirect3DBaseTexture9 pSourceTexture, IDirect3DBaseTexture9 pDestinationTexture) => LpVtbl->UpdateTexture(pSourceTexture, pDestinationTexture);
    /// <inheritdoc cref = "IDirect3DDevice9.ValidateDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HResult ValidateDevice([NativeTypeName("DWORD *")] uint* pNumPasses) => LpVtbl->ValidateDevice(pNumPasses);
    [VtblIndex(70)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult ValidateDevice([NativeTypeName("DWORD *")] Ref<uint> pNumPasses)
    {
        fixed (uint* __dsl_pNumPasses = pNumPasses)
        {
            return (HResult)ValidateDevice(__dsl_pNumPasses);
        }
    }

    /// <include file='IDirect3DDevice9Ex.xml' path='doc/member[@name="IDirect3DDevice9Ex.WaitForVBlank"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(124)]
    public HResult WaitForVBlank(uint iSwapChain) => LpVtbl->WaitForVBlank(iSwapChain);
}