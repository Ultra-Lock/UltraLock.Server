using System;
using UltraLock.Server.Helper;

namespace UltraLock.Server.Entity
{
    public class Lock
    {
        public User User { get; set; }
        public Guid LockGuid { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
