using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP.Models;

public class Description
{
    public string Bottom { get; set; }
    private string deviceType;

    public string DeviceType
    {
        get { return deviceType; }
        set { deviceType = value.ToLower(); }
    }

    public Description(string bottom, string deviceType)
    {
        this.Bottom = bottom;
        this.DeviceType = deviceType;
    }
    
    public override string ToString()
    {
        return $"{Bottom}";
    }

}