using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Models
{
    public class UpdateRatesModel
    {
        public Guid QuizId { get; set; }
        public int Rate { get; set; }
    }
}
