using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food
{
    public interface IBalance
    {
        double WalletBalance{get;set;}

        void WalletRecharge();
    }
}