using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SharpCode4JS
{
    public struct NetMsgParam
    {
        private byte[] m_data;
        public void SetData(byte[] data)
        {
            m_data = data;
        } 
        public string Get64String()
        {
            return Convert.ToBase64String(m_data);
        }
        public byte[] GetBytes()
        {
            return m_data;
        }
    }
    public delegate void NetMsgHandler(NetMsgParam param);
}
