using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotNetNuke.Web.Api;
using System.Web.Http;
using HTC_CRM_DataAccess.Models;
using HTC_CRM_DataAccess.Connections;

namespace AAModules.HTCAPI.Controllers
{
    public class CustomerController : DnnApiController
    {
        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            using(var db = DBConnection.GetConnection())
            {
                return Customer.GetAll<Customer>(db);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public Customer Get(int id)
        {
            using(var db = DBConnection.GetConnection())
            {
                return Customer.GetById<Customer>(db, id);
            }
        }

        [AllowAnonymous]
        [HttpPut]
        public bool Put([FromBody] Customer c)
        {
            using(var db = DBConnection.GetConnection())
            {
                return Customer.Persist<Customer>(db, c);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public bool Post([FromBody] Customer c)
        {
            using (var db = DBConnection.GetConnection())
            {
                return Customer.Persist<Customer>(db, c);
            }
        }

        [AllowAnonymous]
        [HttpDelete]
        public bool Delete(Customer c)
        {
            using(var db = DBConnection.GetConnection())
            {
                return Customer.Delete<Customer>(db, c);
            }
        }
    }
}