using IP.Models;
using IP.Repos;

DescriptionRepo descriptionRepo = new DescriptionRepo();
DeviceRepo deviceRepo = new DeviceRepo();
List<Device> devices = deviceRepo.GetModelsFromCsv();

foreach (Device device in devices)
{
    // Assign Description
    device.Description = descriptionRepo.GetRandomDescriptionFromDeviceType(device.DeviceType, device.DeviceName);
    // Assign list of repairs
}