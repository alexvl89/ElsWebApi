using Microsoft.AspNetCore.Mvc;

namespace ElsWebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class Test : ControllerBase
{
    private readonly ILogger<Test> _logger;

    public Test(ILogger<Test> logger)
    {
        _logger = logger;
    }

    [HttpGet("standart")]
    public ActionResult GetStandart()
    {
        _logger.LogInformation("Ручка Добрались до Get запроса");

        return Ok("Ответ Ок");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    [HttpGet("error")]
    public IActionResult Error()
    {
        _logger.LogError("Ошибка сформированная в Error функции");

        return BadRequest("Error!");
    }
}
