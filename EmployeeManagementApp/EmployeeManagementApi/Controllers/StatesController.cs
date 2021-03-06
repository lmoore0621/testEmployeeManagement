﻿using EmployeeManagement.Database.Models.DataLogic;
using EmployeeManagement.Database.Models.Model;
using EmployeeManagementApi.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace EmployeeManagement.Database.Controllers
{
    [EnableCors("*", "*", "*")]
    public class StatesController : ApiController
    {
        private DataAccessLogic _dah = new DataAccessLogic();

        // GET: api/States
        [Route("api/States/GetAll")]
        public IEnumerable<States> GetAll()
        {
             return _dah.GetAllStates();
        }

        // GET: api/States/5
        [NotFoundFilter]
        public USAState Get(int id)
        {
            return _dah.GetState(id);
        }
    }
}
