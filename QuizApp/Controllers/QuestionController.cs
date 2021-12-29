using Microsoft.AspNetCore.Mvc;
using QuizApp.Entity;
using QuizApp.Services;
using System;

namespace QuizApp.Controllers
{
    public class QuestionController : ApiControllerBase
    {
        private readonly IQuestionService _QuestionService;

        public QuestionController(IQuestionService questionService)
        {
            _QuestionService = questionService;
        }

        //-----------------------GET--------------------------------

        [HttpGet("get-all-questions/{quizId:Guid}")]
        public IActionResult GetAllQuestionsByQuizId([FromRoute] Guid quizId)
        {
            return Ok(_QuestionService.GetAllQuestionsByQuizId(quizId));
        }

        //-----------------------POST--------------------------------
        [HttpPost("create-or-update-question")]
        public IActionResult CreateQuestion([FromBody] Question question)
        {
            //Question question = new Question(model.QuizId, model.Desc, model.Answers);
            _QuestionService.Create(question);
            return Ok("Question created");
        }
    }
}
