using GabrielButterfly.Core.Entities;
using GabrielButterfly.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielButterfly.Core.Services
{
    public class AdditionService : IAddition
    {
        public async Task<Result> Addition(int num1, int num2)
        {
            Result result = new Result();

            result.resultAdd = num1 + num2;

            return result;

        }
    }
}
