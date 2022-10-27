//N. Harrison Wilkins
//10-27-2022
//RESTAURANT PICKER - ENDPOINT
//THIS PROGRAM CONTAINS A CONTROLLER "FoodPickingController" THAT ALLOWS THE USER TO CHOOSE BETWEEN THREE DIFFERENT ARRAYS OF PLACES TO EAT, THE PROGRA CHOOSES A VALUE FROM ONE OF THESE ARRAYS RANDOMLY AND ALLOWS THE USER TO GET A NEW RANDOM ANSWER EVERY TIME THE PROGRAM IS RAN
//PEER REVIEW BY : Elizar Garcia, code works as intended. I really like the layout of this code, look very well organized and simple. very clean. the code shows up on postman with no problem. Great job!


using Microsoft.AspNetCore.Mvc;

namespace WilkinsHRestaurantPicker_Endpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class FoodPickerController : ControllerBase
{
        [HttpGet]
   [Route("getFood/{option}")]
    public string INeedSomeFood(string option)
    {
        Random rnd = new Random();
        string[] chineseFood = {"Uncle Yu's", "Mei Mei's", "China Wok", "The Banana Garden", "The Amazing Kitchen", "Panda Express", "Midori", "Golden Eagle Resturaunt", "Fortune Garden", "Ling Nam Express"};
        string[] fastFood = {"McDonald's", "Burger King", "Five Guy's Burger and Fries", "Chick Fil-A", "Habit Burger", "Popeye's", "Wing Stop", "Little Caesar's", "Wendy's", "Chipotle"};
        string[] mexicanFood = {"La Costa", "Taqueria La Mexicana", "El Pollo Loco", "El Comal Taco Truck", "La Casita", "Tacos Chapala", "La Kositas", "Birrieria Jalisco", "Tacos El Pelon", "Taco Bell"};
        
        int chineseFoodIndex  = rnd.Next(chineseFood.Length);
        int fastFoodIndex  = rnd.Next(chineseFood.Length);
        int mexicanFoodIndex  = rnd.Next(chineseFood.Length);

        if(option == "chinesefood") return $"WE CHOSE \"{chineseFood[chineseFoodIndex]}\" FOR YOU!";
        if(option == "fastfood") return $"WE CHOSE \"{fastFood[fastFoodIndex]}\" FOR YOU!";
        if(option == "mexicanfood") return $"WE CHOSE \"{mexicanFood[mexicanFoodIndex]}\" FOR YOU!";
        else{
            return "THAT IS NOT AN ANSWER I WAS TAUGHT TO ACCEPT!";
        }
    }
}