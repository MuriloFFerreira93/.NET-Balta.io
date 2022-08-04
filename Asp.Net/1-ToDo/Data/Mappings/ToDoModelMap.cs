using _1_ToDo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1_ToDo.Data.Mappings
{
    public class ToDoModelMap : IEntityTypeConfiguration<ToDoModel>
    {
        public void Configure(EntityTypeBuilder<ToDoModel> builder)
        {
            // Tabela
            builder.ToTable("ToDos");

            // Chave Primária
            builder.HasKey(x => x.Id);

            // Identity
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            // Propriedades
            builder.Property(x => x.Title)
                .IsRequired()
                .HasColumnName("Title")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);

            builder.Property(x => x.Done)
                .IsRequired()
                .HasColumnName("Done")
                .HasColumnType("BIT");

            builder.Property(x => x.CreatedAt)
                .IsRequired()
                .HasColumnName("CreatedAt")
                .HasColumnType("DATETIME");

            // Índices
            //builder
            //    .HasIndex(x => x., "IX_X_X")
            //    .IsUnique();

            // Relacionamentos

        }
    }
}
