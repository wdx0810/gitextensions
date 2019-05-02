using System;
using System.Management;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility;

namespace GitUI.Infrastructure.Telemetry
{
    internal class DeviceTelemetryInitializer : ITelemetryInitializer
    {
        private readonly string _uuid;

        public DeviceTelemetryInitializer()
        {
            _uuid = GetUuid();
        }

        public void Initialize(ITelemetry telemetry)
        {
            telemetry.Context.Device.Id = _uuid;
            telemetry.Context.Device.OperatingSystem = Environment.OSVersion.ToString();
        }

        private static string GetUuid()
        {
            string uuid = string.Empty;

            using (var mc = new ManagementClass("Win32_ComputerSystemProduct"))
            {
                using (var moc = mc.GetInstances())
                {
                    foreach (var mo in moc)
                    {
                        uuid = mo.Properties["UUID"].Value.ToString();
                        break;
                    }
                }
            }

            return uuid;
        }
    }
}