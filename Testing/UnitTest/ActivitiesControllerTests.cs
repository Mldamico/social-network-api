using Domain;
using Microsoft.AspNetCore.Mvc;
using SocialNet.Controllers;

namespace Testing.UnitTest;

//
// public class ActivitiesControllerTests: TestBase
// {
//
//     [Test]
//     public async Task GetAllActivities()
//     {
//         var nameDb = Guid.NewGuid().ToString();
//         var context = BuildContext(nameDb);
//
//         context.Activities.Add(new Activity
//         {
//             Title = "Past Activity 1",
//             Date = DateTime.Now.AddMonths(-2),
//             Description = "Activity 2 months ago",
//             Category = "drinks",
//             City = "London",
//             Venue = "Pub",
//         });
//         
//         context.Activities.Add(new Activity
//         {
//             Title = "Past Activity 2",
//             Date = DateTime.Now.AddMonths(-1),
//             Description = "Activity 1 month ago",
//             Category = "culture",
//             City = "Paris",
//             Venue = "Louvre",
//         });
//         await context.SaveChangesAsync();
//
//         var context2 = BuildContext(nameDb);
//
//         var controller = new ActivitiesController(context2);
//         var response = await controller.GetAllActivities();
//         var activities = response.Value;
//         Assert.That(activities.Count, Is.EqualTo(2));
//     }
//     
//     [Test]
//     public async Task GetActivityById_WithValidId_ShouldReturnGenre()
//     {
//         var nameDb = Guid.NewGuid().ToString();
//         var context = BuildContext(nameDb);
//         var guid = new Guid("11223344-5566-7788-99AA-BBCCDDEEFF00");
//         context.Activities.Add(new Activity
//         {
//             Id = guid,
//             Title = "Past Activity 1",
//             Date = DateTime.Now.AddMonths(-2),
//             Description = "Activity 2 months ago",
//             Category = "drinks",
//             City = "London",
//             Venue = "Pub",
//         });
//         
//         context.Activities.Add(new Activity
//         {
//             Title = "Past Activity 2",
//             Date = DateTime.Now.AddMonths(-1),
//             Description = "Activity 1 month ago",
//             Category = "culture",
//             City = "Paris",
//             Venue = "Louvre",
//         });
//         await context.SaveChangesAsync();
//
//         var context2 = BuildContext(nameDb);
//
//         var controller = new ActivitiesController(context2);
//         var response = await controller.GetActivityById(guid);
//
//         var result = response.Value;
//         Assert.That(result.Id, Is.EqualTo(guid));
//     }
//
// }
