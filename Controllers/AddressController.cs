using System.Collections.Generic;
using DotNetNuke.Web.Api;
using System.Web.Http;
using HTC_CRM_DataAccess.Models;
using HTC_CRM_DataAccess.Connections;

namespace AAModules.HTCAPI.HTCAPI.Controllers
{
    public class AddressController : DnnApiController
    {
        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<Address> Get()
        {
            using (var db = DBConnection.GetConnection())
            {
                return Address.GetAll<Address>(db);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public Address Get(int id)
        {
            using (var db = DBConnection.GetConnection())
            {
                return Address.GetById<Address>(db, id);
            }
        }

        [AllowAnonymous]
        [HttpPut]
        public bool Put([FromBody] Address c)
        {
            using (var db = DBConnection.GetConnection())
            {
                return Address.Persist<Address>(db, c);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public bool Post([FromBody] Address c)
        {
            using (var db = DBConnection.GetConnection())
            {
                return Address.Persist<Address>(db, c);
            }
        }

        [AllowAnonymous]
        [HttpDelete]
        public bool Delete(Address c)
        {
            using (var db = DBConnection.GetConnection())
            {
                return Address.Delete<Address>(db, c);
            }
        }
    }
}