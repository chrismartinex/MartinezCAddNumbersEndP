//Chris Martinez
// 10/25/22
//Add two Numbers End Point - Challenge
// Peer Review: Manuel L, The code looks and works // great, went into postman to make sure everything works and it does. Great Job on the whole assignment :) 

using Microsoft.AspNetCore.Mvc;

namespace MartinezCAddNumbersEndP.Controllers;

[ApiController]
[Route("[controller]")]
public class AddingNumbersController : ControllerBase
{
[HttpGet]
 [Route("Adding/{number1}/{number2}")]

 public int Math(string number1, string number2)
 {
  int convertNum1 = Convert.ToInt32(number1);
  int convertNum2 = Convert.ToInt32(number2);
  return convertNum1 + convertNum2;

 }

}
