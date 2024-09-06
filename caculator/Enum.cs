using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caculator
{
  

    class ButtonState
    {
        public const bool ON = true;
        public const bool OFF = false;
    }
        
    public enum Operator
    {
        PLUS = 0,
        MINUS,
        MUL,
        DIV,
        PERCENTAGE,
        END
    }
    public enum KeyCode
    {
        NUMPAD0 = 96,
        NUMPAD1,
        NUMPAD2,
        NUMPAD3,
        NUMPAD4,
        NUMPAD5,
        NUMPAD6,
        NUMPAD7,
        NUMPAD8,
        NUMPAD9,
        D0 = 48,
        D1,
        D2,
        D3,
        D4,
        D5,  
        D6, 
        D7,
        D8,
        D9,
        NUMPADPLUS = 107,
        NUMPADMINUS = 109,
        NUMPADMUL = 106,
        NUMPADDIV = 111,
        NUMPADDOT = 110,
        OEMPLUS = 187,
        OEMMINUS = 189,
        OEMDIV = 191,
        OEMDOT = 190,    
        BACK = 8,
        ESC = 27
    }
}
