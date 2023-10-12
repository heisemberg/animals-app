using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuracion
{
     public class CitaConfiguration : IEntityTypeConfiguration<Cita>
     {
         public void Configure(EntityTypeBuilder<Cita> builder)
         {
             // Aquí puedes configurar las propiedades de la entidad
             // utilizando el objeto builder
             builder.ToTable("Cita");

             builder.HasKey(e => e.Id);
             builder.Property(e => e.Id);

             builder.Property(e => e.Fecha)
                 .HasColumnType("date")
                 .IsRequired();

             builder.Property(e => e.Hora)
                 .HasColumnType("time")
                 .IsRequired();

             builder.HasOne(p => p.Clientes)
                 .WithMany(p => p.Citas)
                 .HasForeignKey(p => p.IdCliente);
                
             builder.HasOne(p => p.Mascotas)
                 .WithMany(p => p.Citas)
                 .HasForeignKey(p => p.IdMascota);

             builder.HasOne(p => p.Servicios)
                 .WithMany(p => p.Citas)
                 .HasForeignKey(p => p.ServicioId);
             
             }
         }
     }