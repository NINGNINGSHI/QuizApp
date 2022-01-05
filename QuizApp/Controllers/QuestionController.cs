using Microsoft.AspNetCore.Mvc;
using QuizApp.Entity;
using QuizApp.Models;
using QuizApp.Services;
using QuizApp.Utils;
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
            return Ok(new DisplayAllQuestionsModel(Mappers.ConvertQuestionEntityToModels(
                _QuestionService.GetAllQuestionsByQuizId(quizId))));
        }

        //-----------------------POST--------------------------------
        [HttpPost("create-question")]
        public IActionResult CreateQuestion([FromBody] CreateQuestionModel model)
        {
            Question question = new Question(model.QuizId, model.Desc,
                Mappers.ConvertAnswerModelsToEntity(model.Answers)); ;
            _QuestionService.Create(question);
            return Ok(Messages.QuestionCreated);
        }

        [HttpPost("update-question")]
        public IActionResult UpdateQuestion([FromBody] UpdateQuestionModel model)
        {
            Question question = new Question(model.Id, model.QuizId, model.Desc,
                Mappers.ConvertAnswerModelsToEntity(model.Answers));
            _QuestionService.UpdateQuestionWithAnswers(question);
            return Ok(Messages.QuestionUpdated);
        }

        //-----------------------DELETE--------------------------------
        [HttpDelete("delete-question/{questionId:Guid}")]
        public IActionResult Delete([FromRoute] Guid questionId)
        {
            _QuestionService.Delete(_QuestionService.GetById(questionId));
            return Ok(Messages.QuestionDeleted);
        }
    }
}
