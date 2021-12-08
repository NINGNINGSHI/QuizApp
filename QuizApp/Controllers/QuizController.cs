using Microsoft.AspNetCore.Mvc;
using QuizApp.Services;
using System;
using System.Linq;

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
		public IActionResult CreateOrUpdate([FromBody] QuizModel model)
        {
			//TODO
			return Ok();
        }

		[HttpDelete("delet/{id:Guid}")]
		public IActionResult Delete(Guid id)
		{
			//TODO
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
