namespace EightToTen.Services.GuessIt;

public class GuessItService : IGuessItService
{
    public string GuessIt(string difficulty, string userGuess)
    {
        if (difficulty.Length > 0)
        {
            int validatedNum = 0;
            bool success = int.TryParse(userGuess, out validatedNum);
            if (success)
            {
                Random random = new();
                if (difficulty.ToLower() == "easy")
                {
                    int thinkingNumber = random.Next(1, 11);
                    string part1 = $"Your number is {validatedNum}, while my number is {thinkingNumber}.";
                    if (validatedNum == thinkingNumber)
                    {
                        return $"{part1}\nYou got it right!";
                    }
                    else if (validatedNum > thinkingNumber)
                    {
                        return $"{part1}It seems you aimed too high...";
                    }
                    else if (validatedNum < thinkingNumber)
                    {
                        return $"{part1}You aimed too low here...";
                    }
                }
                if (difficulty.ToLower() == "medium")
                {
                    int thinkingNumber = random.Next(1, 51);
                    string part1 = $"Your number is {validatedNum}, while my number is {thinkingNumber}";
                    if (validatedNum == thinkingNumber)
                    {
                        return $"{part1}\nYou got it right!";
                    }
                    else if (validatedNum > thinkingNumber)
                    {
                        return $"{part1}It seems you aimed too high...";
                    }
                    else if (validatedNum < thinkingNumber)
                    {
                        return $"{part1}You aimed too low here...";
                    }
                }
                if (difficulty.ToLower() == "hard")
                {
                    int thinkingNumber = random.Next(1, 101);
                    string part1 = $"Your number is {validatedNum}, while my number is {thinkingNumber}";
                    if (validatedNum == thinkingNumber)
                    {
                        return $"{part1}\nYou got it right!";
                    }
                    else if (validatedNum > thinkingNumber)
                    {
                        return $"{part1}It seems you aimed too high...";
                    }
                    else if (validatedNum < thinkingNumber)
                    {
                        return $"{part1}You aimed too low here...";
                    }
                }
            }
            return "No valid number given";
        }
        return "No difficulty was selected.";
    }
}
