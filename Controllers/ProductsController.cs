using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using LogyxAccounting.Data;
using LogyxAccounting.Models;
using LogyxAccounting.Models.Repository;

[Route("[controller]/[action]")]  
public class ProductsController : Controller
{
    private readonly AppDbContext _context;
    public ProductsController(AppDbContext context) => _context = context;

    [HttpGet]
    public object Get(DataSourceLoadOptions loadOptions)
    {
        // IQueryable is best so DevExtreme can translate filter/sort on server
        return DataSourceLoader.Load(_context.Products, loadOptions);
    }

    [HttpPost]
    public IActionResult Post(string values)
    {
        var entity = new ProductsRepository();                     // <-- your entity type
        JsonConvert.PopulateObject(values, entity);     // map incoming JSON to entity

        if (!TryValidateModel(entity))
            return BadRequest(ModelState);

        _context.Products.Add(entity);
        _context.SaveChanges();

        // Must return the created object with its key
        return Json(entity);
    }

    [HttpPut]
    public IActionResult Put(int key, string values)
    {
        var entity = _context.Products.Find(key);
        if (entity == null) return NotFound();

        JsonConvert.PopulateObject(values, entity);

        if (!TryValidateModel(entity))
            return BadRequest(ModelState);

        _context.SaveChanges();
        return Ok();
    }

    [HttpDelete]
    public IActionResult Delete(int key)
    {
        var entity = _context.Products.Find(key);
        if (entity == null) return NotFound();

        _context.Products.Remove(entity);
        _context.SaveChanges();
        return Ok();
    }

    [HttpGet]
    public object TaxationTypes(DataSourceLoadOptions loadOptions)
      => DataSourceLoader.Load(_context.TaxationTypes
              .Select(x => new { id = x.id, name = x.name }), loadOptions);

    [HttpGet]
    public object ProductTypes(DataSourceLoadOptions loadOptions)
        => DataSourceLoader.Load(_context.ProductTypes
                .Select(x => new { id = x.id, name = x.type }), loadOptions);

    [HttpGet]
    public object MeasureUnits(DataSourceLoadOptions loadOptions)
        => DataSourceLoader.Load(_context.MeasureUnits
                .Select(x => new { id = x.id, name = x.measure_name }), loadOptions);

    [HttpGet]
    public object ProductCategories(DataSourceLoadOptions loadOptions)
        => DataSourceLoader.Load(_context.ProductCategories
                .Select(x => new { id = x.id, name = x.type }), loadOptions);


}
