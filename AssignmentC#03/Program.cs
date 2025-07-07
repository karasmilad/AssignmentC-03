namespace AssignmentC_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //Console.Write("Enter Number: ");
            //bool Validation = int.TryParse(Console.ReadLine(),out int Number);
            //if (!Validation)
            //{
            //    Console.WriteLine("Not Validation input");
            //}
            //else
            //{
            //    if (Number % 3 == 0 && Number % 4 == 0)
            //    {
            //        Console.WriteLine("Yes");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No");
            //    }
            //}
            #endregion
            #region Question02
            //Console.Write("Enter Number: ");
            //bool CheckNumber = int.TryParse(Console.ReadLine(),out int Number);
            //if (CheckNumber)
            //{
            //    if (Number > 0)
            //    {
            //        Console.WriteLine("Positive");
            //    }
            //    else if(Number < 0)
            //    {
            //        Console.WriteLine("Negative");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Number = 0");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Not Validation input");
            //}
            #endregion
            #region Question03
            //Console.Write("Ener First Number: ");
            //bool firstCheck = int.TryParse(Console.ReadLine(), out int firstNumber);
            //Console.Write("Ener Second Number: ");
            //bool secondCheck = int.TryParse(Console.ReadLine(), out int secondNumber);
            //Console.Write("Ener Third Number: ");
            //bool thirdCheck = int.TryParse(Console.ReadLine(), out int thirdNumber);
            //int maximum = firstNumber;
            //int minimum = firstNumber;
            //if (firstCheck && secondCheck && thirdCheck)
            //{
            #region Maximum Number
            //if (secondNumber > maximum)
            //{
            //    maximum = secondNumber;
            //    if (thirdNumber > maximum)
            //    {
            //        maximum = thirdNumber;
            //    }
            //    else
            //    {
            //        maximum = secondNumber;
            //    }
            //}
            //else
            //{
            //    if (thirdNumber > maximum)
            //    {
            //        maximum = thirdNumber;
            //    }
            //    else
            //    {
            //        maximum = firstNumber;
            //    }
            //}
            //Console.WriteLine($"The maximum Number = {maximum}");
            #endregion
            #region Minimum Number
            //if (secondNumber < minimum)
            //{
            //    minimum = secondNumber;
            //    if (thirdNumber < minimum)
            //    {
            //        minimum = thirdNumber;
            //    }
            //    else
            //    {
            //        minimum = secondNumber;
            //    }
            //}
            //else
            //{
            //    if (thirdNumber < minimum)
            //    {
            //        minimum = thirdNumber;
            //    }
            //    else
            //    {
            //        minimum = firstNumber;
            //    }
            //}
            //Console.WriteLine($"The maximum Number = {minimum}");
            #endregion
            #region Another Way
            //maximum = Math.Max(firstNumber , Math.Max(secondNumber , thirdNumber));
            //minimum = Math.Min(firstNumber, Math.Min(secondNumber, thirdNumber));

            #endregion
            //}
            //else
            //{
            //    Console.WriteLine("Enter Valid input");
            //}
            #endregion
            #region Question04
            //Console.Write("Enter Number: ");
            //bool Checked = int.TryParse(Console.ReadLine(), out int value);
            //if (Checked) 
            //{
            //    if (value % 2 == 0)
            //    {
            //        Console.WriteLine("Even");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Odd");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Enter Valid Input");
            //}
            #endregion
            #region Question05
            //Console.Write("Enter Char: ");
            //string? Value = Console.ReadLine();
            //if (Value == "a" || Value == "e" || Value == "l" || Value == "o" || Value == "u") 
            //{
            //    Console.WriteLine("Vowel");
            //}
            //else
            //{
            //    Console.WriteLine("Consonant");
            //}
            #endregion
        }
    }
}
