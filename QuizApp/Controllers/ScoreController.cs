using Microsoft.AspNetCore.Mvc;
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

        [HttpGet("rank/{id:Guid}")]
        public IActionResult GetRankByQuizId([FromRoute] Guid quizId)
        {
            throw new NotImplementedException();
        }

        //-----------------------POST--------------------------------
        [HttpPost("create-or-update-Score")]
        public IActionResult CreateScore([FromBody] ScoreModel model)
        {
            throw new NotImplementedException();
        }

    }
}
