using System;
using System.Collections.Generic;

namespace CoreWebApi.Models
{
    public partial class MicrosoftUser
    {
        public int Id { get; set; }
        public string MicrosoftName { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
