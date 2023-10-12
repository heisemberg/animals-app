using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuracion
{
     public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
     {
         public void Configure(EntityTypeBuilder<Cliente> builder)
         {
             // Aquí puedes configurar las propiedades de la entidad
             // utilizando el objeto builder
             builder.ToTable("Cliente");

             builder.HasKey(e => e.Id);
             builder.Property(e => e.Id);

             builder.Property(e => e.Nombre)
                 .IsRequired()
                 .HasMaxLength(50);

             builder.Property(e => e.Apellidos)
                 .IsRequired()
                 .HasMaxLength(50);

             builder.Property(e => e.Email)
                 .IsRequired()
                 .HasMaxLength(80);

             
             }
         }
     }