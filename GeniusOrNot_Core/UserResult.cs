using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniusOrNot_Core
{
    public class UserResult
    {
        public string Name { get; set; }
        public int CorrectAnswers { get; set; }
        public string Diagnosis { get; set; }

        public DateTime TestDate { get; set; } = DateTime.Now;
    }
}
