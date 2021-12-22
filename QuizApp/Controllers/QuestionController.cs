using Microsoft.AspNetCore.Mvc;
using QuizApp.Models;
using QuizApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public IActionResult GetAllQuestionsByQuizId([FromRoute] Guid quiz_id)
        {
            throw new NotImplementedException();
        }

        //-----------------------POST--------------------------------
        [HttpPost("create-or-update-question")]
        public IActionResult CreateQuestion([FromBody] QuestionModel model)
        {
            throw new NotImplementedException();
        }


        //-----------------------DELETE--------------------------------
        [HttpDelete("delete-question/{id:Guid}")]
        public IActionResult Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
