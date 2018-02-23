using System.Collections.Generic;
using DotNetNuke.Web.Api;
using System.Web.Http;
using HTC_CRM_DataAccess.Models;
using HTC_CRM_DataAccess.Connections;

namespace AAModules.HTCAPI.Controllers
{
    public class SubContractorJobController : DnnApiController
    {
        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<SubContractorJob> Get()
        {
            using (var db = DBConnection.GetConnection())
            {
                return SubContractorJob.GetAll<SubContractorJob>(db);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public SubContractorJob Get(int id)
        {
            using (var db = DBConnection.GetConnection())
            {
                return SubContractorJob.GetById<SubContractorJob>(db, id);
            }
        }

        [AllowAnonymous]
        [HttpPut]
        public bool Put([FromBody] SubContractorJob c)
        {
            using (var db = DBConnection.GetConnection())
            {
                return SubContractorJob.Persist<SubContractorJob>(db, c);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public bool Post([FromBody] SubContractorJob c)
        {
            using (var db = DBConnection.GetConnection())
            {
                return SubContractorJob.Persist<SubContractorJob>(db, c);
            }
        }

        [AllowAnonymous]
        [HttpDelete]
        public bool Delete(SubContractorJob c)
        {
            using (var db = DBConnection.GetConnection())
            {
                return SubContractorJob.Delete<SubContractorJob>(db, c);
            }
        }
    }
}