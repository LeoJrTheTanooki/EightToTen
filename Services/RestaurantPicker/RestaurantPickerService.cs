namespace EightToTen.Services.RestaurantPicker;

public class RestaurantPickerService : IRestaurantPickerService
{
    public string RestaurantPicker(string userAnswer)
    {
        if (userAnswer.Length > 0)
        {
            if (userAnswer == "mexican" || userAnswer == "spanish" || userAnswer == "tacos" || userAnswer == "burritos")
            {
                string[] mexican = new string[10];
                mexican[0] = "La Estrella";
                mexican[1] = "Nena's Mexican Cuisine";
                mexican[2] = "Susy's Mexican Food";
                mexican[3] = "Fiesta Mexicana Restaurant";
                mexican[4] = "Maria's Cafe";
                mexican[5] = "Charlie's Tortas";
                mexican[6] = "La Cocina Chiapaneca";
                mexican[7] = "El Senor Frog's";
                mexican[8] = "Las Palmas";
                mexican[9] = "El Primos";

                Random random = new();
                int randomFood = random.Next(0, mexican.Length);
                return $"So you want some {userAnswer}, right? Then I'll bring you some {mexican[randomFood]}.";

                // )
            }
            else if (userAnswer == "chinese" || userAnswer == "noodles" || userAnswer == "orange chicken")
            {
                string[] chinese = new string[10];

                chinese[0] = "Panda Express";
                chinese[1] = "Sun's Garden";
                chinese[2] = "China Express";
                chinese[3] = "Sherman's Buffet";
                chinese[4] = "New Yen Ching";
                chinese[5] = "Oriental Chef";
                chinese[6] = "Silver Chop Stick Restaurant";
                chinese[7] = "China Wok";
                chinese[8] = "Luu's Chicken Bowl";
                chinese[9] = "Golden Bowl";

                Random random = new();
                int randomFood = random.Next(0, chinese.Length);
                return $"So you want some {userAnswer}, right? Then I'll bring you some {chinese[randomFood]}.";

            }
            else if (userAnswer == "freedom" || userAnswer == "freedom!" || userAnswer == "freedom!!" || userAnswer == "freedom!!!" || userAnswer == "murican" || userAnswer == "burgers" || userAnswer == "american")
            {
                string[] freedom = new string[10];

                freedom[0] = "BURGER KING!!!";
                freedom[1] = "MCDONALD'S!!!";
                freedom[2] = "KFC!!!";
                freedom[3] = "AMC!!!";
                freedom[4] = "CARL'S JR!!!";
                freedom[5] = "JACK IN THE BOX!!!";
                freedom[6] = "ARBY'S!!!";
                freedom[7] = "IN-N-OUT!!!";
                freedom[8] = "FIVE GUYS!!!";
                freedom[9] = "WENDY'S!!!";

                Random random = new();
                int randomFood = random.Next(0, freedom.Length);
                return $"So you want some {userAnswer}, right? Then I'll bring you some {freedom[randomFood]}.";

            }
            return "I don't recognize that type of restaurant, I'm sorry. ";
        }
        return "...Are you even going to try and give me a type of restaurant?";

    }
}

