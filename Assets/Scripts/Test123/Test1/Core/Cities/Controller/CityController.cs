using Test123.Test1.Core.Cities.Config;
using Test123.Test1.Core.Cities.Model;
using Test123.Test1.Core.StaticData;
using UnityEditor;

namespace Test123.Test1.Core.Cities.Controller
{
    public class CityController
    {
        public CityController()
        {
            SpawnCities();
        }

        private void SpawnCities()
        {
            City[] cities = new City[CitiesConfig.CITY_COUNT];
            for (int index = 0; index < cities.Length; index++)
            {
                cities[index] = new City()
                {
                    name = CitiesConfig.cityNames[index],
                    id = new GUID(),
                    population = 500,
                };
            }
            StaticDataContainer.cities = cities;
        }
    }
}