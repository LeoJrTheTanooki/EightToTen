namespace EightToTen.Services.Magic8Ball;

public interface IMagic8BallService
{
    public string Magic8Ball(string userQuestion = "Will I be blessed with good luck today?", string userName = "stranger");

}
