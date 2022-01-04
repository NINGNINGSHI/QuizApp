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
        [HttpPost("create-question")]
        public IActionResult CreateQuestion([FromBody] CreateUpdateQuestionModel model)
        {
            Question question = new Question(model.QuizId, model.Desc, model.Answers);
            _QuestionService.Create(question);
            
            return Ok("Question est créée");
        }

        [HttpPost("update-question")]
        public IActionResult UpdateQuestion([FromBody] CreateUpdateQuestionModel model)
        {
            Question question = new Question(model.QuizId, model.Desc, model.Answers);
            _QuestionService.Update(question);
            return Ok("Question est mise à jour");
        }

        //-----------------------DELETE--------------------------------
        [HttpDelete("delete-question/{questionId:Guid}")]
        public IActionResult Delete([FromRoute] Guid questionId)
        {
            _QuestionService.Delete(_QuestionService.GetById(questionId));
            return Ok("Question est supprimée");
        }
    }
}
