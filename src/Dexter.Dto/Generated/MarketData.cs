// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: MarketData.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Dexter.Dto {

  /// <summary>Holder for reflection information generated from MarketData.proto</summary>
  public static partial class MarketDataReflection {

    #region Descriptor
    /// <summary>File descriptor for MarketData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MarketDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBNYXJrZXREYXRhLnByb3RvEgpEZXh0ZXIuRHRvIosBCgpNYXJrZXREYXRh",
            "EhIKCkluc3RydW1lbnQYASABKAkSEAoIQmlkUHJpY2UYAiABKAESDwoHQmlk",
            "U2l6ZRgDIAEoAxIQCghBc2tQcmljZRgEIAEoARIPCgdBc2tTaXplGAUgASgD",
            "EhEKCUxhc3RQcmljZRgGIAEoARIQCghMYXN0U2l6ZRgHIAEoAyInChFNYXJr",
            "ZXREYXRhUmVxdWVzdBISCgpJbnN0dXJtZW50GAEgASgJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Dexter.Dto.MarketData), global::Dexter.Dto.MarketData.Parser, new[]{ "Instrument", "BidPrice", "BidSize", "AskPrice", "AskSize", "LastPrice", "LastSize" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Dexter.Dto.MarketDataRequest), global::Dexter.Dto.MarketDataRequest.Parser, new[]{ "Insturment" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MarketData : pb::IMessage<MarketData> {
    private static readonly pb::MessageParser<MarketData> _parser = new pb::MessageParser<MarketData>(() => new MarketData());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MarketData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Dexter.Dto.MarketDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MarketData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MarketData(MarketData other) : this() {
      instrument_ = other.instrument_;
      bidPrice_ = other.bidPrice_;
      bidSize_ = other.bidSize_;
      askPrice_ = other.askPrice_;
      askSize_ = other.askSize_;
      lastPrice_ = other.lastPrice_;
      lastSize_ = other.lastSize_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MarketData Clone() {
      return new MarketData(this);
    }

    /// <summary>Field number for the "Instrument" field.</summary>
    public const int InstrumentFieldNumber = 1;
    private string instrument_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Instrument {
      get { return instrument_; }
      set {
        instrument_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "BidPrice" field.</summary>
    public const int BidPriceFieldNumber = 2;
    private double bidPrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double BidPrice {
      get { return bidPrice_; }
      set {
        bidPrice_ = value;
      }
    }

    /// <summary>Field number for the "BidSize" field.</summary>
    public const int BidSizeFieldNumber = 3;
    private long bidSize_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long BidSize {
      get { return bidSize_; }
      set {
        bidSize_ = value;
      }
    }

    /// <summary>Field number for the "AskPrice" field.</summary>
    public const int AskPriceFieldNumber = 4;
    private double askPrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double AskPrice {
      get { return askPrice_; }
      set {
        askPrice_ = value;
      }
    }

    /// <summary>Field number for the "AskSize" field.</summary>
    public const int AskSizeFieldNumber = 5;
    private long askSize_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long AskSize {
      get { return askSize_; }
      set {
        askSize_ = value;
      }
    }

    /// <summary>Field number for the "LastPrice" field.</summary>
    public const int LastPriceFieldNumber = 6;
    private double lastPrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double LastPrice {
      get { return lastPrice_; }
      set {
        lastPrice_ = value;
      }
    }

    /// <summary>Field number for the "LastSize" field.</summary>
    public const int LastSizeFieldNumber = 7;
    private long lastSize_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long LastSize {
      get { return lastSize_; }
      set {
        lastSize_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MarketData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MarketData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Instrument != other.Instrument) return false;
      if (BidPrice != other.BidPrice) return false;
      if (BidSize != other.BidSize) return false;
      if (AskPrice != other.AskPrice) return false;
      if (AskSize != other.AskSize) return false;
      if (LastPrice != other.LastPrice) return false;
      if (LastSize != other.LastSize) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Instrument.Length != 0) hash ^= Instrument.GetHashCode();
      if (BidPrice != 0D) hash ^= BidPrice.GetHashCode();
      if (BidSize != 0L) hash ^= BidSize.GetHashCode();
      if (AskPrice != 0D) hash ^= AskPrice.GetHashCode();
      if (AskSize != 0L) hash ^= AskSize.GetHashCode();
      if (LastPrice != 0D) hash ^= LastPrice.GetHashCode();
      if (LastSize != 0L) hash ^= LastSize.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Instrument.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Instrument);
      }
      if (BidPrice != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(BidPrice);
      }
      if (BidSize != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(BidSize);
      }
      if (AskPrice != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(AskPrice);
      }
      if (AskSize != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(AskSize);
      }
      if (LastPrice != 0D) {
        output.WriteRawTag(49);
        output.WriteDouble(LastPrice);
      }
      if (LastSize != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(LastSize);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Instrument.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Instrument);
      }
      if (BidPrice != 0D) {
        size += 1 + 8;
      }
      if (BidSize != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(BidSize);
      }
      if (AskPrice != 0D) {
        size += 1 + 8;
      }
      if (AskSize != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(AskSize);
      }
      if (LastPrice != 0D) {
        size += 1 + 8;
      }
      if (LastSize != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(LastSize);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MarketData other) {
      if (other == null) {
        return;
      }
      if (other.Instrument.Length != 0) {
        Instrument = other.Instrument;
      }
      if (other.BidPrice != 0D) {
        BidPrice = other.BidPrice;
      }
      if (other.BidSize != 0L) {
        BidSize = other.BidSize;
      }
      if (other.AskPrice != 0D) {
        AskPrice = other.AskPrice;
      }
      if (other.AskSize != 0L) {
        AskSize = other.AskSize;
      }
      if (other.LastPrice != 0D) {
        LastPrice = other.LastPrice;
      }
      if (other.LastSize != 0L) {
        LastSize = other.LastSize;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Instrument = input.ReadString();
            break;
          }
          case 17: {
            BidPrice = input.ReadDouble();
            break;
          }
          case 24: {
            BidSize = input.ReadInt64();
            break;
          }
          case 33: {
            AskPrice = input.ReadDouble();
            break;
          }
          case 40: {
            AskSize = input.ReadInt64();
            break;
          }
          case 49: {
            LastPrice = input.ReadDouble();
            break;
          }
          case 56: {
            LastSize = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  public sealed partial class MarketDataRequest : pb::IMessage<MarketDataRequest> {
    private static readonly pb::MessageParser<MarketDataRequest> _parser = new pb::MessageParser<MarketDataRequest>(() => new MarketDataRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MarketDataRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Dexter.Dto.MarketDataReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MarketDataRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MarketDataRequest(MarketDataRequest other) : this() {
      insturment_ = other.insturment_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MarketDataRequest Clone() {
      return new MarketDataRequest(this);
    }

    /// <summary>Field number for the "Insturment" field.</summary>
    public const int InsturmentFieldNumber = 1;
    private string insturment_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Insturment {
      get { return insturment_; }
      set {
        insturment_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MarketDataRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MarketDataRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Insturment != other.Insturment) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Insturment.Length != 0) hash ^= Insturment.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Insturment.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Insturment);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Insturment.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Insturment);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MarketDataRequest other) {
      if (other == null) {
        return;
      }
      if (other.Insturment.Length != 0) {
        Insturment = other.Insturment;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Insturment = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code