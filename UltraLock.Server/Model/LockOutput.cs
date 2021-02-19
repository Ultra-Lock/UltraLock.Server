using System;

namespace UltraLock.Server.Model
{
    public abstract class LockOutput : LockBase
    {
        /// <summary>
        /// 锁的Guid
        /// </summary>
        public Guid LockGuid { get; set; }

        public override string Name { get; set; }
        public override string Description { get; set; }
    }
}
