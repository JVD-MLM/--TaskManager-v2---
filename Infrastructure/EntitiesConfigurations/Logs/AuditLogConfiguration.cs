using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManager.Domain.Entities.Log;

namespace TaskManager.Infrastructure.EntitiesConfigurations.Log;

/// <summary>
///     کانفیگ انتیتی AuditLog
/// </summary>
public class AuditLogConfiguration:IEntityTypeConfiguration<AuditLog>
{
    public void Configure(EntityTypeBuilder<AuditLog> builder)
    {
        builder.Property(x => x.EntityName).HasMaxLength(100);
        builder.Property(x => x.ActionType).HasMaxLength(100);
        builder.HasOne(x => x.User).WithMany(x => x.AuditLogs).HasForeignKey(x => x.PerformedBy)
            .OnDelete(DeleteBehavior.NoAction);
    }
}