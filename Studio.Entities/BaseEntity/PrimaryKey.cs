using System;

namespace Studio.Entities.BaseEntity
{
    public class PrimaryKey : IPrimaryKey
    {
        protected PrimaryKey()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}