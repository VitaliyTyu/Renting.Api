using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Renting.DAL.Entities;

namespace Renting.DAL.Configurations
{
    public class RentConfiguration : IEntityTypeConfiguration<Rent>
    {
        public void Configure(EntityTypeBuilder<Rent> builder)
        {
            //builder.HasKey(anime => anime.Id);

            //builder.HasIndex(anime => anime.Id).IsUnique();

            //builder.Property(anime => anime.Name).HasMaxLength(200).IsRequired();

            //builder
            //    .HasOne(anime => anime.Image)
            //    .WithOne(image => image.AnimeTitle)
            //    .HasForeignKey<Image>(image => image.AnimeId);

            //builder
            //    .HasMany(anime => anime.Genres)
            //    .WithOne(anime => anime.AnimeTitle)
            //    .HasForeignKey(genre => genre.AnimeId);

            //builder
            //    .HasMany(anime => anime.AnimeCollections)
            //    .WithMany(collection => collection.AnimeTitles);

            builder.HasKey(x => x.Id);

            builder
                .HasOne(x => x.Customer)
                .WithOne(customer => customer.Rent)
                .HasForeignKey<Customer>(customer => customer.RentId);
        }
    }
}
