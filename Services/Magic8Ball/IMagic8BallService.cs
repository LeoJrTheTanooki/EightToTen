namespace EightToTen.Services.Magic8Ball;

public interface IMagic8BallService
{
    public string Magic8Ball(string userQuestion, string userName = "stranger");

}
