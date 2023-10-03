using Hotel.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Domain.Entities
{
    public class User : PersonalInfo
    {
        public int UserId { get; set; }
        public int UserRoleId { get; set; } 
        public string? Password { get; set; }   
    }
}
