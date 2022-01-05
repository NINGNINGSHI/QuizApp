using QuizApp.Services;
using QuizApp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace QuizApp
{
    public class CreateQuizModel : IValidatableObject
    {
        public string Title { get; set; }
        public string Password { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var service = (IQuizService)validationContext.GetService(typeof(IQuizService));
            //Title est vide ?
            if (string.IsNullOrWhiteSpace(Title))
            {
                yield return new ValidationResult(Messages.EmptyTitle,
                    new List<string>()
                {
                    nameof(Title)
                });
            }

            //Title existe déjà dans BDD?
            if (service.IsQuizTitleExist(Title))
            {
                yield return new ValidationResult(Messages.ExistsTitle,
                    new List<string>()
                {
                    nameof(Title)
                });
            }

            //Password est vide ?
            if (string.IsNullOrWhiteSpace(Password))
            {
                yield return new ValidationResult(Messages.EmptyPassword,
                    new List<string>()
                {
                nameof(Password)
                });
            }
        }
    }
}
