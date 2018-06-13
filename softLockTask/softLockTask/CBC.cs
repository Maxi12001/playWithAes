using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aesLib;

namespace softLockTask
{
    class CBC
    {
        //initialize key and iv foe aes
        private static readonly byte[] IV = new byte[16] {0x09, 0x9b, 0x61, 0x57, 0xb9, 0x9e,0xdf,0x1f,0x9d,0xc9,0xc4,0x58,0x8a,0x5b,0xed,0x1d };
        private static readonly byte[] _Key = new byte[32] { 0x09, 0x9b, 0x61, 0x57, 0xb9, 0x9e, 0xdf, 0x1f, 0x9d, 0xc9, 0xc4, 0x58, 0x8a, 0x5b, 0xed, 0x1d, 0x7c, 0xe3, 0x39, 0x82, 0x9b, 0x2f, 0xff, 0x87, 0x34, 0x8e, 0x43, 0x44, 0xc4, 0xde, 0xe9, 0xcb };
        //declare member 
        private byte[] _buffIn;
        private AESED _core;
        private List<byte> _buffOut;
        //initialize main component 
        public CBC() {
            _core = new AESED(AESED.KeySize.Bits256, _Key);
            _buffOut = new List<byte>();
        }
        //copy input to the buff
        public void set_buffIN(byte[] input)
        {
            int mod = input.Length % 16;
            int padLen = (mod == 0) ? 0 : (16 - mod);
            _buffIn = new byte[input.Length + padLen];
             for (int i = 0; i < input.Length; i++)
              {
                _buffIn[i] = input[i];
              }
            
        }
        public void encrypt()
        {
            byte[] aesIn = new byte[16];
            byte[] iIV = IV;
            byte[] aesout = new byte[16];
            int x = 0;
            for (int i = 0; i < _buffIn.Length; i=i+16)
            {
                     
                    for (int j = 0; j < 16; j++)
                    { 
                        aesIn[j] = (byte)(iIV[j] ^_buffIn[x++]);
                    }
                    _core.Cipher(aesIn, aesout);
                    for (int j = 0; j < 16; j++)
                    {
                        _buffOut.Add(aesout[j]);
                    }
                    iIV = aesout;
                
            }

    }
        public void decrypt() {
            byte[] aesIn = new byte[16];
            byte[] iIV = IV;
            byte[] aesOut = new byte[16];
            byte[] cbcOut = new byte[16];
            byte[] preCipher = new byte[16];
            int x = 0;
            for (int i = 0; i < _buffIn.Length; i = i + 16)
            {
                    for (int j = 0; j < 16; j++)
                    {
                        aesIn[j] = _buffIn[x++];

                    }
                    _core.InvCipher(aesIn, aesOut);
                    
                    if (i != 0)
                        iIV = preCipher;
                   for (int j = 0; j < 16; j++)
                   {cbcOut[j] = (byte)(iIV[j] ^ aesOut[j]);}
                   
                    for (int j = 0; j < 16; j++)
                    {
                        _buffOut.Add(cbcOut[j]);
                        preCipher[j] = aesIn[j];
                    }     
            }
        }
        public List<byte> get_buffout()
        {
            return _buffOut;
        }
        public void clear_buffout()
        {
            _buffOut.Clear();
            _buffOut.TrimExcess();
        }

    }
}
