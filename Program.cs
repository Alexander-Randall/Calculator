using System;

namespace Calculator
{
    class Program
    {
        enum Operator
        {
            addition, subtraction, multiplication, division, modulus 
        }
        static void Main(string[] args)
        {
            
            while(true)
            {
                int firstNum = GetInteger();
                Operator inputOperator = GetOperator();
                int secondNum = GetInteger();
                //
                OpeatorOutput operatorOutput = GetOpeatorOutput(inputOperator, firstNum, secondNum);

                Console.WriteLine("the " + operatorOutput.outputType + " of " + firstNum + " and " + secondNum + " is  " + operatorOutput.output);
                if (!AskForContinue())
                {
                    break;
                }
                Console.Clear();



            }
        }  
        
        static int GetInteger()
        {
            Console.WriteLine("Input a number.");
            string Input = Console.ReadLine();
            int numberToReturn = 0;

            while (!int.TryParse(Input, out numberToReturn))
            {
                Console.WriteLine("Please input a valid number.");
                Input = Console.ReadLine();
            }
            return numberToReturn;

        }
        static Operator GetOperator()
        {
            Operator toReturn = Operator.addition;
            bool isInputValid = false;
            while (!isInputValid)
            {
                Console.WriteLine("Input an operator");
                string Input = Console.ReadLine();


                if (Input == "+")
                {
                    toReturn = Operator.addition;
                    isInputValid = true;
                }
                else if (Input == "-")
                {
                    isInputValid = true;
                    toReturn = Operator.subtraction;
                }
                else if (Input == "*")
                {
                    toReturn = Operator.multiplication;
                    isInputValid = true;
                }
                else if (Input == "/")
                {
                    toReturn = Operator.division;
                    isInputValid = true;
                }
                else if (Input == "%")
                {
                    toReturn = Operator.modulus;
                    isInputValid = true;
                //asks user of operator
                }
              
            }
            return toReturn;

        }
        static OpeatorOutput GetOpeatorOutput(Operator inputOperator, int firstNum, int secondNum)
        {
            int output = 0;
            string outputType = "";

            if (inputOperator == Operator.addition)
            {
                output = firstNum + secondNum;
                outputType = "sum";
            }
            if (inputOperator == Operator.subtraction)
            {
                output = firstNum - secondNum;
                outputType = "difference";

            }

            if (inputOperator == Operator.multiplication)
            {
                output = firstNum * secondNum;
                outputType = "product";
            }
            if (inputOperator == Operator.division)
            {
                output = firstNum / secondNum;
                outputType = "quotient";

            }
            if (inputOperator == Operator.modulus)
            {
                output = firstNum % secondNum;
                outputType = "modulus";
            }

            return new OpeatorOutput(output, outputType);
        }
        public static bool AskForContinue()
        {
            Console.WriteLine("Would you like to continue? (y/n)");
            string inputContinue = Console.ReadLine();
            if (inputContinue == "y")
            {
                return true;
            }

            return false;

        }



    }
}
