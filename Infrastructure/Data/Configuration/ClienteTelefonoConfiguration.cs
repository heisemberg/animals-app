using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuracion
{
     public class ClienteTelefonoConfiguration : IEntityTypeConfiguration<ClienteTelefono>
     {
         public void Configure(EntityTypeBuilder<ClienteTelefono> builder)
         {
             // Aquí puedes configurar las propiedades de la entidad
             // utilizando el objeto builder
             builder.ToTable("ClienteTelefono");

             builder.HasKey(e => e.Id);
             builder.Property(e => e.Id);

             builder.Property(e => e.Numero)
                 .IsRequired()
                 .HasMaxLength(50);

             builder.HasOne(p => p.Clientes)
                 .WithMany(p => p.ClienteTelefonos)
                 .HasForeignKey(p => p.IdCliente);

             }
         }
     }