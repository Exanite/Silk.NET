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
    [NativeName("Name", "IModulePrecompileService_Experimental")]
    public unsafe partial struct IModulePrecompileServiceExperimental : IComVtbl<IModulePrecompileServiceExperimental>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IModulePrecompileServiceExperimental val)
            => Unsafe.As<IModulePrecompileServiceExperimental, Silk.NET.Core.Native.IUnknown>(ref val);

        public IModulePrecompileServiceExperimental
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
            var @this = (IModulePrecompileServiceExperimental*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, ref void* outObject)
        {
            var @this = (IModulePrecompileServiceExperimental*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, void** outObject)
        {
            var @this = (IModulePrecompileServiceExperimental*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Uuid* uuidPtr = &uuid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, ref void* outObject)
        {
            var @this = (IModulePrecompileServiceExperimental*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Uuid* uuidPtr = &uuid)
            {
                fixed (void** outObjectPtr = &outObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IModulePrecompileServiceExperimental*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IModulePrecompileServiceExperimental*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PrecompileForTarget(CompileTarget target, IBlob** outDiagnostics)
        {
            var @this = (IModulePrecompileServiceExperimental*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, CompileTarget, IBlob**, int>)@this->LpVtbl[3])(@this, target, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PrecompileForTarget(CompileTarget target, ref IBlob* outDiagnostics)
        {
            var @this = (IModulePrecompileServiceExperimental*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, CompileTarget, IBlob**, int>)@this->LpVtbl[3])(@this, target, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrecompiledTargetCode(CompileTarget target, IBlob** outCode, IBlob** outDiagnostics)
        {
            var @this = (IModulePrecompileServiceExperimental*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, CompileTarget, IBlob**, IBlob**, int>)@this->LpVtbl[4])(@this, target, outCode, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrecompiledTargetCode(CompileTarget target, IBlob** outCode, ref IBlob* outDiagnostics)
        {
            var @this = (IModulePrecompileServiceExperimental*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, CompileTarget, IBlob**, IBlob**, int>)@this->LpVtbl[4])(@this, target, outCode, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrecompiledTargetCode(CompileTarget target, ref IBlob* outCode, IBlob** outDiagnostics)
        {
            var @this = (IModulePrecompileServiceExperimental*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outCodePtr = &outCode)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, CompileTarget, IBlob**, IBlob**, int>)@this->LpVtbl[4])(@this, target, outCodePtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrecompiledTargetCode(CompileTarget target, ref IBlob* outCode, ref IBlob* outDiagnostics)
        {
            var @this = (IModulePrecompileServiceExperimental*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outCodePtr = &outCode)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, CompileTarget, IBlob**, IBlob**, int>)@this->LpVtbl[4])(@this, target, outCodePtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly long GetModuleDependencyCount()
        {
            var @this = (IModulePrecompileServiceExperimental*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            long ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, long>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetModuleDependency(long dependencyIndex, IModule** outModule, IBlob** outDiagnostics)
        {
            var @this = (IModulePrecompileServiceExperimental*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, long, IModule**, IBlob**, int>)@this->LpVtbl[6])(@this, dependencyIndex, outModule, outDiagnostics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetModuleDependency(long dependencyIndex, IModule** outModule, ref IBlob* outDiagnostics)
        {
            var @this = (IModulePrecompileServiceExperimental*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, long, IModule**, IBlob**, int>)@this->LpVtbl[6])(@this, dependencyIndex, outModule, outDiagnosticsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetModuleDependency(long dependencyIndex, ref IModule* outModule, IBlob** outDiagnostics)
        {
            var @this = (IModulePrecompileServiceExperimental*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IModule** outModulePtr = &outModule)
            {
                ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, long, IModule**, IBlob**, int>)@this->LpVtbl[6])(@this, dependencyIndex, outModulePtr, outDiagnostics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetModuleDependency(long dependencyIndex, ref IModule* outModule, ref IBlob* outDiagnostics)
        {
            var @this = (IModulePrecompileServiceExperimental*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IModule** outModulePtr = &outModule)
            {
                fixed (IBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IModulePrecompileServiceExperimental*, long, IModule**, IBlob**, int>)@this->LpVtbl[6])(@this, dependencyIndex, outModulePtr, outDiagnosticsPtr);
                }
            }
            return ret;
        }

    }
}
