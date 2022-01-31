using Evaluation.Shared;

namespace Evaluation.Client.Services
{
    public interface IMaritimeCalculator
    {
        Task<double> ConvertKnotsToKmh(double knots);

        Task<double> CalculateCollitionTime(double speed1, double speed2, int distance);
    }
}
