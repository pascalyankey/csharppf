using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLYNET
{
    public interface IKost
    {
        decimal BasisKostprijsPerDag { get; set; }
        decimal BerekenTotaleKostprijsPerDag();
    }
}
