using UnityEngine;
using System.Collections;
using SharpCode4JS;
using Network;
using System.IO;
using System;

public class GameSocketInterface
{
    public static string Serialize<T>(T param, string fileName = null, string protuBufname = null)
    {
        string message = string.Empty;
        if (VersionControl.isUseJS)
        {
            Network.MessageWrap msgWrap = new Network.MessageWrap();
            msgWrap.protuBufname = "Protobuf." + protuBufname;
            msgWrap.fileName = fileName;
            UnityEngine.Debug.LogError("encode之前的数据是" + JSON.stringify(param));
            message = msgWrap.Encode(param);
        }
        else
        {
            MemoryStream stream = new MemoryStream();
            ProtoBuf.Serializer.Serialize<T>(stream, param);
            byte[] bytes = stream.ToArray();
            message = System.Text.Encoding.UTF8.GetString(bytes, 0, bytes.Length);
        }
        return message;
    }


    public static T deserialize<T>(T param, string message, string fileName = null, string protuBufname = null)
    {
        if (VersionControl.isUseJS)
        {
            Network.MessageWrap msgWrap = new Network.MessageWrap();
            msgWrap.protuBufname = "Protobuf." + protuBufname;
            msgWrap.fileName = fileName;
            object obj = msgWrap.Decode(message);
            UnityEngine.Debug.LogError("decode之后的数据是" + JSON.stringify(obj));
            return (T)obj;
        }
        else
        {
            MemoryStream stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(message));
            return ProtoBuf.Serializer.Deserialize<T>(stream);
        }

    }
}
