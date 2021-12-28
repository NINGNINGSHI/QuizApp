using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QuizApp.Entity;
using QuizApp.Models;
using QuizApp.Services;
using System;
using System.Collections.Generic;

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
        public IActionResult CreateQuestion([FromBody]Question model)
        {
            //Question question = new Question(model.QuizId, model.Desc, model.Answers);
            /*
            var question = new
            {
                QuizId = model.QuizId,
                Desc = model.Desc,
                Answers = model.Answers
            };
           
            Console.WriteLine(question);
             */
            _QuestionService.Create(model);
            return Ok("Question created");
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
