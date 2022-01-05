using QuizApp.Services;
using QuizApp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Models
{
    public class UpdateQuestionModel : IValidatableObject
    {
        public Guid Id { get; set; }
        public Guid QuizId { get; set; }
        public string Desc { get; set; }
        public virtual ICollection<AnswerModel> Answers { get; set; }

        public UpdateQuestionModel(Guid id, Guid quizId, string desc,
            ICollection<AnswerModel> answers)
        {
            Id = id;
            QuizId = quizId;
            Desc = desc;
            Answers = answers;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //Id est vide ?
            if (string.IsNullOrWhiteSpace(Id.ToString()))
            {
                yield return new ValidationResult(Messages.EmptyId,
                    new List<string>()
                {
                    nameof(Id)
                });
            }

            //QuizId est vide ?
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
