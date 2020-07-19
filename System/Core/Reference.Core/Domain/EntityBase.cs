using System;

namespace Reference.Core.Domain
{
    public abstract class Entity
    {
        public object Id { get; set; }
    }

    public abstract class EntityBase<T> : Entity
    {
        public new T Id { get; set; }
    }
}
