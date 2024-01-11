using EightToTen.Services.RestaurantPicker;
using Microsoft.AspNetCore.Mvc;

namespace EightToTen.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RestaurantPickerController : ControllerBase
{
    private readonly IRestaurantPickerService _restaurantPicker;

    public RestaurantPickerController(IRestaurantPickerService restaurantPicker)
    {
        _restaurantPicker = restaurantPicker;
    }
    [HttpGet]
    [Route("/RestaurantPicker")]
    public string RestaurantPicker(string userAnswer)
    {
        return _restaurantPicker.RestaurantPicker(userAnswer);
    }

}
