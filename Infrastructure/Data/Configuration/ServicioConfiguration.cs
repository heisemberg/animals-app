using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuracion
{
     public class ServicioConfiguration : IEntityTypeConfiguration<Servicio>
     {
         public void Configure(EntityTypeBuilder<Servicio> builder)
         {
             // Aquí puedes configurar las propiedades de la entidad
             // utilizando el objeto builder
             builder.ToTable("Servicio");

             builder.HasKey(e => e.Id);
             builder.Property(e => e.Id);

             builder.Property(e => e.Nombre)
                 .IsRequired()
                 .HasMaxLength(50);

             builder.Property(e => e.Precio)
                 .IsRequired()
                 .HasMaxLength(50);

             }
         }
     }