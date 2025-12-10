// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Generated using the OpenAL Soft headers and corresponding dependencies.
// Original source is licensed under the LGPL 2.0 license. Please note that while bindings are able to be MIT due to
// being header-derived only, implementations of the headers may have a less permissive license.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenAL;

public unsafe partial interface IALContext
{
    public partial interface Static
    {
        [return: NativeTypeName("ALCboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
        static abstract MaybeBool<sbyte> CaptureCloseDevice(DeviceHandle device);

        [return: NativeTypeName("ALCboolean")]
        [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
        static abstract sbyte CaptureCloseDeviceRaw(DeviceHandle device);

        [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
        static abstract DeviceHandle CaptureOpenDevice(
            [NativeTypeName("const ALCchar *")] sbyte* devicename,
            [NativeTypeName("ALCuint")] uint frequency,
            [NativeTypeName("ALCenum")] int format,
            [NativeTypeName("ALCsizei")] int buffersize
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
        static abstract DeviceHandle CaptureOpenDevice(
            [NativeTypeName("const ALCchar *")] Ref<sbyte> devicename,
            [NativeTypeName("ALCuint")] uint frequency,
            [NativeTypeName("ALCenum")] Constant<int, ALEnum, Format> format,
            [NativeTypeName("ALCsizei")] int buffersize
        );

        [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
        static abstract void CaptureSamples(
            DeviceHandle device,
            [NativeTypeName("ALCvoid *")] void* buffer,
            [NativeTypeName("ALCsizei")] int samples
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
        static abstract void CaptureSamples(
            DeviceHandle device,
            [NativeTypeName("ALCvoid *")] Ref buffer,
            [NativeTypeName("ALCsizei")] int samples
        );

        [NativeFunction("openal", EntryPoint = "alcCaptureStart")]
        static abstract void CaptureStart(DeviceHandle device);

        [NativeFunction("openal", EntryPoint = "alcCaptureStop")]
        static abstract void CaptureStop(DeviceHandle device);

        [return: NativeTypeName("ALCboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
        static abstract MaybeBool<sbyte> CloseDevice(DeviceHandle device);

        [return: NativeTypeName("ALCboolean")]
        [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
        static abstract sbyte CloseDeviceRaw(DeviceHandle device);

        [NativeFunction("openal", EntryPoint = "alcCreateContext")]
        static abstract ContextHandle CreateContext(
            DeviceHandle device,
            [NativeTypeName("const ALCint *")] int* attrlist
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcCreateContext")]
        static abstract ContextHandle CreateContext(
            DeviceHandle device,
            [NativeTypeName("const ALCint *")] Ref<int> attrlist
        );

        [NativeFunction("openal", EntryPoint = "alcDestroyContext")]
        static abstract void DestroyContext(ContextHandle context);

        [NativeFunction("openal", EntryPoint = "alcDevicePauseSOFT")]
        static abstract void DevicePauseSOFT(DeviceHandle device);

        [NativeFunction("openal", EntryPoint = "alcDeviceResumeSOFT")]
        static abstract void DeviceResumeSOFT(DeviceHandle device);

        [NativeFunction("openal", EntryPoint = "alcEventCallbackSOFT")]
        static abstract void EventCallbackSOFT(
            [NativeTypeName("ALCEVENTPROCTYPESOFT")] ContextEventProcSOFT callback,
            void* userParam
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcEventCallbackSOFT")]
        static abstract void EventCallbackSOFT(
            [NativeTypeName("ALCEVENTPROCTYPESOFT")] ContextEventProcSOFT callback,
            Ref userParam
        );

        [return: NativeTypeName("ALCboolean")]
        [NativeFunction("openal", EntryPoint = "alcEventControlSOFT")]
        static abstract sbyte EventControlSOFT(
            [NativeTypeName("ALCsizei")] int count,
            [NativeTypeName("const ALCenum *")] int* events,
            [NativeTypeName("ALCboolean")] sbyte enable
        );

        [return: NativeTypeName("ALCboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcEventControlSOFT")]
        static abstract MaybeBool<sbyte> EventControlSOFT(
            [NativeTypeName("ALCsizei")] int count,
            [NativeTypeName("const ALCenum *")] Ref<int> events,
            [NativeTypeName("ALCboolean")] MaybeBool<sbyte> enable
        );

        [return: NativeTypeName("ALCenum")]
        [NativeFunction("openal", EntryPoint = "alcEventIsSupportedSOFT")]
        static abstract int EventIsSupportedSOFT(
            [NativeTypeName("ALCenum")] int eventType,
            [NativeTypeName("ALCenum")] int deviceType
        );

        [return: NativeTypeName("ALCenum")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcEventIsSupportedSOFT")]
        static abstract Constant<int, ALCEnum, EventSupportSOFT> EventIsSupportedSOFT(
            [NativeTypeName("ALCenum")] Constant<int, ALCEnum, SystemEventTypeSOFT> eventType,
            [NativeTypeName("ALCenum")] Constant<int, ALCEnum, DeviceTypeSOFT> deviceType
        );

        [NativeFunction("openal", EntryPoint = "alcGetContextsDevice")]
        static abstract DeviceHandle GetContextsDevice(ContextHandle context);

        [NativeFunction("openal", EntryPoint = "alcGetCurrentContext")]
        static abstract ContextHandle GetCurrentContext();

        [return: NativeTypeName("ALCenum")]
        [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
        static abstract int GetEnumValue(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* enumname
        );

        [return: NativeTypeName("ALCenum")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
        static abstract int GetEnumValue(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] Ref<sbyte> enumname
        );

        [return: NativeTypeName("ALCenum")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetError")]
        static abstract Constant<int, ALCEnum, ContextErrorCode> GetError(DeviceHandle device);

        [return: NativeTypeName("ALCenum")]
        [NativeFunction("openal", EntryPoint = "alcGetError")]
        static abstract int GetErrorRaw(DeviceHandle device);

        [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
        static abstract void GetInteger64SOFT(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int pname,
            [NativeTypeName("ALsizei")] int size,
            [NativeTypeName("ALCint64SOFT *")] long* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
        static abstract void GetInteger64SOFT(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int pname,
            [NativeTypeName("ALsizei")] int size,
            [NativeTypeName("ALCint64SOFT *")] Ref<long> values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
        static abstract long GetInteger64SOFT(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int pname
        );

        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        static abstract void GetInteger(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int param1,
            [NativeTypeName("ALCsizei")] int size,
            [NativeTypeName("ALCint *")] int* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        static abstract void GetInteger(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int param1,
            [NativeTypeName("ALCsizei")] int size,
            [NativeTypeName("ALCint *")] Ref<int> values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        static abstract int GetInteger(DeviceHandle device, [NativeTypeName("ALCenum")] int param1);

        [return: NativeTypeName("ALCvoid *")]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
        static abstract void* GetProcAddress(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* funcname
        );

        [return: NativeTypeName("ALCvoid *")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
        static abstract Ptr GetProcAddress(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] Ref<sbyte> funcname
        );

        [return: NativeTypeName("ALCvoid *")]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress2")]
        static abstract void* GetProcAddress2(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* funcName
        );

        [return: NativeTypeName("ALCvoid *")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress2")]
        static abstract Ptr GetProcAddress2(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] Ref<sbyte> funcName
        );

        [return: NativeTypeName("const ALCchar *")]
        [NativeFunction("openal", EntryPoint = "alcGetString")]
        static abstract sbyte* GetString(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int param1
        );

        [return: NativeTypeName("const ALCchar *")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetString")]
        static abstract Ptr<sbyte> GetString(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] Constant<int, ALCEnum, ContextString> param1
        );

        [return: NativeTypeName("const ALCchar *")]
        [NativeFunction("openal", EntryPoint = "alcGetStringiSOFT")]
        static abstract sbyte* GetStringSOFT(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int paramName,
            [NativeTypeName("ALCsizei")] int index
        );

        [return: NativeTypeName("const ALCchar *")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetStringiSOFT")]
        static abstract Ptr<sbyte> GetStringSOFT(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] Constant<int, ALCEnum, ContextString> paramName,
            [NativeTypeName("ALCsizei")] int index
        );

        [NativeFunction("openal", EntryPoint = "alcGetThreadContext")]
        static abstract ContextHandle GetThreadContext();

        [return: NativeTypeName("ALCboolean")]
        [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
        static abstract sbyte IsExtensionPresent(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* extname
        );

        [return: NativeTypeName("ALCboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
        static abstract MaybeBool<sbyte> IsExtensionPresent(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] Ref<sbyte> extname
        );

        [return: NativeTypeName("ALCboolean")]
        [NativeFunction("openal", EntryPoint = "alcIsRenderFormatSupportedSOFT")]
        static abstract sbyte IsRenderFormatSupportedSOFT(
            DeviceHandle device,
            [NativeTypeName("ALCsizei")] int freq,
            [NativeTypeName("ALCenum")] int channels,
            [NativeTypeName("ALCenum")] int type
        );

        [return: NativeTypeName("ALCboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcIsRenderFormatSupportedSOFT")]
        static abstract MaybeBool<sbyte> IsRenderFormatSupportedSOFT(
            DeviceHandle device,
            [NativeTypeName("ALCsizei")] int freq,
            [NativeTypeName("ALCenum")] Constant<int, ALCEnum, RenderFormatChannelSOFT> channels,
            [NativeTypeName("ALCenum")] Constant<int, ALCEnum, RenderFormatTypeSOFT> type
        );

        [NativeFunction("openal", EntryPoint = "alcLoopbackOpenDeviceSOFT")]
        static abstract DeviceHandle LoopbackOpenDeviceSOFT(
            [NativeTypeName("const ALCchar *")] sbyte* deviceName
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcLoopbackOpenDeviceSOFT")]
        static abstract DeviceHandle LoopbackOpenDeviceSOFT(
            [NativeTypeName("const ALCchar *")] Ref<sbyte> deviceName
        );

        [return: NativeTypeName("ALCboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
        static abstract MaybeBool<sbyte> MakeContextCurrent(ContextHandle context);

        [return: NativeTypeName("ALCboolean")]
        [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
        static abstract sbyte MakeContextCurrentRaw(ContextHandle context);

        [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
        static abstract DeviceHandle OpenDevice(
            [NativeTypeName("const ALCchar *")] sbyte* devicename
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
        static abstract DeviceHandle OpenDevice(
            [NativeTypeName("const ALCchar *")] Ref<sbyte> devicename
        );

        [NativeFunction("openal", EntryPoint = "alcProcessContext")]
        static abstract void ProcessContext(ContextHandle context);

        [NativeFunction("openal", EntryPoint = "alcRenderSamplesSOFT")]
        static abstract void RenderSamplesSOFT(
            DeviceHandle device,
            [NativeTypeName("ALCvoid *")] void* buffer,
            [NativeTypeName("ALCsizei")] int samples
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcRenderSamplesSOFT")]
        static abstract void RenderSamplesSOFT(
            DeviceHandle device,
            [NativeTypeName("ALCvoid *")] Ref buffer,
            [NativeTypeName("ALCsizei")] int samples
        );

        [return: NativeTypeName("ALCboolean")]
        [NativeFunction("openal", EntryPoint = "alcReopenDeviceSOFT")]
        static abstract sbyte ReopenDeviceSOFT(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* deviceName,
            [NativeTypeName("const ALCint *")] int* attribs
        );

        [return: NativeTypeName("ALCboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcReopenDeviceSOFT")]
        static abstract MaybeBool<sbyte> ReopenDeviceSOFT(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] Ref<sbyte> deviceName,
            [NativeTypeName("const ALCint *")] Ref<int> attribs
        );

        [return: NativeTypeName("ALCboolean")]
        [NativeFunction("openal", EntryPoint = "alcResetDeviceSOFT")]
        static abstract sbyte ResetDeviceSOFT(
            DeviceHandle device,
            [NativeTypeName("const ALCint *")] int* attribs
        );

        [return: NativeTypeName("ALCboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcResetDeviceSOFT")]
        static abstract MaybeBool<sbyte> ResetDeviceSOFT(
            DeviceHandle device,
            [NativeTypeName("const ALCint *")] Ref<int> attribs
        );

        [return: NativeTypeName("ALCboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcSetThreadContext")]
        static abstract MaybeBool<sbyte> SetThreadContext(ContextHandle context);

        [return: NativeTypeName("ALCboolean")]
        [NativeFunction("openal", EntryPoint = "alcSetThreadContext")]
        static abstract sbyte SetThreadContextRaw(ContextHandle context);

        [NativeFunction("openal", EntryPoint = "alcSuspendContext")]
        static abstract void SuspendContext(ContextHandle context);
    }

    [return: NativeTypeName("ALCboolean")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
    MaybeBool<sbyte> CaptureCloseDevice(DeviceHandle device);

    [return: NativeTypeName("ALCboolean")]
    [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
    sbyte CaptureCloseDeviceRaw(DeviceHandle device);

    [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
    DeviceHandle CaptureOpenDevice(
        [NativeTypeName("const ALCchar *")] sbyte* devicename,
        [NativeTypeName("ALCuint")] uint frequency,
        [NativeTypeName("ALCenum")] int format,
        [NativeTypeName("ALCsizei")] int buffersize
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
    DeviceHandle CaptureOpenDevice(
        [NativeTypeName("const ALCchar *")] Ref<sbyte> devicename,
        [NativeTypeName("ALCuint")] uint frequency,
        [NativeTypeName("ALCenum")] Constant<int, ALEnum, Format> format,
        [NativeTypeName("ALCsizei")] int buffersize
    );

    [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
    void CaptureSamples(
        DeviceHandle device,
        [NativeTypeName("ALCvoid *")] void* buffer,
        [NativeTypeName("ALCsizei")] int samples
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
    void CaptureSamples(
        DeviceHandle device,
        [NativeTypeName("ALCvoid *")] Ref buffer,
        [NativeTypeName("ALCsizei")] int samples
    );

    [NativeFunction("openal", EntryPoint = "alcCaptureStart")]
    void CaptureStart(DeviceHandle device);

    [NativeFunction("openal", EntryPoint = "alcCaptureStop")]
    void CaptureStop(DeviceHandle device);

    [return: NativeTypeName("ALCboolean")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
    MaybeBool<sbyte> CloseDevice(DeviceHandle device);

    [return: NativeTypeName("ALCboolean")]
    [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
    sbyte CloseDeviceRaw(DeviceHandle device);

    [NativeFunction("openal", EntryPoint = "alcCreateContext")]
    ContextHandle CreateContext(
        DeviceHandle device,
        [NativeTypeName("const ALCint *")] int* attrlist
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcCreateContext")]
    ContextHandle CreateContext(
        DeviceHandle device,
        [NativeTypeName("const ALCint *")] Ref<int> attrlist
    );

    [NativeFunction("openal", EntryPoint = "alcDestroyContext")]
    void DestroyContext(ContextHandle context);

    [NativeFunction("openal", EntryPoint = "alcDevicePauseSOFT")]
    void DevicePauseSOFT(DeviceHandle device);

    [NativeFunction("openal", EntryPoint = "alcDeviceResumeSOFT")]
    void DeviceResumeSOFT(DeviceHandle device);

    [NativeFunction("openal", EntryPoint = "alcEventCallbackSOFT")]
    void EventCallbackSOFT(
        [NativeTypeName("ALCEVENTPROCTYPESOFT")] ContextEventProcSOFT callback,
        void* userParam
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcEventCallbackSOFT")]
    void EventCallbackSOFT(
        [NativeTypeName("ALCEVENTPROCTYPESOFT")] ContextEventProcSOFT callback,
        Ref userParam
    );

    [return: NativeTypeName("ALCboolean")]
    [NativeFunction("openal", EntryPoint = "alcEventControlSOFT")]
    sbyte EventControlSOFT(
        [NativeTypeName("ALCsizei")] int count,
        [NativeTypeName("const ALCenum *")] int* events,
        [NativeTypeName("ALCboolean")] sbyte enable
    );

    [return: NativeTypeName("ALCboolean")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcEventControlSOFT")]
    MaybeBool<sbyte> EventControlSOFT(
        [NativeTypeName("ALCsizei")] int count,
        [NativeTypeName("const ALCenum *")] Ref<int> events,
        [NativeTypeName("ALCboolean")] MaybeBool<sbyte> enable
    );

    [return: NativeTypeName("ALCenum")]
    [NativeFunction("openal", EntryPoint = "alcEventIsSupportedSOFT")]
    int EventIsSupportedSOFT(
        [NativeTypeName("ALCenum")] int eventType,
        [NativeTypeName("ALCenum")] int deviceType
    );

    [return: NativeTypeName("ALCenum")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcEventIsSupportedSOFT")]
    Constant<int, ALCEnum, EventSupportSOFT> EventIsSupportedSOFT(
        [NativeTypeName("ALCenum")] Constant<int, ALCEnum, SystemEventTypeSOFT> eventType,
        [NativeTypeName("ALCenum")] Constant<int, ALCEnum, DeviceTypeSOFT> deviceType
    );

    [NativeFunction("openal", EntryPoint = "alcGetContextsDevice")]
    DeviceHandle GetContextsDevice(ContextHandle context);

    [NativeFunction("openal", EntryPoint = "alcGetCurrentContext")]
    ContextHandle GetCurrentContext();

    [return: NativeTypeName("ALCenum")]
    [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
    int GetEnumValue(DeviceHandle device, [NativeTypeName("const ALCchar *")] sbyte* enumname);

    [return: NativeTypeName("ALCenum")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
    int GetEnumValue(DeviceHandle device, [NativeTypeName("const ALCchar *")] Ref<sbyte> enumname);

    [return: NativeTypeName("ALCenum")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetError")]
    Constant<int, ALCEnum, ContextErrorCode> GetError(DeviceHandle device);

    [return: NativeTypeName("ALCenum")]
    [NativeFunction("openal", EntryPoint = "alcGetError")]
    int GetErrorRaw(DeviceHandle device);

    [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
    void GetInteger64SOFT(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] int pname,
        [NativeTypeName("ALsizei")] int size,
        [NativeTypeName("ALCint64SOFT *")] long* values
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
    void GetInteger64SOFT(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] int pname,
        [NativeTypeName("ALsizei")] int size,
        [NativeTypeName("ALCint64SOFT *")] Ref<long> values
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
    long GetInteger64SOFT(DeviceHandle device, [NativeTypeName("ALCenum")] int pname);

    [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
    void GetInteger(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] int param1,
        [NativeTypeName("ALCsizei")] int size,
        [NativeTypeName("ALCint *")] int* values
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
    void GetInteger(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] int param1,
        [NativeTypeName("ALCsizei")] int size,
        [NativeTypeName("ALCint *")] Ref<int> values
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
    int GetInteger(DeviceHandle device, [NativeTypeName("ALCenum")] int param1);

    [return: NativeTypeName("ALCvoid *")]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
    void* GetProcAddress(DeviceHandle device, [NativeTypeName("const ALCchar *")] sbyte* funcname);

    [return: NativeTypeName("ALCvoid *")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
    Ptr GetProcAddress(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] Ref<sbyte> funcname
    );

    [return: NativeTypeName("ALCvoid *")]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress2")]
    void* GetProcAddress2(DeviceHandle device, [NativeTypeName("const ALCchar *")] sbyte* funcName);

    [return: NativeTypeName("ALCvoid *")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress2")]
    Ptr GetProcAddress2(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] Ref<sbyte> funcName
    );

    [return: NativeTypeName("const ALCchar *")]
    [NativeFunction("openal", EntryPoint = "alcGetString")]
    sbyte* GetString(DeviceHandle device, [NativeTypeName("ALCenum")] int param1);

    [return: NativeTypeName("const ALCchar *")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetString")]
    Ptr<sbyte> GetString(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] Constant<int, ALCEnum, ContextString> param1
    );

    [return: NativeTypeName("const ALCchar *")]
    [NativeFunction("openal", EntryPoint = "alcGetStringiSOFT")]
    sbyte* GetStringSOFT(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] int paramName,
        [NativeTypeName("ALCsizei")] int index
    );

    [return: NativeTypeName("const ALCchar *")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetStringiSOFT")]
    Ptr<sbyte> GetStringSOFT(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] Constant<int, ALCEnum, ContextString> paramName,
        [NativeTypeName("ALCsizei")] int index
    );

    [NativeFunction("openal", EntryPoint = "alcGetThreadContext")]
    ContextHandle GetThreadContext();

    [return: NativeTypeName("ALCboolean")]
    [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
    sbyte IsExtensionPresent(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] sbyte* extname
    );

    [return: NativeTypeName("ALCboolean")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
    MaybeBool<sbyte> IsExtensionPresent(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] Ref<sbyte> extname
    );

    [return: NativeTypeName("ALCboolean")]
    [NativeFunction("openal", EntryPoint = "alcIsRenderFormatSupportedSOFT")]
    sbyte IsRenderFormatSupportedSOFT(
        DeviceHandle device,
        [NativeTypeName("ALCsizei")] int freq,
        [NativeTypeName("ALCenum")] int channels,
        [NativeTypeName("ALCenum")] int type
    );

    [return: NativeTypeName("ALCboolean")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcIsRenderFormatSupportedSOFT")]
    MaybeBool<sbyte> IsRenderFormatSupportedSOFT(
        DeviceHandle device,
        [NativeTypeName("ALCsizei")] int freq,
        [NativeTypeName("ALCenum")] Constant<int, ALCEnum, RenderFormatChannelSOFT> channels,
        [NativeTypeName("ALCenum")] Constant<int, ALCEnum, RenderFormatTypeSOFT> type
    );

    [NativeFunction("openal", EntryPoint = "alcLoopbackOpenDeviceSOFT")]
    DeviceHandle LoopbackOpenDeviceSOFT([NativeTypeName("const ALCchar *")] sbyte* deviceName);

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcLoopbackOpenDeviceSOFT")]
    DeviceHandle LoopbackOpenDeviceSOFT([NativeTypeName("const ALCchar *")] Ref<sbyte> deviceName);

    [return: NativeTypeName("ALCboolean")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
    MaybeBool<sbyte> MakeContextCurrent(ContextHandle context);

    [return: NativeTypeName("ALCboolean")]
    [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
    sbyte MakeContextCurrentRaw(ContextHandle context);

    [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
    DeviceHandle OpenDevice([NativeTypeName("const ALCchar *")] sbyte* devicename);

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
    DeviceHandle OpenDevice([NativeTypeName("const ALCchar *")] Ref<sbyte> devicename);

    [NativeFunction("openal", EntryPoint = "alcProcessContext")]
    void ProcessContext(ContextHandle context);

    [NativeFunction("openal", EntryPoint = "alcRenderSamplesSOFT")]
    void RenderSamplesSOFT(
        DeviceHandle device,
        [NativeTypeName("ALCvoid *")] void* buffer,
        [NativeTypeName("ALCsizei")] int samples
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcRenderSamplesSOFT")]
    void RenderSamplesSOFT(
        DeviceHandle device,
        [NativeTypeName("ALCvoid *")] Ref buffer,
        [NativeTypeName("ALCsizei")] int samples
    );

    [return: NativeTypeName("ALCboolean")]
    [NativeFunction("openal", EntryPoint = "alcReopenDeviceSOFT")]
    sbyte ReopenDeviceSOFT(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] sbyte* deviceName,
        [NativeTypeName("const ALCint *")] int* attribs
    );

    [return: NativeTypeName("ALCboolean")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcReopenDeviceSOFT")]
    MaybeBool<sbyte> ReopenDeviceSOFT(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] Ref<sbyte> deviceName,
        [NativeTypeName("const ALCint *")] Ref<int> attribs
    );

    [return: NativeTypeName("ALCboolean")]
    [NativeFunction("openal", EntryPoint = "alcResetDeviceSOFT")]
    sbyte ResetDeviceSOFT(DeviceHandle device, [NativeTypeName("const ALCint *")] int* attribs);

    [return: NativeTypeName("ALCboolean")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcResetDeviceSOFT")]
    MaybeBool<sbyte> ResetDeviceSOFT(
        DeviceHandle device,
        [NativeTypeName("const ALCint *")] Ref<int> attribs
    );

    [return: NativeTypeName("ALCboolean")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcSetThreadContext")]
    MaybeBool<sbyte> SetThreadContext(ContextHandle context);

    [return: NativeTypeName("ALCboolean")]
    [NativeFunction("openal", EntryPoint = "alcSetThreadContext")]
    sbyte SetThreadContextRaw(ContextHandle context);

    [NativeFunction("openal", EntryPoint = "alcSuspendContext")]
    void SuspendContext(ContextHandle context);
}
