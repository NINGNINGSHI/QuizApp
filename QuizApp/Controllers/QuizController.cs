using Microsoft.AspNetCore.Mvc;
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
		public QuizController(IQuizService QuizService)
		{
			_QuizService = QuizService;
		}

		[HttpGet("{id:Guid}")]
		public IActionResult Get([FromRoute] Guid id)
        {
			var quiz = _QuizService.GetById(id);
			if (quiz == null) return BadRequest("Quiz not found for given id");
			return Ok(new QuizModel(quiz));
        }

		[HttpPost("create-or-update")]
		public IActionResult Create([FromBody] QuizModel model)
        {
			Quiz quiz = new(model.Title, model.State, model.Password, 
				model.ScoreBoard, model.Questions, model.Rate);
			_QuizService.Create(quiz);
			return Ok();
		}

		[HttpDelete("delete/{id:Guid}")]
		public IActionResult Delete(Guid id)
		{
			_QuizService.Delete(_QuizService.GetById(id));
			return Ok();
		}

		[HttpGet("all")]
		public IActionResult GetAll()
		{
			return Ok(_QuizService.GetAll().Select(s => new
			{
				s.Title,
				s.Id
			}));
		}
	}
}
