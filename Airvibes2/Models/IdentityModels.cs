using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Airvibes2.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(50, ErrorMessage = "Limite de 50 caractères.")]
        [Display(Name = "Nom")]
        public string Nom { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Limite de 50 caractères.")]
        [Display(Name = "Prénom")]
        public string Prénom { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd-MM-yyyy",ApplyFormatInEditMode = true)]
        [Display(Name = "Date de naissance")]
        public System.DateTime DateNaissance {get;set;}
        public string Adresse { get; set; }
        public string NumeroTelephone { get; set; }
        public string Ville { get; set; }
        
        public virtual List<SComment> SComment { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public DbSet<Artists> Artists { get; set; }
        public DbSet<Records> Records { get; set; }
        public DbSet<Songs> Songs { get; set; }
        public DbSet<SComment> SComment { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCart { get; set; }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}