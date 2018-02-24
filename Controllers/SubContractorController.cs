using System.Collections.Generic;
using DotNetNuke.Web.Api;
using System.Web.Http;
using HTC_CRM_DataAccess.Models;
using HTC_CRM_DataAccess.Connections;

namespace AAModules.HTCAPI.Controllers
{
    public class SubContractorController : DnnApiController
    {
        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<SubContractor> Get()
        {
            using (var db = DBConnection.GetConnection())
            {
                return SubContractor.GetAll<SubContractor>(db);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public SubContractor Get(int id)
        {
            using (var db = DBConnection.GetConnection())
            {
                return SubContractor.GetById<SubContractor>(db, id);
            }
        }

        [AllowAnonymous]
        [HttpPut]
        public bool Put([FromBody] SubContractor c)
        {
            using (var db = DBConnection.GetConnection())
            {
                return SubContractor.Persist<SubContractor>(db, c);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public bool Post([FromBody] SubContractor c)
        {
            using (var db = DBConnection.GetConnection())
            {
                return SubContractor.Persist<SubContractor>(db, c);
            }
        }

        [AllowAnonymous]
        [HttpDelete]
        public bool Delete(SubContractor c)
        {
            using (var db = DBConnection.GetConnection())
            {
                return SubContractor.Delete<SubContractor>(db, c);
            }
        }
    }
}