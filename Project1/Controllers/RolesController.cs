using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Linq;

public class RolesController : Controller
{
    private readonly RoleManager<ApplicationRole> _roleManager;

    public RolesController(RoleManager<ApplicationRole> roleManager)
    {
        _roleManager = roleManager;
    }

    // 顯示所有角色
    public IActionResult Index()
    {
        var roles = _roleManager.Roles.ToList();
        return View(roles);
    }

    // 新增角色的視圖
    public IActionResult Create()
    {
        return View();
    }

    // 處理新增角色的請求
    [HttpPost]
    public async Task<IActionResult> Create(string roleName, string displayName, string description)
    {
        if (!string.IsNullOrEmpty(roleName))
        {
            var role = new ApplicationRole
            {
                Name = roleName,
                //DisplayName = displayName,
                //Description = description
            };
            var result = await _roleManager.CreateAsync(role);

            if (result.Succeeded)
            {
                return RedirectToAction(nameof(Index));
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        return View();
    }

    // 編輯角色的視圖
    public async Task<IActionResult> Edit(string id)
    {
        var role = await _roleManager.FindByIdAsync(id);
        if (role == null)
        {
            return NotFound();
        }

        return View(role);
    }

    // 處理編輯角色的請求
    [HttpPost]
    public async Task<IActionResult> Edit(string id, string roleName)
    {
        var role = await _roleManager.FindByIdAsync(id);
        if (role == null)
        {
            return NotFound();
        }

        role.Name = roleName;
        

        var result = await _roleManager.UpdateAsync(role);

        if (result.Succeeded)
        {
            return RedirectToAction(nameof(Index));
        }

        foreach (var error in result.Errors)
        {
            ModelState.AddModelError(string.Empty, error.Description);
        }

        return View(role);
    }

    // 刪除角色的視圖
    public async Task<IActionResult> Delete(string id)
    {
        var role = await _roleManager.FindByIdAsync(id);
        if (role == null)
        {
            return NotFound();
        }

        return View(role);
    }

    // 處理刪除角色的請求
    [HttpPost, ActionName("Delete")]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        var role = await _roleManager.FindByIdAsync(id);
        if (role == null)
        {
            return NotFound();
        }

        var result = await _roleManager.DeleteAsync(role);

        if (result.Succeeded)
        {
            return RedirectToAction(nameof(Index));
        }

        foreach (var error in result.Errors)
        {
            ModelState.AddModelError(string.Empty, error.Description);
        }

        return View(role);
    }
}
