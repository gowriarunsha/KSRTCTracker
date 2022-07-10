using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
//using TreasureHunt.CRUD;
//using TreasureHunt.DataContext;
//using TreasureHunt.Models;

namespace TreasureHunt.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly VuScoreUpdates vuScoreUpdates;

//        int minutes = 5;
//        int seconds = 0;
//        int attempt = 0;

//        public string _TeamName = null!;
//        public HomeController(ILogger<HomeController> logger, VuScoreContext context)
//        {
//            _logger = logger;
//            vuScoreUpdates = new VuScoreUpdates(context);
//        }

//        public IActionResult Index()
//        {
//            return View();
//        }
//        [HttpGet]
//        public IActionResult ScoreBoard()
//        {
//            return View(vuScoreUpdates.ReturnScoreBoard());
//        }


//        [ValidateAntiForgeryToken]
//        [HttpPost]
//        public IActionResult Game1([Bind("id,teamName,timestamp,loggedIN,completed")] Score score, string what, string TeamName, string TeamID)

//        {
//            if (score.id == 0)
//            {
//                score.id = Convert.ToInt32(TeamID);
//            }
//            if (what == "Game")
//            {
//                TempData["TeamName"] = TeamName;
//                return View();
//            }
//            else
//            {
//                TempData["minutes"] = minutes;
//                TempData["seconds"] = seconds;
//                TempData["TeamName"] = TeamName;
//                return View("QAPage", score);
//            }
//        }
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public IActionResult Index(string TeamName)
//        {
//            if (TeamName == null)
//            {
//                return View();
//            }
//            TempData["TeamName"] = TeamName;
//            _TeamName = TeamName;
//            Score score = new Score();
//            score.timestamp = DateTime.Now;
//            score.loggedIN = DateTime.Now;
//            score.completed = DateTime.Now.AddDays(-1);
//            score.teamName = TeamName;
//            score.submit = "Not Yet";
//            vuScoreUpdates.UpdateLoggedTeam(score);

//            return View("HaHaTeamName", score);
//        }
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public IActionResult HaHaTeamName(string TeamName)
//        {
//            TempData["TeamName"] = TeamName;

//            return View();
//        }
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public IActionResult QAPage([Bind("id,teamName,timestamp,loggedIN,completed")] Score Scrd, string id, string TeamName, string Answer1, string minutesH, string secondsH, string attemptH)
//        {
//            string RightAnswer = "importjava.util.ArrayList;importjava.util.Arrays;importjava.util.Collections;importjava.util.List;/*JavaProgramsortanintegerarrayusingradixsortalgorithm.*input:[80,50,30,10,90,60,0,70,40,20,50]*output:[0,10,20,30,40,50,50,60,70,80,90]*TimeComplexityofSolution:*BestCaseO(n);AverageCaseO(n);WorstCaseO(n^2).*/publicclassVYUH{publicstaticvoidmain(String[]args){int[]input{80,50,30,10,90,60,0,70,40,20,50};System.out.println(Arrays.toString(input));bucketSort(input);System.out.println(Arrays.toString(input));}publicstaticvoidbucketSort(int[]input){finalint[]code=hash(input);List[]buckets=newList[code[1]];for(inti=0;i<code[1];i++){buckets[i]=newArrayList();}for(inti:input){buckets[hash(i,code)].add(i);}for(Listbucket:buckets){Collections.sort(bucket);}intndx= 0;for(intb=0;b<buckets.length;b++){for(intv: buckets[b]){input[ndx++]=v;}}}privatestaticint[]hash(int[]input){intm=input[0];for (inti=1;i<input.length;i++){if(m<input[i]){m=input[i];}}returnnewint[]{m,(int)Math.sqrt(input.length)}}privatestaticinthash(inti,int[]code){return(int)((double)i/code[0]*(code[1]-1));}}";
//            RightAnswer = RightAnswer.ToString().Replace("\r", "").Replace("\n", "").Replace(" ", "");
//            string cleanAnswer = null!;
//            if (Answer1 != null)
//            {
//                cleanAnswer = Answer1.ToString().Replace("\r", "").Replace("\n", "").Replace(" ", "");
//            }
//            else
//            {
//                cleanAnswer = "Nothing";
//            }
//            if (Scrd.id == 0)
//            {
//                Scrd.id = Convert.ToInt32(id);
//            }
//            if (cleanAnswer != RightAnswer & Convert.ToInt32(minutesH) <= 5 && minutesH != null)
//            {
//                //'check for secondsH less than 10 seconds'
//                int _sec = Convert.ToInt32(secondsH);
//                int _min = Convert.ToInt32(minutesH);




//                if (Convert.ToInt32(secondsH) == 10 && Convert.ToInt32(minutesH) != 0)
//                {
//                    _min = _min - 1;
//                    _sec = 0;
//                }
//                else if (Convert.ToInt32(secondsH) <= 9 && Convert.ToInt32(minutesH) != 0)
//                {
//                    _sec = 60 - (10 - Convert.ToInt32(secondsH));
//                    _min = _min - 1;
//                }
//                else if (_min <= 0 && _sec <= 10)
//                {
//                    _min = 0;
//                    _sec = 0;
//                    return View("Failed");
//                }

//                else
//                {
//                    _sec = _sec - 10;
//                }

//                minutesH = _min.ToString();
//                secondsH = _sec.ToString();
//                attempt = Convert.ToInt32(attemptH) + 1;
//            }
//            else if (cleanAnswer == RightAnswer && (Convert.ToInt32(minutesH) >= 0 && Convert.ToInt32(secondsH) >= 1))
//            {
//                Score score = new Score();
//                score.completed = DateTime.Now;
//                score.teamName = TeamName;
//                score.submit = "Yup";
//                score.id = Scrd.id;
//                vuScoreUpdates.Updatecompeleted(score);
//                return View("ScoreBoard", vuScoreUpdates.ReturnScoreBoard());
//            }
//            TempData["minutes"] = minutesH;
//            TempData["seconds"] = secondsH;
//            TempData["attempt"] = attempt;
//            return View("QAPage", Scrd);

//        }
//        public IActionResult Privacy()
//        {
//            return View();
//        }

//        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//        public IActionResult Error()
//        {
//            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//        }
//    }
//}