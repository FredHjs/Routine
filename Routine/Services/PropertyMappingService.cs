using System;
using System.Collections.Generic;
using System.Linq;
using Routine.Entities;
using Routine.Models;

namespace Routine.Services
{
    public class PropertyMappingService : IPropertyMappingService
    {
        private readonly Dictionary<string, PropertyMappingValue> _employeePropertyMapping = new Dictionary<string, PropertyMappingValue>(StringComparer.OrdinalIgnoreCase)
        {

            {"Id", new PropertyMappingValue(new List<string>{"Id"}) },
            {"CompanyId", new PropertyMappingValue(new List<string>{"CompanyId"}) },
            {"EmployeeNo", new PropertyMappingValue(new List<string> {"EmployeeNo"}) },
            {"Name", new PropertyMappingValue(new List<string> {"FirstName", "LastName"}) },
            {"GenderDisplay", new PropertyMappingValue(new List<string> {"Gender"}) },
            {"Age", new PropertyMappingValue(new List<string> {"DateOfBirth"}, true) }
        };
        private readonly Dictionary<string, PropertyMappingValue> _companyPropertyMapping = new Dictionary<string, PropertyMappingValue>(StringComparer.OrdinalIgnoreCase)
        {

            {"Id", new PropertyMappingValue(new List<string>{"Id"}) },
            {"Name", new PropertyMappingValue(new List<string>{"Name"}) },
            {"Country", new PropertyMappingValue(new List<string> {"Country"}) },
            {"Industry", new PropertyMappingValue(new List<string> {"Industry"}) },
            {"Product", new PropertyMappingValue(new List<string> {"Product"}) },
            {"Introduction", new PropertyMappingValue(new List<string> {"introduction"}) }
        };

        private readonly IList<IPropertyMapping> _propertyMappings = new List<IPropertyMapping>();

        public PropertyMappingService()
        {
            _propertyMappings.Add(new PropertyMapping<EmployeeDto, Employee>(_employeePropertyMapping));
            _propertyMappings.Add(new PropertyMapping<CompanyDto, Company>(_companyPropertyMapping));
        }

        public Dictionary<string, PropertyMappingValue> GetPropertyMapping<TSource, TDestination>()
        {
            var matchingMapping = _propertyMappings.OfType<PropertyMapping<TSource, TDestination>>();

            var propertyMapping = matchingMapping.ToList();
            if (matchingMapping.Count() == 1)
            {
                return matchingMapping.First().MappingDictionary;
            }
            else
            {
                throw new Exception($"无法找到唯一的映射关系：{typeof(TSource)},{typeof(TDestination)}");
            }

        }

        public bool ValidMappingExistsFor<TSource, TDestination>(string fields)
        {
            var propertyMapping = GetPropertyMapping<TSource, TDestination>();

            if (string.IsNullOrWhiteSpace(fields))
            {
                return true;
            }

            var fieldAfterSplit = fields.Split("，");

            foreach(var field in fieldAfterSplit)
            {
                var trimmedField = field.Trim();
                var indexOfFirstSpace = trimmedField.IndexOf(" ", StringComparison.Ordinal);
                var propertyName = indexOfFirstSpace == -1 ? trimmedField : trimmedField.Remove(indexOfFirstSpace);

                if (!propertyMapping.ContainsKey(propertyName))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
