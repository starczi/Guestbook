using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guestbook.Models
{
    public class MockRecordRepository : IRecordRepository
    {
        public IEnumerable<Record> AllRecords =>
            new List<Record>
            {
                new Record{RecordId = 1, Nick = "starczi", DatePosted = DateTime.Now, Comment = "first comment", Country = "poland", Email = "xxx@gmail.com"},
                new Record{RecordId = 2, Nick = "starczi1", DatePosted = DateTime.Now, Comment = "second comment", Country = "universe", Email = "yyy@gmail.com"},
                new Record{RecordId = 3, Nick = "starczi2", DatePosted = DateTime.Now, Comment = "third comment", Country = "europe", Email = "zzz@gmail.com"}
            };
        public Record GetRecordById(int recordId)
        {
            return AllRecords.FirstOrDefault(r => r.RecordId == recordId);
        }
    }
}
