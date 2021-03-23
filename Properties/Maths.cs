using System;

namespace maths

{
    internal class Calculation
    {
        internal double Square(double num1)
        {
            double no = 0;
            try
            {
                no = num1 * num1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                Console.WriteLine("End of program");
            }

            return no;
        }

        internal double SquareRoot(double num2)
        {
            double no = 0;
            no = Math.Sqrt(num2);
            return no;

        }

        internal double Cube(double num1)
        {
            double no = 0;
            no = num1 * num1 * num1;
            return no;
        }
    }
}