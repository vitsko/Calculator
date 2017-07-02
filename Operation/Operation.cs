namespace Operation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Operation
    {
        private const int CountOfOperands = 2;
        private static double[] containerOperand;

        private enum TypeOperation
        {
            Sum = 49,
            Subtraction = 50,
            Multiplication = 51,
            Division = 52
        }

        public static double GetResultOperation(byte selectOperation)
        {
            Dictionary<byte, double> dictionaryOperations = new Dictionary<byte, double>();

            dictionaryOperations.Add((byte)TypeOperation.Sum, containerOperand[0] + containerOperand[1]);
            dictionaryOperations.Add((byte)TypeOperation.Subtraction, containerOperand[0] - containerOperand[1]);
            dictionaryOperations.Add((byte)TypeOperation.Multiplication, containerOperand[0] * containerOperand[1]);
            dictionaryOperations.Add((byte)TypeOperation.Division, containerOperand[0] / containerOperand[1]);

            var result = dictionaryOperations.Where(d => d.Key == selectOperation)
                                       .Select(d => d.Value)
                                       .First();

            CheckDivideByZero(result);

            return result;
        }

        public static bool CheckOperands(string operands)
        {
            if (string.IsNullOrWhiteSpace(operands))
            {
                return false;
            }

            Operation.ClearOperands();

            if (IsParseOperands(operands, out containerOperand))
            {
                return true;
            }

            return false;
        }

        private static void ClearOperands()
        {
            if (containerOperand is double[])
            {
                containerOperand = null;
            }
        }

        private static bool IsParseOperands(string operands, out double[] result)
        {
            string[] operand = operands.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            result = TryParseMoreZero(operand);

            return result.Length == CountOfOperands;
        }

        private static double[] TryParseMoreZero(string[] operand)
        {
            List<double> operands = new List<double>();

            double toParse = -1d;

            for (var index = 0; index < operand.Length; index++)
            {
                if (double.TryParse(operand[index], out toParse))
                {
                    operands.Add(toParse);
                }
            }

            return operands.ToArray();
        }

        private static void CheckDivideByZero(double result)
        {
            if (double.IsPositiveInfinity(result) || double.IsNegativeInfinity(result) || double.IsNaN(result))
            {
                throw new DivideByZeroException();
            }
        }
    }
}