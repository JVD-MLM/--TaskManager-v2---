using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManager.Domain.Entities.Log;

namespace TaskManager.Infrastructure.EntitiesConfigurations.Log;

/// <summary>
///     کانفیگ انتیتی SystemLog
/// </summary>
public class SystemLogConfiguration:IEntityTypeConfiguration<SystemLog>
{
    public void Configure(EntityTypeBuilder<SystemLog> builder)
    {
        builder.Property(x => x.LogLevel).HasMaxLength(10);
        builder.Property(x => x.Source).HasMaxLength(50);
    }
}