using Microsoft.AspNetCore.Mvc;
using QuizApp.Models;
using QuizApp.Services;
using QuizApp.Utils;
using System;
using System.Linq;
/**
* Permettant de créer/éditer/supprimer/lire un Quiz, API ne renvoie jamais des entités mais des modèles.
*/
namespace QuizApp.Controllers
{
    public class QuizController : ApiControllerBase
    {
        private readonly IQuizService _QuizService;
        public QuizController(IQuizService quizService)
        {
            _QuizService = quizService;
        }

        //-----------------------GET--------------------------------

        [HttpGet("get-quiz/{quizId:Guid}")]
        public IActionResult GetQuiz([FromRoute] Guid quizId)
        {
            var quiz = _QuizService.GetById(quizId);
            if (quiz == null) return BadRequest(Messages.QuizNotFound);
            return Ok(new DisplayQuizModel(quiz));
        }

        [HttpGet("drafted")]
        public IActionResult GetAllDraftQuizes()
        {
            return Ok(_QuizService.GetByStateType(StateType.Draft).Select(s => new
            DisplayDraftedQuizes(s)));
        }

        [HttpGet("published")]
        public IActionResult GetAllPublishedQuizes()
        {
            return Ok(_QuizService.GetByStateType(StateType.Published).Select(s => new
            DisplayDraftedQuizes(s)));
        }

        //-----------------------POST--------------------------------

        [HttpPost("create-quiz")]
        public IActionResult CreateQuiz([FromBody] CreateQuizModel model)
        {
            string salt = PasswordUtil.GenerateSaltBytes();
            Quiz quiz = new(model.Title, PasswordUtil.GenerateSaltedHash(
                model.Password, salt), salt);
            _QuizService.Create(quiz);
            return Ok(quiz.Id);
        }

        [HttpPost("update-rate")]
        public IActionResult UpdateQuiz([FromBody] UpdateRatesModel model)
        {
            _QuizService.UpdateRate(model.QuizId, model.Rate);
            return Ok(model.QuizId);
        }

        [HttpPost("publish/{quizId:Guid}")]
        public IActionResult PublishQuiz([FromRoute] Guid quizId)
        {
            _QuizService.PublishQuiz(quizId);
            return Ok(Messages.QuizPublished);
        }

        [HttpPost("check-password")]
        public IActionResult PublishQuiz([FromBody] CheckPasswordModel model)
        {
            if (_QuizService.CheckPassword(model.QuizId, model.Password))
            {
                return Ok(Messages.CorrectPassword);
            }
            else
            {
                return BadRequest(Messages.WrongPassword);
            }
        }

        //-----------------------DELETE--------------------------------
        [HttpDelete("delete/{quizId:Guid}")]
        public IActionResult Delete([FromRoute] Guid quizId)
        {
            _QuizService.Delete(_QuizService.GetById(quizId));
            return Ok(Messages.QuizDeleted);
        }
    }
}
