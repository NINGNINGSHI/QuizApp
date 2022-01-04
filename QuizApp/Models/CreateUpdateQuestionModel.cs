using QuizApp.Entity;
using QuizApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace QuizApp.Models
{
    public class CreateUpdateQuestionModel : IValidatableObject
    {
        public Guid Id { get; set; }
        public Guid QuizId { get; set; }
        public string Desc { get; set; }
        public ICollection<Answer> Answers { get; set; }

        
        public CreateUpdateQuestionModel(CreateUpdateQuestionModel q)
        {
            Id = q.Id;
            QuizId = q.QuizId;
            Desc = q.Desc;
            Answers = q.Answers;
        }

        [JsonConstructor]
        public CreateUpdateQuestionModel(Guid quizId, string desc, ICollection<Answer> answers)
        {
            QuizId = quizId;
            Desc = desc;
            Answers = answers;
        }
        
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var service = (IQuestionService)validationContext.GetService(typeof(IQuestionService));
            //Quiz Id est vide ?
            if (string.IsNullOrWhiteSpace(QuizId.ToString()))
            {
                yield return new ValidationResult("Quiz id ne peut pas être vide.",
                    new List<string>()
                {
                    nameof(QuizId)
                });
            }

            //Description est vide ?
            if (string.IsNullOrWhiteSpace(Desc))
            {
                yield return new ValidationResult("La description de la question" +
                    " ne peut pas être vide.",
                    new List<string>()
                {
                nameof(Desc)
                });
            }
        }
    }
}
