using System.Collections.Generic;
using DotNetNuke.Web.Api;
using System.Web.Http;
using HTC_CRM_DataAccess.Models;
using HTC_CRM_DataAccess.Connections;
namespace AAModules.HTCAPI.HTCAPI.Controllers
{
    public class JobNoteController : DnnApiController
    {
        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<JobNote> Get()
        {
            using (var db = DBConnection.GetConnection())
            {
                return JobNote.GetAll<JobNote>(db);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public JobNote Get(int id)
        {
            using (var db = DBConnection.GetConnection())
            {
                return JobNote.GetById<JobNote>(db, id);
            }
        }

        [AllowAnonymous]
        [HttpPut]
        public bool Put([FromBody] JobNote j)
        {
            using (var db = DBConnection.GetConnection())
            {
                return JobNote.Persist<JobNote>(db, j);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public bool Post([FromBody] JobNote j)
        {
            using (var db = DBConnection.GetConnection())
            {
                return JobNote.Persist<JobNote>(db, j);
            }
        }

        [AllowAnonymous]
        [HttpDelete]
        public bool Delete(JobNote j)
        {
            using (var db = DBConnection.GetConnection())
            {
                return JobNote.Delete<JobNote>(db, j);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<JobNote> GetByParentId(int id)
        {
            using (var db = DBConnection.GetConnection())
            {
                return JobNote.GetByJobId(db, id);
            }
        }
    }
}