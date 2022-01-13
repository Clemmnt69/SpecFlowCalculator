using System;
using System.Collections.Generic;

namespace SpecFlowCalculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public List<int> ListNumber { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }

        public int AddMultipleNumbers()
        {
            int result = 0;
            if (ListNumber.Count > 0)
            {                
                foreach (int n in ListNumber)
                    result += n;            
            }
            return result; 
        }

        public int Multiply()
        {
            return FirstNumber * SecondNumber;
        }

        public int MultiplyMultipleNumbers()
        {
            int result = 0;
            if (ListNumber.Count > 0)
            {
                foreach (int n in ListNumber)
                    result += result * n;
            }
            return result;
        }

        public int Divide()
        {
            if (SecondNumber == 0)
                return 0;
            else
                return Convert.ToInt32(FirstNumber / SecondNumber);
        }
    }
}
