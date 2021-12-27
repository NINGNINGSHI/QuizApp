using Microsoft.AspNetCore.Mvc;
using QuizApp.Entity;
using QuizApp.Models;
using QuizApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        [HttpGet("rank/{quizId:Guid}")]
        public IActionResult GetRankByQuizId([FromRoute] Guid quizId)
        {
            return Ok(_ScoreService.GetRankOfQuiz(quizId).Select(s => new
            {
                s.Id,
                s.Pseudo,
                s.Value
            }));
        }

        //-----------------------POST--------------------------------
        [HttpPost("create-or-update-Score")]
        public IActionResult CreateScore([FromBody] ScoreModel model)
        {
            Score score = new(model.QuizId, model.Pseudo, model.Value);
            _ScoreService.Create(score);
            return Ok("Score created");
        }
    }
}
