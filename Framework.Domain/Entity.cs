using System;

namespace Framework.Domain
{
    public abstract class Entity<TKey>
    {
        public TKey Id { get; protected set; }

        //TODO: to be completed...
    }
}
