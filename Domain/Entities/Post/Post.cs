using TaskManager.Domain.BaseEntities;

namespace TaskManager.Domain.Entities.Post;

/// <summary>
///     پست
/// </summary>
public class Post : BaseEntity<int>
{
    /// <summary>
    ///     عنوان
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    ///     واحد
    /// </summary>
    public int SectionId { get; set; }

    /// <summary>
    ///     پست والد
    /// </summary>
    public int ParentPostId { get; set; }
}