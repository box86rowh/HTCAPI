using System.Collections.Generic;
using DotNetNuke.Web.Api;
using System.Web.Http;
using HTC_CRM_DataAccess.Models;
using HTC_CRM_DataAccess.Connections;

namespace AAModules.HTCAPI.Controllers
{
    public class CustomerUserUserController : DnnApiController
    {
        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<CustomerUser> Get()
        {
            using (var db = DBConnection.GetConnection())
            {
                return CustomerUser.GetAll<CustomerUser>(db);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public CustomerUser Get(int id)
        {
            using (var db = DBConnection.GetConnection())
            {
                return CustomerUser.GetById<CustomerUser>(db, id);
            }
        }

        [AllowAnonymous]
        [HttpPut]
        public bool Put([FromBody] CustomerUser c)
        {
            using (var db = DBConnection.GetConnection())
            {
                return CustomerUser.Persist<CustomerUser>(db, c);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public bool Post([FromBody] CustomerUser c)
        {
            using (var db = DBConnection.GetConnection())
            {
                return CustomerUser.Persist<CustomerUser>(db, c);
            }
        }

        [AllowAnonymous]
        [HttpDelete]
        public bool Delete(CustomerUser c)
        {
            using (var db = DBConnection.GetConnection())
            {
                return CustomerUser.Delete<CustomerUser>(db, c);
            }
        }
    }
}