using Masuit.Tools.Html;

namespace UltraLock.Server.Model.UserDto
{
    public class UserInput : UserBase
    {
        private string _name;

        public override string Name
        {
            get => _name;
            set => _name = value.HtmlSantinizerStandard();
        }
    }
}
