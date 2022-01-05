using QuizApp.Entity;
using QuizApp.Services;
using QuizApp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace QuizApp.Models
{
    public class CreateQuestionModel : IValidatableObject
    {
        public Guid QuizId { get; set; }
        public string Desc { get; set; }
        public virtual ICollection<AnswerModel> Answers { get; set; }

        public CreateQuestionModel(Guid quizId, string desc, ICollection<AnswerModel> answers)
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
                yield return new ValidationResult(Messages.EmptyQuizId,
                    new List<string>()
                {
                    nameof(QuizId)
                });
            }

            //Description est vide ?
            if (string.IsNullOrWhiteSpace(Desc))
            {
                yield return new ValidationResult(Messages.EmptyDesc,
                    new List<string>()
                {
                nameof(Desc)
                });
            }
        }
    }
}
