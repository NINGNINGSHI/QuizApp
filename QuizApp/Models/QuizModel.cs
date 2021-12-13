using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

/**
 * Pour front
 */
namespace QuizApp
{
    public class QuizModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

       
        public QuizModel(Quiz quiz)
        {
            Id = quiz.Id;
            Title = quiz.Title;
        }

        [JsonConstructor]
        public QuizModel(Guid id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}
