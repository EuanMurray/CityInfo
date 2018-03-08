using CityInfo.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public static class CityInfoContextExtensions
    {
        public static void EnsureSeedDataForContext(this CityInfoContext context)
        {
            if (context.Cities.Any())
            {
                return;
            }

            // init dummy data
            var cities = new List<City>()
            {
                new City()
                {
                    Name="New York",
                    Description = "Big City in USA",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Statue of Liberty",
                            Description = "A big French statue"
                        },
                        new PointOfInterest()
                        {
                            Name = "Central Park",
                            Description = "A Park"
                        }
                    }
                },
                new City()
                {
                    Name="London",
                    Description = "Big City in UK",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Big Ben",
                            Description = "A bell"
                        },
                        new PointOfInterest()
                        {
                            Name = "Houses of Parliament",
                            Description = "A place where shits hang out"
                        }
                    }
                },
                new City()
                {
                    Name="Edinburgh",
                    Description = "City in UK",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Princess Street Garden",
                            Description = "A park"
                        },
                        new PointOfInterest()
                        {
                            Name = "Another place",
                            Description = "I cant be bothered"
                        }
                    }
                }
            };

            context.Cities.AddRange(cities);
            context.SaveChanges();

        }
    }
}
