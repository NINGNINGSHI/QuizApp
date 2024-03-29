﻿using QuizApp.Services;
using QuizApp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace QuizApp.Models
{
    public class CheckPasswordModel : IValidatableObject
    {
        public Guid QuizId { get; set; }
        public string Password { get; set; }
        
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //QuizId est vide ?
            if (string.IsNullOrWhiteSpace(QuizId.ToString()))
            {
                yield return new ValidationResult(Messages.EmptyQuizId,
                    new List<string>()
                {
                    nameof(QuizId)
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
