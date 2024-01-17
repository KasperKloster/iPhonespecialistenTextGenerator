using IP.Models;

namespace IP_Tests
{
    [TestClass]
    public class DeviceTest
    {
        [TestMethod]
        public void AppleSmartphoneDeviceNameTest()
        {
            Device device = new Device(brand: "Apple", model: "iPhone 11", deviceType: "Smartphone");
            string deviceName = device.DeviceName;
            Assert.AreEqual("iPhone 11", deviceName);
        }
        [TestMethod]
        public void SamsungSmartphoneDeviceNameTest()
        {
            Device device = new Device(brand: "Samsung", model: "Galaxy S23", deviceType: "Smartphone");

            string deviceName = device.DeviceName;
            Assert.AreEqual("Samsung Galaxy S23", deviceName);
        }
    }
}