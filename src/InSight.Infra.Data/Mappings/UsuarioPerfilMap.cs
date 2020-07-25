using InSight.Domain.Aggregates.Usuarios.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InSight.Infra.Data.Mappings
{
    public class UsuarioPerfilMap : IEntityTypeConfiguration<UsuarioPerfil>
    {
        public void Configure(EntityTypeBuilder<UsuarioPerfil> builder)
        {
            builder.ToTable("UsuarioPerfil");

            builder.HasKey(up => new
            {
                up.UsuarioId,
                up.PerfilId
            });

            builder.Property(up => up.UsuarioId)
                .HasColumnName("UsuarioId")
                .IsRequired();

            builder.Property(up => up.PerfilId)
                .HasColumnName("PerfilId")
                .IsRequired();

            builder.HasOne(up => up.Usuario)
                .WithMany(u => u.Perfis)
                .HasForeignKey(up => up.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(up => up.Perfil)
                .WithMany(p => p.Usuarios)
                .HasForeignKey(up => up.PerfilId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
