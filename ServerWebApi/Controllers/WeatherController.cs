using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServerWebApi.Models;

namespace ServerWebApi.Controllers
{
    public class WeatherController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage GetAll()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, WeatherDataStorage.GetAll());
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        public HttpResponseMessage GetByCityName([FromBody] string cityName)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, WeatherDataStorage.GetByCityName(cityName));
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        //[HttpPost]
        //public void PutCityByName([FromBody] WeatherData weatherData)
        //{
        //    WeatherDataStorage.PutCityByName(weatherData);
        //}
        [HttpPost]
        public HttpResponseMessage PutCityByName([FromBody] WeatherData weatherData)
        {
            try
            {
                WeatherDataStorage.PutCityByName(weatherData);

                return Request.CreateResponse(HttpStatusCode.OK);

            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        public HttpResponseMessage PostEditDataByCityName([FromBody] WeatherData weatherData)
        {
            try
            {
                WeatherDataStorage.PostEditDataByCityName(weatherData);

                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        public HttpResponseMessage DeleteDataByCityName([FromBody] string cityName)
        {
            try
            {
                // WeatherDataStorage.DeleteDataByCityName(cityName);
                bool isDeleted = WeatherDataStorage.DeleteDataByCityName(cityName);

                return Request.CreateResponse(HttpStatusCode.OK, isDeleted);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        public HttpResponseMessage GetException([FromBody] bool isExp)
        {
            if (isExp == true)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "sample of error");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK,
                    new WeatherData()
                    {
                        CityName = "gg",
                        Temperature = 228
                    });
            }
        }
    }
}
