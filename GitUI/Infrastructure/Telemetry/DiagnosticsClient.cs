// The original idea and the implementation are borrowed from  https://github.com/NuGetPackageExplorer/NuGetPackageExplorer
// Credits to Oren Novotny

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using GitExtUtils.GitUI;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;

namespace GitUI.Infrastructure.Telemetry
{
    public static class DiagnosticsClient
    {
        private static bool _initialized;

        private static TelemetryClient _client;

        public static void Initialize(bool isDirty)
        {
            TelemetryConfiguration.Active.InstrumentationKey = "2ef275e3-8850-4305-9d7c-825a60c3d296";
            TelemetryConfiguration.Active.TelemetryChannel.DeveloperMode = Debugger.IsAttached;
            TelemetryConfiguration.Active.TelemetryInitializers.Add(new AppInfoTelemetryInitializer(isDirty));
            TelemetryConfiguration.Active.TelemetryInitializers.Add(new DeviceTelemetryInitializer());

            _initialized = true;

            _client = new TelemetryClient();

            var properties = new Dictionary<string, string>
            {
                // environment
                { "DotNetVersion", RuntimeInformation.FrameworkDescription },

                // languages
                { "CurrentCulture", CultureInfo.CurrentCulture.Name },
                { "CurrentUICulture", CultureInfo.CurrentUICulture.Name }
            };
            AttachMonitorInformation(properties);

            _client.TrackEvent("Startup.Environment", properties);
        }

        public static void OnExit()
        {
            if (!_initialized)
            {
                return;
            }

            _client.Flush();

            // Allow time for flushing:
            System.Threading.Thread.Sleep(1000);
        }

        public static void TrackEvent(string eventName, IDictionary<string, string> properties = null, IDictionary<string, double> metrics = null)
        {
            if (!_initialized)
            {
                return;
            }

            _client.TrackEvent(eventName, properties, metrics);
        }

        public static void TrackTrace(string evt)
        {
            if (!_initialized)
            {
                return;
            }

            _client.TrackTrace(evt);
        }

        public static void Notify(Exception exception)
        {
            if (!_initialized)
            {
                return;
            }

            _client.TrackException(exception);
        }

        public static void TrackPageView(string pageName)
        {
            if (!_initialized)
            {
                return;
            }

            _client.TrackPageView(pageName);
        }

        private static void AttachMonitorInformation(Dictionary<string, string> properties)
        {
            properties["Monitors"] = Screen.AllScreens.Length.ToString();
            properties["Monitor-Primary-Dpi"] = $"{DpiUtil.DpiX}dpi ({(DpiUtil.ScaleX == 1 ? "no" : $"{Math.Round(DpiUtil.ScaleX * 100)}%")} scaling)";

            for (int i = 0; i < Screen.AllScreens.Length; i++)
            {
                var key = Screen.AllScreens[i].Primary ? "Monitor-Primary" : $"Monitor-{i}";

                properties[$"{key}-Resolution"] = Screen.AllScreens[i].Bounds.ToString();
            }
        }
    }
}
