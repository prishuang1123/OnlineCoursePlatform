using Microsoft.AspNetCore.Identity;
namespace Project1
{
    //修改註冊畫面
    //客製化錯誤訊息
    //繼承IdentityErrorDescriber類別覆寫預設錯誤訊息
    public class CustomIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError
            {
                Code = nameof(DuplicateEmail),
                Description = $"電子郵件地址'{email}'已經被使用。"
            };
        }

        public override IdentityError DuplicateUserName(string userName)
        {
            return new IdentityError
            {
                Code = nameof(DuplicateUserName),
                Description = $"使用者名稱'{userName}'已經被使用。"
            };
        }

    }
}
