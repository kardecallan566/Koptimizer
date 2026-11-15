using System.Windows;
using Koptimizer.Windows.Diagnostics;
namespace Koptimizer.App;
public partial class MainWindow : Window
{
 private readonly SystemSnapshotProvider _provider = new();
 public MainWindow() { InitializeComponent(); Loaded += OnLoaded; }
 private async void OnLoaded(object sender,RoutedEventArgs e)
 {
  try { var s = await Task.Run(_provider.Capture); CpuValue.Text=s.LogicalProcessors.ToString(); MemoryValue.Text=$"{s.MemoryUsagePercent:F1}%"; MemoryDetail.Text=$"{Format(s.TotalPhysicalMemoryBytes-s.AvailablePhysicalMemoryBytes)} / {Format(s.TotalPhysicalMemoryBytes)}"; ProcessValue.Text=s.RunningProcessCount.ToString(); SystemInfo.Text=$"{s.OperatingSystem} • {s.Architecture} • Capturado {s.CapturedAt.ToLocalTime():HH:mm:ss}"; }
  catch(Exception ex) { CpuValue.Text=MemoryValue.Text=ProcessValue.Text="—"; SystemInfo.Text=$"Falha no diagnóstico: {ex.Message}"; }
 }
 private static string Format(ulong b) => $"{b/(1024d*1024d*1024d):F1} GB";
}
