using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Skills
    {
        [Key]
        public int SkilssId { get; set; }

        [StringLength(100)]
        public string SkilssName { get; set; }


        //Kullanıcı yetenek
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
