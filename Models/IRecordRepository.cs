using System.Collections;
using System.Collections.Generic;

namespace Guestbook.Models
{
    public interface IRecordRepository
    {
        IEnumerable<Record> AllRecords { get; }
        Record GetRecordById(int recordId);
        void CreateRecord(Record record);
    }
}