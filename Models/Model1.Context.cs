//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sifre_Tutma_Programi.Models
{
    using System;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SifreEntities : DbContext
    {
        public SifreEntities()
            : base("name=SifreEntities")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
        public class CustomDbConfiguration : DbConfiguration//sürekli database versiyonu sorgulaması 
        {                                                   //yapmaması için yazılan kod
            public CustomDbConfiguration()
            {
                SetManifestTokenResolver(new CustomManifestTokenResolver());
            }
        }

        public class CustomManifestTokenResolver : IManifestTokenResolver
        {
            public string ResolveManifestToken(DbConnection connection)
            {
                return "2019"; //kullandığınız db versiyonu.
            }
        }

        public virtual DbSet<Sifreler> Sifrelers { get; set; }
    }
}
