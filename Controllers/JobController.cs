using System.Collections.Generic;
using DotNetNuke.Web.Api;
using System.Web.Http;
using HTC_CRM_DataAccess.Models;
using HTC_CRM_DataAccess.Connections;

namespace AAModules.HTCAPI.Controllers
{
    public class JobController : DnnApiController
    {
        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<Job> Get()
        {
            using (var db = DBConnection.GetConnection())
            {
                return Job.GetAll<Job>(db);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public Job Get(int id)
        {
            using (var db = DBConnection.GetConnection())
            {
                return Job.GetById<Job>(db, id);
            }
        }

        [AllowAnonymous]
        [HttpPut]
        public bool Put([FromBody] Job j)
        {
            using (var db = DBConnection.GetConnection())
            {
                return Job.Persist<Job>(db, j);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public bool Post([FromBody] Job j)
        {
            using (var db = DBConnection.GetConnection())
            {
                return Job.Persist<Job>(db, j);
            }
        }

        [AllowAnonymous]
        [HttpDelete]
        public bool Delete(Job j)
        {
            using (var db = DBConnection.GetConnection())
            {
                return Job.Delete<Job>(db, j);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<Job> GetByCustomerId(int id)
        {
            using(var db = DBConnection.GetConnection())
            {
                return Job.GetByCustomerId(db, id);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<Job> GetBySubContractorId(int id)
        {
            using (var db = DBConnection.GetConnection())
            {
                return Job.GetBySubContractorId(db, id);
            }
        }
    }
}