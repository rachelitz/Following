using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FollowingBl.Dto
{
    public class JourneyDto
    {
        public int JourneyCode { get; set; }

        public string? JourneyName { get; set; }

        public int? CountryCode { get; set; }

        public int? TypeGroupCode { get; set; }

        public DateOnly? BeginningDate { get; set; }

        public DateOnly? EndDate { get; set; }

        public int? BuisnessCustomersCode { get; set; }

        public int? StatusCode { get; set; }

        public int? BeginningFlighCode { get; set; }

        public int? EndFlighCode { get; set; }
    }
}
