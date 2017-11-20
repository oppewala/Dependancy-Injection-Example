using System.Collections.Generic;
using System.Threading.Tasks;
using DependancyInjectionExample.Data;
using DependancyInjectionExample.Models;
using Microsoft.EntityFrameworkCore;

namespace DependancyInjectionExample.Managers
{
    public interface IValuesManager
    {
        Task<Value> GetValues();
        void AddValue();
    }

    public class ValuesManager : IValuesManager
    {
        private readonly ValuesContext _valuesContext;
        public ValuesManager(ValuesContext valuesContext)
        {
            _valuesContext = valuesContext;
        }

        public async Task<Value> GetValues()
        {
            return await _valuesContext.Values
                .FirstOrDefaultAsync();
        }

        public void AddValue()
        {
            _valuesContext.Values.Add(new Value
            {
                Description = "Value 1"
            });
            _valuesContext.SaveChanges();
            return;
        }
    }
}