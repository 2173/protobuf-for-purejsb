using UnityEngine;
using System.Collections;
using Network;
using Protobuf;

public class TestNetWork : MonoBehaviour 
{
    public void Start()
    {
        UserProto proto = new UserProto();
        proto.id = 1;
        proto.name = "2173";
       
        //============================================================================序列化
        string message = GameSocketInterface.Serialize(proto, "ExampleMessage", UserProto.GetProtoName());

        //============================================================================反序列化
        UserProto proto1 = new UserProto();
        proto1 = GameSocketInterface.deserialize(proto1, message, "ExampleMessage", UserProto.GetProtoName());
        Debug.LogError(proto1.name);
    }


}
