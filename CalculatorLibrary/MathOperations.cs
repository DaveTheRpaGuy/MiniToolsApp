using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary;

public class MathOperations
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        return a / b;
    }

    public double Modulus(double a, double b)
    {
        return a % b;
    }

    public double Reciprocal(double a)
    {
        return 1 / a;
    }
    
    public double Square(double a)
    {
        return a * a;
    }

    public double SquareRoot(double a)
    {
        return Math.Sqrt(a);
    }

    public double ReverseSign(double a)
    {
        return a * -1;
    }
}
