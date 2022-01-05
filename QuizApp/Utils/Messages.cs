using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Utils
{
    public static class Messages
    {
        /**
         * Réponse de controller Quiz
         */
        public const string QuizPublished = "Quiz est publié";
        public const string WrongPassword = "Le mot de passe n'est pas correct";
        public const string CorrectPassword = "Le mot de passe est correct";
        public const string QuizNotFound = "Quiz n'est par trouvé avec cet Id";
        public const string QuizDeleted = "Quiz est supprimé";

        /**
         * Réponse de controller Question
         */
        public const string QuestionCreated = "Question est créée";
        public const string QuestionUpdated = "Question est mise à jour";
        public const string QuestionDeleted = "Question est supprimée";

        /**
         * Réponse de controller Score
         */
        public const string ScoreCreated = "Score est créé";

        /**
         * Message de validateur
         */
        public const string EmptyDesc = "La description de la réponse" +
                    " ne peut pas être vide";
        public const string EmptyQuizId = "QuizId ne peut pas être vide";
        public const string EmptyPassword = "Le mot de passe ne peut pas être vide";
        public const string EmptyTitle = "Le titre ne peut pas être vide";
        public const string ExistsTitle = "Ce titre existe déjà";
        public const string EmptyPseudo = "Le pseudo nom ne peut pas être vide";
        public const string EmptyScore = "La valeur de score ne peut pas être vide";
        public const string NegatifScore = "La valeur de score ne peut pas être inférieur à 0";
        public const string EmptyId = "Id ne peut pas être vide";

    }
}
