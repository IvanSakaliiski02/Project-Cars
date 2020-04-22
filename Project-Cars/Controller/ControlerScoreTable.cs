using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Project_Cars.Data;
using Project_Cars.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Cars.Controller
{
    public class ControlerScoreTable
    {   
        ScoreTable Updated = new ScoreTable();
        private ScoreContext scoreContext;
        public ControlerScoreTable(ScoreContext score)
        {
            scoreContext = score;           
        }
        public ScoreTable Get(int id) 
        {
            var GetId = scoreContext.rankingscore.FirstOrDefault(x => x.id == id);
            return GetId;
        }
        public void Add(int scoreTable,int userId) 
        {
            var score = new ScoreTable() { score = scoreTable,users_id=userId};
            scoreContext.Add(score);
            scoreContext.SaveChanges();                      
        }
        public void Update(int scoreUpDate,int UserId) 
        {
            var score = new ScoreTable() { score = scoreUpDate,users_id=UserId};           
            var RankingScoreId = scoreContext.users.FirstOrDefault(x => x.id == UserId);
            var id = Get(RankingScoreId.id);
            Updated = score;
            Updated.id = RankingScoreId.id;
            scoreContext.Entry(id).CurrentValues.SetValues(Updated);
            scoreContext.SaveChanges();
        }
        public void Delete(string name) 
        {
            var del = scoreContext.users.FirstOrDefault(x => x.name == name);
            var GetDel = scoreContext.rankingscore.FirstOrDefault(x => x.users_id == del.id);
            scoreContext.Remove(GetDel);
            scoreContext.SaveChanges();
        }

    }
}
