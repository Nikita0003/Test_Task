using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Task.Models
{
    public class User
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3),RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        public string Name { get; set; }

        public bool Q1 { get; set; }
        public bool Q2 { get; set; }
        public bool Q3 { get; set; }
        public bool Q4 { get; set; }
        public bool Q5 { get; set; }
        public bool Q6 { get; set; }
        public bool Q7 { get; set; }
        public bool Q8 { get; set; }
        public bool Q9 { get; set; }
        public bool Q10 { get; set; }

        public double Sum { get; set; }

    }
}
