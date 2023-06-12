namespace ProgrammingConstructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programming Constructs !");
            IfAndElse ifAndElse = new IfAndElse();
            ifAndElse.TwoNumAreEqual();
            ifAndElse.IsEvenOrOdd();
            ifAndElse.IsEligible();

            If_ElseIf_Else if_ElseIf_Else = new If_ElseIf_Else();
            if_ElseIf_Else.LargestOfThree();
            if_ElseIf_Else.EligibleForAdmission();

            SwitchCase switchCase = new SwitchCase();
            switchCase.WeekDayName();
            switchCase.Calculator();

            ForLoop forLoop=new ForLoop();
            forLoop.PowerOfTwo();
            forLoop.SumOfSquares();
            forLoop.Factorial();

            WhileLoop whileLoop = new WhileLoop();
            whileLoop.FlipCoin();
            whileLoop.ReverseWord();
            whileLoop.SumOfNaturalNumbers();
        }
    }
}