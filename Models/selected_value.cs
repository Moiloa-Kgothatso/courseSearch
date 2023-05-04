using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace courseSearch.Models
{
    [Keyless]
    public class selected_value
    {
        public string subject {get; set;} = "";
        public int level {get; set;}
        public int percentage {get; set;}
    }
}