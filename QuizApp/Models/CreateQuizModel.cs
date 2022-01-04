using QuizApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace QuizApp
{
    public class CreateQuizModel : IValidatableObject
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public StateType State { get; set; }
        public string Password { get; set; }
        public int Rate { get; set; }


        public CreateQuizModel(Quiz quiz)
        {
            Id = quiz.Id;
            Title = quiz.Title;
            State = quiz.State;
            Password = quiz.Password;
            Rate = quiz.Rate;
        }

        [JsonConstructor]
        public CreateQuizModel(string title, string password, int rate)
        {
            Title = title;
            Password = password;
            Rate = rate;
        }
        

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var service = (IQuizService)validationContext.GetService(typeof(IQuizService));
            //Title est vide ?
            if (string.IsNullOrWhiteSpace(Title))
            {
                yield return new ValidationResult("Le titre ne peut pas être vide.",
                    new List<string>()
                {
                    nameof(Title)
                });
            }

            //Title existe déjà dans BDD?
            if (service.IsQuizTitleExist(Title))
            {
                yield return new ValidationResult("Ce titre existe déjà.",
                    new List<string>()
                {
                    nameof(Title)
                });
            }

            //Password est vide ?
            if (string.IsNullOrWhiteSpace(Password))
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
