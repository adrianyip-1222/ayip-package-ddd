using System;

namespace AYip.DDD
{
    public interface IAggregateRoot
    {
        Guid Id { get; }
    }
}