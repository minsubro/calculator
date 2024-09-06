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
                throw new Exception("오버플로");
            return ret;
        }
        
        public static double Reciprocal(double n)
        {
            return 1 / n;
        }

        public static double Pow(double n)
        {
            double ret = Math.Pow(n, 2);
            if (double.IsInfinity(ret))
                throw new Exception("오버플로");
            return ret;

        }

        public static double Square(double n)
        {
            double ret = Math.Sqrt(n);
            if (double.IsNaN(ret))
                throw new Exception("입력이 잘못되었습니다.");
            return ret;
        }
    }
}

