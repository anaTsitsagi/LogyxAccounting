using Microsoft.AspNetCore.Mvc;

public class DirectoriesMenuViewComponent : ViewComponent
{
    public class Item
    {
        public string Text { get; set; } = "";
        public string Action { get; set; } = "";
        public string Controller { get; set; } = "";
        public string Key { get; set; } = "";
    }

    public IViewComponentResult Invoke(string? activeKey = null)
    {
        var items = new[] {
            new Item { Text = "პროდუქტები",           Controller="Products",   Action="Index", Key="products" },
            new Item { Text = "ანგარიშთა გეგმა",           Controller="Accounts",   Action="Index", Key="accounts" },
            new Item { Text = "ძირითადი საშუალებები",  Controller="Contractors",Action="Index", Key="contractors" },
            new Item { Text = "მყიდველები",            Controller="Reports",    Action="Index", Key="reports-buyers" },
            new Item { Text = "მომწოდებლები",         Controller="Contractors",Action="Index", Key="contractors-suppliers" },
            new Item { Text = "თანამშრომლები",         Controller="Reports",    Action="Index", Key="reports-staff" }
        };

        activeKey ??= (RouteData.Values["controller"]?.ToString() ?? "").ToLower();

        ViewData["Items"] = items;
        ViewData["ActiveKey"] = activeKey;
        return View();
    }
}
