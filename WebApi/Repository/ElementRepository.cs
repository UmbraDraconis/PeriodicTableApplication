using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Models;

namespace WebApi.Repository
{
    public class ElementRepository
    {
        private List<ElementModel> _elements;

        public ElementRepository()
        {
            _elements = new List<ElementModel>();
        }

        public List<ElementModel> Create()
        {
            return null;
        }
    }
}