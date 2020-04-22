using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Cars.Data.Model
{
    public class ScoreTable
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int score { get; set; }
        [ForeignKey(nameof(users))]
        public int users_id { get; set; }
        public User users { get; set; }
    }
}
