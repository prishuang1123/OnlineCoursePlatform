using Microsoft.AspNetCore.Identity;
using Project1.Data;
using System.Security.Claims;

namespace Project1.Utilities
{
    public class Util
    {
        public static int getMemberId(ProjectDbContext _db, UserManager<IdentityUser> _userManager, ClaimsPrincipal User)
        {
            var userId = _userManager.GetUserId(User);
            var member = _db.Member.Where(m => m.AspID == userId).FirstOrDefault();
            var memberId = member.MemberID;
            return memberId;
        }
    }
}

/**
 class User{
    private String name;
    public static String country = "Taiwan";stati

}

User user1 = new User();
User user2 = new User();
User.country;
user2.country; taiwan
user1.country = "xxx";
user2.country; xxx
 */