using MeetingPlanner.Core.Models;
using MeetingPlanner.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingPlanner.Controllers
{
    public class HomeController : Controller
    {



        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Meeting(int userId)
        {



            return View("Meeting", userId);
        }

        public IActionResult Index()
        {
            var calendar = new Core.Models.Calendar
            {
                UserPlanns = new ObservableCollection<UserPlan>
                 {
                    new UserPlan
                    {
                        Id = 0,
                        Name = "Michał",
                        WorkStart = DateTime.ParseExact("09:00", "HH:mm", CultureInfo.InvariantCulture),
                        WorkEnd = DateTime.ParseExact("19:55", "HH:mm", CultureInfo.InvariantCulture),

                        Meetings = new ObservableCollection<Meeting>
                        {
                        new Meeting {
                            Id = 0,
                            Name = "Kawa",
                            Start = DateTime.ParseExact("09:00", "HH:mm", CultureInfo.InvariantCulture),
                            End = DateTime.ParseExact("10:30", "HH:mm", CultureInfo.InvariantCulture)
                            },
                        new Meeting {
                            Name = "Komputer",
                            Id = 1,
                            Start = DateTime.ParseExact("12:00", "HH:mm", CultureInfo.InvariantCulture),
                            }
                        }
                    },

                    new UserPlan
                    {
                        Id = 1,
                        Name = "Wiki",
                        WorkStart = DateTime.ParseExact("10:00", "HH:mm", CultureInfo.InvariantCulture),
                        WorkEnd = DateTime.ParseExact("18:30", "HH:mm", CultureInfo.InvariantCulture),

                        Meetings = new ObservableCollection<Meeting>
                        {
                        new Meeting {
                            Id = 0,
                            Start = DateTime.ParseExact("10:00", "HH:mm", CultureInfo.InvariantCulture),
                            End = DateTime.ParseExact("11:30", "HH:mm", CultureInfo.InvariantCulture)
                        },
                        new Meeting {
                            Id = 1,
                            Start = DateTime.ParseExact("12:30", "HH:mm", CultureInfo.InvariantCulture),
                            End = DateTime.ParseExact("14:30", "HH:mm", CultureInfo.InvariantCulture)
                        },
                        new Meeting {
                            Id = 2,
                            Start = DateTime.ParseExact("14:30", "HH:mm", CultureInfo.InvariantCulture),
                            End = DateTime.ParseExact("15:00", "HH:mm", CultureInfo.InvariantCulture)
                        },
                        new Meeting {
                            Id = 3,
                            Start = DateTime.ParseExact("16:00", "HH:mm", CultureInfo.InvariantCulture),
                            End = DateTime.ParseExact("17:00", "HH:mm", CultureInfo.InvariantCulture)
                            },
                        }
                    }
                }
            };



            return View(calendar);
        }

        //public IActionResult delete(int id)
        //{
        //    try
        //    {
        //        var meetingToRemove = userPlan.Meetings.Single(x => x.Id == id);
        //        userPlan.Meetings.ToList().Remove(meetingToRemove);
        //    }
        //    catch (Exception exeption)
        //    {

        //        return Json(new { success = false, message = exeption.Message });
        //    }


        //    return Json(new { success = true });
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
