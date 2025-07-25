// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12InfoQueue1.xml' path='doc/member[@name="ID3D12InfoQueue1"]/*'/>
[Guid("2852DD88-B484-4C0C-B6B1-67168500E600")]
[NativeTypeName("struct ID3D12InfoQueue1 : ID3D12InfoQueue")]
[NativeInheritance("ID3D12InfoQueue")]
public unsafe partial struct ID3D12InfoQueue1 : ID3D12InfoQueue1.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12InfoQueue1));

    public interface Interface : ID3D12InfoQueue.Interface
    {
        [VtblIndex(39)]
        HResult UnregisterMessageCallback([NativeTypeName("DWORD")] uint CallbackCookie);
    }

    /// <include file='ID3D12InfoQueue1.xml' path='doc/member[@name="ID3D12InfoQueue1"]/*'/>
    [Guid("2852DD88-B484-4C0C-B6B1-67168500E600")]
    [NativeTypeName("struct ID3D12InfoQueue1 : ID3D12InfoQueue")]
    [NativeInheritance("ID3D12InfoQueue")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12InfoQueue1));

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
            [NativeTypeName("HRESULT (UINT64) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ulong, HResult> SetMessageCountLimit;
            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void> ClearStoredMessages;
            [NativeTypeName("HRESULT (UINT64, D3D12_MESSAGE *, SIZE_T *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ulong, D3D12Message*, nuint*, HResult> GetMessage;
            [NativeTypeName("UINT64 () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ulong> GetNumMessagesAllowedByStorageFilter;
            [NativeTypeName("UINT64 () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ulong> GetNumMessagesDeniedByStorageFilter;
            [NativeTypeName("UINT64 () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ulong> GetNumStoredMessages;
            [NativeTypeName("UINT64 () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ulong> GetNumStoredMessagesAllowedByRetrievalFilter;
            [NativeTypeName("UINT64 () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ulong> GetNumMessagesDiscardedByMessageCountLimit;
            [NativeTypeName("UINT64 () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ulong> GetMessageCountLimit;
            [NativeTypeName("HRESULT (D3D12_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12InfoQueueFilter*, HResult> AddStorageFilterEntries;
            [NativeTypeName("HRESULT (D3D12_INFO_QUEUE_FILTER *, SIZE_T *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12InfoQueueFilter*, nuint*, HResult> GetStorageFilter;
            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void> ClearStorageFilter;
            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HResult> PushEmptyStorageFilter;
            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HResult> PushCopyOfStorageFilter;
            [NativeTypeName("HRESULT (D3D12_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12InfoQueueFilter*, HResult> PushStorageFilter;
            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void> PopStorageFilter;
            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> GetStorageFilterStackSize;
            [NativeTypeName("HRESULT (D3D12_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12InfoQueueFilter*, HResult> AddRetrievalFilterEntries;
            [NativeTypeName("HRESULT (D3D12_INFO_QUEUE_FILTER *, SIZE_T *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12InfoQueueFilter*, nuint*, HResult> GetRetrievalFilter;
            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void> ClearRetrievalFilter;
            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HResult> PushEmptyRetrievalFilter;
            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HResult> PushCopyOfRetrievalFilter;
            [NativeTypeName("HRESULT (D3D12_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12InfoQueueFilter*, HResult> PushRetrievalFilter;
            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void> PopRetrievalFilter;
            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> GetRetrievalFilterStackSize;
            [NativeTypeName("HRESULT (D3D12_MESSAGE_CATEGORY, D3D12_MESSAGE_SEVERITY, D3D12_MESSAGE_ID, LPCSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12MessageCategory, D3D12MessageSeverity, D3D12MessageId, sbyte*, HResult> AddMessage;
            [NativeTypeName("HRESULT (D3D12_MESSAGE_SEVERITY, LPCSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12MessageSeverity, sbyte*, HResult> AddApplicationMessage;
            [NativeTypeName("HRESULT (D3D12_MESSAGE_CATEGORY, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12MessageCategory, MaybeBool<int>, HResult> SetBreakOnCategory;
            [NativeTypeName("HRESULT (D3D12_MESSAGE_SEVERITY, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12MessageSeverity, MaybeBool<int>, HResult> SetBreakOnSeverity;
            [NativeTypeName("HRESULT (D3D12_MESSAGE_ID, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12MessageId, MaybeBool<int>, HResult> SetBreakOnID;
            [NativeTypeName("BOOL (D3D12_MESSAGE_CATEGORY) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12MessageCategory, MaybeBool<int>> GetBreakOnCategory;
            [NativeTypeName("BOOL (D3D12_MESSAGE_SEVERITY) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12MessageSeverity, MaybeBool<int>> GetBreakOnSeverity;
            [NativeTypeName("BOOL (D3D12_MESSAGE_ID) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12MessageId, MaybeBool<int>> GetBreakOnID;
            [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, MaybeBool<int>, void> SetMuteDebugOutput;
            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, MaybeBool<int>> GetMuteDebugOutput;
            [NativeTypeName("HRESULT (D3D12MessageFunc, D3D12_MESSAGE_CALLBACK_FLAGS, void *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, delegate* unmanaged<D3D12MessageCategory, D3D12MessageSeverity, D3D12MessageId, sbyte*, void*, void> , D3D12MessageCallbackFlags, void*, uint*, HResult> RegisterMessageCallback;
            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, HResult> UnregisterMessageCallback;
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.AddApplicationMessage"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HResult AddApplicationMessage(D3D12MessageSeverity Severity, [NativeTypeName("LPCSTR")] sbyte* pDescription)
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, D3D12MessageSeverity, sbyte*, HResult> )(lpVtbl[29]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this), Severity, pDescription);
        }

        [VtblIndex(29)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult AddApplicationMessage(D3D12MessageSeverity Severity, [NativeTypeName("LPCSTR")] Ref<sbyte> pDescription)
        {
            fixed (sbyte* __dsl_pDescription = pDescription)
            {
                return (HResult)AddApplicationMessage(Severity, __dsl_pDescription);
            }
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.AddMessage"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HResult AddMessage(D3D12MessageCategory Category, D3D12MessageSeverity Severity, D3D12MessageId ID, [NativeTypeName("LPCSTR")] sbyte* pDescription)
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, D3D12MessageCategory, D3D12MessageSeverity, D3D12MessageId, sbyte*, HResult> )(lpVtbl[28]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this), Category, Severity, ID, pDescription);
        }

        [VtblIndex(28)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult AddMessage(D3D12MessageCategory Category, D3D12MessageSeverity Severity, D3D12MessageId ID, [NativeTypeName("LPCSTR")] Ref<sbyte> pDescription)
        {
            fixed (sbyte* __dsl_pDescription = pDescription)
            {
                return (HResult)AddMessage(Category, Severity, ID, __dsl_pDescription);
            }
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, uint> )(lpVtbl[1]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.AddRetrievalFilterEntries"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HResult AddRetrievalFilterEntries(D3D12InfoQueueFilter* pFilter)
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, D3D12InfoQueueFilter*, HResult> )(lpVtbl[20]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this), pFilter);
        }

        [VtblIndex(20)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult AddRetrievalFilterEntries(Ref<D3D12InfoQueueFilter> pFilter)
        {
            fixed (D3D12InfoQueueFilter* __dsl_pFilter = pFilter)
            {
                return (HResult)AddRetrievalFilterEntries(__dsl_pFilter);
            }
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.AddStorageFilterEntries"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HResult AddStorageFilterEntries(D3D12InfoQueueFilter* pFilter)
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, D3D12InfoQueueFilter*, HResult> )(lpVtbl[12]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this), pFilter);
        }

        [VtblIndex(12)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult AddStorageFilterEntries(Ref<D3D12InfoQueueFilter> pFilter)
        {
            fixed (D3D12InfoQueueFilter* __dsl_pFilter = pFilter)
            {
                return (HResult)AddStorageFilterEntries(__dsl_pFilter);
            }
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.ClearRetrievalFilter"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public void ClearRetrievalFilter()
        {
            ((delegate* unmanaged<ID3D12InfoQueue1.Native*, void> )(lpVtbl[22]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.ClearStorageFilter"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public void ClearStorageFilter()
        {
            ((delegate* unmanaged<ID3D12InfoQueue1.Native*, void> )(lpVtbl[14]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.ClearStoredMessages"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void ClearStoredMessages()
        {
            ((delegate* unmanaged<ID3D12InfoQueue1.Native*, void> )(lpVtbl[4]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.GetBreakOnCategory"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("BOOL")]
        public MaybeBool<int> GetBreakOnCategory(D3D12MessageCategory Category)
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, D3D12MessageCategory, MaybeBool<int>> )(lpVtbl[33]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this), Category);
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.GetBreakOnID"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("BOOL")]
        public MaybeBool<int> GetBreakOnID(D3D12MessageId ID)
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, D3D12MessageId, MaybeBool<int>> )(lpVtbl[35]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this), ID);
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.GetBreakOnSeverity"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("BOOL")]
        public MaybeBool<int> GetBreakOnSeverity(D3D12MessageSeverity Severity)
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, D3D12MessageSeverity, MaybeBool<int>> )(lpVtbl[34]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this), Severity);
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.GetMessage"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult GetMessage([NativeTypeName("UINT64")] ulong MessageIndex, D3D12Message* pMessage, [NativeTypeName("SIZE_T *")] nuint* pMessageByteLength)
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, ulong, D3D12Message*, nuint*, HResult> )(lpVtbl[5]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this), MessageIndex, pMessage, pMessageByteLength);
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetMessage([NativeTypeName("UINT64")] ulong MessageIndex, Ref<D3D12Message> pMessage, [NativeTypeName("SIZE_T *")] Ref<nuint> pMessageByteLength)
        {
            fixed (nuint* __dsl_pMessageByteLength = pMessageByteLength)
            fixed (D3D12Message* __dsl_pMessage = pMessage)
            {
                return (HResult)GetMessage(MessageIndex, __dsl_pMessage, __dsl_pMessageByteLength);
            }
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.GetMessageCountLimit"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("UINT64")]
        public ulong GetMessageCountLimit()
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, ulong> )(lpVtbl[11]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.GetMuteDebugOutput"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("BOOL")]
        public MaybeBool<int> GetMuteDebugOutput()
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, MaybeBool<int>> )(lpVtbl[37]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.GetNumMessagesAllowedByStorageFilter"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesAllowedByStorageFilter()
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, ulong> )(lpVtbl[6]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.GetNumMessagesDeniedByStorageFilter"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesDeniedByStorageFilter()
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, ulong> )(lpVtbl[7]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.GetNumMessagesDiscardedByMessageCountLimit"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesDiscardedByMessageCountLimit()
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, ulong> )(lpVtbl[10]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.GetNumStoredMessages"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("UINT64")]
        public ulong GetNumStoredMessages()
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, ulong> )(lpVtbl[8]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.GetNumStoredMessagesAllowedByRetrievalFilter"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("UINT64")]
        public ulong GetNumStoredMessagesAllowedByRetrievalFilter()
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, ulong> )(lpVtbl[9]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.GetRetrievalFilter"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HResult GetRetrievalFilter(D3D12InfoQueueFilter* pFilter, [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength)
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, D3D12InfoQueueFilter*, nuint*, HResult> )(lpVtbl[21]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this), pFilter, pFilterByteLength);
        }

        [VtblIndex(21)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetRetrievalFilter(Ref<D3D12InfoQueueFilter> pFilter, [NativeTypeName("SIZE_T *")] Ref<nuint> pFilterByteLength)
        {
            fixed (nuint* __dsl_pFilterByteLength = pFilterByteLength)
            fixed (D3D12InfoQueueFilter* __dsl_pFilter = pFilter)
            {
                return (HResult)GetRetrievalFilter(__dsl_pFilter, __dsl_pFilterByteLength);
            }
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.GetRetrievalFilterStackSize"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public uint GetRetrievalFilterStackSize()
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, uint> )(lpVtbl[27]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.GetStorageFilter"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HResult GetStorageFilter(D3D12InfoQueueFilter* pFilter, [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength)
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, D3D12InfoQueueFilter*, nuint*, HResult> )(lpVtbl[13]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this), pFilter, pFilterByteLength);
        }

        [VtblIndex(13)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetStorageFilter(Ref<D3D12InfoQueueFilter> pFilter, [NativeTypeName("SIZE_T *")] Ref<nuint> pFilterByteLength)
        {
            fixed (nuint* __dsl_pFilterByteLength = pFilterByteLength)
            fixed (D3D12InfoQueueFilter* __dsl_pFilter = pFilter)
            {
                return (HResult)GetStorageFilter(__dsl_pFilter, __dsl_pFilterByteLength);
            }
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.GetStorageFilterStackSize"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public uint GetStorageFilterStackSize()
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, uint> )(lpVtbl[19]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.PopRetrievalFilter"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public void PopRetrievalFilter()
        {
            ((delegate* unmanaged<ID3D12InfoQueue1.Native*, void> )(lpVtbl[26]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.PopStorageFilter"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public void PopStorageFilter()
        {
            ((delegate* unmanaged<ID3D12InfoQueue1.Native*, void> )(lpVtbl[18]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.PushCopyOfRetrievalFilter"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HResult PushCopyOfRetrievalFilter()
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, HResult> )(lpVtbl[24]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.PushCopyOfStorageFilter"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HResult PushCopyOfStorageFilter()
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, HResult> )(lpVtbl[16]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.PushEmptyRetrievalFilter"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HResult PushEmptyRetrievalFilter()
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, HResult> )(lpVtbl[23]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.PushEmptyStorageFilter"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HResult PushEmptyStorageFilter()
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, HResult> )(lpVtbl[15]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.PushRetrievalFilter"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HResult PushRetrievalFilter(D3D12InfoQueueFilter* pFilter)
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, D3D12InfoQueueFilter*, HResult> )(lpVtbl[25]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this), pFilter);
        }

        [VtblIndex(25)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult PushRetrievalFilter(Ref<D3D12InfoQueueFilter> pFilter)
        {
            fixed (D3D12InfoQueueFilter* __dsl_pFilter = pFilter)
            {
                return (HResult)PushRetrievalFilter(__dsl_pFilter);
            }
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.PushStorageFilter"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HResult PushStorageFilter(D3D12InfoQueueFilter* pFilter)
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, D3D12InfoQueueFilter*, HResult> )(lpVtbl[17]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this), pFilter);
        }

        [VtblIndex(17)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult PushStorageFilter(Ref<D3D12InfoQueueFilter> pFilter)
        {
            fixed (D3D12InfoQueueFilter* __dsl_pFilter = pFilter)
            {
                return (HResult)PushStorageFilter(__dsl_pFilter);
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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

        /// <include file='ID3D12InfoQueue1.xml' path='doc/member[@name="ID3D12InfoQueue1.RegisterMessageCallback"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HResult RegisterMessageCallback([NativeTypeName("D3D12MessageFunc")] delegate* unmanaged<D3D12MessageCategory, D3D12MessageSeverity, D3D12MessageId, sbyte*, void*, void> CallbackFunc, D3D12MessageCallbackFlags CallbackFilterFlags, void* pContext, [NativeTypeName("DWORD *")] uint* pCallbackCookie)
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, delegate* unmanaged<D3D12MessageCategory, D3D12MessageSeverity, D3D12MessageId, sbyte*, void*, void> , D3D12MessageCallbackFlags, void*, uint*, HResult> )(lpVtbl[38]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this), CallbackFunc, CallbackFilterFlags, pContext, pCallbackCookie);
        }

        [VtblIndex(38)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult RegisterMessageCallback([NativeTypeName("D3D12MessageFunc")] delegate* unmanaged<D3D12MessageCategory, D3D12MessageSeverity, D3D12MessageId, sbyte*, void*, void> CallbackFunc, D3D12MessageCallbackFlags CallbackFilterFlags, Ref pContext, [NativeTypeName("DWORD *")] Ref<uint> pCallbackCookie)
        {
            fixed (uint* __dsl_pCallbackCookie = pCallbackCookie)
            fixed (void* __dsl_pContext = pContext)
            {
                return (HResult)RegisterMessageCallback(CallbackFunc, CallbackFilterFlags, __dsl_pContext, __dsl_pCallbackCookie);
            }
        }

        /// <inheritdoc cref = "IUnknown.Release"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, uint> )(lpVtbl[2]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.SetBreakOnCategory"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HResult SetBreakOnCategory(D3D12MessageCategory Category, [NativeTypeName("BOOL")] MaybeBool<int> bEnable)
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, D3D12MessageCategory, MaybeBool<int>, HResult> )(lpVtbl[30]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this), Category, bEnable);
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.SetBreakOnID"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HResult SetBreakOnID(D3D12MessageId ID, [NativeTypeName("BOOL")] MaybeBool<int> bEnable)
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, D3D12MessageId, MaybeBool<int>, HResult> )(lpVtbl[32]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this), ID, bEnable);
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.SetBreakOnSeverity"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HResult SetBreakOnSeverity(D3D12MessageSeverity Severity, [NativeTypeName("BOOL")] MaybeBool<int> bEnable)
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, D3D12MessageSeverity, MaybeBool<int>, HResult> )(lpVtbl[31]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this), Severity, bEnable);
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.SetMessageCountLimit"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult SetMessageCountLimit([NativeTypeName("UINT64")] ulong MessageCountLimit)
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, ulong, HResult> )(lpVtbl[3]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this), MessageCountLimit);
        }

        /// <inheritdoc cref = "ID3D12InfoQueue.SetMuteDebugOutput"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public void SetMuteDebugOutput([NativeTypeName("BOOL")] MaybeBool<int> bMute)
        {
            ((delegate* unmanaged<ID3D12InfoQueue1.Native*, MaybeBool<int>, void> )(lpVtbl[36]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this), bMute);
        }

        /// <include file='ID3D12InfoQueue1.xml' path='doc/member[@name="ID3D12InfoQueue1.UnregisterMessageCallback"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HResult UnregisterMessageCallback([NativeTypeName("DWORD")] uint CallbackCookie)
        {
            return ((delegate* unmanaged<ID3D12InfoQueue1.Native*, uint, HResult> )(lpVtbl[39]))((ID3D12InfoQueue1.Native*)Unsafe.AsPointer(ref this), CallbackCookie);
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12InfoQueue1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12InfoQueue1(Ptr3D vtbl) => LpVtbl = (ID3D12InfoQueue1.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12InfoQueue1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12InfoQueue1(Ptr<ID3D12InfoQueue1.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12InfoQueue1.Native"/> to <see cref = "ID3D12InfoQueue1"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12InfoQueue1.Native"/> instance to be converted </param>
    public static implicit operator ID3D12InfoQueue1(ID3D12InfoQueue1.Native* value) => new ID3D12InfoQueue1((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12InfoQueue1"/> to <see cref = "ID3D12InfoQueue1.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12InfoQueue1"/> instance to be converted </param>
    public static implicit operator ID3D12InfoQueue1.Native*(ID3D12InfoQueue1 value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12InfoQueue1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12InfoQueue1(Ptr3D value) => new ID3D12InfoQueue1(value);
    /// <summary>casts <see cref = "ID3D12InfoQueue1"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12InfoQueue1"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12InfoQueue1 value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12InfoQueue1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12InfoQueue1(Ptr<ID3D12InfoQueue1.Native> value) => new ID3D12InfoQueue1(value);
    /// <summary>casts <see cref = "ID3D12InfoQueue1"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12InfoQueue1"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12InfoQueue1.Native>(ID3D12InfoQueue1 value) => (Ptr<ID3D12InfoQueue1.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12InfoQueue1"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12InfoQueue1(void*** value) => new ID3D12InfoQueue1((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12InfoQueue1"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12InfoQueue1"/> instance to be converted </param>
    public static implicit operator void***(ID3D12InfoQueue1 value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12InfoQueue1"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12InfoQueue1(nuint value) => new ID3D12InfoQueue1((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12InfoQueue1"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12InfoQueue1"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12InfoQueue1 value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "ID3D12InfoQueue.AddApplicationMessage"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HResult AddApplicationMessage(D3D12MessageSeverity Severity, [NativeTypeName("LPCSTR")] sbyte* pDescription) => LpVtbl->AddApplicationMessage(Severity, pDescription);
    [VtblIndex(29)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult AddApplicationMessage(D3D12MessageSeverity Severity, [NativeTypeName("LPCSTR")] Ref<sbyte> pDescription)
    {
        fixed (sbyte* __dsl_pDescription = pDescription)
        {
            return (HResult)AddApplicationMessage(Severity, __dsl_pDescription);
        }
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.AddMessage"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HResult AddMessage(D3D12MessageCategory Category, D3D12MessageSeverity Severity, D3D12MessageId ID, [NativeTypeName("LPCSTR")] sbyte* pDescription) => LpVtbl->AddMessage(Category, Severity, ID, pDescription);
    [VtblIndex(28)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult AddMessage(D3D12MessageCategory Category, D3D12MessageSeverity Severity, D3D12MessageId ID, [NativeTypeName("LPCSTR")] Ref<sbyte> pDescription)
    {
        fixed (sbyte* __dsl_pDescription = pDescription)
        {
            return (HResult)AddMessage(Category, Severity, ID, __dsl_pDescription);
        }
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <inheritdoc cref = "ID3D12InfoQueue.AddRetrievalFilterEntries"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HResult AddRetrievalFilterEntries(D3D12InfoQueueFilter* pFilter) => LpVtbl->AddRetrievalFilterEntries(pFilter);
    [VtblIndex(20)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult AddRetrievalFilterEntries(Ref<D3D12InfoQueueFilter> pFilter)
    {
        fixed (D3D12InfoQueueFilter* __dsl_pFilter = pFilter)
        {
            return (HResult)AddRetrievalFilterEntries(__dsl_pFilter);
        }
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.AddStorageFilterEntries"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HResult AddStorageFilterEntries(D3D12InfoQueueFilter* pFilter) => LpVtbl->AddStorageFilterEntries(pFilter);
    [VtblIndex(12)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult AddStorageFilterEntries(Ref<D3D12InfoQueueFilter> pFilter)
    {
        fixed (D3D12InfoQueueFilter* __dsl_pFilter = pFilter)
        {
            return (HResult)AddStorageFilterEntries(__dsl_pFilter);
        }
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.ClearRetrievalFilter"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public void ClearRetrievalFilter() => LpVtbl->ClearRetrievalFilter();
    /// <inheritdoc cref = "ID3D12InfoQueue.ClearStorageFilter"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public void ClearStorageFilter() => LpVtbl->ClearStorageFilter();
    /// <inheritdoc cref = "ID3D12InfoQueue.ClearStoredMessages"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void ClearStoredMessages() => LpVtbl->ClearStoredMessages();
    /// <inheritdoc cref = "ID3D12InfoQueue.GetBreakOnCategory"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    [return: NativeTypeName("BOOL")]
    public MaybeBool<int> GetBreakOnCategory(D3D12MessageCategory Category) => LpVtbl->GetBreakOnCategory(Category);
    /// <inheritdoc cref = "ID3D12InfoQueue.GetBreakOnID"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    [return: NativeTypeName("BOOL")]
    public MaybeBool<int> GetBreakOnID(D3D12MessageId ID) => LpVtbl->GetBreakOnID(ID);
    /// <inheritdoc cref = "ID3D12InfoQueue.GetBreakOnSeverity"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    [return: NativeTypeName("BOOL")]
    public MaybeBool<int> GetBreakOnSeverity(D3D12MessageSeverity Severity) => LpVtbl->GetBreakOnSeverity(Severity);
    /// <inheritdoc cref = "ID3D12InfoQueue.GetMessage"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult GetMessage([NativeTypeName("UINT64")] ulong MessageIndex, D3D12Message* pMessage, [NativeTypeName("SIZE_T *")] nuint* pMessageByteLength) => LpVtbl->GetMessage(MessageIndex, pMessage, pMessageByteLength);
    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetMessage([NativeTypeName("UINT64")] ulong MessageIndex, Ref<D3D12Message> pMessage, [NativeTypeName("SIZE_T *")] Ref<nuint> pMessageByteLength)
    {
        fixed (nuint* __dsl_pMessageByteLength = pMessageByteLength)
        fixed (D3D12Message* __dsl_pMessage = pMessage)
        {
            return (HResult)GetMessage(MessageIndex, __dsl_pMessage, __dsl_pMessageByteLength);
        }
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.GetMessageCountLimit"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("UINT64")]
    public ulong GetMessageCountLimit() => LpVtbl->GetMessageCountLimit();
    /// <inheritdoc cref = "ID3D12InfoQueue.GetMuteDebugOutput"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    [return: NativeTypeName("BOOL")]
    public MaybeBool<int> GetMuteDebugOutput() => LpVtbl->GetMuteDebugOutput();
    /// <inheritdoc cref = "ID3D12InfoQueue.GetNumMessagesAllowedByStorageFilter"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNumMessagesAllowedByStorageFilter() => LpVtbl->GetNumMessagesAllowedByStorageFilter();
    /// <inheritdoc cref = "ID3D12InfoQueue.GetNumMessagesDeniedByStorageFilter"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNumMessagesDeniedByStorageFilter() => LpVtbl->GetNumMessagesDeniedByStorageFilter();
    /// <inheritdoc cref = "ID3D12InfoQueue.GetNumMessagesDiscardedByMessageCountLimit"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNumMessagesDiscardedByMessageCountLimit() => LpVtbl->GetNumMessagesDiscardedByMessageCountLimit();
    /// <inheritdoc cref = "ID3D12InfoQueue.GetNumStoredMessages"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNumStoredMessages() => LpVtbl->GetNumStoredMessages();
    /// <inheritdoc cref = "ID3D12InfoQueue.GetNumStoredMessagesAllowedByRetrievalFilter"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNumStoredMessagesAllowedByRetrievalFilter() => LpVtbl->GetNumStoredMessagesAllowedByRetrievalFilter();
    /// <inheritdoc cref = "ID3D12InfoQueue.GetRetrievalFilter"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HResult GetRetrievalFilter(D3D12InfoQueueFilter* pFilter, [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength) => LpVtbl->GetRetrievalFilter(pFilter, pFilterByteLength);
    [VtblIndex(21)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetRetrievalFilter(Ref<D3D12InfoQueueFilter> pFilter, [NativeTypeName("SIZE_T *")] Ref<nuint> pFilterByteLength)
    {
        fixed (nuint* __dsl_pFilterByteLength = pFilterByteLength)
        fixed (D3D12InfoQueueFilter* __dsl_pFilter = pFilter)
        {
            return (HResult)GetRetrievalFilter(__dsl_pFilter, __dsl_pFilterByteLength);
        }
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.GetRetrievalFilterStackSize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public uint GetRetrievalFilterStackSize() => LpVtbl->GetRetrievalFilterStackSize();
    /// <inheritdoc cref = "ID3D12InfoQueue.GetStorageFilter"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HResult GetStorageFilter(D3D12InfoQueueFilter* pFilter, [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength) => LpVtbl->GetStorageFilter(pFilter, pFilterByteLength);
    [VtblIndex(13)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetStorageFilter(Ref<D3D12InfoQueueFilter> pFilter, [NativeTypeName("SIZE_T *")] Ref<nuint> pFilterByteLength)
    {
        fixed (nuint* __dsl_pFilterByteLength = pFilterByteLength)
        fixed (D3D12InfoQueueFilter* __dsl_pFilter = pFilter)
        {
            return (HResult)GetStorageFilter(__dsl_pFilter, __dsl_pFilterByteLength);
        }
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.GetStorageFilterStackSize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public uint GetStorageFilterStackSize() => LpVtbl->GetStorageFilterStackSize();
    /// <inheritdoc cref = "ID3D12InfoQueue.PopRetrievalFilter"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public void PopRetrievalFilter() => LpVtbl->PopRetrievalFilter();
    /// <inheritdoc cref = "ID3D12InfoQueue.PopStorageFilter"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public void PopStorageFilter() => LpVtbl->PopStorageFilter();
    /// <inheritdoc cref = "ID3D12InfoQueue.PushCopyOfRetrievalFilter"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HResult PushCopyOfRetrievalFilter() => LpVtbl->PushCopyOfRetrievalFilter();
    /// <inheritdoc cref = "ID3D12InfoQueue.PushCopyOfStorageFilter"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HResult PushCopyOfStorageFilter() => LpVtbl->PushCopyOfStorageFilter();
    /// <inheritdoc cref = "ID3D12InfoQueue.PushEmptyRetrievalFilter"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HResult PushEmptyRetrievalFilter() => LpVtbl->PushEmptyRetrievalFilter();
    /// <inheritdoc cref = "ID3D12InfoQueue.PushEmptyStorageFilter"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HResult PushEmptyStorageFilter() => LpVtbl->PushEmptyStorageFilter();
    /// <inheritdoc cref = "ID3D12InfoQueue.PushRetrievalFilter"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HResult PushRetrievalFilter(D3D12InfoQueueFilter* pFilter) => LpVtbl->PushRetrievalFilter(pFilter);
    [VtblIndex(25)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult PushRetrievalFilter(Ref<D3D12InfoQueueFilter> pFilter)
    {
        fixed (D3D12InfoQueueFilter* __dsl_pFilter = pFilter)
        {
            return (HResult)PushRetrievalFilter(__dsl_pFilter);
        }
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.PushStorageFilter"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HResult PushStorageFilter(D3D12InfoQueueFilter* pFilter) => LpVtbl->PushStorageFilter(pFilter);
    [VtblIndex(17)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult PushStorageFilter(Ref<D3D12InfoQueueFilter> pFilter)
    {
        fixed (D3D12InfoQueueFilter* __dsl_pFilter = pFilter)
        {
            return (HResult)PushStorageFilter(__dsl_pFilter);
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

    /// <include file='ID3D12InfoQueue1.xml' path='doc/member[@name="ID3D12InfoQueue1.RegisterMessageCallback"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HResult RegisterMessageCallback([NativeTypeName("D3D12MessageFunc")] delegate* unmanaged<D3D12MessageCategory, D3D12MessageSeverity, D3D12MessageId, sbyte*, void*, void> CallbackFunc, D3D12MessageCallbackFlags CallbackFilterFlags, void* pContext, [NativeTypeName("DWORD *")] uint* pCallbackCookie) => LpVtbl->RegisterMessageCallback(CallbackFunc, CallbackFilterFlags, pContext, pCallbackCookie);
    [VtblIndex(38)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult RegisterMessageCallback([NativeTypeName("D3D12MessageFunc")] delegate* unmanaged<D3D12MessageCategory, D3D12MessageSeverity, D3D12MessageId, sbyte*, void*, void> CallbackFunc, D3D12MessageCallbackFlags CallbackFilterFlags, Ref pContext, [NativeTypeName("DWORD *")] Ref<uint> pCallbackCookie)
    {
        fixed (uint* __dsl_pCallbackCookie = pCallbackCookie)
        fixed (void* __dsl_pContext = pContext)
        {
            return (HResult)RegisterMessageCallback(CallbackFunc, CallbackFilterFlags, __dsl_pContext, __dsl_pCallbackCookie);
        }
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release() => LpVtbl->Release();
    /// <inheritdoc cref = "ID3D12InfoQueue.SetBreakOnCategory"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HResult SetBreakOnCategory(D3D12MessageCategory Category, [NativeTypeName("BOOL")] MaybeBool<int> bEnable) => LpVtbl->SetBreakOnCategory(Category, bEnable);
    /// <inheritdoc cref = "ID3D12InfoQueue.SetBreakOnID"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HResult SetBreakOnID(D3D12MessageId ID, [NativeTypeName("BOOL")] MaybeBool<int> bEnable) => LpVtbl->SetBreakOnID(ID, bEnable);
    /// <inheritdoc cref = "ID3D12InfoQueue.SetBreakOnSeverity"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HResult SetBreakOnSeverity(D3D12MessageSeverity Severity, [NativeTypeName("BOOL")] MaybeBool<int> bEnable) => LpVtbl->SetBreakOnSeverity(Severity, bEnable);
    /// <inheritdoc cref = "ID3D12InfoQueue.SetMessageCountLimit"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult SetMessageCountLimit([NativeTypeName("UINT64")] ulong MessageCountLimit) => LpVtbl->SetMessageCountLimit(MessageCountLimit);
    /// <inheritdoc cref = "ID3D12InfoQueue.SetMuteDebugOutput"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public void SetMuteDebugOutput([NativeTypeName("BOOL")] MaybeBool<int> bMute) => LpVtbl->SetMuteDebugOutput(bMute);
    /// <include file='ID3D12InfoQueue1.xml' path='doc/member[@name="ID3D12InfoQueue1.UnregisterMessageCallback"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HResult UnregisterMessageCallback([NativeTypeName("DWORD")] uint CallbackCookie) => LpVtbl->UnregisterMessageCallback(CallbackCookie);
}