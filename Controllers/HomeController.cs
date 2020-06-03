using Guestbook.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Guestbook.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRecordRepository _recordRepository;

        public HomeController(IRecordRepository recordRepository)
        {
            _recordRepository = recordRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(Record record)
        {
            Record newRecord = new Record
            {
                RecordId = 11,
                Nick = record.Nick,
                DatePosted = DateTime.Now,
                Country = record.Country,
                Email = record.Email,
                Comment = record.Comment
            };

            if (ModelState.IsValid)
            {
                _recordRepository.CreateRecord(newRecord);
                return RedirectToAction("Index", "Record");
            }

            return View("Index", record);

        }
    }
}
