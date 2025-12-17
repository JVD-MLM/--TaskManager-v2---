using TaskManager.Domain.BaseEntities;
using TaskManager.Domain.Entities.Identity;

namespace TaskManager.Domain.Entities.Section;

/// <summary>
///     واحد
/// </summary>
public class Section : BaseEntity<int>
{
    /// <summary>
    ///     عنوان
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    ///     واحد والد
    /// </summary>
    public int? ParentSectionId { get; set; }


    #region Relations

    public Section? Parent { get; set; }
    public ICollection<Section>? Childs { get; set; }
    public ICollection<Post.Post> Posts { get; set; }
    public ICollection<ApplicationUser> Users { get; set; }

    #endregion
}