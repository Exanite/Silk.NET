// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    public static ID3D12CommandList* CommandListCast<t_CommandListType>(t_CommandListType** pp)
        where t_CommandListType : unmanaged, ID3D12CommandList.Interface
    {
        return (ID3D12CommandList*)(pp);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr<ID3D12CommandList> CommandListCast<t_CommandListType>(
        Ref2D<t_CommandListType> pp
    )
        where t_CommandListType : unmanaged, ID3D12CommandList.Interface
    {
        fixed (t_CommandListType** __dsl_pp = pp)
        {
            return (ID3D12CommandList*)CommandListCast(__dsl_pp);
        }
    }

    [return: NativeTypeName("const CD3DX12_RESOURCE_DESC1 *")]
    public static ref readonly D3D12ResourceDesc1 D3DX12ConditionallyExpandAPIDesc(
        [NativeTypeName("CD3DX12_RESOURCE_DESC1 &")] ref D3D12ResourceDesc1 LclDesc,
        [NativeTypeName("const CD3DX12_RESOURCE_DESC1 *")] in D3D12ResourceDesc1 pDesc
    )
    {
        if ((pDesc.MipLevels == 0) || (pDesc.Alignment == 0))
        {
            LclDesc = pDesc;
            if (pDesc.MipLevels == 0)
            {
                ulong uiMaxDimension = ulong.Max(
                    (LclDesc.Dimension == D3D12ResourceDimension.Texture3D)
                        ? LclDesc.DepthOrArraySize
                        : 1UL,
                    ulong.Max(LclDesc.Width, LclDesc.Height)
                );
                ushort uiRet = 0;
                while (uiMaxDimension > 0)
                {
                    uiRet++;
                    uiMaxDimension >>= 1;
                }
                LclDesc.MipLevels = uiRet;
            }
            if (pDesc.Alignment == 0)
            {
                if (
                    (pDesc.Layout == D3D12TextureLayout.Layout64KbUndefinedSwizzle)
                    || (pDesc.Layout == D3D12TextureLayout.Layout64KbStandardSwizzle)
                )
                {
                    LclDesc.Alignment = D3D12.DefaultResourcePlacementAlignment;
                }
                else
                {
                    LclDesc.Alignment =
                        (pDesc.SampleDesc.Count > 1)
                            ? (ulong)(D3D12.DefaultMsaaResourcePlacementAlignment)
                            : (ulong)(D3D12.DefaultResourcePlacementAlignment);
                }
            }
            return ref LclDesc;
        }
        else
        {
            return ref pDesc;
        }
    }
}
