namespace CoreFullTest.Model
{
    using System;
    using System.Collections.Generic;

    public class Bulletin
    {
        public string Id { get; set; }
        public string Body { get; set; }
        public string Head { get; set; }   
        public virtual ICollection<UserLog> UserLogs { get; set; }       
    }
}