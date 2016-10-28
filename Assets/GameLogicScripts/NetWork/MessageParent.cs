using System;
using System.Collections.Generic;
using UnityEngine;

namespace Network
{
    public class MessageParent
    {
        public virtual string GetMessageName() {

            return "";
        }

        public virtual string GetProToString()
        {

            return "";
        }
        public virtual string  Encode() 
        {
            string rawString = ProtoBufferWrap.Encode(GetProToString(), GetMessageName(), this);
            return rawString;

        }

        public virtual string Encode(object dataInstance)
        {
            string rawString = ProtoBufferWrap.Encode(GetProToString(), GetMessageName(), dataInstance);
            return rawString;

        }

        public virtual object  Decode(string data) 
        {
            object _object = ProtoBufferWrap.Decode(GetProToString(), GetMessageName(), data);
               return _object;
        }

    }
}
