using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuracion
{
     public class MascotaConfiguration : IEntityTypeConfiguration<Mascota>
     {
         public void Configure(EntityTypeBuilder<Mascota> builder)
         {
             // Aquí puedes configurar las propiedades de la entidad
             // utilizando el objeto builder
             builder.ToTable("Mascota");

             builder.HasKey(e => e.Id);
             builder.Property(e => e.Id);

             builder.Property(e => e.Nombre)
                 .IsRequired()
                 .HasMaxLength(50);

             builder.Property(e => e.Especie)
                 .IsRequired()
                 .HasMaxLength(50);

             builder.Property(e => e.FechaNacimiento)
                 .HasColumnType("datetime")
                 .IsRequired();

             builder.HasOne(p => p.Raza)
                 .WithMany(p => p.Mascotas)
                 .HasForeignKey(p => p.IdRaza);

             builder.HasOne(p => p.Clientes)
                 .WithMany(p => p.Mascotas)
                 .HasForeignKey(p => p.IdCliente);

             }
         }
     }