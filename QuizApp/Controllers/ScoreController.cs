using Microsoft.AspNetCore.Mvc;
using QuizApp.Entity;
using QuizApp.Models;
using QuizApp.Services;
using System;
using System.Linq;

namespace QuizApp.Controllers
{
    public class ScoreController : ApiControllerBase
    {
        private readonly IScoreService _ScoreService;

        public ScoreController(IScoreService scoreService)
        {
            _ScoreService = scoreService;
        }

        //-----------------------GET--------------------------------

        [HttpGet("ranking/{quizId:Guid}")]
        public IActionResult GetRankingByQuizId([FromRoute] Guid quizId)
        {
            return Ok(_ScoreService.GetRankingByQuizId(quizId).Select(s => new
            DisplayRankModel(s)));
        }

        //-----------------------POST--------------------------------
        [HttpPost("create-score")]
        public IActionResult CreateScore([FromBody] CreateScoreModel model)
        {
            Score score = new(model.QuizId, model.Pseudo, model.Value);
            _ScoreService.Create(score);
            return Ok();
        }
    }
}
