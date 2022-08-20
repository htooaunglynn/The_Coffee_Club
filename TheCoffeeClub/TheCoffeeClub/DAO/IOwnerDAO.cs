using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffeeClub.Model;

namespace TheCoffeeClub.DAO
{
    public interface IOwnerDAO
    {
        OwnerModel GetOwnerListByUserNameAndPassword (string UserName, string Password);

        List<OwnerModel> GetOwnerList ();

        void OwnerRegistration(OwnerModel owner);

        void OwnerUpdate(OwnerModel owner);

        void OwnerDelete(OwnerModel owner);

        void OwnerAdd(OwnerModel owner);
    }
}
