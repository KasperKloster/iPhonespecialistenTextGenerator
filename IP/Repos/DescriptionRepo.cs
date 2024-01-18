using IP.Models;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP.Repos;

public class DescriptionRepo
{
    private static List<Description> list = new List<Description>();

    public DescriptionRepo() {
        SetAllBottomDescriptions();
    }

    public void SetAllBottomDescriptions()
    {
        var path = @"C:\Users\Kasper\Documents\Projects\iPhonespecialisenTextGenerator\csv\description.csv";
        using (TextFieldParser csvParser = new TextFieldParser(path, defaultEncoding: Encoding.UTF8))
        {
            csvParser.SetDelimiters(new string[] {";"});
            csvParser.ReadLine();

            while(!csvParser.EndOfData)
            {
                string[]? fields = csvParser.ReadFields();
                string bottom = fields[0];
                string deviceType = fields[1];

                Description description = new Description(bottom, deviceType);
                list.Add(description);
            }
        }
    }

    public string GetRandomDescriptionFromDeviceType(string deviceType, string deviceName)
    {
        // Filter the list based on the condition
        var filteredList = list.Where(description => description.DeviceType == deviceType).ToList();

        // Check if there are any matching elements
        if (filteredList.Any())
        {
            // If there are matching elements, order them randomly and take the first
            var randomDescription = filteredList.OrderBy(_ => Guid.NewGuid()).First();
            // Replace variable in description
            string description = replaceVariablesInDescription(randomDescription.Bottom, deviceName);
            return description;
        }
        Console.WriteLine("No matching elements found.");
        return null;
    }

    private string replaceVariablesInDescription(string description, string deviceName)
    {
        description = description.Replace("[DEVICE_NAME]", deviceName);
        return description;
    }


}