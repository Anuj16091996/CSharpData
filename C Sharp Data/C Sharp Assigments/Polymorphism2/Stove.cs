using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism2
{
    class Stove : KitchenAppliance
    {

        public override string PowerOn()
        {
            return ("User is using Stove");
        }


    }
}
