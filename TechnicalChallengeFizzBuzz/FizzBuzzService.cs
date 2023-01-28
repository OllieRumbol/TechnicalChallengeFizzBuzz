namespace TechnicalChallengeFizzBuzz;

public class FizzBuzzService : IFizzBuzzService
{
    public bool IsMultipleOfThree(int numbertoCheck)
    {
        return IsMultipleOf(numbertoCheck, 3);
    }

    public bool IsMultipleOfFive(int numbertoCheck)
    {
        return IsMultipleOf(numbertoCheck, 5);
    }

    public bool IsMultipleOf(int numbertoCheck, int multipleOf)
    {
        return numbertoCheck % multipleOf == 0;
    }
}
