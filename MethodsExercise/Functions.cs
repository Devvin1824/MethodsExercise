using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    internal class Functions
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
       
        public static int Multiply(int num3, int num4)
        {
            return num3 * num4;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        
        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }

        public static int AddChallenge(params int[] list)
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum += list[i]; 
            }
            return sum;
            
        }
    }
    
}
