using GabrielButterfly.Core.Entities;
using GabrielButterfly.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielButterfly.Core.Services
{
    public class SubtractionService : ISubtraction
    {
        public async Task<Result> Subtraction(int num1, int num2)
        {
            Result result = new Result();

            if (num1 < num2)
            {
                throw new InvalidOperationException("Minuend must be greater than Subtrahend");
            }
            else
            {
                result.resutl = num1 - num2;
            }

            return result;

        }
    }
}
