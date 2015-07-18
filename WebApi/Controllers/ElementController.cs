using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;
using WebApi.Repository;

namespace WebApi.Controllers
{
    public class ElementController : ApiController
    {
        private ElementRepository _elementRepository;

        public ElementController()
        {
            _elementRepository = new ElementRepository();
        }

        public ElementModel Get()
        {
            return null;
        }

        public ElementModel Get(int AtomicId)
        {
            return null;
        }
    }
}
