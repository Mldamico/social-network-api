using Application.Activities;
using Domain;
using Microsoft.AspNetCore.Mvc;


namespace SocialNet.Controllers;

public class ActivitiesController : BaseApiController
{
   

    [HttpGet]
    public async Task<ActionResult<List<Activity>>> GetAllActivities()
    {
        return await Mediator?.Send(new List.Query())!;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Activity>> GetActivityById(Guid id)
    {
        return await Mediator.Send(new Details.Query{Id = id});
    }
}