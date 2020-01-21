using System;

namespace SlipperyJim
{
    internal class DeviceAndBrowser
    {
        private string _deviceName;

        public void SetDeviceName(string deviceName)
        {
        }

        public void SetBrowserName(string deviceName)
        {
        }

        public string GetDeviceName()
        {
            var deviceNameArray = new[]
            {
                "iPhone", "Android Phone", "Laptop", "iPad", "ChromeBook", "Windows Tablet", "Netbook", "Smart TV"
            };
            var deviceNameGen = new Random();
            var deviceNameGenRandom = deviceNameGen.Next(0, deviceNameArray.Length);

            _deviceName = deviceNameArray[deviceNameGenRandom];
            return _deviceName;
        }

        public string GetBrowserName()
        {
            var browserNameArray = new[] {"Edge", "Chrome", "Internet Explorer", "Safari", "Firefox"};
            var browserNameGen = new Random();
            var browserNameGenRandom = browserNameGen.Next(0, browserNameArray.Length);

            _deviceName = browserNameArray[browserNameGenRandom];
            return _deviceName;
        }
    }
}