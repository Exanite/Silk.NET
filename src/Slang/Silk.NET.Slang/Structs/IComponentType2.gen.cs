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
    [NativeName("Name", "IComponentType2")]
    public unsafe partial struct IComponentType2 : IComVtbl<IComponentType2>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IComponentType2 val)
            => Unsafe.As<IComponentType2, Silk.NET.Core.Native.IUnknown>(ref val);

        public IComponentType2
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
            var @this = (IComponentType2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IComponentType2*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, ref void* outObject)
        {
            var @this = (IComponentType2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType2*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, void** outObject)
        {
            var @this = (IComponentType2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Uuid* uuidPtr = &uuid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType2*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, ref void* outObject)
        {
            var @this = (IComponentType2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Uuid* uuidPtr = &uuid)
            {
                fixed (void** outObjectPtr = &outObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IComponentType2*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IComponentType2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IComponentType2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IComponentType2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IComponentType2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetCompileResult(long targetIndex, ICompileResult** outCompileResult, IBlob** outDiagnostics)
        {
            var @this = (IComponentType2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IComponentType2*, long, ICompileResult**, IBlob**, int>)@this->LpVtbl[3])(@this, targetIndex, outCompileResult, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetCompileResult(long targetIndex, ICompileResult** outCompileResult, ref IBlob* outDiagnostics)
        {
            var @this = (IComponentType2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType2*, long, ICompileResult**, IBlob**, int>)@this->LpVtbl[3])(@this, targetIndex, outCompileResult, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetCompileResult(long targetIndex, ref ICompileResult* outCompileResult, IBlob** outDiagnostics)
        {
            var @this = (IComponentType2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ICompileResult** outCompileResultPtr = &outCompileResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType2*, long, ICompileResult**, IBlob**, int>)@this->LpVtbl[3])(@this, targetIndex, outCompileResultPtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetCompileResult(long targetIndex, ref ICompileResult* outCompileResult, ref IBlob* outDiagnostics)
        {
            var @this = (IComponentType2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ICompileResult** outCompileResultPtr = &outCompileResult)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IComponentType2*, long, ICompileResult**, IBlob**, int>)@this->LpVtbl[3])(@this, targetIndex, outCompileResultPtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointCompileResult(long entryPointIndex, long targetIndex, ICompileResult** outCompileResult, IBlob** outDiagnostics)
        {
            var @this = (IComponentType2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IComponentType2*, long, long, ICompileResult**, IBlob**, int>)@this->LpVtbl[4])(@this, entryPointIndex, targetIndex, outCompileResult, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointCompileResult(long entryPointIndex, long targetIndex, ICompileResult** outCompileResult, ref IBlob* outDiagnostics)
        {
            var @this = (IComponentType2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType2*, long, long, ICompileResult**, IBlob**, int>)@this->LpVtbl[4])(@this, entryPointIndex, targetIndex, outCompileResult, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointCompileResult(long entryPointIndex, long targetIndex, ref ICompileResult* outCompileResult, IBlob** outDiagnostics)
        {
            var @this = (IComponentType2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ICompileResult** outCompileResultPtr = &outCompileResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IComponentType2*, long, long, ICompileResult**, IBlob**, int>)@this->LpVtbl[4])(@this, entryPointIndex, targetIndex, outCompileResultPtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPointCompileResult(long entryPointIndex, long targetIndex, ref ICompileResult* outCompileResult, ref IBlob* outDiagnostics)
        {
            var @this = (IComponentType2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ICompileResult** outCompileResultPtr = &outCompileResult)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IComponentType2*, long, long, ICompileResult**, IBlob**, int>)@this->LpVtbl[4])(@this, entryPointIndex, targetIndex, outCompileResultPtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

    }
}
