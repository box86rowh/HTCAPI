using System.Collections.Generic;
using DotNetNuke.Web.Api;
using System.Web.Http;
using HTC_CRM_DataAccess.Models;
using HTC_CRM_DataAccess.Connections;

namespace AAModules.HTCAPI.Controllers
{
    public class ProposalLineItemController : DnnApiController
    {
        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<ProposalLineItem> Get()
        {
            using (var db = DBConnection.GetConnection())
            {
                return ProposalLineItem.GetAll<ProposalLineItem>(db);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public ProposalLineItem Get(int id)
        {
            using (var db = DBConnection.GetConnection())
            {
                return ProposalLineItem.GetById<ProposalLineItem>(db, id);
            }
        }

        [AllowAnonymous]
        [HttpPut]
        public bool Put([FromBody] ProposalLineItem j)
        {
            using (var db = DBConnection.GetConnection())
            {
                return ProposalLineItem.Persist<ProposalLineItem>(db, j);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public bool Post([FromBody] ProposalLineItem j)
        {
            using (var db = DBConnection.GetConnection())
            {
                return ProposalLineItem.Persist<ProposalLineItem>(db, j);
            }
        }

        [AllowAnonymous]
        [HttpDelete]
        public bool Delete(ProposalLineItem j)
        {
            using (var db = DBConnection.GetConnection())
            {
                return ProposalLineItem.Delete<ProposalLineItem>(db, j);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<ProposalLineItem> GetByParentId(int id)
        {
            using (var db = DBConnection.GetConnection())
            {
                return ProposalLineItem.GetByProposalId(db, id);
            }
        }
    }
}