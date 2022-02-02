
namespace Evaluation.Server.Services
{
    public interface IMaritimeConverterService
    {
        Task<double> ConvertKnotsToKmh(double knots);
        Task<double> CalculateCollitionTime(double speed1, double speed2, int distance);
    }
}
