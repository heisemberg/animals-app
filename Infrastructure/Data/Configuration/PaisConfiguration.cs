using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuracion
{
     public class PaisConfiguration : IEntityTypeConfiguration<Pais>
     {
         public void Configure(EntityTypeBuilder<Pais> builder)
         {
             // Aquí puedes configurar las propiedades de la entidad
             // utilizando el objeto builder
             builder.ToTable("pais");

             builder.HasKey(e => e.Id);
             builder.Property(e => e.Id);
             builder.Property(e => e.NombrePais)
                 .IsRequired()
                 .HasMaxLength(50);
        
             }
         }
     }