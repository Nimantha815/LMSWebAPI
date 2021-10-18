using System;
using System.Collections.Generic;

#nullable disable

namespace LMSWebAPI.Models
{
    public partial class BOOK
    {
        public int ID { get; set; }
        public string BOOK_CODE { get; set; }
        public string BOOK_NAME { get; set; }
        public int? BOOK_COUNT { get; set; }
    }
}
