using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace caculator
{
    public class Value
    {
        private string _buffer;
        private bool _dot;
        public string String { get => _buffer; set { _buffer = value; } }
        public double Double { get => GetDouble(); }
        
        public bool dot { get => _dot; set { _dot = value; } }
        public int Length { get => _buffer.Length; }

        public Value() { 
            Clear();
        }
        public void Clear() { 
            _buffer = "0";
            dot = false;
        }

        public double GetDouble()
        {
            return Double.Parse(_buffer);
        }

        public void RemoveLeadingZeros()
        {
            _buffer = _buffer.TrimStart('0');
            if (_buffer.Length == 0)
                _buffer = "0";
        }

        public void Del()
        {
            if (_buffer[_buffer.Length - 1] == '.')
                _dot = false;
            _buffer = _buffer.Remove(_buffer.Length - 1);
            if (_buffer.Length == 0)
                _buffer = "0";
        }

        public void Negate()
        {
            if (_buffer == "0")
                return;
            if (_buffer[0] == '-')
                _buffer = _buffer.Substring(1);
            else
                _buffer = _buffer.Insert(0, "-"); 
        }
        
    }
}
