using Microsoft.AspNetCore.Mvc;
using QuizApp.Models;
using QuizApp.Services;
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
			if (quiz == null) return BadRequest("Quiz not found for given id");
			return Ok(new QuizModel(quiz));
        }

		/*
		[HttpGet("all")]
		public IActionResult GetAllQuizes()
		{
			return Ok(_QuizService.GetAll().Select(s => new
			{
				s.Title,
				s.Id
			}));
		}
		*/

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
		public IActionResult Create([FromBody] QuizModel model)
        {
			Quiz quiz = new(model.Title, /*model.State,*/ model.Password);
			_QuizService.Create(quiz);
			return Ok("Quiz created");
		}

		[HttpPost("publish/{quizId:Guid}")]
		public IActionResult PublishQuiz([FromRoute] Guid quizId)
        {
			_QuizService.PublishQuiz(quizId);
			return Ok("Quiz published");
		}

		//-----------------------DELETE--------------------------------
		[HttpDelete("delete/{quizId:Guid}")]
		public IActionResult Delete([FromRoute] Guid quizId)
		{
			_QuizService.Delete(_QuizService.GetById(quizId));
			return Ok("Quiz deleted");
		}
	}
}
