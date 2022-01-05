using QuizApp.Entity;
using QuizApp.Services;
using QuizApp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace QuizApp.Models
{
    public class CreateScoreModel : IValidatableObject
    {
        public string Pseudo { get; set; }
        public int Value { get; set; }
        public Guid QuizId { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var service = (IScoreService)validationContext.GetService(typeof(IScoreService));
            //QuizId est vide ?
            if (string.IsNullOrWhiteSpace(QuizId.ToString()))
            {
                yield return new ValidationResult(Messages.EmptyQuizId,
                    new List<string>()
                {
                    nameof(QuizId)
                });
            }

            //Pseudo est vide ?
            if (string.IsNullOrWhiteSpace(Pseudo))
            {
                yield return new ValidationResult(Messages.EmptyPseudo,
                    new List<string>()
                {
                    nameof(Pseudo)
                });
            }

            //Value est vide ?
            if (string.IsNullOrWhiteSpace(Value.ToString()))
            {
                yield return new ValidationResult(Messages.EmptyScore,
                    new List<string>()
                {
                    nameof(Value)
                });
            }

            //Value < 0 ?
            if (Value < 0)
            {
                yield return new ValidationResult(Messages.NegatifScore,
                    new List<string>()
                {
                    nameof(Value)
                });
            }
        }
    }
}
