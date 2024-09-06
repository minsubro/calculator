using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caculator
{
    

    public class Calculator
    {
        public static double Calculate(double a, double b, Operator op)
        {
            double ret = 0;

            switch (op)
            {
                case Operator.PLUS:
                    ret = a + b;
                    break;
                case Operator.MINUS:
                    ret = a - b;
                    break;
                case Operator.DIV:
                    if (a == 0 && b == 0)
                        throw new Exception("정의되지 않은 결과입니다.");
                    if (b == 0)
                        throw new Exception("0으로 나눌 수 없습니다.");
                    ret = a / b;
                    break;
                case Operator.MUL:
                    ret = a * b;
                    break;
                case Operator.END:
                    break;
            }
            if (double.IsInfinity(ret))
                throw new Exception("오버플로우");
            return ret;
        }
    }
}

