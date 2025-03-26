using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Models
{
    public class Context:DbContext
    {
        // Veritabında olusturulacak tablolar
        public DbSet<User> Users { get; set; }
        public DbSet<Projects> Projectss { get; set; }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Blogs> Blogss { get; set; }
    }
}
