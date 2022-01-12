using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstSQL.Models
{
    public class Slider
    {
        public int ID { get; set; }
        public int Order { get; set; }
        public string RedirectUrl { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Info { get; set; }
    }
}

