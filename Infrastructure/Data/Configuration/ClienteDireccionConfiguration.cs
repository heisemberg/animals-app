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
             builder.ToTable("ClienteDireccion");

             builder.HasKey(e => e.Id);
             builder.Property(e => e.Id);

            builder.Property(e => e.TipoDeVia)
                 .HasMaxLength(50);

            builder.Property(e => e.NumeroPri)
                 .HasMaxLength(50);

            builder.Property(e => e.Letra)
                 .HasMaxLength(50);

            builder.Property(e => e.Bis)
                 .IsRequired()
                 .HasMaxLength(3);

            builder.Property(e => e.LetraSec)
                 .IsRequired()
                 .HasMaxLength(2);

            builder.Property(e => e.Cardinal)
                 .IsRequired()
                 .HasMaxLength(10);

            builder.Property(e => e.NumeroSec) 
                 .HasColumnType("int");

            builder.Property(e => e.LetraTer)
                 .IsRequired()
                 .HasMaxLength(10);

            builder.Property(e => e.NumeroTer) 
                 .HasColumnType("int");

            builder.Property(e => e.CardinalSec) 
                 .IsRequired()  
                 .HasMaxLength(10);

            builder.Property(e => e.Complemento)
                 .HasMaxLength(50);

            builder.Property(e => e.CodigoPostal)   
                 .HasMaxLength(10);

            builder.HasOne(p => p.Clientes)
                 .WithOne(p => p.ClienteDireccion)
                 .HasForeignKey<ClienteDireccion>(p => p.IdCliente);
                    
            builder.HasOne(p => p.Ciudades)
                 .WithOne(p => p.ClienteDireccion)
                 .HasForeignKey<ClienteDireccion>(p => p.IdCiudad);
             }
         }
     }