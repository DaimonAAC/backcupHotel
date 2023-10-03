using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Domain.Core
{
    public class PersonalInfo : BaseEntity
    {
        // Es lo mismo que pasa con BDescripcion
        public string FullName { get; set; }
        public string Mail { get; set; }
    }
}
