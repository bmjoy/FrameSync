//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: PBLogin.proto
namespace PBLogin
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TcpLogin")]
  public partial class TcpLogin : global::ProtoBuf.IExtensible
  {
    public TcpLogin() {}
    
    private string _token;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"token", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string token
    {
      get { return _token; }
      set { _token = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TcpResponseLogin")]
  public partial class TcpResponseLogin : global::ProtoBuf.IExtensible
  {
    public TcpResponseLogin() {}
    
    private bool _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool result
    {
      get { return _result; }
      set { _result = value; }
    }
    private int _uid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private int _udpPort;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"udpPort", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int udpPort
    {
      get { return _udpPort; }
      set { _udpPort = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}