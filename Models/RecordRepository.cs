using System;
using System.Collections.Generic;
using System.Linq;

namespace Guestbook.Models
{
    public class RecordRepository : IRecordRepository
    {
        private readonly AppDbContext _appDbContext;

        public RecordRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Record> AllRecords => _appDbContext.Records;

        public Record GetRecordById(int recordId)
        {
            return _appDbContext.Records.FirstOrDefault(r => r.RecordId == recordId);
        }

        public void CreateRecord(Record record)
        {
            _appDbContext.Records.Add(record);

            _appDbContext.SaveChanges();
        }
    }
}