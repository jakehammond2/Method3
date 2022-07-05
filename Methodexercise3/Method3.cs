using System;
namespace Methodexercise3
{
    public class Method3
    {
        public static int Add(params int[] values)
        {
            int sum = 0;

            foreach (int num in values)
            {

                sum += num;
            }

            return sum;         



        }
       
    }
}

