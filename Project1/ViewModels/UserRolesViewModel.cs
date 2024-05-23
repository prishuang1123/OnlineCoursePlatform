namespace Project1.ViewModels
{
    //顯示所有用戶及其角色
    public class UserRolesViewModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public IList<string> Roles { get; set; }
    }
}