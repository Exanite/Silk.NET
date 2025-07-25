// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC"]/*'/>
public unsafe partial struct DmlLstmOperatorDesc
{
    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.InputTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* InputTensor;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.WeightTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* WeightTensor;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.RecurrenceTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* RecurrenceTensor;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.BiasTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* BiasTensor;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.HiddenInitTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* HiddenInitTensor;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.CellMemInitTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* CellMemInitTensor;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.SequenceLengthsTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* SequenceLengthsTensor;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.PeepholeTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* PeepholeTensor;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.OutputSequenceTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* OutputSequenceTensor;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.OutputSingleTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* OutputSingleTensor;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.OutputCellSingleTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* OutputCellSingleTensor;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.ActivationDescCount"]/*'/>

    public uint ActivationDescCount;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.ActivationDescs"]/*'/>

    [NativeTypeName("const DML_OPERATOR_DESC *")]
    public DmlOperatorDesc* ActivationDescs;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.Direction"]/*'/>

    public DmlRecurrentNetworkDirection Direction;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.ClipThreshold"]/*'/>

    public float ClipThreshold;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.UseClipThreshold"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> UseClipThreshold;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.CoupleInputForget"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> CoupleInputForget;
}
