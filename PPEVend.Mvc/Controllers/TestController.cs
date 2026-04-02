using Microsoft.AspNetCore.Mvc;
using System.Device.Gpio;
using System.Device.I2c;

namespace PPEVend.Mvc.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Test(bool onOff)
        {
            try
            {
                int busId = 1;
                int deviceAddress = 0x10; // Example address for an ADC or sensor

                var settings = new I2cConnectionSettings(busId, deviceAddress);
                using I2cDevice device = I2cDevice.Create(settings);

                // Write a byte to a specific register
                byte register = 0x01;
                byte value = onOff ? (byte)0xFF : (byte)0x00;
                device.Write(new byte[] { register, value });

                // Read data from the device
                Span<byte> readBuffer = stackalloc byte[2];
                device.Read(readBuffer);
            }
            catch
            {

            }
            return RedirectToAction("Index");
        }
    }
}
