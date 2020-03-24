using System;

namespace user_netcore.Models
{
    public class User
    {
        public string id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public DateTime createAt { get; set; }
        public string phoneNo { get; set; }
        public string companyName { get; set; }
        public string vatId { get; set; }


    }
}