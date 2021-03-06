using System.Collections.Generic;
using Android.Hardware.Usb;

namespace XamarinUsbDriver.UsbSerial
{
    public class CdcAcmSerialDriver : IUsbSerialDriver
    {
        public UsbDevice Device { get; }
        public List<IUsbSerialPort> Ports { get; }

        public CdcAcmSerialDriver(UsbDevice device)
        {
            Device = device;
            Ports = new List<IUsbSerialPort> {new CdcAcmSerialPort(device, 0)};
        }

        public static Dictionary<int, int[]> GetSupportedDevices()
        {
            return new Dictionary<int, int[]>
            {
                {
                    0x1cbe, new[] {0x9652}
                },
                {
                    0x2a19, new[] {0x800}
                }
            };
        }
    }
}
