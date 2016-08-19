namespace CoreFullTest.Model
{
    using System;
    using System.Collections.Generic;

    public class UserLog
    {
        public int id { get; set; }
        public string device_id { get; set; }
        public string first_seen { get; set; }
        public string last_seen { get; set; }
        public int is_active { get; set; }
       // public virtual ICollection<Bulletin> UserLogs { get; set; }

    }
}