
using UltraLock.Server.Helper;

namespace UltraLock.Server.Model
{
    public abstract class LockBase
    {
        /// <summary>
        /// 名称
        /// </summary>
        public abstract string Name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public abstract string Description { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public LockStatus Status { get; set; }
    }
}
