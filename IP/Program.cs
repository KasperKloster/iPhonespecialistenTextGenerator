using IP.Models;
using IP.Repos;

DeviceRepo deviceRepo = new DeviceRepo();
List<Device> devices = deviceRepo.GetModelsFromCsv();

foreach(Device device in devices)
{
    Console.WriteLine(device);
    Console.WriteLine(device.Subtitle);

    foreach (string feature in device.Features)
    {
        Console.WriteLine(feature);
    }
}


