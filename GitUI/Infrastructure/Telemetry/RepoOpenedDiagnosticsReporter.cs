namespace GitUI.Infrastructure.Telemetry
{
    internal sealed class RepoOpenedDiagnosticsReporter
    {
        public void Report()
        {
            ////DiagnosticsClient.TrackEvent("AppStart",
            ////    new Dictionary<string, string>
            ////    {
            ////        { "Git", GitVersion.Current.ToString() },
            ////        { "SSH", sshClient },
            ////        { nameof(AppSettings.CurrentTranslation), AppSettings.CurrentTranslation },
            ////        { nameof(AppSettings.StartWithRecentWorkingDir), AppSettings.StartWithRecentWorkingDir.ToString() },
            ////    });
        }
    }
}
