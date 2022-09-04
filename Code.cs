using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    internal class Code
    {
        public Code(int key)
        {
            this.big = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯABCDEFGHIJKLMNOPQRSTUVWXYZ";
            this.small = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяabcdefghijklmnopqrstuvwxyz";
            this.key = key;
        }
        public char DecodeChar(char c)
        {
            //-----------------------------------------
            var indexOut = 0;
            char outPut = c;
            //-----------------------------------------
            if (this.small.Contains(outPut))
            {
                indexOut = this.small.IndexOf(c) - this.key;
                if (indexOut < 0)
                    indexOut = this.small.Length + indexOut;
                if (indexOut > this.small.Length)
                    indexOut = indexOut - this.small.Length;
                outPut = this.small[indexOut];
            }
            if (this.big.Contains(outPut))
            {
                indexOut = this.big.IndexOf(c) - this.key;
                if (indexOut < 0)
                    indexOut = this.big.Length + indexOut;
                if (indexOut > this.big.Length)
                    indexOut = this.big.Length - indexOut;
                outPut = this.big[indexOut];
            }
            return outPut;
        }
        public char EncodeChar(char c)
        {
            //-----------------------------------------------
            var indexOut = 0;
            char outPut = c;
            //-----------------------------------------------
            if (this.small.Contains(c))
            {
                indexOut = this.small.IndexOf(c) + this.key;
                if (indexOut < 0)
                    indexOut = this.small.Length + indexOut;
                if (indexOut >= this.small.Length)
                    indexOut = indexOut - this.small.Length;
                outPut = this.small[indexOut];
            }
            if (this.big.Contains(c))
            {
                indexOut = this.big.IndexOf(c) + this.key;
                if (indexOut < 0)
                    indexOut = this.big.Length + indexOut;
                if (indexOut >= this.big.Length)
                    indexOut = indexOut - this.big.Length;
                outPut = this.big[indexOut];
            }
            return outPut;
        }
        private string small;
        private string big;
        private int key;
    }
}
