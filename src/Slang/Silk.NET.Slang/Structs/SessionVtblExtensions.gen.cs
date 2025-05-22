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

namespace Silk.NET.Slang;

public unsafe static class SessionVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISession*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Uuid* uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** outObjectPtr = &outObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuid, outObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Uuid* uuidPtr = &uuid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Uuid uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Uuid* uuidPtr = &uuid)
        {
            fixed (void** outObjectPtr = &outObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, Uuid*, void**, int>)@this->LpVtbl[0])(@this, uuidPtr, outObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ISession> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISession*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ISession> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISession*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IGlobalSession* GetGlobalSession(this ComPtr<ISession> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        IGlobalSession* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISession*, IGlobalSession*>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModule(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[4])(@this, moduleName, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModule(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[4])(@this, moduleName, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModule(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[4])(@this, moduleNamePtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModule(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[4])(@this, moduleNamePtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModule(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[4])(@this, moduleNamePtr, outDiagnostics);
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModule(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[4])(@this, moduleNamePtr, outDiagnosticsPtr);
        }
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob* source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, path, source, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, path, source, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (ISlangBlob* sourcePtr = &source)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, path, sourcePtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (ISlangBlob* sourcePtr = &source)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, path, sourcePtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob* source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* pathPtr = &path)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, pathPtr, source, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* pathPtr = &path)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, pathPtr, source, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* pathPtr = &path)
        {
            fixed (ISlangBlob* sourcePtr = &source)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, pathPtr, sourcePtr, outDiagnostics);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* pathPtr = &path)
        {
            fixed (ISlangBlob* sourcePtr = &source)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, pathPtr, sourcePtr, outDiagnosticsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob* source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, pathPtr, source, outDiagnostics);
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, pathPtr, source, outDiagnosticsPtr);
        }
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (ISlangBlob* sourcePtr = &source)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, pathPtr, sourcePtr, outDiagnostics);
        }
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (ISlangBlob* sourcePtr = &source)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleName, pathPtr, sourcePtr, outDiagnosticsPtr);
            }
        }
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob* source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, path, source, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, path, source, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
            fixed (ISlangBlob* sourcePtr = &source)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, path, sourcePtr, outDiagnostics);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
            fixed (ISlangBlob* sourcePtr = &source)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, path, sourcePtr, outDiagnosticsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob* source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, source, outDiagnostics);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
            fixed (byte* pathPtr = &path)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, source, outDiagnosticsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
            fixed (byte* pathPtr = &path)
            {
                fixed (ISlangBlob* sourcePtr = &source)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnostics);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
            fixed (byte* pathPtr = &path)
            {
                fixed (ISlangBlob* sourcePtr = &source)
                {
                    fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnosticsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob* source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, source, outDiagnostics);
        SilkMarshal.Free((nint)pathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, source, outDiagnosticsPtr);
            }
        SilkMarshal.Free((nint)pathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (ISlangBlob* sourcePtr = &source)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnostics);
            }
        SilkMarshal.Free((nint)pathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (ISlangBlob* sourcePtr = &source)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnosticsPtr);
                }
            }
        SilkMarshal.Free((nint)pathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob* source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, path, source, outDiagnostics);
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, path, source, outDiagnosticsPtr);
        }
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        fixed (ISlangBlob* sourcePtr = &source)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, path, sourcePtr, outDiagnostics);
        }
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        fixed (ISlangBlob* sourcePtr = &source)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, path, sourcePtr, outDiagnosticsPtr);
            }
        }
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob* source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        fixed (byte* pathPtr = &path)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, source, outDiagnostics);
        }
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        fixed (byte* pathPtr = &path)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, source, outDiagnosticsPtr);
            }
        }
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        fixed (byte* pathPtr = &path)
        {
            fixed (ISlangBlob* sourcePtr = &source)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnostics);
            }
        }
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        fixed (byte* pathPtr = &path)
        {
            fixed (ISlangBlob* sourcePtr = &source)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnosticsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob* source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, source, outDiagnostics);
        SilkMarshal.Free((nint)pathPtr);
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, source, outDiagnosticsPtr);
        }
        SilkMarshal.Free((nint)pathPtr);
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (ISlangBlob* sourcePtr = &source)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnostics);
        }
        SilkMarshal.Free((nint)pathPtr);
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (ISlangBlob* sourcePtr = &source)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[5])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnosticsPtr);
            }
        }
        SilkMarshal.Free((nint)pathPtr);
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompositeComponentType(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IComponentType** componentTypes, long componentTypeCount, IComponentType** outCompositeComponentType, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISession*, IComponentType**, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, componentTypes, componentTypeCount, outCompositeComponentType, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompositeComponentType(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IComponentType** componentTypes, long componentTypeCount, IComponentType** outCompositeComponentType, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, IComponentType**, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, componentTypes, componentTypeCount, outCompositeComponentType, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompositeComponentType(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IComponentType** componentTypes, long componentTypeCount, ref IComponentType* outCompositeComponentType, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outCompositeComponentTypePtr = &outCompositeComponentType)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, IComponentType**, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, componentTypes, componentTypeCount, outCompositeComponentTypePtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompositeComponentType(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IComponentType** componentTypes, long componentTypeCount, ref IComponentType* outCompositeComponentType, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** outCompositeComponentTypePtr = &outCompositeComponentType)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, IComponentType**, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, componentTypes, componentTypeCount, outCompositeComponentTypePtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompositeComponentType(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IComponentType* componentTypes, long componentTypeCount, IComponentType** outCompositeComponentType, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** componentTypesPtr = &componentTypes)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, IComponentType**, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, componentTypesPtr, componentTypeCount, outCompositeComponentType, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompositeComponentType(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IComponentType* componentTypes, long componentTypeCount, IComponentType** outCompositeComponentType, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** componentTypesPtr = &componentTypes)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, IComponentType**, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, componentTypesPtr, componentTypeCount, outCompositeComponentType, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompositeComponentType(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IComponentType* componentTypes, long componentTypeCount, ref IComponentType* outCompositeComponentType, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** componentTypesPtr = &componentTypes)
        {
            fixed (IComponentType** outCompositeComponentTypePtr = &outCompositeComponentType)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, IComponentType**, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, componentTypesPtr, componentTypeCount, outCompositeComponentTypePtr, outDiagnostics);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompositeComponentType(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IComponentType* componentTypes, long componentTypeCount, ref IComponentType* outCompositeComponentType, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IComponentType** componentTypesPtr = &componentTypes)
        {
            fixed (IComponentType** outCompositeComponentTypePtr = &outCompositeComponentType)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, IComponentType**, long, IComponentType**, ISlangBlob**, int>)@this->LpVtbl[6])(@this, componentTypesPtr, componentTypeCount, outCompositeComponentTypePtr, outDiagnosticsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe TypeReflection* SpecializeType(this ComPtr<ISession> thisVtbl, TypeReflection* type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        TypeReflection* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, SpecializationArg*, long, ISlangBlob**, TypeReflection*>)@this->LpVtbl[7])(@this, type, specializationArgs, specializationArgCount, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe TypeReflection* SpecializeType(this ComPtr<ISession> thisVtbl, TypeReflection* type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationArg* specializationArgs, long specializationArgCount, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        TypeReflection* ret = default;
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, SpecializationArg*, long, ISlangBlob**, TypeReflection*>)@this->LpVtbl[7])(@this, type, specializationArgs, specializationArgCount, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe TypeReflection* SpecializeType(this ComPtr<ISession> thisVtbl, TypeReflection* type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        TypeReflection* ret = default;
        fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, SpecializationArg*, long, ISlangBlob**, TypeReflection*>)@this->LpVtbl[7])(@this, type, specializationArgsPtr, specializationArgCount, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe TypeReflection* SpecializeType(this ComPtr<ISession> thisVtbl, TypeReflection* type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpecializationArg specializationArgs, long specializationArgCount, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        TypeReflection* ret = default;
        fixed (SpecializationArg* specializationArgsPtr = &specializationArgs)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, SpecializationArg*, long, ISlangBlob**, TypeReflection*>)@this->LpVtbl[7])(@this, type, specializationArgsPtr, specializationArgCount, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe TypeLayoutReflection* GetTypeLayout(this ComPtr<ISession> thisVtbl, TypeReflection* type, long targetIndex, LayoutRules rules, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        TypeLayoutReflection* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, long, LayoutRules, ISlangBlob**, TypeLayoutReflection*>)@this->LpVtbl[8])(@this, type, targetIndex, rules, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe TypeLayoutReflection* GetTypeLayout(this ComPtr<ISession> thisVtbl, TypeReflection* type, long targetIndex, LayoutRules rules, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        TypeLayoutReflection* ret = default;
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, long, LayoutRules, ISlangBlob**, TypeLayoutReflection*>)@this->LpVtbl[8])(@this, type, targetIndex, rules, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe TypeReflection* GetContainerType(this ComPtr<ISession> thisVtbl, TypeReflection* elementType, ContainerType containerType, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        TypeReflection* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, ContainerType, ISlangBlob**, TypeReflection*>)@this->LpVtbl[9])(@this, elementType, containerType, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe TypeReflection* GetContainerType(this ComPtr<ISession> thisVtbl, TypeReflection* elementType, ContainerType containerType, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        TypeReflection* ret = default;
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, ContainerType, ISlangBlob**, TypeReflection*>)@this->LpVtbl[9])(@this, elementType, containerType, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe TypeReflection* GetDynamicType(this ComPtr<ISession> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        TypeReflection* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*>)@this->LpVtbl[10])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeRTTIMangledName(this ComPtr<ISession> thisVtbl, TypeReflection* type, ISlangBlob** outNameBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, ISlangBlob**, int>)@this->LpVtbl[11])(@this, type, outNameBlob);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeRTTIMangledName(this ComPtr<ISession> thisVtbl, TypeReflection* type, ref ISlangBlob* outNameBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangBlob** outNameBlobPtr = &outNameBlob)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, ISlangBlob**, int>)@this->LpVtbl[11])(@this, type, outNameBlobPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeConformanceWitnessMangledName(this ComPtr<ISession> thisVtbl, TypeReflection* type, TypeReflection* interfaceType, ISlangBlob** outNameBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, TypeReflection*, ISlangBlob**, int>)@this->LpVtbl[12])(@this, type, interfaceType, outNameBlob);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeConformanceWitnessMangledName(this ComPtr<ISession> thisVtbl, TypeReflection* type, TypeReflection* interfaceType, ref ISlangBlob* outNameBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangBlob** outNameBlobPtr = &outNameBlob)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, TypeReflection*, ISlangBlob**, int>)@this->LpVtbl[12])(@this, type, interfaceType, outNameBlobPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeConformanceWitnessSequentialID(this ComPtr<ISession> thisVtbl, TypeReflection* type, TypeReflection* interfaceType, uint* outId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, TypeReflection*, uint*, int>)@this->LpVtbl[13])(@this, type, interfaceType, outId);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeConformanceWitnessSequentialID(this ComPtr<ISession> thisVtbl, TypeReflection* type, TypeReflection* interfaceType, ref uint outId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* outIdPtr = &outId)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, TypeReflection*, uint*, int>)@this->LpVtbl[13])(@this, type, interfaceType, outIdPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompileRequest(this ComPtr<ISession> thisVtbl, ICompileRequest** outCompileRequest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISession*, ICompileRequest**, int>)@this->LpVtbl[14])(@this, outCompileRequest);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompileRequest(this ComPtr<ISession> thisVtbl, ref ICompileRequest* outCompileRequest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ICompileRequest** outCompileRequestPtr = &outCompileRequest)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, ICompileRequest**, int>)@this->LpVtbl[14])(@this, outCompileRequestPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTypeConformanceComponentType(this ComPtr<ISession> thisVtbl, TypeReflection* type, TypeReflection* interfaceType, ITypeConformance** outConformance, long conformanceIdOverride, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, TypeReflection*, ITypeConformance**, long, ISlangBlob**, int>)@this->LpVtbl[15])(@this, type, interfaceType, outConformance, conformanceIdOverride, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTypeConformanceComponentType(this ComPtr<ISession> thisVtbl, TypeReflection* type, TypeReflection* interfaceType, ITypeConformance** outConformance, long conformanceIdOverride, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, TypeReflection*, ITypeConformance**, long, ISlangBlob**, int>)@this->LpVtbl[15])(@this, type, interfaceType, outConformance, conformanceIdOverride, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTypeConformanceComponentType(this ComPtr<ISession> thisVtbl, TypeReflection* type, TypeReflection* interfaceType, ref ITypeConformance* outConformance, long conformanceIdOverride, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeConformance** outConformancePtr = &outConformance)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, TypeReflection*, ITypeConformance**, long, ISlangBlob**, int>)@this->LpVtbl[15])(@this, type, interfaceType, outConformancePtr, conformanceIdOverride, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTypeConformanceComponentType(this ComPtr<ISession> thisVtbl, TypeReflection* type, TypeReflection* interfaceType, ref ITypeConformance* outConformance, long conformanceIdOverride, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeConformance** outConformancePtr = &outConformance)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, TypeReflection*, TypeReflection*, ITypeConformance**, long, ISlangBlob**, int>)@this->LpVtbl[15])(@this, type, interfaceType, outConformancePtr, conformanceIdOverride, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob* source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, path, source, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, path, source, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (ISlangBlob* sourcePtr = &source)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, path, sourcePtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (ISlangBlob* sourcePtr = &source)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, path, sourcePtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob* source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* pathPtr = &path)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, pathPtr, source, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* pathPtr = &path)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, pathPtr, source, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* pathPtr = &path)
        {
            fixed (ISlangBlob* sourcePtr = &source)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, pathPtr, sourcePtr, outDiagnostics);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* pathPtr = &path)
        {
            fixed (ISlangBlob* sourcePtr = &source)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, pathPtr, sourcePtr, outDiagnosticsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob* source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, pathPtr, source, outDiagnostics);
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, pathPtr, source, outDiagnosticsPtr);
        }
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (ISlangBlob* sourcePtr = &source)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, pathPtr, sourcePtr, outDiagnostics);
        }
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (ISlangBlob* sourcePtr = &source)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleName, pathPtr, sourcePtr, outDiagnosticsPtr);
            }
        }
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob* source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, path, source, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, path, source, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
            fixed (ISlangBlob* sourcePtr = &source)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, path, sourcePtr, outDiagnostics);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
            fixed (ISlangBlob* sourcePtr = &source)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, path, sourcePtr, outDiagnosticsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob* source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, source, outDiagnostics);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
            fixed (byte* pathPtr = &path)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, source, outDiagnosticsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
            fixed (byte* pathPtr = &path)
            {
                fixed (ISlangBlob* sourcePtr = &source)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnostics);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
            fixed (byte* pathPtr = &path)
            {
                fixed (ISlangBlob* sourcePtr = &source)
                {
                    fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnosticsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob* source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, source, outDiagnostics);
        SilkMarshal.Free((nint)pathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, source, outDiagnosticsPtr);
            }
        SilkMarshal.Free((nint)pathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (ISlangBlob* sourcePtr = &source)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnostics);
            }
        SilkMarshal.Free((nint)pathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (ISlangBlob* sourcePtr = &source)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnosticsPtr);
                }
            }
        SilkMarshal.Free((nint)pathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob* source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, path, source, outDiagnostics);
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, path, source, outDiagnosticsPtr);
        }
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        fixed (ISlangBlob* sourcePtr = &source)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, path, sourcePtr, outDiagnostics);
        }
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        fixed (ISlangBlob* sourcePtr = &source)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, path, sourcePtr, outDiagnosticsPtr);
            }
        }
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob* source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        fixed (byte* pathPtr = &path)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, source, outDiagnostics);
        }
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        fixed (byte* pathPtr = &path)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, source, outDiagnosticsPtr);
            }
        }
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        fixed (byte* pathPtr = &path)
        {
            fixed (ISlangBlob* sourcePtr = &source)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnostics);
            }
        }
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        fixed (byte* pathPtr = &path)
        {
            fixed (ISlangBlob* sourcePtr = &source)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnosticsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob* source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, source, outDiagnostics);
        SilkMarshal.Free((nint)pathPtr);
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, source, outDiagnosticsPtr);
        }
        SilkMarshal.Free((nint)pathPtr);
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (ISlangBlob* sourcePtr = &source)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnostics);
        }
        SilkMarshal.Free((nint)pathPtr);
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref ISlangBlob source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (ISlangBlob* sourcePtr = &source)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, ISlangBlob*, ISlangBlob**, IModule*>)@this->LpVtbl[16])(@this, moduleNamePtr, pathPtr, sourcePtr, outDiagnosticsPtr);
            }
        }
        SilkMarshal.Free((nint)pathPtr);
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static long GetLoadedModuleCount(this ComPtr<ISession> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        long ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISession*, long>)@this->LpVtbl[17])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* GetLoadedModule(this ComPtr<ISession> thisVtbl, long index)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISession*, long, IModule*>)@this->LpVtbl[18])(@this, index);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe bool IsBinaryModuleUpToDate(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* modulePath, ISlangBlob* binaryModuleBlob)
    {
        var @this = thisVtbl.Handle;
        bool ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, ISlangBlob*, bool>)@this->LpVtbl[19])(@this, modulePath, binaryModuleBlob);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe bool IsBinaryModuleUpToDate(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* modulePath, ref ISlangBlob binaryModuleBlob)
    {
        var @this = thisVtbl.Handle;
        bool ret = default;
        fixed (ISlangBlob* binaryModuleBlobPtr = &binaryModuleBlob)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, ISlangBlob*, bool>)@this->LpVtbl[19])(@this, modulePath, binaryModuleBlobPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe bool IsBinaryModuleUpToDate(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte modulePath, ISlangBlob* binaryModuleBlob)
    {
        var @this = thisVtbl.Handle;
        bool ret = default;
        fixed (byte* modulePathPtr = &modulePath)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, ISlangBlob*, bool>)@this->LpVtbl[19])(@this, modulePathPtr, binaryModuleBlob);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static bool IsBinaryModuleUpToDate(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte modulePath, ref ISlangBlob binaryModuleBlob)
    {
        var @this = thisVtbl.Handle;
        bool ret = default;
        fixed (byte* modulePathPtr = &modulePath)
        {
            fixed (ISlangBlob* binaryModuleBlobPtr = &binaryModuleBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, ISlangBlob*, bool>)@this->LpVtbl[19])(@this, modulePathPtr, binaryModuleBlobPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe bool IsBinaryModuleUpToDate(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string modulePath, ISlangBlob* binaryModuleBlob)
    {
        var @this = thisVtbl.Handle;
        bool ret = default;
        var modulePathPtr = (byte*) SilkMarshal.StringToPtr(modulePath, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, ISlangBlob*, bool>)@this->LpVtbl[19])(@this, modulePathPtr, binaryModuleBlob);
        SilkMarshal.Free((nint)modulePathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static bool IsBinaryModuleUpToDate(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string modulePath, ref ISlangBlob binaryModuleBlob)
    {
        var @this = thisVtbl.Handle;
        bool ret = default;
        var modulePathPtr = (byte*) SilkMarshal.StringToPtr(modulePath, NativeStringEncoding.UTF8);
        fixed (ISlangBlob* binaryModuleBlobPtr = &binaryModuleBlob)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, ISlangBlob*, bool>)@this->LpVtbl[19])(@this, modulePathPtr, binaryModuleBlobPtr);
        }
        SilkMarshal.Free((nint)modulePathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, path, @string, outDiagnostics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, path, @string, outDiagnosticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* @stringPtr = &@string)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, path, @stringPtr, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* @stringPtr = &@string)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, path, @stringPtr, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, path, @stringPtr, outDiagnostics);
        SilkMarshal.Free((nint)@stringPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, path, @stringPtr, outDiagnosticsPtr);
        }
        SilkMarshal.Free((nint)@stringPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* pathPtr = &path)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @string, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* pathPtr = &path)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @string, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* pathPtr = &path)
        {
            fixed (byte* @stringPtr = &@string)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @stringPtr, outDiagnostics);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* pathPtr = &path)
        {
            fixed (byte* @stringPtr = &@string)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @stringPtr, outDiagnosticsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* pathPtr = &path)
        {
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @stringPtr, outDiagnostics);
        SilkMarshal.Free((nint)@stringPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* pathPtr = &path)
        {
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @stringPtr, outDiagnosticsPtr);
            }
        SilkMarshal.Free((nint)@stringPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @string, outDiagnostics);
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @string, outDiagnosticsPtr);
        }
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (byte* @stringPtr = &@string)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @stringPtr, outDiagnostics);
        }
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (byte* @stringPtr = &@string)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @stringPtr, outDiagnosticsPtr);
            }
        }
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @stringPtr, outDiagnostics);
        SilkMarshal.Free((nint)@stringPtr);
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleName, pathPtr, @stringPtr, outDiagnosticsPtr);
        }
        SilkMarshal.Free((nint)@stringPtr);
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @string, outDiagnostics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @string, outDiagnosticsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
            fixed (byte* @stringPtr = &@string)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @stringPtr, outDiagnostics);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
            fixed (byte* @stringPtr = &@string)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @stringPtr, outDiagnosticsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @stringPtr, outDiagnostics);
        SilkMarshal.Free((nint)@stringPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @stringPtr, outDiagnosticsPtr);
            }
        SilkMarshal.Free((nint)@stringPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
            fixed (byte* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @string, outDiagnostics);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
            fixed (byte* pathPtr = &path)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @string, outDiagnosticsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
            fixed (byte* pathPtr = &path)
            {
                fixed (byte* @stringPtr = &@string)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnostics);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
            fixed (byte* pathPtr = &path)
            {
                fixed (byte* @stringPtr = &@string)
                {
                    fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnosticsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
            fixed (byte* pathPtr = &path)
            {
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnostics);
        SilkMarshal.Free((nint)@stringPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
            fixed (byte* pathPtr = &path)
            {
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnosticsPtr);
                }
        SilkMarshal.Free((nint)@stringPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @string, outDiagnostics);
        SilkMarshal.Free((nint)pathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @string, outDiagnosticsPtr);
            }
        SilkMarshal.Free((nint)pathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (byte* @stringPtr = &@string)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnostics);
            }
        SilkMarshal.Free((nint)pathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (byte* @stringPtr = &@string)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnosticsPtr);
                }
            }
        SilkMarshal.Free((nint)pathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnostics);
        SilkMarshal.Free((nint)@stringPtr);
        SilkMarshal.Free((nint)pathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        fixed (byte* moduleNamePtr = &moduleName)
        {
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnosticsPtr);
            }
        SilkMarshal.Free((nint)@stringPtr);
        SilkMarshal.Free((nint)pathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @string, outDiagnostics);
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @string, outDiagnosticsPtr);
        }
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        fixed (byte* @stringPtr = &@string)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @stringPtr, outDiagnostics);
        }
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        fixed (byte* @stringPtr = &@string)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @stringPtr, outDiagnosticsPtr);
            }
        }
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @stringPtr, outDiagnostics);
        SilkMarshal.Free((nint)@stringPtr);
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, path, @stringPtr, outDiagnosticsPtr);
        }
        SilkMarshal.Free((nint)@stringPtr);
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        fixed (byte* pathPtr = &path)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @string, outDiagnostics);
        }
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        fixed (byte* pathPtr = &path)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @string, outDiagnosticsPtr);
            }
        }
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        fixed (byte* pathPtr = &path)
        {
            fixed (byte* @stringPtr = &@string)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnostics);
            }
        }
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        fixed (byte* pathPtr = &path)
        {
            fixed (byte* @stringPtr = &@string)
            {
                fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnosticsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        fixed (byte* pathPtr = &path)
        {
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnostics);
        SilkMarshal.Free((nint)@stringPtr);
        }
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        fixed (byte* pathPtr = &path)
        {
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnosticsPtr);
            }
        SilkMarshal.Free((nint)@stringPtr);
        }
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @string, outDiagnostics);
        SilkMarshal.Free((nint)pathPtr);
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @string, outDiagnosticsPtr);
        }
        SilkMarshal.Free((nint)pathPtr);
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (byte* @stringPtr = &@string)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnostics);
        }
        SilkMarshal.Free((nint)pathPtr);
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (byte* @stringPtr = &@string)
        {
            fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnosticsPtr);
            }
        }
        SilkMarshal.Free((nint)pathPtr);
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnostics);
        SilkMarshal.Free((nint)@stringPtr);
        SilkMarshal.Free((nint)pathPtr);
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        IModule* ret = default;
        var moduleNamePtr = (byte*) SilkMarshal.StringToPtr(moduleName, NativeStringEncoding.UTF8);
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        fixed (ISlangBlob** outDiagnosticsPtr = &outDiagnostics)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISession*, byte*, byte*, byte*, ISlangBlob**, IModule*>)@this->LpVtbl[20])(@this, moduleNamePtr, pathPtr, @stringPtr, outDiagnosticsPtr);
        }
        SilkMarshal.Free((nint)@stringPtr);
        SilkMarshal.Free((nint)pathPtr);
        SilkMarshal.Free((nint)moduleNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Uuid> uuid, void** outObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(in uuid.GetPinnableReference(), outObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Uuid> uuid, ref void* outObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(in uuid.GetPinnableReference(), ref outObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModule(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModule(in moduleName.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModule(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModule(in moduleName.GetPinnableReference(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, Span<ISlangBlob> source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSource(moduleName, path, ref source.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, Span<ISlangBlob> source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSource(moduleName, path, ref source.GetPinnableReference(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, ISlangBlob* source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSource(moduleName, in path.GetPinnableReference(), source, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSource(moduleName, in path.GetPinnableReference(), source, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, Span<ISlangBlob> source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSource(moduleName, in path.GetPinnableReference(), ref source.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, Span<ISlangBlob> source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSource(moduleName, in path.GetPinnableReference(), ref source.GetPinnableReference(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, Span<ISlangBlob> source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSource(moduleName, path, ref source.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, Span<ISlangBlob> source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSource(moduleName, path, ref source.GetPinnableReference(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob* source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSource(in moduleName.GetPinnableReference(), path, source, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSource(in moduleName.GetPinnableReference(), path, source, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, Span<ISlangBlob> source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSource(in moduleName.GetPinnableReference(), path, ref source.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, Span<ISlangBlob> source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSource(in moduleName.GetPinnableReference(), path, ref source.GetPinnableReference(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, ISlangBlob* source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSource(in moduleName.GetPinnableReference(), in path.GetPinnableReference(), source, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSource(in moduleName.GetPinnableReference(), in path.GetPinnableReference(), source, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, Span<ISlangBlob> source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSource(in moduleName.GetPinnableReference(), in path.GetPinnableReference(), ref source.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, Span<ISlangBlob> source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSource(in moduleName.GetPinnableReference(), in path.GetPinnableReference(), ref source.GetPinnableReference(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob* source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSource(in moduleName.GetPinnableReference(), path, source, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSource(in moduleName.GetPinnableReference(), path, source, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, Span<ISlangBlob> source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSource(in moduleName.GetPinnableReference(), path, ref source.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, Span<ISlangBlob> source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSource(in moduleName.GetPinnableReference(), path, ref source.GetPinnableReference(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, Span<ISlangBlob> source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSource(moduleName, path, ref source.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, Span<ISlangBlob> source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSource(moduleName, path, ref source.GetPinnableReference(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, ISlangBlob* source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSource(moduleName, in path.GetPinnableReference(), source, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSource(moduleName, in path.GetPinnableReference(), source, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, Span<ISlangBlob> source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSource(moduleName, in path.GetPinnableReference(), ref source.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, Span<ISlangBlob> source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSource(moduleName, in path.GetPinnableReference(), ref source.GetPinnableReference(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, Span<ISlangBlob> source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSource(moduleName, path, ref source.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSource(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, Span<ISlangBlob> source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSource(moduleName, path, ref source.GetPinnableReference(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompositeComponentType<TI0, TI1>(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> componentTypes, long componentTypeCount, ref ComPtr<TI1> outCompositeComponentType, ISlangBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCompositeComponentType((IComponentType**) componentTypes.GetAddressOf(), componentTypeCount, (IComponentType**) outCompositeComponentType.GetAddressOf(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompositeComponentType<TI0, TI1>(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> componentTypes, long componentTypeCount, ref ComPtr<TI1> outCompositeComponentType, ref ISlangBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCompositeComponentType((IComponentType**) componentTypes.GetAddressOf(), componentTypeCount, (IComponentType**) outCompositeComponentType.GetAddressOf(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompositeComponentType<TI0>(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> componentTypes, long componentTypeCount, ref IComponentType* outCompositeComponentType, ISlangBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCompositeComponentType((IComponentType**) componentTypes.GetAddressOf(), componentTypeCount, ref outCompositeComponentType, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompositeComponentType<TI0>(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> componentTypes, long componentTypeCount, ref IComponentType* outCompositeComponentType, ref ISlangBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCompositeComponentType((IComponentType**) componentTypes.GetAddressOf(), componentTypeCount, ref outCompositeComponentType, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompositeComponentType<TI0>(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IComponentType* componentTypes, long componentTypeCount, ref ComPtr<TI0> outCompositeComponentType, ISlangBlob** outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCompositeComponentType(in componentTypes, componentTypeCount, (IComponentType**) outCompositeComponentType.GetAddressOf(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompositeComponentType<TI0>(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IComponentType* componentTypes, long componentTypeCount, ref ComPtr<TI0> outCompositeComponentType, ref ISlangBlob* outDiagnostics) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCompositeComponentType(in componentTypes, componentTypeCount, (IComponentType**) outCompositeComponentType.GetAddressOf(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe TypeReflection* SpecializeType(this ComPtr<ISession> thisVtbl, TypeReflection* type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpecializationArg> specializationArgs, long specializationArgCount, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SpecializeType(type, in specializationArgs.GetPinnableReference(), specializationArgCount, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe TypeReflection* SpecializeType(this ComPtr<ISession> thisVtbl, TypeReflection* type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpecializationArg> specializationArgs, long specializationArgCount, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SpecializeType(type, in specializationArgs.GetPinnableReference(), specializationArgCount, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeConformanceWitnessSequentialID(this ComPtr<ISession> thisVtbl, TypeReflection* type, TypeReflection* interfaceType, Span<uint> outId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTypeConformanceWitnessSequentialID(type, interfaceType, ref outId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, Span<ISlangBlob> source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromIRBlob(moduleName, path, ref source.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, Span<ISlangBlob> source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromIRBlob(moduleName, path, ref source.GetPinnableReference(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, ISlangBlob* source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromIRBlob(moduleName, in path.GetPinnableReference(), source, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromIRBlob(moduleName, in path.GetPinnableReference(), source, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, Span<ISlangBlob> source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromIRBlob(moduleName, in path.GetPinnableReference(), ref source.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, Span<ISlangBlob> source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromIRBlob(moduleName, in path.GetPinnableReference(), ref source.GetPinnableReference(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, Span<ISlangBlob> source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromIRBlob(moduleName, path, ref source.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, Span<ISlangBlob> source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromIRBlob(moduleName, path, ref source.GetPinnableReference(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob* source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromIRBlob(in moduleName.GetPinnableReference(), path, source, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromIRBlob(in moduleName.GetPinnableReference(), path, source, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, Span<ISlangBlob> source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromIRBlob(in moduleName.GetPinnableReference(), path, ref source.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, Span<ISlangBlob> source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromIRBlob(in moduleName.GetPinnableReference(), path, ref source.GetPinnableReference(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, ISlangBlob* source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromIRBlob(in moduleName.GetPinnableReference(), in path.GetPinnableReference(), source, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromIRBlob(in moduleName.GetPinnableReference(), in path.GetPinnableReference(), source, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, Span<ISlangBlob> source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromIRBlob(in moduleName.GetPinnableReference(), in path.GetPinnableReference(), ref source.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, Span<ISlangBlob> source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromIRBlob(in moduleName.GetPinnableReference(), in path.GetPinnableReference(), ref source.GetPinnableReference(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob* source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromIRBlob(in moduleName.GetPinnableReference(), path, source, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromIRBlob(in moduleName.GetPinnableReference(), path, source, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, Span<ISlangBlob> source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromIRBlob(in moduleName.GetPinnableReference(), path, ref source.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, Span<ISlangBlob> source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromIRBlob(in moduleName.GetPinnableReference(), path, ref source.GetPinnableReference(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, Span<ISlangBlob> source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromIRBlob(moduleName, path, ref source.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, Span<ISlangBlob> source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromIRBlob(moduleName, path, ref source.GetPinnableReference(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, ISlangBlob* source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromIRBlob(moduleName, in path.GetPinnableReference(), source, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, ISlangBlob* source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromIRBlob(moduleName, in path.GetPinnableReference(), source, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, Span<ISlangBlob> source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromIRBlob(moduleName, in path.GetPinnableReference(), ref source.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, Span<ISlangBlob> source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromIRBlob(moduleName, in path.GetPinnableReference(), ref source.GetPinnableReference(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, Span<ISlangBlob> source, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromIRBlob(moduleName, path, ref source.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromIRBlob(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, Span<ISlangBlob> source, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromIRBlob(moduleName, path, ref source.GetPinnableReference(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe bool IsBinaryModuleUpToDate(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* modulePath, Span<ISlangBlob> binaryModuleBlob)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsBinaryModuleUpToDate(modulePath, ref binaryModuleBlob.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe bool IsBinaryModuleUpToDate(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> modulePath, ISlangBlob* binaryModuleBlob)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsBinaryModuleUpToDate(in modulePath.GetPinnableReference(), binaryModuleBlob);
    }

    /// <summary>To be documented.</summary>
    public static bool IsBinaryModuleUpToDate(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> modulePath, Span<ISlangBlob> binaryModuleBlob)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsBinaryModuleUpToDate(in modulePath.GetPinnableReference(), ref binaryModuleBlob.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static bool IsBinaryModuleUpToDate(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string modulePath, Span<ISlangBlob> binaryModuleBlob)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsBinaryModuleUpToDate(modulePath, ref binaryModuleBlob.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(moduleName, path, in @string.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(moduleName, path, in @string.GetPinnableReference(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(moduleName, in path.GetPinnableReference(), @string, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(moduleName, in path.GetPinnableReference(), @string, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(moduleName, in path.GetPinnableReference(), in @string.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(moduleName, in path.GetPinnableReference(), in @string.GetPinnableReference(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(moduleName, in path.GetPinnableReference(), @string, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(moduleName, in path.GetPinnableReference(), @string, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(moduleName, path, in @string.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(moduleName, path, in @string.GetPinnableReference(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(in moduleName.GetPinnableReference(), path, @string, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(in moduleName.GetPinnableReference(), path, @string, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(in moduleName.GetPinnableReference(), path, in @string.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(in moduleName.GetPinnableReference(), path, in @string.GetPinnableReference(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(in moduleName.GetPinnableReference(), path, @string, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(in moduleName.GetPinnableReference(), path, @string, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(in moduleName.GetPinnableReference(), in path.GetPinnableReference(), @string, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(in moduleName.GetPinnableReference(), in path.GetPinnableReference(), @string, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(in moduleName.GetPinnableReference(), in path.GetPinnableReference(), in @string.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(in moduleName.GetPinnableReference(), in path.GetPinnableReference(), in @string.GetPinnableReference(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(in moduleName.GetPinnableReference(), in path.GetPinnableReference(), @string, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(in moduleName.GetPinnableReference(), in path.GetPinnableReference(), @string, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(in moduleName.GetPinnableReference(), path, @string, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(in moduleName.GetPinnableReference(), path, @string, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(in moduleName.GetPinnableReference(), path, in @string.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(in moduleName.GetPinnableReference(), path, in @string.GetPinnableReference(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(in moduleName.GetPinnableReference(), path, @string, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(in moduleName.GetPinnableReference(), path, @string, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(moduleName, path, in @string.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(moduleName, path, in @string.GetPinnableReference(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(moduleName, in path.GetPinnableReference(), @string, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(moduleName, in path.GetPinnableReference(), @string, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(moduleName, in path.GetPinnableReference(), in @string.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(moduleName, in path.GetPinnableReference(), in @string.GetPinnableReference(), ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(moduleName, in path.GetPinnableReference(), @string, outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(moduleName, in path.GetPinnableReference(), @string, ref outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> @string, ISlangBlob** outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(moduleName, path, in @string.GetPinnableReference(), outDiagnostics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe IModule* LoadModuleFromSourceString(this ComPtr<ISession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> @string, ref ISlangBlob* outDiagnostics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadModuleFromSourceString(moduleName, path, in @string.GetPinnableReference(), ref outDiagnostics);
    }

}
