
namespace Evaluation.Server.Services
{
    public class MaritimeConverterService : IMaritimeConverterService
    {
        public Task<double> CalculateCollitionTime(double speed1, double speed2, int distance)
        {
            return Task.FromResult(((distance / (speed1 + speed2)) * 60));
        }

        public Task<double> ConvertKnotsToKmh(double knots)
        {
            throw new NotImplementedException();
            //return Task.FromResult(knots * ??);
        }
    }
}
