using QuizApp.Entity;
using QuizApp.Repositories;
using System;
using System.Collections.Generic;

namespace QuizApp.Services
{
    public class ScoreService : CRUDService<Score>, IScoreService
    {
        private IScoreRepository _Repository;
        public ScoreService(IScoreRepository repository) : base(repository)
        {
            _Repository = repository;
        }

        public IEnumerable<Score> GetRankingByQuizId(Guid quizId)
        {
            return _Repository.GetScoreByQuizId(quizId);
        }
    }
}
