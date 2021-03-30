using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.StructuralPatterns.Adapter.II
{
    class DbPeopleServiceAdapter : IPeopleService
    {
        private DbPeopleService _service;

        public DbPeopleServiceAdapter(DbPeopleService service)
        {
            _service = service;
        }

        public IEnumerable<IPerson> Get()
        {
            var dbPeople = _service.Get();
            return dbPeople.Select(x => new DbPersonAdapter(x));
        }
    }
}
