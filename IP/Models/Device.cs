using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace IP.Models;

public class Device
{    
    public string Brand { get; set; }
    public string Model { get; set; }
    public string DeviceType { get; set; }
    public string Storage { get; set; }
    public string ScreenSize { get; set; }
    public string Camera { get; set; }
    public string Subtitle { get; set; }
    public List<string> Features { get; }

    // TODO
    public string Description { get; set; }
    public string PageTitle { get; set; }
    public string MetaDescription { get; set; }

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

    private string categoryTitle;
    public string CategoryTitle
    {
        get { return categoryTitle; }
        set { categoryTitle = $"{DeviceName} Reparation"; }
    }

    public Device(string brand, string model, string deviceType, string storage, string screenSize, string camera) { 
        this.Brand = brand;
        this.Model = model;
        this.DeviceType= deviceType;
        this.Storage = storage;
        this.ScreenSize = screenSize;
        this.Camera = camera;
        this.DeviceName = Model;
        this.CategoryTitle = "";
        this.Subtitle = $"{DeviceName} reparation mens du venter. Vi bruger reservedele af høj kvalitet.";
        this.Features = ["Erfaring siden 2005", "Uddannede teknikere", "1 års garanti på alle reparationer"];
    }

    public override string ToString()
    {
        return $"Brand: {Brand} Model: {Model} DeviceType: {DeviceType}, Devicename: {DeviceName}";
    }
}
