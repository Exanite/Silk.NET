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

namespace Silk.NET.Slang
{
    [NativeName("Name", "IByteCodeRunner")]
    public unsafe partial struct IByteCodeRunner : IComVtbl<IByteCodeRunner>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IByteCodeRunner val)
            => Unsafe.As<IByteCodeRunner, Silk.NET.Core.Native.IUnknown>(ref val);

        public IByteCodeRunner
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, void** outObject)
        {
            var @this = (IByteCodeRunner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, ref void* outObject)
        {
            var @this = (IByteCodeRunner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, void** outObject)
        {
            var @this = (IByteCodeRunner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Uuid* uuidPtr = &uuid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, ref void* outObject)
        {
            var @this = (IByteCodeRunner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Uuid* uuidPtr = &uuid)
            {
                fixed (void** outObjectPtr = &outObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IByteCodeRunner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IByteCodeRunner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadModule(IBlob* moduleBlob)
        {
            var @this = (IByteCodeRunner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, IBlob*, int>)@this->LpVtbl[3])(@this, moduleBlob);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadModule(ref IBlob moduleBlob)
        {
            var @this = (IByteCodeRunner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob* moduleBlobPtr = &moduleBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, IBlob*, int>)@this->LpVtbl[3])(@this, moduleBlobPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SelectFunctionByIndex(uint functionIndex)
        {
            var @this = (IByteCodeRunner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, uint, int>)@this->LpVtbl[4])(@this, functionIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFunctionByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name)
        {
            var @this = (IByteCodeRunner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, byte*, int>)@this->LpVtbl[5])(@this, name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FindFunctionByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name)
        {
            var @this = (IByteCodeRunner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, byte*, int>)@this->LpVtbl[5])(@this, namePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FindFunctionByName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name)
        {
            var @this = (IByteCodeRunner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, byte*, int>)@this->LpVtbl[5])(@this, namePtr);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFunctionInfo(uint index, ByteCodeFuncInfo* outInfo)
        {
            var @this = (IByteCodeRunner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, uint, ByteCodeFuncInfo*, int>)@this->LpVtbl[6])(@this, index, outInfo);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFunctionInfo(uint index, ref ByteCodeFuncInfo outInfo)
        {
            var @this = (IByteCodeRunner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ByteCodeFuncInfo* outInfoPtr = &outInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, uint, ByteCodeFuncInfo*, int>)@this->LpVtbl[6])(@this, index, outInfoPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* GetCurrentWorkingSet()
        {
            var @this = (IByteCodeRunner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, void*>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Execute(void* argumentData, nuint argumentSize)
        {
            var @this = (IByteCodeRunner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, void*, nuint, int>)@this->LpVtbl[8])(@this, argumentData, argumentSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Execute<T0>(ref T0 argumentData, nuint argumentSize) where T0 : unmanaged
        {
            var @this = (IByteCodeRunner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* argumentDataPtr = &argumentData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, void*, nuint, int>)@this->LpVtbl[8])(@this, argumentDataPtr, argumentSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetErrorString(IBlob** outBlob)
        {
            var @this = (IByteCodeRunner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, IBlob**, void>)@this->LpVtbl[9])(@this, outBlob);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetErrorString(ref IBlob* outBlob)
        {
            var @this = (IByteCodeRunner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IBlob** outBlobPtr = &outBlob)
            {
                ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, IBlob**, void>)@this->LpVtbl[9])(@this, outBlobPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* GetReturnValue(nuint* outValueSize)
        {
            var @this = (IByteCodeRunner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, nuint*, void*>)@this->LpVtbl[10])(@this, outValueSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* GetReturnValue(ref nuint outValueSize)
        {
            var @this = (IByteCodeRunner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            fixed (nuint* outValueSizePtr = &outValueSize)
            {
                ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, nuint*, void*>)@this->LpVtbl[10])(@this, outValueSizePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetExtInstHandlerUserData(void* userData)
        {
            var @this = (IByteCodeRunner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, void*, void>)@this->LpVtbl[11])(@this, userData);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetExtInstHandlerUserData<T0>(ref T0 userData) where T0 : unmanaged
        {
            var @this = (IByteCodeRunner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* userDataPtr = &userData)
            {
                ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, void*, void>)@this->LpVtbl[11])(@this, userDataPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterExtCall([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, PfnVMExtFunction functionPtr)
        {
            var @this = (IByteCodeRunner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, byte*, PfnVMExtFunction, int>)@this->LpVtbl[12])(@this, name, functionPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterExtCall([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, PfnVMExtFunction functionPtr)
        {
            var @this = (IByteCodeRunner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, byte*, PfnVMExtFunction, int>)@this->LpVtbl[12])(@this, namePtr, functionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterExtCall([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, PfnVMExtFunction functionPtr)
        {
            var @this = (IByteCodeRunner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, byte*, PfnVMExtFunction, int>)@this->LpVtbl[12])(@this, namePtr, functionPtr);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrintCallback(PfnDiagnosticCallback callback, void* userData)
        {
            var @this = (IByteCodeRunner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, PfnDiagnosticCallback, void*, int>)@this->LpVtbl[13])(@this, callback, userData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrintCallback<T0>(PfnDiagnosticCallback callback, ref T0 userData) where T0 : unmanaged
        {
            var @this = (IByteCodeRunner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* userDataPtr = &userData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IByteCodeRunner*, PfnDiagnosticCallback, void*, int>)@this->LpVtbl[13])(@this, callback, userDataPtr);
            }
            return ret;
        }

    }
}
