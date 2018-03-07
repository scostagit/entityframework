using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using lojaComEntity;

namespace lojaComEntity.Migrations
{
    [DbContext(typeof(EntidadesContext))]
    [Migration("20170521165340_tipoDeUsuario")]
    partial class tipoDeUsuario
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("lojaComEntity.Entities.Categoria", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("lojaComEntity.Entities.Produto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoriaID");

                    b.Property<string>("Nome");

                    b.Property<decimal>("Preco");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("lojaComEntity.Entities.ProdutoVenda", b =>
                {
                    b.Property<int>("VendaID");

                    b.Property<int>("ProdutoID");

                    b.HasKey("VendaID", "ProdutoID");
                });

            modelBuilder.Entity("lojaComEntity.Entities.Usuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.HasKey("ID");

                    b.HasAnnotation("Relational:DiscriminatorProperty", "Discriminator");

                    b.HasAnnotation("Relational:DiscriminatorValue", "Usuario");
                });

            modelBuilder.Entity("lojaComEntity.Entities.Venda", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteID");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("lojaComEntity.Entities.PessoaJuridica", b =>
                {
                    b.HasBaseType("lojaComEntity.Entities.Usuario");

                    b.Property<string>("CNPJ");

                    b.HasAnnotation("Relational:DiscriminatorValue", "PessoaJuridica");
                });

            modelBuilder.Entity("lojaComEntity.Entities.Produto", b =>
                {
                    b.HasOne("lojaComEntity.Entities.Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaID");
                });

            modelBuilder.Entity("lojaComEntity.Entities.ProdutoVenda", b =>
                {
                    b.HasOne("lojaComEntity.Entities.Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoID");

                    b.HasOne("lojaComEntity.Entities.Venda")
                        .WithMany()
                        .HasForeignKey("VendaID");
                });

            modelBuilder.Entity("lojaComEntity.Entities.Venda", b =>
                {
                    b.HasOne("lojaComEntity.Entities.Usuario")
                        .WithMany()
                        .HasForeignKey("ClienteID");
                });
        }
    }
}
