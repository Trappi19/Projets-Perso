using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class TryCatch
    {
        public void ExampleMethod()
        {
            try
            {
                // Code that may throw an exception
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[5]); // This will throw an IndexOutOfRangeException
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of range error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
            finally
            {
            }
    }
}
