using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Domain.Core
{
    public class BDescription : BaseEntity
    {
        // Se repiten en algunas tablas, pero no en todas 
        public string Descripction { get; set; }
    }
}
