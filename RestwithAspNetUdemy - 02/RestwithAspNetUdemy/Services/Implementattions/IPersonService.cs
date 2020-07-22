using RestwithAspNetUdemy.Model;
using System.Collections.Generic;

namespace RestwithAspNetUdemy.Services.Implementattions
{
    interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long Id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long Id);
    }
}
