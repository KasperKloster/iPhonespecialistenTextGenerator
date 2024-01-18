using IP.Models;
using Microsoft.VisualBasic.FileIO;

namespace IP.Repos;

public class DeviceRepo
{
    public List<Device> GetModelsFromCsv()
    {
        List<Device> devices = new List<Device>();

        var path = @"C:\Users\Kasper\Documents\Projects\iPhonespecialisenTextGenerator\csv\models.csv";
        using (TextFieldParser csvParser  = new TextFieldParser(path))
        {
            csvParser.SetDelimiters(new string[] { ";" });            
            // Skip column rows
            csvParser.ReadLine();

            while (!csvParser.EndOfData)
            {
                string[]? fields = csvParser.ReadFields();                
                string Brand = fields[0];
                string Model = fields[1];
                string DeviceType = fields[2];
                string Storage = fields[3];
                string ScreenSize = fields[4];
                string Camera = fields[5];

                Device device = new Device(brand: Brand, model: Model, deviceType: DeviceType, storage: Storage, screenSize: ScreenSize, camera: Camera);
                devices.Add(device);
            }
        }
        return devices;
    }
}