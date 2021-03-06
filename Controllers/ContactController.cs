﻿using System.Collections.Generic;
using DotNetNuke.Web.Api;
using System.Web.Http;
using HTC_CRM_DataAccess.Models;
using HTC_CRM_DataAccess.Connections;

namespace AAModules.HTCAPI.Controllers
{
    public class CustomerContactController : DnnApiController
    {
        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<CustomerContact> Get()
        {
            using (var db = DBConnection.GetConnection())
            {
                return CustomerContact.GetAll<CustomerContact>(db);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public CustomerContact Get(int id)
        {
            using (var db = DBConnection.GetConnection())
            {
                return CustomerContact.GetById<CustomerContact>(db, id);
            }
        }

        [AllowAnonymous]
        [HttpPut]
        public bool Put([FromBody] CustomerContact c)
        {
            using (var db = DBConnection.GetConnection())
            {
                return CustomerContact.Persist<CustomerContact>(db, c);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public bool Post([FromBody] CustomerContact c)
        {
            using (var db = DBConnection.GetConnection())
            {
                return CustomerContact.Persist<CustomerContact>(db, c);
            }
        }

        [AllowAnonymous]
        [HttpDelete]
        public bool Delete(CustomerContact c)
        {
            using (var db = DBConnection.GetConnection())
            {
                return CustomerContact.Delete<CustomerContact>(db, c);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<CustomerContact> GetByParentId(int id)
        {
            using(var db = DBConnection.GetConnection())
            {
                return CustomerContact.GetByCustomerId(db, id);
            }
        }
    }
}