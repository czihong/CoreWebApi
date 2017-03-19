using System;
using System.Collections.Generic;

namespace CoreWebApi.Models
{
    public partial class WeChatUser
    {
        public int Id { get; set; }
        public string UnionId { get; set; }
        public string OpenId { get; set; }
        public string NickName { get; set; }
        public string Sex { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PictureUrl { get; set; }
        public string Privilege { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
