using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP.Models;

public class Device
{    
    public string Brand { get; set; }
    public string Model { get; set; }
    public string DeviceType { get; set; }

    private string deviceName;
    public string DeviceName
    {
        get { return deviceName; }
        set
        {
            if (Brand.ToLower() == "apple")
            {
                deviceName = Model;
            }
            else
            {
                deviceName = $"{Brand} {Model}";
            }
        }
    }

    
    
    public Device(string brand, string model, string deviceType) { 
        this.Brand = brand;
        this.Model = model;
        this.DeviceType= deviceType;
        this.DeviceName = Model;
    }

    public override string ToString()
    {
        return $"Brand: {Brand}, Model: {Model}, DeviceType: {DeviceType}, Devicename: {DeviceName}";
    }
}
