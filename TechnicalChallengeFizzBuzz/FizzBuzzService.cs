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

    private bool IsMultipleOf(int numbertoCheck, int multipleOf)
    {
        if(multipleOf is 0)
        {
            throw new ArgumentException("Multiple of cant be 0");
        }

        return numbertoCheck % multipleOf == 0;
    }
}
