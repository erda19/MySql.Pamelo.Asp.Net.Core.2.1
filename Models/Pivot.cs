using System;
using System.Collections.Generic;

namespace mysqlPamelo.Models
{
    public partial class Pivot
    {
        public int Id { get; set; }
        public int? Categoryid { get; set; }
        public DateTime? Processdate { get; set; }
        public int? Percentchange { get; set; }
    }
}
