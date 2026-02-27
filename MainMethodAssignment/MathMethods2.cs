using System;

namespace MainMethodAssignment
{
    public class MathMethods2
    {
        public int MathOp(int number)
        {
            return number + 7;
        }

        public int MathOp(decimal number)
        {
            int newnum = Convert.ToInt32(number);
            return newnum * 20;
        }

        public int MathOp(string number)
        {
            int newnum = Convert.ToInt32(number);
            return newnum % 3;
        }
    }
}