﻿using InSight.Domain.Aggregates.Produtos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InSight.Infra.Data.Mappings
{
    public class FornecedorMap : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("Fornecedor");

            builder.HasKey(f => f.Id);

            builder.Property(f => f.Id)
                .HasColumnName("Id");

            builder.Property(f => f.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(f => f.Cnpj)
                .HasColumnName("Cnpj")
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}
