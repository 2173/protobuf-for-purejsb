using UnityEngine;
using System.Collections;
using Network;
using Protobuf;

public class TestNetWork : MonoBehaviour 
{
    public void Awake()
    {
        UserProto proto = new UserProto();
        proto.id = 1;
        proto.name = "2173";

        //============================================================================序列化
        Network.MessageWrap msgWrap = new Network.MessageWrap();
        msgWrap.protuBufname = "Protobuf." + UserProto.GetProtoName();
        msgWrap.fileName = "ExampleMessage";
        UnityEngine.Debug.LogError("encode之前的数据是" + JSON.stringify(proto));

        string message = msgWrap.Encode(proto);
        UnityEngine.Debug.LogError("encode");
        //============================================================================反序列化

        Network.MessageWrap msgWrap1 = new Network.MessageWrap();
        msgWrap1.protuBufname = "Protobuf." + UserProto.GetProtoName();
        msgWrap1.fileName = "ExampleMessage";

        UnityEngine.Debug.LogError("decode");
        UserProto proto1 = (UserProto)msgWrap.Decode(message);
        UnityEngine.Debug.LogError("decode之后的数据是" + JSON.stringify(proto1));
    }
}
