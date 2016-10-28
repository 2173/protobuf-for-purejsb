using System;
using System.Collections.Generic;
using SharpKit.JavaScript;

namespace Network
{
    public class ProtoBufferWrap
    {

        [JsMethod(Code = @"var	ProtoBuf = dcodeIO.ProtoBuf,
                                Message = ProtoBuf.protoFromString(ProtoString).build(MessageName);
                                Message = new Message(JSON.parse(JSON.stringify(dataInstance)));
                                return Message.encode().toBase64();")]
        public static string Encode(string ProtoString, string MessageName, object dataInstance)
        {
            return (string) null;
        }


        [JsMethod(Code = @"var	ProtoBuf = dcodeIO.ProtoBuf,
                                Bytebuffer=dcodeIO.ByteBuffer,
                                Message = ProtoBuf.protoFromString(ProtoString).build(MessageName);
                                return  Message.decode(Bytebuffer.fromBase64(dataString));")]
        public static JsObject Decode(string ProtoString, string MessageName, string dataString)
        {
            return (JsObject)null;
        }

    }
}
