using GabrielButterfly.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielButterfly.Core.Interfaces
{
    public interface ISubtraction
    {
        Task<Result> Subtraction(int num1, int num2);
    }
}
