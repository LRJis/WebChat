using System;

namespace Shared
{
    public class UserInfo
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string PassWord { get; set; }
    }

    public class MessageInfo
    {
        public int SenderId { get; set; }
        public string Content { get; set; }
        public int ReceiverId { get; set; }
        public DateTime PublishTime { get; set; }
    }
}