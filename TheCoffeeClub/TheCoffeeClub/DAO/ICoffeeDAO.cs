using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffeeClub.Model;

namespace TheCoffeeClub.DAO
{
    public interface ICoffeeDAO
    {

        List<CoffeeModel> GetCoffeeList();

        void DeleteCoffee(CoffeeModel coffeeModel);

        void UpdateCoffee(CoffeeModel coffeeModel); 

        void InsertCoffee(CoffeeModel coffeeModel);

        
    }
}
