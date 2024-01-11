namespace EightToTen.Services.Magic8Ball;

public class Magic8BallService : IMagic8BallService
{
    public string Magic8Ball(string userQuestion, string userName = "stranger")
    {
        if (userQuestion.Length > 0)
        {
            Random random = new();
            int randomNumber = random.Next(0, 8);
            string eightBall = "";
            switch (randomNumber)
            {
                case 0:
                    eightBall = "It is certain";
                    break;
                case 1:
                    eightBall = "It is decidedly so";
                    break;
                case 2:
                    eightBall = "Reply hazy try again";
                    break;
                case 3:
                    eightBall = "Cannot predict now";
                    break;
                case 4:
                    eightBall = "Do not count on it";
                    // console.log("https://youtu.be/y7jncW7p9Nc?si=f1YHTRp1bsMqgwdq&t=18");
                    break;
                case 5:
                    eightBall = "My sources say no";
                    break;
                case 6:
                    eightBall = "Outlook is not good";
                    break;
                case 7:
                    eightBall = "Signs point to yes";
                    break;
            }
            return $"Hello, {userName}... it seems you are asking '{userQuestion}'...\nThe Magic 8 Ball says '{eightBall}...";
        }
        return "You have not asked a question... I'm afraid I cannot tell you what the Magic 8 Ball says...";
    }
}
