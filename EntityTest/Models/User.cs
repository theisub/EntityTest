using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnotherWebTest.Models
{
    public class User
    {
        //[Key]
        public int UserId { get; set; }
        public string UserImage { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }

    }
}
