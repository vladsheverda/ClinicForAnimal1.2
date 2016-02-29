namespace ClinicForAnimal1._2.Models.Reviews
{
    using System.Data.Entity;

    public partial class ReviewsEntity : DbContext
    {
        public ReviewsEntity()
            : base("name=ReviewsEntity")
        {
        }
   
    
        public virtual DbSet<Review> Reviews { get; set; }
    }
}
