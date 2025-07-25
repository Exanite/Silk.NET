// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12VideoDevice.xml' path='doc/member[@name="ID3D12VideoDevice"]/*'/>
[Guid("1F052807-0B46-4ACC-8A89-364F793718A4")]
[NativeTypeName("struct ID3D12VideoDevice : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12VideoDevice : ID3D12VideoDevice.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12VideoDevice));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HResult CheckFeatureSupport(D3D12FeatureVideo FeatureVideo, void* pFeatureSupportData, uint FeatureSupportDataSize);
        [VtblIndex(3)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CheckFeatureSupport(D3D12FeatureVideo FeatureVideo, Ref pFeatureSupportData, uint FeatureSupportDataSize);
        [VtblIndex(4)]
        HResult CreateVideoDecoder([NativeTypeName("const D3D12_VIDEO_DECODER_DESC *")] D3D12VideoDecoderDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoDecoder);
        [VtblIndex(4)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateVideoDecoder([NativeTypeName("const D3D12_VIDEO_DECODER_DESC *")] Ref<D3D12VideoDecoderDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoDecoder);
        [VtblIndex(5)]
        HResult CreateVideoDecoderHeap([NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")] D3D12VideoDecoderHeapDesc* pVideoDecoderHeapDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoDecoderHeap);
        [VtblIndex(5)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateVideoDecoderHeap([NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")] Ref<D3D12VideoDecoderHeapDesc> pVideoDecoderHeapDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoDecoderHeap);
        [VtblIndex(6)]
        HResult CreateVideoProcessor(uint NodeMask, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")] D3D12VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")] D3D12VideoProcessInputStreamDesc* pInputStreamDescs, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoProcessor);
        [VtblIndex(6)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateVideoProcessor(uint NodeMask, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")] Ref<D3D12VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")] Ref<D3D12VideoProcessInputStreamDesc> pInputStreamDescs, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoProcessor);
    }

    /// <include file='ID3D12VideoDevice.xml' path='doc/member[@name="ID3D12VideoDevice"]/*'/>
    [Guid("1F052807-0B46-4ACC-8A89-364F793718A4")]
    [NativeTypeName("struct ID3D12VideoDevice : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12VideoDevice));

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
            [NativeTypeName("HRESULT (D3D12_FEATURE_VIDEO, void *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12FeatureVideo, void*, uint, HResult> CheckFeatureSupport;
            [NativeTypeName("HRESULT (const D3D12_VIDEO_DECODER_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12VideoDecoderDesc*, Guid*, void**, HResult> CreateVideoDecoder;
            [NativeTypeName("HRESULT (const D3D12_VIDEO_DECODER_HEAP_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12VideoDecoderHeapDesc*, Guid*, void**, HResult> CreateVideoDecoderHeap;
            [NativeTypeName("HRESULT (UINT, const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *, UINT, const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3D12VideoProcessOutputStreamDesc*, uint, D3D12VideoProcessInputStreamDesc*, Guid*, void**, HResult> CreateVideoProcessor;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12VideoDevice.Native*, uint> )(lpVtbl[1]))((ID3D12VideoDevice.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12VideoDevice.xml' path='doc/member[@name="ID3D12VideoDevice.CheckFeatureSupport"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult CheckFeatureSupport(D3D12FeatureVideo FeatureVideo, void* pFeatureSupportData, uint FeatureSupportDataSize)
        {
            return ((delegate* unmanaged<ID3D12VideoDevice.Native*, D3D12FeatureVideo, void*, uint, HResult> )(lpVtbl[3]))((ID3D12VideoDevice.Native*)Unsafe.AsPointer(ref this), FeatureVideo, pFeatureSupportData, FeatureSupportDataSize);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CheckFeatureSupport(D3D12FeatureVideo FeatureVideo, Ref pFeatureSupportData, uint FeatureSupportDataSize)
        {
            fixed (void* __dsl_pFeatureSupportData = pFeatureSupportData)
            {
                return (HResult)CheckFeatureSupport(FeatureVideo, __dsl_pFeatureSupportData, FeatureSupportDataSize);
            }
        }

        /// <include file='ID3D12VideoDevice.xml' path='doc/member[@name="ID3D12VideoDevice.CreateVideoDecoder"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult CreateVideoDecoder([NativeTypeName("const D3D12_VIDEO_DECODER_DESC *")] D3D12VideoDecoderDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoDecoder)
        {
            return ((delegate* unmanaged<ID3D12VideoDevice.Native*, D3D12VideoDecoderDesc*, Guid*, void**, HResult> )(lpVtbl[4]))((ID3D12VideoDevice.Native*)Unsafe.AsPointer(ref this), pDesc, riid, ppVideoDecoder);
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVideoDecoder([NativeTypeName("const D3D12_VIDEO_DECODER_DESC *")] Ref<D3D12VideoDecoderDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoDecoder)
        {
            fixed (void** __dsl_ppVideoDecoder = ppVideoDecoder)
            fixed (Guid* __dsl_riid = riid)
            fixed (D3D12VideoDecoderDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)CreateVideoDecoder(__dsl_pDesc, __dsl_riid, __dsl_ppVideoDecoder);
            }
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVideoDecoder<TCom>([NativeTypeName("const D3D12_VIDEO_DECODER_DESC *")] Ref<D3D12VideoDecoderDesc> pDesc, out TCom ppVideoDecoder)
            where TCom : unmanaged, IComVtbl
        {
            fixed (D3D12VideoDecoderDesc* __dsl_pDesc = pDesc)
            {
                ppVideoDecoder = default;
                return CreateVideoDecoder(__dsl_pDesc, TCom.NativeGuid, ppVideoDecoder.GetAddressOf());
            }
        }

        /// <include file='ID3D12VideoDevice.xml' path='doc/member[@name="ID3D12VideoDevice.CreateVideoDecoderHeap"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult CreateVideoDecoderHeap([NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")] D3D12VideoDecoderHeapDesc* pVideoDecoderHeapDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoDecoderHeap)
        {
            return ((delegate* unmanaged<ID3D12VideoDevice.Native*, D3D12VideoDecoderHeapDesc*, Guid*, void**, HResult> )(lpVtbl[5]))((ID3D12VideoDevice.Native*)Unsafe.AsPointer(ref this), pVideoDecoderHeapDesc, riid, ppVideoDecoderHeap);
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVideoDecoderHeap([NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")] Ref<D3D12VideoDecoderHeapDesc> pVideoDecoderHeapDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoDecoderHeap)
        {
            fixed (void** __dsl_ppVideoDecoderHeap = ppVideoDecoderHeap)
            fixed (Guid* __dsl_riid = riid)
            fixed (D3D12VideoDecoderHeapDesc* __dsl_pVideoDecoderHeapDesc = pVideoDecoderHeapDesc)
            {
                return (HResult)CreateVideoDecoderHeap(__dsl_pVideoDecoderHeapDesc, __dsl_riid, __dsl_ppVideoDecoderHeap);
            }
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVideoDecoderHeap<TCom>([NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")] Ref<D3D12VideoDecoderHeapDesc> pVideoDecoderHeapDesc, out TCom ppVideoDecoderHeap)
            where TCom : unmanaged, IComVtbl
        {
            fixed (D3D12VideoDecoderHeapDesc* __dsl_pVideoDecoderHeapDesc = pVideoDecoderHeapDesc)
            {
                ppVideoDecoderHeap = default;
                return CreateVideoDecoderHeap(__dsl_pVideoDecoderHeapDesc, TCom.NativeGuid, ppVideoDecoderHeap.GetAddressOf());
            }
        }

        /// <include file='ID3D12VideoDevice.xml' path='doc/member[@name="ID3D12VideoDevice.CreateVideoProcessor"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult CreateVideoProcessor(uint NodeMask, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")] D3D12VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")] D3D12VideoProcessInputStreamDesc* pInputStreamDescs, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoProcessor)
        {
            return ((delegate* unmanaged<ID3D12VideoDevice.Native*, uint, D3D12VideoProcessOutputStreamDesc*, uint, D3D12VideoProcessInputStreamDesc*, Guid*, void**, HResult> )(lpVtbl[6]))((ID3D12VideoDevice.Native*)Unsafe.AsPointer(ref this), NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessor);
        }

        [VtblIndex(6)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVideoProcessor(uint NodeMask, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")] Ref<D3D12VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")] Ref<D3D12VideoProcessInputStreamDesc> pInputStreamDescs, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoProcessor)
        {
            fixed (void** __dsl_ppVideoProcessor = ppVideoProcessor)
            fixed (Guid* __dsl_riid = riid)
            fixed (D3D12VideoProcessInputStreamDesc* __dsl_pInputStreamDescs = pInputStreamDescs)
            fixed (D3D12VideoProcessOutputStreamDesc* __dsl_pOutputStreamDesc = pOutputStreamDesc)
            {
                return (HResult)CreateVideoProcessor(NodeMask, __dsl_pOutputStreamDesc, NumInputStreamDescs, __dsl_pInputStreamDescs, __dsl_riid, __dsl_ppVideoProcessor);
            }
        }

        [VtblIndex(6)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVideoProcessor<TCom>(uint NodeMask, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")] Ref<D3D12VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")] Ref<D3D12VideoProcessInputStreamDesc> pInputStreamDescs, out TCom ppVideoProcessor)
            where TCom : unmanaged, IComVtbl
        {
            fixed (D3D12VideoProcessInputStreamDesc* __dsl_pInputStreamDescs = pInputStreamDescs)
            fixed (D3D12VideoProcessOutputStreamDesc* __dsl_pOutputStreamDesc = pOutputStreamDesc)
            {
                ppVideoProcessor = default;
                return CreateVideoProcessor(NodeMask, __dsl_pOutputStreamDesc, NumInputStreamDescs, __dsl_pInputStreamDescs, TCom.NativeGuid, ppVideoProcessor.GetAddressOf());
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12VideoDevice.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12VideoDevice.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12VideoDevice.Native*, uint> )(lpVtbl[2]))((ID3D12VideoDevice.Native*)Unsafe.AsPointer(ref this));
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12VideoDevice"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12VideoDevice(Ptr3D vtbl) => LpVtbl = (ID3D12VideoDevice.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12VideoDevice"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12VideoDevice(Ptr<ID3D12VideoDevice.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12VideoDevice.Native"/> to <see cref = "ID3D12VideoDevice"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDevice.Native"/> instance to be converted </param>
    public static implicit operator ID3D12VideoDevice(ID3D12VideoDevice.Native* value) => new ID3D12VideoDevice((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12VideoDevice"/> to <see cref = "ID3D12VideoDevice.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDevice"/> instance to be converted </param>
    public static implicit operator ID3D12VideoDevice.Native*(ID3D12VideoDevice value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12VideoDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12VideoDevice(Ptr3D value) => new ID3D12VideoDevice(value);
    /// <summary>casts <see cref = "ID3D12VideoDevice"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDevice"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12VideoDevice value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12VideoDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12VideoDevice(Ptr<ID3D12VideoDevice.Native> value) => new ID3D12VideoDevice(value);
    /// <summary>casts <see cref = "ID3D12VideoDevice"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDevice"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12VideoDevice.Native>(ID3D12VideoDevice value) => (Ptr<ID3D12VideoDevice.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12VideoDevice"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12VideoDevice(void*** value) => new ID3D12VideoDevice((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12VideoDevice"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDevice"/> instance to be converted </param>
    public static implicit operator void***(ID3D12VideoDevice value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12VideoDevice"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12VideoDevice(nuint value) => new ID3D12VideoDevice((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12VideoDevice"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDevice"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12VideoDevice value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='ID3D12VideoDevice.xml' path='doc/member[@name="ID3D12VideoDevice.CheckFeatureSupport"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult CheckFeatureSupport(D3D12FeatureVideo FeatureVideo, void* pFeatureSupportData, uint FeatureSupportDataSize) => LpVtbl->CheckFeatureSupport(FeatureVideo, pFeatureSupportData, FeatureSupportDataSize);
    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CheckFeatureSupport(D3D12FeatureVideo FeatureVideo, Ref pFeatureSupportData, uint FeatureSupportDataSize)
    {
        fixed (void* __dsl_pFeatureSupportData = pFeatureSupportData)
        {
            return (HResult)CheckFeatureSupport(FeatureVideo, __dsl_pFeatureSupportData, FeatureSupportDataSize);
        }
    }

    /// <include file='ID3D12VideoDevice.xml' path='doc/member[@name="ID3D12VideoDevice.CreateVideoDecoder"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult CreateVideoDecoder([NativeTypeName("const D3D12_VIDEO_DECODER_DESC *")] D3D12VideoDecoderDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoDecoder) => LpVtbl->CreateVideoDecoder(pDesc, riid, ppVideoDecoder);
    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVideoDecoder([NativeTypeName("const D3D12_VIDEO_DECODER_DESC *")] Ref<D3D12VideoDecoderDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoDecoder)
    {
        fixed (void** __dsl_ppVideoDecoder = ppVideoDecoder)
        fixed (Guid* __dsl_riid = riid)
        fixed (D3D12VideoDecoderDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)CreateVideoDecoder(__dsl_pDesc, __dsl_riid, __dsl_ppVideoDecoder);
        }
    }

    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVideoDecoder<TCom>([NativeTypeName("const D3D12_VIDEO_DECODER_DESC *")] Ref<D3D12VideoDecoderDesc> pDesc, out TCom ppVideoDecoder)
        where TCom : unmanaged, IComVtbl
    {
        fixed (D3D12VideoDecoderDesc* __dsl_pDesc = pDesc)
        {
            ppVideoDecoder = default;
            return CreateVideoDecoder(__dsl_pDesc, TCom.NativeGuid, ppVideoDecoder.GetAddressOf());
        }
    }

    /// <include file='ID3D12VideoDevice.xml' path='doc/member[@name="ID3D12VideoDevice.CreateVideoDecoderHeap"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult CreateVideoDecoderHeap([NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")] D3D12VideoDecoderHeapDesc* pVideoDecoderHeapDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoDecoderHeap) => LpVtbl->CreateVideoDecoderHeap(pVideoDecoderHeapDesc, riid, ppVideoDecoderHeap);
    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVideoDecoderHeap([NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")] Ref<D3D12VideoDecoderHeapDesc> pVideoDecoderHeapDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoDecoderHeap)
    {
        fixed (void** __dsl_ppVideoDecoderHeap = ppVideoDecoderHeap)
        fixed (Guid* __dsl_riid = riid)
        fixed (D3D12VideoDecoderHeapDesc* __dsl_pVideoDecoderHeapDesc = pVideoDecoderHeapDesc)
        {
            return (HResult)CreateVideoDecoderHeap(__dsl_pVideoDecoderHeapDesc, __dsl_riid, __dsl_ppVideoDecoderHeap);
        }
    }

    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVideoDecoderHeap<TCom>([NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")] Ref<D3D12VideoDecoderHeapDesc> pVideoDecoderHeapDesc, out TCom ppVideoDecoderHeap)
        where TCom : unmanaged, IComVtbl
    {
        fixed (D3D12VideoDecoderHeapDesc* __dsl_pVideoDecoderHeapDesc = pVideoDecoderHeapDesc)
        {
            ppVideoDecoderHeap = default;
            return CreateVideoDecoderHeap(__dsl_pVideoDecoderHeapDesc, TCom.NativeGuid, ppVideoDecoderHeap.GetAddressOf());
        }
    }

    /// <include file='ID3D12VideoDevice.xml' path='doc/member[@name="ID3D12VideoDevice.CreateVideoProcessor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult CreateVideoProcessor(uint NodeMask, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")] D3D12VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")] D3D12VideoProcessInputStreamDesc* pInputStreamDescs, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoProcessor) => LpVtbl->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessor);
    [VtblIndex(6)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVideoProcessor(uint NodeMask, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")] Ref<D3D12VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")] Ref<D3D12VideoProcessInputStreamDesc> pInputStreamDescs, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoProcessor)
    {
        fixed (void** __dsl_ppVideoProcessor = ppVideoProcessor)
        fixed (Guid* __dsl_riid = riid)
        fixed (D3D12VideoProcessInputStreamDesc* __dsl_pInputStreamDescs = pInputStreamDescs)
        fixed (D3D12VideoProcessOutputStreamDesc* __dsl_pOutputStreamDesc = pOutputStreamDesc)
        {
            return (HResult)CreateVideoProcessor(NodeMask, __dsl_pOutputStreamDesc, NumInputStreamDescs, __dsl_pInputStreamDescs, __dsl_riid, __dsl_ppVideoProcessor);
        }
    }

    [VtblIndex(6)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVideoProcessor<TCom>(uint NodeMask, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")] Ref<D3D12VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")] Ref<D3D12VideoProcessInputStreamDesc> pInputStreamDescs, out TCom ppVideoProcessor)
        where TCom : unmanaged, IComVtbl
    {
        fixed (D3D12VideoProcessInputStreamDesc* __dsl_pInputStreamDescs = pInputStreamDescs)
        fixed (D3D12VideoProcessOutputStreamDesc* __dsl_pOutputStreamDesc = pOutputStreamDesc)
        {
            ppVideoProcessor = default;
            return CreateVideoProcessor(NodeMask, __dsl_pOutputStreamDesc, NumInputStreamDescs, __dsl_pInputStreamDescs, TCom.NativeGuid, ppVideoProcessor.GetAddressOf());
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

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release() => LpVtbl->Release();
}