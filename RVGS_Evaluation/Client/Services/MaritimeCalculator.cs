using System.Net.Http.Json;

namespace Evaluation.Client.Services
{
    public class MaritimeCalculator : IMaritimeCalculator
    {
        private readonly HttpClient httpClient;

        public MaritimeCalculator(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<double> CalculateCollitionTime(double speed1, double speed2, int distance)
        {
            return await httpClient.GetFromJsonAsync<double>($"api/MaritimeConversion/CalculateCollitionTime/{speed1}/{speed2}/{distance}");
        }

        public async Task<double> ConvertKnotsToKmh(double knots)
        {
            return await httpClient.GetFromJsonAsync<double>($"api/MaritimeConversion/ConvertKnotsToKmh/{knots}");
        }

    }
}
