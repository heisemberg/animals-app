using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuracion
{
     public class ClienteDireccionConfiguration : IEntityTypeConfiguration<ClienteDireccion>
     {
         public void Configure(EntityTypeBuilder<ClienteDireccion> builder)
         {
             // Aquí puedes configurar las propiedades de la entidad
             // utilizando el objeto builder
             builder.ToTable("cliente_direccion");

             builder.HasKey(e => e.Id);
             builder.Property(e => e.Id);

             
             }
         }
     }