using QuizApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace QuizApp.Models
{
    public class CheckPasswordModel : IValidatableObject
    {
        public Guid Id { get; set; }
        public string Password { get; set; }

        [JsonConstructor]
        public CheckPasswordModel(Guid id, string password)
        {
            Id = id;
            Password = password;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var service = (IQuizService)validationContext.GetService(typeof(IQuizService));
            //Id est vide ?
            if (string.IsNullOrWhiteSpace(Id.ToString()))
            {
                yield return new ValidationResult("Id ne peut pas être vide.",
                    new List<string>()
                {
                    nameof(Id)
                });
            }

            //Password est vide ?
            if (service.IsQuizTitleExist(Password))
            {
                yield return new ValidationResult("Le mot de passe ne peut pas être vide.",
                    new List<string>()
                {
                    nameof(Password)
                });
            }
        }
    }
}
