using TechnicalChallengeFizzBuzz;

IFizzBuzzService FizzBuzzService = new FizzBuzzService();

for (int counter = 1; counter <= 100; counter++)
{
    if (FizzBuzzService.IsMultipleOfThree(counter) && FizzBuzzService.IsMultipleOfFive(counter))
    {
        Console.WriteLine("FizzBuzz");
    }
    else if(FizzBuzzService.IsMultipleOfThree(counter))
    {
        Console.WriteLine("Fizz");
    }
    else if (FizzBuzzService.IsMultipleOfFive(counter))
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(counter);
    }
}