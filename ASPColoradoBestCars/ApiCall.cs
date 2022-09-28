using ASPColoradoBestCars.Models;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;

namespace ASPColoradoBestCars
{
    public static class ApiCall
    {
        public static CarProperty CallAPI(string make)
        {
            switch (make.ToLower())
            {
                case "toyota":
                    return CallToyota();
                    break;
                case "chevrolet":
                case "chevy":
                    return CallChevy();
                    break;
                case "ford":
                    return CallFord();
                    break;
                case "subaru":
                    return CallSubi();
                    break;
                default:
                    return CallChevy();
                    break;

            }
            
        }


        public static CarProperty CallChevy()
        {
            var client = new RestClient("https://car-data.p.rapidapi.com/cars?limit=1&page=0&year=2019&model=Colorado");
            var request = new RestRequest(Method.GET);
            request.AddHeader("X-RapidAPI-Key", "187b193293msh63b6a7cab422aabp1f6b15jsnc9fe38c4453b");
            request.AddHeader("X-RapidAPI-Host", "car-data.p.rapidapi.com");
            IRestResponse response = client.Execute(request);
            dynamic api = JArray.Parse(response.Content);
            var make = api[0]["make"];
            var model = api[0]["model"];
            var type = api[0]["type"];
            var year = api[0]["year"];
            var pic = ("~/Images/chevycolorado.jpg");
            //Console.WriteLine(make);
            //Console.WriteLine(model);
            //Console.WriteLine(year);
            //Console.WriteLine(type);

            return new CarProperty()
            {
                Make = make,
                Model = model,
                Type = type,
                Year = year,
                PicturePath = pic
            };
        }
        public static CarProperty CallToyota()
        {

            var client = new RestClient("https://car-data.p.rapidapi.com/cars?limit=1&page=0&year=2019&model=Rav4");
            var request = new RestRequest(Method.GET);
            request.AddHeader("X-RapidAPI-Key", "187b193293msh63b6a7cab422aabp1f6b15jsnc9fe38c4453b");
            request.AddHeader("X-RapidAPI-Host", "car-data.p.rapidapi.com");
            IRestResponse response = client.Execute(request);
            dynamic api = JArray.Parse(response.Content);
            var make = api[0]["make"];
            var model = api[0]["model"];
            var type = api[0]["type"];
            var year = api[0]["year"];
            var pic = ("~/Images/rav4.jpg");
            //Console.WriteLine(make);
            //Console.WriteLine(model);
            //Console.Writeline(year);
            //Console.Writeline(type);

            return new CarProperty()
            {
                Make = make,
                Model = model,
                Type = type,
                Year = year,
                PicturePath = pic
            };
        }
        public static CarProperty CallFord()
        {
            var client = new RestClient("https://car-data.p.rapidapi.com/cars?limit=1&page=0&year=2019&model=F150");
            var request = new RestRequest(Method.GET);
            request.AddHeader("X-RapidAPI-Key", "187b193293msh63b6a7cab422aabp1f6b15jsnc9fe38c4453b");
            request.AddHeader("X-RapidAPI-Host", "car-data.p.rapidapi.com");
            IRestResponse response = client.Execute(request);
            dynamic api = JArray.Parse(response.Content);
            var make = api[0]["make"];
            var model = api[0]["model"];
            var type = api[0]["type"];
            var year = api[0]["year"];
            var pic = ("~/Images/f150.jpg");
            //Console.WriteLine(make);
            //Console.WriteLine(model);
            //Console.WriteLine(year);
            //Console.WriteLine(type);

            return new CarProperty()
            {
                Make = make,
                Model = model,
                Type = type,
                Year = year,
                PicturePath = pic
            };
        }
        public static CarProperty CallSubi()
        {
            var client = new RestClient("https://car-data.p.rapidapi.com/cars?limit=40&page=0&year=2019&make=Subaru&model=Impreza&type=sedan");
            var request = new RestRequest(Method.GET);
            request.AddHeader("X-RapidAPI-Key", "187b193293msh63b6a7cab422aabp1f6b15jsnc9fe38c4453b");
            request.AddHeader("X-RapidAPI-Host", "car-data.p.rapidapi.com");
            IRestResponse response = client.Execute(request);
            dynamic api = JArray.Parse(response.Content);
            var make = api[0]["make"];
            var model = api[0]["model"];
            var type = api[0]["type"];
            var year = api[0]["year"];
            var pic = ("~/Images/Subi.jpg");
            //Console.WriteLine(make);
            //Console.WriteLine(model);
            //Console.WriteLine(year);
            //Console.WriteLine(type);

            return new CarProperty()
            {
                Make = make,
                Model = model,
                Type = type,
                Year = year,
                PicturePath = pic
            };
        }
        public static CarProperty CallEscape()
        {
            var client = new RestClient("https://car-data.p.rapidapi.com/cars?limit=40&page=0&year=2019&make=Ford&model=Escape&type=SUV");
            var request = new RestRequest(Method.GET);
            request.AddHeader("X-RapidAPI-Key", "187b193293msh63b6a7cab422aabp1f6b15jsnc9fe38c4453b");
            request.AddHeader("X-RapidAPI-Host", "car-data.p.rapidapi.com");
            IRestResponse response = client.Execute(request);
            dynamic api = JArray.Parse(response.Content);
            var make = api[0]["make"];
            var model = api[0]["model"];
            var type = api[0]["type"];
            var year = api[0]["year"];
            //Console.WriteLine(make);
            //Console.WriteLine(model);
            //Console.WriteLine(year);
            //Console.WriteLine(type);

            return new CarProperty()
            {
                Make = make,
                Model = model,
                Type = type,
                Year = year
            };
        }


    
    }
}
