using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Dados.data.Model;

public partial class DBLPJMNContext : DbContext
{
    public DBLPJMNContext()
    {
    }

    public DBLPJMNContext(DbContextOptions<DBLPJMNContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categoria> Categoria { get; set; }

    public virtual DbSet<Estoque> Estoques { get; set; }

    public virtual DbSet<Fornecedor> Fornecedors { get; set; }

    public virtual DbSet<Marca> Marcas { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Produto> Produtos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Venda> Venda { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { 
        if(!optionsBuilder.IsConfigured) 
            optionsBuilder.UseSqlServer("Server=DESKTOP-OGM7EIT \\sqlexpress;Database=LPJMN;Trusted_Connection=True; TrustServerCertificate=True");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Categori__3213E83FC8971AAF");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Estoque>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Estoque__3213E83F17F02712");

            entity.ToTable("Dados");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<Fornecedor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Forneced__3213E83FF0AC7EC7");

            entity.ToTable("Fornecedor");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CNPJ");
            entity.Property(e => e.Contato)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Endereco)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Marca>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Marca__3213E83F49656085");

            entity.ToTable("Marca");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pedido__3213E83F36B6B73B");

            entity.ToTable("Pedido");

            entity.HasIndex(e => e.FornecedorId, "Pedido_FKIndex1");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FornecedorId).HasColumnName("Fornecedor_id");
            entity.Property(e => e.Status2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Status_2");

            entity.HasOne(d => d.Fornecedor).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.FornecedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Pedido__Forneced__4222D4EF");

            entity.HasMany(d => d.Produtos).WithMany(p => p.Pedidos)
                .UsingEntity<Dictionary<string, object>>(
                    "PedidoHasProduto",
                    r => r.HasOne<Produto>().WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Pedido_ha__Produ__5165187F"),
                    l => l.HasOne<Pedido>().WithMany()
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Pedido_ha__Pedid__5070F446"),
                    j =>
                    {
                        j.HasKey("PedidoId", "ProdutoId").HasName("PK__Pedido_h__514F804194ABD8B0");
                        j.ToTable("Pedido_has_Produto");
                        j.HasIndex(new[] { "PedidoId" }, "Pedido_has_Produto_FKIndex1");
                        j.HasIndex(new[] { "ProdutoId" }, "Pedido_has_Produto_FKIndex2");
                        j.IndexerProperty<int>("PedidoId").HasColumnName("Pedido_id");
                        j.IndexerProperty<int>("ProdutoId").HasColumnName("Produto_id");
                    });
        });

        modelBuilder.Entity<Produto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Produto__3213E83FBB2FB305");

            entity.ToTable("Produto");

            entity.HasIndex(e => e.CategoriaId, "Produto_FKIndex1");

            entity.HasIndex(e => e.MarcaId, "Produto_FKIndex3");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoriaId).HasColumnName("Categoria_id");
            entity.Property(e => e.MarcaId).HasColumnName("Marca_id");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Categoria).WithMany(p => p.Produtos)
                .HasForeignKey(d => d.CategoriaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Produto__Categor__48CFD27E");

            entity.HasOne(d => d.Marca).WithMany(p => p.Produtos)
                .HasForeignKey(d => d.MarcaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Produto__Marca_i__49C3F6B7");

            entity.HasMany(d => d.Estoques).WithMany(p => p.Produtos)
                .UsingEntity<Dictionary<string, object>>(
                    "ProdutoHasEstoque",
                    r => r.HasOne<Estoque>().WithMany()
                        .HasForeignKey("EstoqueId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Produto_h__Estoq__4D94879B"),
                    l => l.HasOne<Produto>().WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Produto_h__Produ__4CA06362"),
                    j =>
                    {
                        j.HasKey("ProdutoId", "EstoqueId").HasName("PK__Produto___50F6ABC1E104C479");
                        j.ToTable("Produto_has_Estoque");
                        j.HasIndex(new[] { "ProdutoId" }, "Produto_has_Estoque_FKIndex1");
                        j.HasIndex(new[] { "EstoqueId" }, "Produto_has_Estoque_FKIndex2");
                        j.IndexerProperty<int>("ProdutoId").HasColumnName("Produto_id");
                        j.IndexerProperty<int>("EstoqueId").HasColumnName("Estoque_id");
                    });
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario__3213E83F2FA7B169");

            entity.ToTable("Usuario");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PermissaoAdm).HasColumnName("PermissaoADM");
            entity.Property(e => e.Senha)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Venda>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Venda__3213E83F79A752F3");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.HasMany(d => d.Estoques).WithMany(p => p.Venda)
                .UsingEntity<Dictionary<string, object>>(
                    "VendaHasEstoque",
                    r => r.HasOne<Estoque>().WithMany()
                        .HasForeignKey("EstoqueId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Venda_has__Estoq__45F365D3"),
                    l => l.HasOne<Venda>().WithMany()
                        .HasForeignKey("VendaId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Venda_has__Venda__44FF419A"),
                    j =>
                    {
                        j.HasKey("VendaId", "EstoqueId").HasName("PK__Venda_ha__A9E3EF3F3BF99314");
                        j.ToTable("Venda_has_Estoque");
                        j.HasIndex(new[] { "VendaId" }, "Venda_has_Estoque_FKIndex1");
                        j.HasIndex(new[] { "EstoqueId" }, "Venda_has_Estoque_FKIndex2");
                        j.IndexerProperty<int>("VendaId").HasColumnName("Venda_id");
                        j.IndexerProperty<int>("EstoqueId").HasColumnName("Estoque_id");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
