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

        public ElementModel Get(int AtomicId = 1)
        {
            return _elementRepository.GetElement(AtomicId);
        }
    }
}
