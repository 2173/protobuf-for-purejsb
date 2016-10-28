using UnityEngine;
using System.Collections;

namespace Network
{
    public class MessageWrap : MessageParent
    {

        public string fileName;
        public string protuBufname;
        public override string GetProToString()
        {
            TextAsset proto = (TextAsset)Resources.Load("Protos/" + fileName);
            return proto.ToString();
        }

        public override string GetMessageName()
        {
            return protuBufname;
        }
    }
}
