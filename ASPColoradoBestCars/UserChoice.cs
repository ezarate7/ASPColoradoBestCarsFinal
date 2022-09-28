using ASPColoradoBestCars.Models;

namespace ASPColoradoBestCars
{
    public class UserChoice
    {
        public CarProperty UserInput()
        {
            Console.WriteLine("Pick a Make");
            var input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "toyota":
                    return ApiCall.CallToyota();
                    break;
                case "chevrolet":
                case "chevy":
                    return ApiCall.CallChevy();
                    break;
                case "ford":
                    return ApiCall.CallFord();
                    break;
                case "subaru":
                    return ApiCall.CallSubi();
                    break;
                default:
                   return ApiCall.CallChevy();
                    break;

            }
            Console.ReadKey();
        }
    }
}
