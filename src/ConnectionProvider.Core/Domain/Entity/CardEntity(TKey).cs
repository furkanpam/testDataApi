﻿using System.Diagnostics.CodeAnalysis;

namespace ConnectionProvider.Core.Domain.Entity
{
    public abstract class CardEntity<TKey> : BaseEntity<TKey> where TKey : struct
    {
        public CardEntity()
        {

        }

        [AllowNull]
        public long? CreateUserId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [AllowNull]
        public long? UpdateUserId { get; set; }

        [AllowNull]
        public DateTime? UpdateDate { get; set; }

        [AllowNull]
        public long? DeleteUserId { get; set; }

        [AllowNull]
        public DateTime? DeleteDate { get; set; }
        public bool? IsDelete { get; set; } = false;


    }
}
