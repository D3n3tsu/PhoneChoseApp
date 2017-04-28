using PhoneCoseApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneCoseApp.Services
{
    public interface IPhonesData
    {
        IEnumerable<Phone> GetAllPhones();
        object GetPhoneById(int id);
        Phone Add(Phone newPhone);
    }

    public class InMemoryPhonesData : IPhonesData
    {
        private static List<Phone> _phones;

        static InMemoryPhonesData()
        {
            _phones = new List<Phone>()
            {
                new Phone(){ Id=1, Name="Phone1"},
                new Phone(){ Id=2, Name="Phone2"},
                new Phone(){ Id=3, Name="Phone3"}
            };
        }

        public Phone Add(Phone newPhone)
        {
            newPhone.Id = _phones.Max(m => m.Id)+1;
            _phones.Add(newPhone);
            return newPhone;
        }

        public IEnumerable<Phone> GetAllPhones()
        {
            return _phones;
        }

        public object GetPhoneById(int id)
        {
            return _phones.FirstOrDefault(item => item.Id == id);
        }
    }
}
