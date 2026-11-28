using Microsoft.AspNetCore.Mvc;
using System.Device.Gpio;
using System.Device.I2c;

namespace DIYVendingMachine.Mvc.Controllers
{
    public class TestController : Controller
    {
        private const string ButtonStatesKey = "TestButtonStates";

        public IActionResult Index()
        {
            var activeButtons = HttpContext.Session.GetObject<HashSet<int>>(ButtonStatesKey) ?? new HashSet<int>();
            return View(activeButtons);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Toggle(int? channel)
        {
            if (!channel.HasValue || channel.Value / 10 < 1 || channel.Value / 10 > 3 || channel.Value % 10 < 0 || channel.Value % 10 > 3)
            {
                return BadRequest("Invalid test button.");
            }

            var activeButtons = HttpContext.Session.GetObject<HashSet<int>>(ButtonStatesKey) ?? new HashSet<int>();
            if (!activeButtons.Add(channel.Value))
            {
                activeButtons.Remove(channel.Value);
            }
            HttpContext.Session.SetObject(ButtonStatesKey, activeButtons);

            return RedirectToAction(nameof(Index));
        }

        //[HttpPost]
        //public IActionResult Test(bool onOff)
        //{
        //    try
        //    {
        //        int busId = 1;
        //        int deviceAddress = 0x10; // Example address for an ADC or sensor

        //        var settings = new I2cConnectionSettings(busId, deviceAddress);
        //        using I2cDevice device = I2cDevice.Create(settings);

        //        // Write a byte to a specific register
        //        byte register = 0x01;
        //        byte value = onOff ? (byte)0xFF : (byte)0x00;
        //        device.Write(new byte[] { register, value });

        //        // Read data from the device
        //        Span<byte> readBuffer = stackalloc byte[2];
        //        device.Read(readBuffer);
        //    }
        //    catch
        //    {

        //    }
        //    return RedirectToAction("Index");
        //}
    }
}
