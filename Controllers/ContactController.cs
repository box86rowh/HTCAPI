using System.Collections.Generic;
using DotNetNuke.Web.Api;
using System.Web.Http;
using HTC_CRM_DataAccess.Models;
using HTC_CRM_DataAccess.Connections;

namespace AAModules.HTCAPI.Controllers
{
    public class ContactController : DnnApiController
    {
        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<Contact> Get()
        {
            using (var db = DBConnection.GetConnection())
            {
                return Contact.GetAll<Contact>(db);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public Contact Get(int id)
        {
            using (var db = DBConnection.GetConnection())
            {
                return Contact.GetById<Contact>(db, id);
            }
        }

        [AllowAnonymous]
        [HttpPut]
        public bool Put([FromBody] Contact c)
        {
            using (var db = DBConnection.GetConnection())
            {
                return Contact.Persist<Contact>(db, c);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public bool Post([FromBody] Contact c)
        {
            using (var db = DBConnection.GetConnection())
            {
                return Contact.Persist<Contact>(db, c);
            }
        }

        [AllowAnonymous]
        [HttpDelete]
        public bool Delete(Contact c)
        {
            using (var db = DBConnection.GetConnection())
            {
                return Contact.Delete<Contact>(db, c);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<Contact> GetByParentId(int id)
        {
            using(var db = DBConnection.GetConnection())
            {
                return Contact.GetByCustomerId(db, id);
            }
        }
    }
}