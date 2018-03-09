using System.Collections.Generic;
using DotNetNuke.Web.Api;
using System.Web.Http;
using HTC_CRM_DataAccess.Models;
using HTC_CRM_DataAccess.Connections;

namespace AAModules.HTCAPI.Controllers
{
    public class ProposalController : DnnApiController
    {
        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<Proposal> Get()
        {
            using (var db = DBConnection.GetConnection())
            {
                return Proposal.GetAll<Proposal>(db);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public Proposal Get(int id)
        {
            using (var db = DBConnection.GetConnection())
            {
                return Proposal.GetById<Proposal>(db, id);
            }
        }

        [AllowAnonymous]
        [HttpPut]
        public bool Put([FromBody] Proposal c)
        {
            using (var db = DBConnection.GetConnection())
            {
                return Proposal.Persist<Proposal>(db, c);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public bool Post([FromBody] Proposal c)
        {
            using (var db = DBConnection.GetConnection())
            {
                return Proposal.Persist<Proposal>(db, c);
            }
        }

        [AllowAnonymous]
        [HttpDelete]
        public bool Delete(Proposal c)
        {
            using (var db = DBConnection.GetConnection())
            {
                return Proposal.Delete<Proposal>(db, c);
            }
        }
    }
}