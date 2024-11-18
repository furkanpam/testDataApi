using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ConnectionProvider.Core.Domain.Entity
{

    public class TypeCardEntity<TKey> : CardEntity<TKey> where TKey : struct
    {
        [StringLength(maximumLength: 100)]
        public string Title { get; set; }
        [AllowNull]
        public string Abbreviation { get; set; } = null;
        [AllowNull]
        public string Code { get; set; }
        [AllowNull]
        public string Description { get; set; }

    }
}
