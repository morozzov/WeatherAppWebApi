using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerWebApi.Models
{
    public class WeatherDataStorage
    {
        private static List<WeatherData> dataList = new List<WeatherData>()
        {
            new WeatherData()
            {
                CityName="Брянск",
                Temperature=1
            },
             new WeatherData()
            {
                CityName="Москва",
                Temperature=2
            },
              new WeatherData()
            {
                CityName="Волгоград",
                Temperature=2
            }
        };

        public static List<WeatherData> GetAll()
        {
            try
            {
                return dataList;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public static WeatherData GetByCityName(string cityName)
        {
            try
            {
                return dataList.FirstOrDefault(item => item.CityName == cityName);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void PutCityByName(WeatherData weatherData)
        {
            try
            {
                dataList.Add(weatherData);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void PostEditDataByCityName(WeatherData weatherData)
        {
            try
            {
                dataList.FirstOrDefault(item => item.CityName == weatherData.CityName).Temperature = weatherData.Temperature;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool DeleteDataByCityName(string cityName)
        {
            try
            {
               return dataList.Remove(dataList.FirstOrDefault(item => item.CityName == cityName));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}