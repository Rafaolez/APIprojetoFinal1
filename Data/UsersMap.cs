/*using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data
{
    public class UsersMap : IEntityTypeConfiguration<UsersModel>
    {
        public void Configure(EntityTypeBuilder<UsersModel> builder)
        {
            builder.HasKey(x => x.UserId);
            builder.Property(x=> x.UserName).IsRequired().HasMaxLength(255);
            builder.Property(x => x.UserPassword).IsRequired().HasMaxLength(255);
            builder.Property(x => x.UserEmail).IsRequired().HasMaxLength(255);
        }
    }
}
*/