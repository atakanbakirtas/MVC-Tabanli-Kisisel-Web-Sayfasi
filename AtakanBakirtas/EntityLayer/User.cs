using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [StringLength (20)]
        public string UserName { get; set; }
        [StringLength (20)]
        public string UserSurname { get; set; }

        [StringLength (200)]
        public string UserDetails { get; set; }
        [StringLength (20)]
        public string Password { get; set; }
        [StringLength (40)]
        public string Email { get; set; }


        // İlişki kısmı
        public ICollection<Blogs> Blogs { get; set; }

        public ICollection<Projects> Projects { get; set; }


        public ICollection<Skills> Skillss { get;}



    }
}
