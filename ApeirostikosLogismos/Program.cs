using System;

namespace ApeirostikosLogismos
{
    class ApeiII
    {
        static void Main(string[] args)
        {
            #region Number e
            Console.WriteLine("The number e!");

            ApeiII model = new ApeiII();

            decimal e = 1;
            for (int k = 1; k < 9; k++)
            {
                e += (1 / model.Factorial(k));
            }

            Console.WriteLine("Number e = " + e);
            #endregion
        }

        public decimal Factorial(long n)
        {
            long F = 1;
            for (int i = 1; i <= n; i++)
            {
                F *= i;
            }
            return F;
        }
    }
}
