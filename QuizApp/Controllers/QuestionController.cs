using Microsoft.AspNetCore.Mvc;
using QuizApp.Entity;
using QuizApp.Models;
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
        public IActionResult CreateQuestion([FromBody] QuestionModel model)
        {
            Question Question = new(model.QuizId, model.Desc, model.Answers);
            _QuestionService.Create(Question);
            return Ok("Score created");
        }


        //-----------------------DELETE--------------------------------
        /*
        [HttpDelete("delete-question/{id:Guid}")]
        public IActionResult Delete([FromRoute] Guid id)
        {
            throw new NotImplementedException();
        }
        */
    }
}
