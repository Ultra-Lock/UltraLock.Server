using Masuit.Tools.Html;

namespace UltraLock.Server.Model
{
    public abstract class LockInput : LockBase
    {
        // 对字段进行安全检查

        private string _name;
        private string _description;

        public override string Name
        {
            get => _name;
            set => _name = value.HtmlSantinizerStandard();
        }

        public override string Description
        {
            get => _description;
            set => _description = value.HtmlSantinizerStandard();
        }
    }
}
