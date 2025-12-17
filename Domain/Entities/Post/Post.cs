using TaskManager.Domain.BaseEntities;
using TaskManager.Domain.Entities.Identity;

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




    #region Relations

    public Section.Section Section { get; set; }
    public Post Paretnt { get; set; }
    public ICollection<Post> Childs { get; set; }
    public ICollection<ApplicationUser> Users { get; set; }

    #endregion
}