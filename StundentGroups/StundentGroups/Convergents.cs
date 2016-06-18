

namespace StundentGroups
{
    using System;
    
    public delegate double Function(int a);
    class Convergent
    {
        public static double Sum(Function NqkakvaConvergeFunc, double precision)
        {
            double result = 0;
            int index = 0;

            while (true)
            {
                double temp = NqkakvaConvergeFunc(index);
                result += temp;
                if (Math.Abs(temp) < precision)
                    break;
                index++;
            }

            return result;
        }
    }
}