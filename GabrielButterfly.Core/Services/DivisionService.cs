using GabrielButterfly.Core.Entities;
using GabrielButterfly.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielButterfly.Core.Services
{
    public class DivisionService : IDivision
    {
        public async Task<Result> Division(int num1, int num2)
        {
            Result result = new Result();

            if (num2 == 0)
            {
                throw new InvalidOperationException("Divisor cannot be 0");
            }
            else
            {
                result.resultDiv = num1 / num2;
            }

            return result;

        }
    }
}
