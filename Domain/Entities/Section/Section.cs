using TaskManager.Domain.BaseEntities;

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
    public int ParentSectionId { get; set; }
}