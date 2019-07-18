using System.Linq;
using CS.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;

namespace CS.Controllers {
    [Route("api/[controller]/[action]")]
    public class DataController : Controller {
        InMemoryEmployeesDataContext db;
        public DataController(IHttpContextAccessor httpContextAccessor, IMemoryCache memoryCache) {
            db = new InMemoryEmployeesDataContext(httpContextAccessor, memoryCache);
        }

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions) {
            return DataSourceLoader.Load(db.Employees, loadOptions);
        }
        [HttpGet]
        public object GetStates(DataSourceLoadOptions loadOptions) {
            return DataSourceLoader.Load(SampleData.States, loadOptions);
        }
        [HttpPost]
        public IActionResult AddEmployee(string values) {
            var newEmployee = new Employee();
            JsonConvert.PopulateObject(values, newEmployee);

            if(!TryValidateModel(newEmployee))
                return BadRequest(ModelState.GetFullErrorMessage());

            db.Employees.Add(newEmployee);
            db.SaveChanges();

            return Ok(newEmployee);
        }

        [HttpPut]
        public IActionResult UpdateEmployee(int key, string values) {
            var employee = db.Employees.First(o => o.ID == key);
            JsonConvert.PopulateObject(values, employee);

            if(!TryValidateModel(employee))
                return BadRequest(ModelState.GetFullErrorMessage());

            db.SaveChanges();
            return Ok(employee);
        }

        [HttpDelete]
        public void DeleteEmployee(int key) {
            var employee = db.Employees.First(e => e.ID == key);
            db.Employees.Remove(employee);
            db.SaveChanges();
        }
    }
}