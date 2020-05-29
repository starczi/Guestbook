using System;
using Microsoft.AspNetCore.Components;

namespace Guestbook.Models
{
    public class Record
    {
        public int RecordId { get; set; }
        public string Nick { get; set; }
        public DateTime DatePosted { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
    }
}