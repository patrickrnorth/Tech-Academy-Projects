namespace NewsletterAppMVC
{
    using NewsletterAppMVC.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class NewsletterEntities : DbContext
    {
        public NewsletterEntities()
                : base("name=NewsletterEntities")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<SignUp> SignUps { get; set; }
    }
}