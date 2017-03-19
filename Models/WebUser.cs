using System;
using System.Collections.Generic;

namespace CoreWebApi.Models
{
    public partial class WebUser
    {
        public int WebUserId { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string WeChatId { get; set; }
        public string MicrosoftId { get; set; }
        public string OrgId { get; set; }
        public string SinaWeiboId { get; set; }
        public string QqId { get; set; }
        public string PictureUrl { get; set; }
        public string UserName { get; set; }
        public int UserType { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
