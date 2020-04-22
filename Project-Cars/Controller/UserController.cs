using Project_Cars.Data;
using Project_Cars.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Cars.Controller
{
    public class UserController
    {

        private ScoreContext scoreContext;

        public UserController(ScoreContext score)
        {
            scoreContext = score;
        }
        public int GetAll() 
        {
            var GetAllid = scoreContext.users.Count();
            return GetAllid;
        }
        public void Add(string Name)
        {
            var User = new User() { name = Name};
            scoreContext.Add(User);
            scoreContext.SaveChanges();
        }
        public void Delete (string name)
        {
            var del = scoreContext.users.FirstOrDefault(x=>x.name==name);
            scoreContext.Remove(del);
            scoreContext.SaveChanges();
        }
    }
}
