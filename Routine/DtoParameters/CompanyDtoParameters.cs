using System;


namespace Routine.DtoParameters
{
    public class CompanyDtoParameters
    {

        public string CompanyName { get; set; }
        public string SearchTerm { get; set; }
        public int PageNumber { get; set; } = 1;
        private int _pageSize = 5;
        public string OrderBy { get; set; } = "Name";
        public string Fields { get; set; }

        public int PageSize
        {
            get => _pageSize; 
            set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
        }


        private const int MaxPageSize = 20;
    }
}
