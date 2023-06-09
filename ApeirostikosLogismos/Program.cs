using System;

namespace ApeirostikosLogismos
{
    class ApeiII
    {
        static void Main(string[] args)
        {
            ApeiII model = new ApeiII();

            // Find Number e
            Number_e(model);
        }

        /// <summary>
        /// Number e
        /// </summary>
        /// <param name="model"></param>
        private static void Number_e(ApeiII model)
        {
            Console.WriteLine("The number e!");

            decimal e = 1;
            for (int k = 1; k < 9; k++)
            {
                e += (1 / model.Factorial(k));
            }

            Console.WriteLine("Number e = " + e);
        }

        /// <summary>
        /// Factorial 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
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
