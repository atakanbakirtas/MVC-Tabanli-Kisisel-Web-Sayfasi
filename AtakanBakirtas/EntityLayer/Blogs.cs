using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Blogs
    {
        [Key]
        public int BlogId { get; set; }
        [StringLength (25)]
        public string BlogName { get; set; }
        [StringLength (50)]
        public string BlogDescription { get; set;}
        [MaxLength]
        public string BlogDetails { get; set; }
        [MaxLength]
        public  string BlogImage { get; set; }
        public DateTime BlogTime { get; set; }
        

        // User Blog İliskisi
        public int UserId { get; set; }
        public virtual User User { get; set; }





    }
}
