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
            if (quiz == null) return BadRequest("Quiz n'est par trouvé avec cet Id");
            return Ok(new CreateQuizModel(quiz));
        }

        [HttpGet("drafted")]
        public IActionResult GetAllDraftQuizes()
        {
            return Ok(_QuizService.GetByStateType(StateType.Draft).Select(s => new
            {
                s.Title,
                s.Id
            }));
        }

        [HttpGet("published")]
        public IActionResult GetAllPublishedQuizes()
        {
            return Ok(_QuizService.GetByStateType(StateType.Published).Select(s => new
            {
                s.Title,
                s.Rate,
                s.Id
            }));
        }

        //-----------------------POST--------------------------------

        [HttpPost("create")]
        public IActionResult Create([FromBody] CreateQuizModel model)
        {
            string salt = PasswordUtil.GenerateSaltBytes();
            Quiz quiz = new(model.Title, PasswordUtil.GenerateSaltedHash(
                model.Password, salt), salt);
            _QuizService.Create(quiz);
            return Ok("Quiz est créé");
        }

        [HttpPost("publish/{quizId:Guid}")]
        public IActionResult PublishQuiz([FromRoute] Guid quizId)
        {
            _QuizService.PublishQuiz(quizId);
            return Ok("Quiz est publié");
        }

        [HttpPost("check-password")]
        public IActionResult PublishQuiz([FromBody] CheckPasswordModel model)
        {
            if (_QuizService.CheckPassword(model.Id, model.Password))
            {
                return Ok("Le mot de passe est correct");
            }
            else
            {
                return BadRequest("Le mot de passe n'est pas correct");
            }
        }

        //-----------------------DELETE--------------------------------
        [HttpDelete("delete/{quizId:Guid}")]
        public IActionResult Delete([FromRoute] Guid quizId)
        {
            _QuizService.Delete(_QuizService.GetById(quizId));
            return Ok("Quiz est supprimé");
        }
    }
}
