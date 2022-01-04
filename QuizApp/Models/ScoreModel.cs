using QuizApp.Entity;
using QuizApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace QuizApp.Models
{
    public class ScoreModel : IValidatableObject
    {
        public Guid Id { get; set; }
        public string Pseudo { get; set; }
        public int Value { get; set; }
        public Guid QuizId { get; set; }
    
        public ScoreModel(Score s)
        {
            Id = s.Id;
            QuizId = s.QuizId;
            Pseudo = s.Pseudo;
            Value = s.Value;
        }

        [JsonConstructor]
        public ScoreModel(Guid quizId, string pseudo, int value)
        {
            QuizId = quizId;
            Pseudo = pseudo;
            Value = value;
        }
        
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var service = (IScoreService)validationContext.GetService(typeof(IScoreService));
            //QuizId est vide ?
            if (string.IsNullOrWhiteSpace(QuizId.ToString()))
            {
                yield return new ValidationResult("Le quiz Id ne peut pas être vide.",
                    new List<string>()
                {
                    nameof(QuizId)
                });
            }

            //Pseudo est vide ?
            if (string.IsNullOrWhiteSpace(Pseudo))
            {
                yield return new ValidationResult("Le pseudo nom ne peut pas être vide.",
                    new List<string>()
                {
                    nameof(Pseudo)
                });
            }

            //Value est vide ?
            if (string.IsNullOrWhiteSpace(Value.ToString()))
            {
                yield return new ValidationResult("La valeur de score ne peut pas être vide.",
                    new List<string>()
                {
                    nameof(Value)
                });
            }

            //Value < 0 ?
            if (Value < 0)
            {
                yield return new ValidationResult("La valeur de score ne peut pas être inférieur à 0.",
                    new List<string>()
                {
                    nameof(Value)
                });
            }
        }
    }
}
