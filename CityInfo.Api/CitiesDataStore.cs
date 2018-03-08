using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            // init dummy data
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id=1,
                    Name="New York",
                    Description = "Big City in USA",
                    PointOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Statue of Liberty",
                            Description = "A big French statue"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Central Park",
                            Description = "A Park"
                        }
                    }
                },
                new CityDto()
                {
                    Id=2,
                    Name="London",
                    Description = "Big City in UK",
                    PointOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Big Ben",
                            Description = "A bell"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Houses of Parliament",
                            Description = "A place where shits hang out"
                        }
                    }
                },
                new CityDto()
                {
                    Id=3,
                    Name="Edinburgh",
                    Description = "City in UK",
                    PointOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "Princess Street Garden",
                            Description = "A park"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 6,
                            Name = "Another place",
                            Description = "I cant be bothered"
                        }
                    }
                }
            };


        }
    }
}

