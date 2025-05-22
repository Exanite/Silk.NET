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
    [NativeName("Name", "ISlangWriter")]
    public unsafe partial struct ISlangWriter : IComVtbl<ISlangWriter>, IComVtbl<ISlangUnknown>
    {
        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ISlangUnknown(ISlangWriter val)
            => Unsafe.As<ISlangWriter, ISlangUnknown>(ref val);

        public ISlangWriter
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
            var @this = (ISlangWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, ref void* outObject)
        {
            var @this = (ISlangWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, void** outObject)
        {
            var @this = (ISlangWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Uuid* uuidPtr = &uuid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, ref void* outObject)
        {
            var @this = (ISlangWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Uuid* uuidPtr = &uuid)
            {
                fixed (void** outObjectPtr = &outObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ISlangWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ISlangWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe byte* BeginAppendBuffer(nuint maxNumChars)
        {
            var @this = (ISlangWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            byte* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, nuint, byte*>)@this->LpVtbl[3])(@this, maxNumChars);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        public readonly string BeginAppendBufferS(nuint maxNumChars)
        {
            var @this = (ISlangWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            string ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, nuint, string>)@this->LpVtbl[3])(@this, maxNumChars);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EndAppendBuffer(byte* buffer, nuint numChars)
        {
            var @this = (ISlangWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, byte*, nuint, int>)@this->LpVtbl[4])(@this, buffer, numChars);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EndAppendBuffer(ref byte buffer, nuint numChars)
        {
            var @this = (ISlangWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* bufferPtr = &buffer)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, byte*, nuint, int>)@this->LpVtbl[4])(@this, bufferPtr, numChars);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EndAppendBuffer([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer, nuint numChars)
        {
            var @this = (ISlangWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var bufferPtr = (byte*) SilkMarshal.StringToPtr(buffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, byte*, nuint, int>)@this->LpVtbl[4])(@this, bufferPtr, numChars);
            SilkMarshal.Free((nint)bufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Write([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* chars, nuint numChars)
        {
            var @this = (ISlangWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, byte*, nuint, int>)@this->LpVtbl[5])(@this, chars, numChars);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Write([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte chars, nuint numChars)
        {
            var @this = (ISlangWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* charsPtr = &chars)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, byte*, nuint, int>)@this->LpVtbl[5])(@this, charsPtr, numChars);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Write([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string chars, nuint numChars)
        {
            var @this = (ISlangWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var charsPtr = (byte*) SilkMarshal.StringToPtr(chars, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, byte*, nuint, int>)@this->LpVtbl[5])(@this, charsPtr, numChars);
            SilkMarshal.Free((nint)charsPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void Flush()
        {
            var @this = (ISlangWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ISlangWriter*, void>)@this->LpVtbl[6])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly bool IsConsole()
        {
            var @this = (ISlangWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            bool ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, bool>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetMode(WriterMode mode)
        {
            var @this = (ISlangWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISlangWriter*, WriterMode, int>)@this->LpVtbl[8])(@this, mode);
            return ret;
        }

    }
}
