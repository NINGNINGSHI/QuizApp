using Newtonsoft.Json;
using QuizApp.Entity;
using QuizApp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuizApp.Models
{
    public class AnswerModel : IValidatableObject
    {
        public string Desc { get; set; }
        public bool RightAnswer { get; set; }

        public AnswerModel(string desc, bool rightAnswer)
        {
            Desc = desc;
            RightAnswer = rightAnswer;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {

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
