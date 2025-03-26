using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Projects
    {
        [Key]
        public int ProjectId { get; set; }
        [StringLength(50)]
        public string ProjectName { get; set; }
        [StringLength(300)]
        public string ProjectDetails { get; set; }
        [StringLength(200)]
        public string ProjectLink { get; set; }
        

        // Yazar-Proje İlişkisi
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
