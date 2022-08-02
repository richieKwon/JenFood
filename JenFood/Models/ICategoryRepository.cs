using System.Collections.Generic;

namespace JenKitchen.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Allcategories { get; }
    }
}