using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using LogyxAccounting.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using LogyxAccounting.Models.Repository;

[Route("[controller]/[action]")]          // /Accounts/Get, /Accounts/Post, ...
public class AccountsController : Controller
{
    private readonly AppDbContext _db;

    public AccountsController(AppDbContext db) => _db = db;

    [HttpGet]
    public object Get(DataSourceLoadOptions o)
        => DataSourceLoader.Load(_db.Accounts, o); // IQueryable with Code, Name, ParentCode

    [HttpPost]
    public IActionResult Post(string values)
    {
        var item = new AccountsRepository();                   // your EF entity
        JsonConvert.PopulateObject(values, item);
        if (!TryValidateModel(item)) return BadRequest(ModelState);
        _db.Accounts.Add(item);
        _db.SaveChanges();
        return Json(item);                          // must return created object with key
    }

    [HttpPut]
    public IActionResult Put(int key, string values) // key type should match Code’s type
    {
        var item = _db.Accounts.Find(key);
        if (item == null) return NotFound();
        JsonConvert.PopulateObject(values, item);
        if (!TryValidateModel(item)) return BadRequest(ModelState);
        _db.SaveChanges();
        return Ok();
    }

    [HttpDelete]
    public IActionResult Delete(int key)
    {
        var item = _db.Accounts.Find(key);
        if (item == null) return NotFound();
        _db.Accounts.Remove(item);
        _db.SaveChanges();
        return Ok();
    }
}
