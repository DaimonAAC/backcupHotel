﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Domain.Core
{
    public class PersonalInfo : BaseEntity
    {
        public string FullName { get; set; }
        public string Mail { get; set; }
    }
}
