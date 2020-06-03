using Guestbook.Models;
using Microsoft.AspNetCore.Mvc;

namespace Guestbook.Controllers
{
    public class RecordController : Controller
    {
        private readonly IRecordRepository _recordRepository;

        public RecordController(IRecordRepository recordRepository)
        {
            _recordRepository = recordRepository;
        }
        public ViewResult Index()
        {
            return View(_recordRepository.AllRecords);
        }
    }
}
