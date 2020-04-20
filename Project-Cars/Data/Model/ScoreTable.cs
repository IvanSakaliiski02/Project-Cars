using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Cars.Data.Model
{
    public class ScoreTable
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Score { get; set; }


    }
}
