﻿namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Given the following code, change the code to implement:

                inferred typing
                string interpolation
                and the ternary operator*/

            var answer = 4;
            string response;
            if (answer < 9)
            {
                response = "answer is less than nine";
            }
            else
            {
                response = "answer is greater than or equal to nine";
            }
        }
    }
}
