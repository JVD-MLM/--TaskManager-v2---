using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManager.Domain.Entities.Message;

namespace TaskManager.Infrastructure.EntitiesConfigurations.Message;

/// <summary>
///     کانفیگ انتیتی MessageGroupMember
/// </summary>
public class MessageGroupMemberConfiguration : IEntityTypeConfiguration<MessageGroupMember>
{
    public void Configure(EntityTypeBuilder<MessageGroupMember> builder)
    {
    }
}