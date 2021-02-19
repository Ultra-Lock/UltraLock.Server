using System.ComponentModel.DataAnnotations;

using UltraLock.Server.Helper;

namespace UltraLock.Server.Model.LockDto
{
    public abstract class LockBase
    {
        /// <summary>
        /// 名称
        /// </summary>
        [Required]
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
