using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Members_Jefferson
{
    static class Calculate
    {
        //Initialize the vulnerable and set it to 0.
        public static float result = 0.0f;

        //reduce the susceptible to zero.
        static Calculate()
        {
            result = 0.0f;
        }

        // Integers. that combine, remove, multiply, and divide two numbers and output the result.

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Sub(int x, int y)
        {
            return x - y;
        }

        public static int Mult(int x, int y)
        {
            return x * y;
        }

        public static int Div(int x, int y)
        {
            return x / y;
        }

        // Float. that add together, subtract from, multiply, and divide two integers and output the outcome.

        public static float Add(float x, float y)
        {
            return x + y;
        }

        public static float Sub(float x, float y)
        {
            return x - y;
        }

        public static float Mult(float x, float y)
        {
            return x * y;
        }

        public static float Div(float x, float y)
        {
            return x / y;
        }
    }
}
