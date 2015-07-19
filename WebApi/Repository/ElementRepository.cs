using System.Collections.Generic;
using System.Linq;
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

        public void Create()
        {
        }

        public ElementModel GetElement(int elementId)
        {
            return _elements.Where(e => elementId == e.AtomicNumber).FirstOrDefault();
        }

        public List<ElementModel> GetAllElements()
        {
            return _elements;
        }
    }
}