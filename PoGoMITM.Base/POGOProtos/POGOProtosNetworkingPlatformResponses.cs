// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos.Networking.Platform.Responses.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Platform.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos.Networking.Platform.Responses.proto</summary>
  public static partial class POGOProtosNetworkingPlatformResponsesReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos.Networking.Platform.Responses.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static POGOProtosNetworkingPlatformResponsesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUGxhdGZvcm0uUmVzcG9uc2VzLnBy",
            "b3RvEihQT0dPUHJvdG9zLk5ldHdvcmtpbmcuUGxhdGZvcm0uUmVzcG9uc2Vz",
            "GhxQT0dPUHJvdG9zLkRhdGEuUGxheWVyLnByb3RvGh9QT0dPUHJvdG9zLklu",
            "dmVudG9yeS5JdGVtLnByb3RvIq0BChZCdXlJdGVtQW5kcm9pZFJlc3BvbnNl",
            "ElcKBnJlc3VsdBgBIAEoDjJHLlBPR09Qcm90b3MuTmV0d29ya2luZy5QbGF0",
            "Zm9ybS5SZXNwb25zZXMuQnV5SXRlbUFuZHJvaWRSZXNwb25zZS5TdGF0dXMS",
            "FgoOcHVyY2hhc2VfdG9rZW4YAiABKAkiIgoGU3RhdHVzEgsKB1VOS05PV04Q",
            "ABILCgdTVUNDRVNTEAEiswEKGEJ1eUl0ZW1Qb2tlQ29pbnNSZXNwb25zZRJZ",
            "CgZyZXN1bHQYASABKA4ySS5QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUGxhdGZv",
            "cm0uUmVzcG9uc2VzLkJ1eUl0ZW1Qb2tlQ29pbnNSZXNwb25zZS5TdGF0dXMi",
            "PAoGU3RhdHVzEgsKB1VOS05PV04QABILCgdTVUNDRVNTEAESGAoUTk9UX0VO",
            "T1VHSF9QT0tFQ09JTlMQAyK8BQoVR2V0U3RvcmVJdGVtc1Jlc3BvbnNlElYK",
            "BnN0YXR1cxgBIAEoDjJGLlBPR09Qcm90b3MuTmV0d29ya2luZy5QbGF0Zm9y",
            "bS5SZXNwb25zZXMuR2V0U3RvcmVJdGVtc1Jlc3BvbnNlLlN0YXR1cxJYCgVp",
            "dGVtcxgCIAMoCzJJLlBPR09Qcm90b3MuTmV0d29ya2luZy5QbGF0Zm9ybS5S",
            "ZXNwb25zZXMuR2V0U3RvcmVJdGVtc1Jlc3BvbnNlLlN0b3JlSXRlbRI7ChFw",
            "bGF5ZXJfY3VycmVuY2llcxgDIAMoCzIgLlBPR09Qcm90b3MuRGF0YS5QbGF5",
            "ZXIuQ3VycmVuY3kSEAoIdW5rbm93bjQYBCABKAka/gIKCVN0b3JlSXRlbRIP",
            "CgdpdGVtX2lkGAEgASgJEg4KBmlzX2lhcBgCIAEoCBI5Cg9jdXJyZW5jeV90",
            "b19idXkYAyABKAsyIC5QT0dPUHJvdG9zLkRhdGEuUGxheWVyLkN1cnJlbmN5",
            "EjkKD3lpZWxkc19jdXJyZW5jeRgEIAEoCzIgLlBPR09Qcm90b3MuRGF0YS5Q",
            "bGF5ZXIuQ3VycmVuY3kSOAoLeWllbGRzX2l0ZW0YBSABKAsyIy5QT0dPUHJv",
            "dG9zLkludmVudG9yeS5JdGVtLkl0ZW1EYXRhEmEKBHRhZ3MYBiADKAsyUy5Q",
            "T0dPUHJvdG9zLk5ldHdvcmtpbmcuUGxhdGZvcm0uUmVzcG9uc2VzLkdldFN0",
            "b3JlSXRlbXNSZXNwb25zZS5TdG9yZUl0ZW0uVGFnc0VudHJ5EhAKCHVua25v",
            "d243GAcgASgFGisKCVRhZ3NFbnRyeRILCgNrZXkYASABKAkSDQoFdmFsdWUY",
            "AiABKAk6AjgBIiEKBlN0YXR1cxINCglVTkRFRklORUQQABIICgRPS0FZEAEi",
            "MgoeU2VuZEVuY3J5cHRlZFNpZ25hdHVyZVJlc3BvbnNlEhAKCHJlY2VpdmVk",
            "GAEgASgIUABQAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.Player.POGOProtosDataPlayerReflection.Descriptor, global::POGOProtos.Inventory.Item.POGOProtosInventoryItemReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Platform.Responses.BuyItemAndroidResponse), global::POGOProtos.Networking.Platform.Responses.BuyItemAndroidResponse.Parser, new[]{ "Result", "PurchaseToken" }, null, new[]{ typeof(global::POGOProtos.Networking.Platform.Responses.BuyItemAndroidResponse.Types.Status) }, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Platform.Responses.BuyItemPokeCoinsResponse), global::POGOProtos.Networking.Platform.Responses.BuyItemPokeCoinsResponse.Parser, new[]{ "Result" }, null, new[]{ typeof(global::POGOProtos.Networking.Platform.Responses.BuyItemPokeCoinsResponse.Types.Status) }, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse), global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Parser, new[]{ "Status", "Items", "PlayerCurrencies", "Unknown4" }, null, new[]{ typeof(global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.Status) }, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.StoreItem), global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.StoreItem.Parser, new[]{ "ItemId", "IsIap", "CurrencyToBuy", "YieldsCurrency", "YieldsItem", "Tags", "Unknown7" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })}),
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Platform.Responses.SendEncryptedSignatureResponse), global::POGOProtos.Networking.Platform.Responses.SendEncryptedSignatureResponse.Parser, new[]{ "Received" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BuyItemAndroidResponse : pb::IMessage<BuyItemAndroidResponse> {
    private static readonly pb::MessageParser<BuyItemAndroidResponse> _parser = new pb::MessageParser<BuyItemAndroidResponse>(() => new BuyItemAndroidResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BuyItemAndroidResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Platform.Responses.POGOProtosNetworkingPlatformResponsesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuyItemAndroidResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuyItemAndroidResponse(BuyItemAndroidResponse other) : this() {
      result_ = other.result_;
      purchaseToken_ = other.purchaseToken_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuyItemAndroidResponse Clone() {
      return new BuyItemAndroidResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::POGOProtos.Networking.Platform.Responses.BuyItemAndroidResponse.Types.Status result_ = 0;
    /// <summary>
    ///  result
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Platform.Responses.BuyItemAndroidResponse.Types.Status Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "purchase_token" field.</summary>
    public const int PurchaseTokenFieldNumber = 2;
    private string purchaseToken_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PurchaseToken {
      get { return purchaseToken_; }
      set {
        purchaseToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BuyItemAndroidResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BuyItemAndroidResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (PurchaseToken != other.PurchaseToken) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (PurchaseToken.Length != 0) hash ^= PurchaseToken.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      if (PurchaseToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PurchaseToken);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (PurchaseToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PurchaseToken);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BuyItemAndroidResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.PurchaseToken.Length != 0) {
        PurchaseToken = other.PurchaseToken;
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
          case 8: {
            result_ = (global::POGOProtos.Networking.Platform.Responses.BuyItemAndroidResponse.Types.Status) input.ReadEnum();
            break;
          }
          case 18: {
            PurchaseToken = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the BuyItemAndroidResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      ///  THESE ARE SOMEWHAT SPECULATED, failed may be 2
      /// </summary>
      public enum Status {
        [pbr::OriginalName("UNKNOWN")] Unknown = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
      }

    }
    #endregion

  }

  public sealed partial class BuyItemPokeCoinsResponse : pb::IMessage<BuyItemPokeCoinsResponse> {
    private static readonly pb::MessageParser<BuyItemPokeCoinsResponse> _parser = new pb::MessageParser<BuyItemPokeCoinsResponse>(() => new BuyItemPokeCoinsResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BuyItemPokeCoinsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Platform.Responses.POGOProtosNetworkingPlatformResponsesReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuyItemPokeCoinsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuyItemPokeCoinsResponse(BuyItemPokeCoinsResponse other) : this() {
      result_ = other.result_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuyItemPokeCoinsResponse Clone() {
      return new BuyItemPokeCoinsResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::POGOProtos.Networking.Platform.Responses.BuyItemPokeCoinsResponse.Types.Status result_ = 0;
    /// <summary>
    ///  result
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Platform.Responses.BuyItemPokeCoinsResponse.Types.Status Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BuyItemPokeCoinsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BuyItemPokeCoinsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BuyItemPokeCoinsResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
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
          case 8: {
            result_ = (global::POGOProtos.Networking.Platform.Responses.BuyItemPokeCoinsResponse.Types.Status) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the BuyItemPokeCoinsResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      ///  THESE ARE SOMEWHAT SPECULATED, should be a NOT ENOUGH ROOM status too for bag being full somewhere.
      /// </summary>
      public enum Status {
        [pbr::OriginalName("UNKNOWN")] Unknown = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("NOT_ENOUGH_POKECOINS")] NotEnoughPokecoins = 3,
      }

    }
    #endregion

  }

  public sealed partial class GetStoreItemsResponse : pb::IMessage<GetStoreItemsResponse> {
    private static readonly pb::MessageParser<GetStoreItemsResponse> _parser = new pb::MessageParser<GetStoreItemsResponse>(() => new GetStoreItemsResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetStoreItemsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Platform.Responses.POGOProtosNetworkingPlatformResponsesReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetStoreItemsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetStoreItemsResponse(GetStoreItemsResponse other) : this() {
      status_ = other.status_;
      items_ = other.items_.Clone();
      playerCurrencies_ = other.playerCurrencies_.Clone();
      unknown4_ = other.unknown4_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetStoreItemsResponse Clone() {
      return new GetStoreItemsResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.Status status_ = 0;
    /// <summary>
    /// unconfirmed
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "items" field.</summary>
    public const int ItemsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.StoreItem> _repeated_items_codec
        = pb::FieldCodec.ForMessage(18, global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.StoreItem.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.StoreItem> items_ = new pbc::RepeatedField<global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.StoreItem>();
    /// <summary>
    ///  Items to show in the shop
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.StoreItem> Items {
      get { return items_; }
    }

    /// <summary>Field number for the "player_currencies" field.</summary>
    public const int PlayerCurrenciesFieldNumber = 3;
    private static readonly pb::FieldCodec<global::POGOProtos.Data.Player.Currency> _repeated_playerCurrencies_codec
        = pb::FieldCodec.ForMessage(26, global::POGOProtos.Data.Player.Currency.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Data.Player.Currency> playerCurrencies_ = new pbc::RepeatedField<global::POGOProtos.Data.Player.Currency>();
    /// <summary>
    ///  currencies that player has at the moment
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Data.Player.Currency> PlayerCurrencies {
      get { return playerCurrencies_; }
    }

    /// <summary>Field number for the "unknown4" field.</summary>
    public const int Unknown4FieldNumber = 4;
    private string unknown4_ = "";
    /// <summary>
    ///  Some base64 encoded stuff... (Developer payload?)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Unknown4 {
      get { return unknown4_; }
      set {
        unknown4_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetStoreItemsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetStoreItemsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if(!items_.Equals(other.items_)) return false;
      if(!playerCurrencies_.Equals(other.playerCurrencies_)) return false;
      if (Unknown4 != other.Unknown4) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != 0) hash ^= Status.GetHashCode();
      hash ^= items_.GetHashCode();
      hash ^= playerCurrencies_.GetHashCode();
      if (Unknown4.Length != 0) hash ^= Unknown4.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Status != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
      }
      items_.WriteTo(output, _repeated_items_codec);
      playerCurrencies_.WriteTo(output, _repeated_playerCurrencies_codec);
      if (Unknown4.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Unknown4);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      size += items_.CalculateSize(_repeated_items_codec);
      size += playerCurrencies_.CalculateSize(_repeated_playerCurrencies_codec);
      if (Unknown4.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Unknown4);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetStoreItemsResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      items_.Add(other.items_);
      playerCurrencies_.Add(other.playerCurrencies_);
      if (other.Unknown4.Length != 0) {
        Unknown4 = other.Unknown4;
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
          case 8: {
            status_ = (global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Types.Status) input.ReadEnum();
            break;
          }
          case 18: {
            items_.AddEntriesFrom(input, _repeated_items_codec);
            break;
          }
          case 26: {
            playerCurrencies_.AddEntriesFrom(input, _repeated_playerCurrencies_codec);
            break;
          }
          case 34: {
            Unknown4 = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the GetStoreItemsResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("UNDEFINED")] Undefined = 0,
        [pbr::OriginalName("OKAY")] Okay = 1,
      }

      public sealed partial class StoreItem : pb::IMessage<StoreItem> {
        private static readonly pb::MessageParser<StoreItem> _parser = new pb::MessageParser<StoreItem>(() => new StoreItem());
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<StoreItem> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::POGOProtos.Networking.Platform.Responses.GetStoreItemsResponse.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public StoreItem() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public StoreItem(StoreItem other) : this() {
          itemId_ = other.itemId_;
          isIap_ = other.isIap_;
          CurrencyToBuy = other.currencyToBuy_ != null ? other.CurrencyToBuy.Clone() : null;
          YieldsCurrency = other.yieldsCurrency_ != null ? other.YieldsCurrency.Clone() : null;
          YieldsItem = other.yieldsItem_ != null ? other.YieldsItem.Clone() : null;
          tags_ = other.tags_.Clone();
          unknown7_ = other.unknown7_;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public StoreItem Clone() {
          return new StoreItem(this);
        }

        /// <summary>Field number for the "item_id" field.</summary>
        public const int ItemIdFieldNumber = 1;
        private string itemId_ = "";
        /// <summary>
        ///  Internal ID (probably for Google Play/App Store) example: "pgorelease.incenseordinary.1"
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string ItemId {
          get { return itemId_; }
          set {
            itemId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "is_iap" field.</summary>
        public const int IsIapFieldNumber = 2;
        private bool isIap_;
        /// <summary>
        ///  If true, this item is bought with real currency (USD, etc.) through the Play/App Store instead of Pokecoins
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool IsIap {
          get { return isIap_; }
          set {
            isIap_ = value;
          }
        }

        /// <summary>Field number for the "currency_to_buy" field.</summary>
        public const int CurrencyToBuyFieldNumber = 3;
        private global::POGOProtos.Data.Player.Currency currencyToBuy_;
        /// <summary>
        ///  This defines how much the item costs (with the exception of items that cost real money like Pokecoins, that's defined in the respective store)
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::POGOProtos.Data.Player.Currency CurrencyToBuy {
          get { return currencyToBuy_; }
          set {
            currencyToBuy_ = value;
          }
        }

        /// <summary>Field number for the "yields_currency" field.</summary>
        public const int YieldsCurrencyFieldNumber = 4;
        private global::POGOProtos.Data.Player.Currency yieldsCurrency_;
        /// <summary>
        ///  When bought, this IAP will yield this much currency
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::POGOProtos.Data.Player.Currency YieldsCurrency {
          get { return yieldsCurrency_; }
          set {
            yieldsCurrency_ = value;
          }
        }

        /// <summary>Field number for the "yields_item" field.</summary>
        public const int YieldsItemFieldNumber = 5;
        private global::POGOProtos.Inventory.Item.ItemData yieldsItem_;
        /// <summary>
        ///  The item and count of such item that this IAP will yield
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::POGOProtos.Inventory.Item.ItemData YieldsItem {
          get { return yieldsItem_; }
          set {
            yieldsItem_ = value;
          }
        }

        /// <summary>Field number for the "tags" field.</summary>
        public const int TagsFieldNumber = 6;
        private static readonly pbc::MapField<string, string>.Codec _map_tags_codec
            = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 50);
        private readonly pbc::MapField<string, string> tags_ = new pbc::MapField<string, string>();
        /// <summary>
        ///  Stuff like SORT:12, CATEGORY:ITEMS
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::MapField<string, string> Tags {
          get { return tags_; }
        }

        /// <summary>Field number for the "unknown7" field.</summary>
        public const int Unknown7FieldNumber = 7;
        private int unknown7_;
        /// <summary>
        ///  Possibly something to toggle visibility in the store/purchasibility?
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int Unknown7 {
          get { return unknown7_; }
          set {
            unknown7_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as StoreItem);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(StoreItem other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (ItemId != other.ItemId) return false;
          if (IsIap != other.IsIap) return false;
          if (!object.Equals(CurrencyToBuy, other.CurrencyToBuy)) return false;
          if (!object.Equals(YieldsCurrency, other.YieldsCurrency)) return false;
          if (!object.Equals(YieldsItem, other.YieldsItem)) return false;
          if (!Tags.Equals(other.Tags)) return false;
          if (Unknown7 != other.Unknown7) return false;
          return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (ItemId.Length != 0) hash ^= ItemId.GetHashCode();
          if (IsIap != false) hash ^= IsIap.GetHashCode();
          if (currencyToBuy_ != null) hash ^= CurrencyToBuy.GetHashCode();
          if (yieldsCurrency_ != null) hash ^= YieldsCurrency.GetHashCode();
          if (yieldsItem_ != null) hash ^= YieldsItem.GetHashCode();
          hash ^= Tags.GetHashCode();
          if (Unknown7 != 0) hash ^= Unknown7.GetHashCode();
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (ItemId.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(ItemId);
          }
          if (IsIap != false) {
            output.WriteRawTag(16);
            output.WriteBool(IsIap);
          }
          if (currencyToBuy_ != null) {
            output.WriteRawTag(26);
            output.WriteMessage(CurrencyToBuy);
          }
          if (yieldsCurrency_ != null) {
            output.WriteRawTag(34);
            output.WriteMessage(YieldsCurrency);
          }
          if (yieldsItem_ != null) {
            output.WriteRawTag(42);
            output.WriteMessage(YieldsItem);
          }
          tags_.WriteTo(output, _map_tags_codec);
          if (Unknown7 != 0) {
            output.WriteRawTag(56);
            output.WriteInt32(Unknown7);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (ItemId.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(ItemId);
          }
          if (IsIap != false) {
            size += 1 + 1;
          }
          if (currencyToBuy_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(CurrencyToBuy);
          }
          if (yieldsCurrency_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(YieldsCurrency);
          }
          if (yieldsItem_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(YieldsItem);
          }
          size += tags_.CalculateSize(_map_tags_codec);
          if (Unknown7 != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Unknown7);
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(StoreItem other) {
          if (other == null) {
            return;
          }
          if (other.ItemId.Length != 0) {
            ItemId = other.ItemId;
          }
          if (other.IsIap != false) {
            IsIap = other.IsIap;
          }
          if (other.currencyToBuy_ != null) {
            if (currencyToBuy_ == null) {
              currencyToBuy_ = new global::POGOProtos.Data.Player.Currency();
            }
            CurrencyToBuy.MergeFrom(other.CurrencyToBuy);
          }
          if (other.yieldsCurrency_ != null) {
            if (yieldsCurrency_ == null) {
              yieldsCurrency_ = new global::POGOProtos.Data.Player.Currency();
            }
            YieldsCurrency.MergeFrom(other.YieldsCurrency);
          }
          if (other.yieldsItem_ != null) {
            if (yieldsItem_ == null) {
              yieldsItem_ = new global::POGOProtos.Inventory.Item.ItemData();
            }
            YieldsItem.MergeFrom(other.YieldsItem);
          }
          tags_.Add(other.tags_);
          if (other.Unknown7 != 0) {
            Unknown7 = other.Unknown7;
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
                ItemId = input.ReadString();
                break;
              }
              case 16: {
                IsIap = input.ReadBool();
                break;
              }
              case 26: {
                if (currencyToBuy_ == null) {
                  currencyToBuy_ = new global::POGOProtos.Data.Player.Currency();
                }
                input.ReadMessage(currencyToBuy_);
                break;
              }
              case 34: {
                if (yieldsCurrency_ == null) {
                  yieldsCurrency_ = new global::POGOProtos.Data.Player.Currency();
                }
                input.ReadMessage(yieldsCurrency_);
                break;
              }
              case 42: {
                if (yieldsItem_ == null) {
                  yieldsItem_ = new global::POGOProtos.Inventory.Item.ItemData();
                }
                input.ReadMessage(yieldsItem_);
                break;
              }
              case 50: {
                tags_.AddEntriesFrom(input, _map_tags_codec);
                break;
              }
              case 56: {
                Unknown7 = input.ReadInt32();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  public sealed partial class SendEncryptedSignatureResponse : pb::IMessage<SendEncryptedSignatureResponse> {
    private static readonly pb::MessageParser<SendEncryptedSignatureResponse> _parser = new pb::MessageParser<SendEncryptedSignatureResponse>(() => new SendEncryptedSignatureResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SendEncryptedSignatureResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Platform.Responses.POGOProtosNetworkingPlatformResponsesReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SendEncryptedSignatureResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SendEncryptedSignatureResponse(SendEncryptedSignatureResponse other) : this() {
      received_ = other.received_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SendEncryptedSignatureResponse Clone() {
      return new SendEncryptedSignatureResponse(this);
    }

    /// <summary>Field number for the "received" field.</summary>
    public const int ReceivedFieldNumber = 1;
    private bool received_;
    /// <summary>
    ///  speculated, could be an enum
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Received {
      get { return received_; }
      set {
        received_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SendEncryptedSignatureResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SendEncryptedSignatureResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Received != other.Received) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Received != false) hash ^= Received.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Received != false) {
        output.WriteRawTag(8);
        output.WriteBool(Received);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Received != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SendEncryptedSignatureResponse other) {
      if (other == null) {
        return;
      }
      if (other.Received != false) {
        Received = other.Received;
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
          case 8: {
            Received = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
