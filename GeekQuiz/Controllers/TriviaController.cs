using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Data.Entity;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Description;
using GeekQuiz.Models;

public class TriviaController : ApiController
{
    private TriviaContext db = new TriviaContext();

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            this.db.Dispose();
        }
        base.Dispose(disposing);
    }

    private async Task<TriviaQuestion> NextQuestionAsync(string userId)
    {
        //var lastQuestionId = await this.db.TriviaAnswers
        //    .Where(a ==> a.UserId == userId)
        //    .GroupBy(a ==> a.QuestionId)
    }
}


namespace GeekQuiz.Controllers
{
    public class TriviaController : ApiController
    {
    }
}
