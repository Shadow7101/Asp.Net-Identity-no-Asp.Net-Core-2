using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using App1.Web.Models;
using Microsoft.AspNetCore.Identity;

namespace App1.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            
            builder.Entity<ApplicationRole>().ToTable("Perfis");
            builder.Entity<IdentityUserClaim<Guid>>().ToTable("UsuariosDireitosDeAcesso");
            builder.Entity<IdentityUserRole<Guid>>().ToTable("UsuariosPerfis");
            builder.Entity<IdentityUserLogin<Guid>>().ToTable("UsuariosLogin");
            builder.Entity<IdentityRoleClaim<Guid>>().ToTable("PerfisDireitosDeAcesso");
            builder.Entity<IdentityUserToken<Guid>>().ToTable("UsuariosTokens");

            builder.Entity<ApplicationUser>().ToTable("Usuarios");
            builder.Entity<ApplicationUser>(b =>
            {
                b.Property(u => u.Id).HasColumnName("UsuarioId");
                b.Property(u => u.AccessFailedCount).HasColumnName("ContadorFalhasDeLogin");
                b.Property(u => u.ConcurrencyStamp).HasColumnName("ChaveDeValidacao").HasColumnType("uniqueidentifier");
                b.Property(u => u.Email).HasColumnName("EnderecoDeEmail").HasMaxLength(100);
                b.Property(u => u.LockoutEnabled).HasColumnName("UsuarioBloqueado");
                b.Property(u => u.LockoutEnd).HasColumnName("UsuarioBloqueadoAte");
                b.Property(u => u.NormalizedEmail).HasColumnName("EmailPadronizado").HasMaxLength(100);
                b.Property(u => u.NormalizedUserName).HasColumnName("LoginPadronizado").HasMaxLength(100);
                b.Property(u => u.PasswordHash).HasColumnName("Senha").HasMaxLength(256);
                b.Property(u => u.SecurityStamp).HasColumnName("Salt").HasMaxLength(50);
                b.Property(u => u.PhoneNumber).HasColumnName("Celular").HasMaxLength(30);
                b.Property(u => u.PhoneNumberConfirmed).HasColumnName("CelularConfirmado");
                b.Property(u => u.TwoFactorEnabled).HasColumnName("LoginDeDoisFatores");
                b.Property(u => u.UserName).HasColumnName("Login").HasMaxLength(100);
            });
        }
    }
}
