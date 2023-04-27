using System;

    class Calculator
    {

    static void Main(string[] args)
    {
        Calculator calcobject = new Calculator();
        calcobject.add(10, 10);
        calcobject.add(3.4, 7.5);

    }
    public int add(int x, int y)
        {
            return x + y;
        }

        public double add(double x, double y)
        {
            return x + y;
        }
    }

