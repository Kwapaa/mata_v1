using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mata_v1
{
    class Packet
    {
        private byte[] _buffer;
        private int _PacketSz;

        public Packet()
        {
            _buffer = new byte[12000];
        }

        public void setBuffer(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public void setPacketSz(int PacketSz)
        {
            this._PacketSz = PacketSz;
        }

        public byte[] getBuffer()
        {
            return this._buffer; 
        }

        public int getPacketSz()
        {
            return this._PacketSz;
        }
    }
}
