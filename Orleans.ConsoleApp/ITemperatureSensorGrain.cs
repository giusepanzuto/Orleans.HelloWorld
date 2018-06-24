using System.Threading.Tasks;

namespace Orleans.ConsoleApp
{
    public interface ITemperatureSensorGrain : IGrainWithIntegerKey
    {
        Task SubmitTemperatureAsync(float temperature);
    }
}