using System;
using System.Threading.Tasks;

namespace Orleans.ConsoleApp
{
    public class TemperatureSensorGrain : Grain, ITemperatureSensorGrain
    {
        public Task SubmitTemperatureAsync(float temperature)
        {
            long grainId = this.GetPrimaryKeyLong();
            Console.WriteLine($"{grainId} received temperature: {temperature}");

            return Task.CompletedTask;
        }
    }
}