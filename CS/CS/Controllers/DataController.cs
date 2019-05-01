using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
        public DataController(IHttpContextAccessor httpContextAccessor, IMemoryCache memoryCache)
        {
            db = new InMemoryEmployeesDataContext(httpContextAccessor, memoryCache);
        }


        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(db.Employees, loadOptions);
        }
        [HttpGet]
        public object GetStates(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(SampleData.States, loadOptions);
        }
        //[HttpPost]
        //public IActionResult Post(FormDataCollection form)
        //{
        //    var values = form.Get("values");

        //    var newEmployee = new Employee();
        //    JsonConvert.PopulateObject(values, newEmployee);

        //    Validate(newEmployee);
        //    if (!ModelState.IsValid)
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, GetFullErrorMessage(ModelState));

        //    db.Employees.Add(newEmployee);
        //    db.SaveChanges();

        //    return Request.CreateResponse(HttpStatusCode.Created);
        //}

        //[HttpPut]
        //public IActionResult Put(FormDataCollection form)
        //{
        //    var key = Convert.ToInt32(form.Get("key"));
        //    var values = form.Get("values");
        //    var employee = db.Employees.First(e => e.ID == key);

        //    JsonConvert.PopulateObject(values, employee);

        //    Validate(employee);
        //    if (!ModelState.IsValid)
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, GetFullErrorMessage(ModelState));

        //    db.SaveChanges();

        //    return Request.CreateResponse(HttpStatusCode.OK);
        //}

        //[HttpDelete]
        //public void DeleteEmployee(int key)
        //{
        //    var key = Convert.ToInt32(form.Get("key"));
        //    var employee = db.Employees.First(e => e.ID == key);

        //    db.Employees.Remove(employee);
        //    db.SaveChanges();
        //}
        //public string GetFullErrorMessage(ModelStateDictionary modelState)
        //{
        //    var messages = new List<string>();

        //    foreach (var entry in modelState)
        //    {
        //        foreach (var error in entry.Value.Errors)
        //            messages.Add(error.ErrorMessage);
        //    }

        //    return String.Join(" ", messages);
        //}
    }
}