using IP.Models;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP.Repos;

public class DeviceRepo
{
    public List<Device> GetModelsFromCsv()
    {
        List<Device> devices = new List<Device>();

        var path = @"C:\Users\Kasper\Documents\Projects\csv\models.csv";
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

                Device device = new Device(brand: Brand, model: Model, deviceType: DeviceType);
                devices.Add(device);
            }
        }
        return devices;
    }
}