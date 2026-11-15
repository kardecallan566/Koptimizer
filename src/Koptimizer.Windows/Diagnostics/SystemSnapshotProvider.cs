using System.Diagnostics;
using System.Runtime.InteropServices;
namespace Koptimizer.Windows.Diagnostics;
public sealed class SystemSnapshotProvider
{
 public SystemSnapshot Capture()
 {
  if (!OperatingSystem.IsWindows()) throw new PlatformNotSupportedException("Available only on Windows.");
  var memory = new MemoryStatusEx { Length = (uint)Marshal.SizeOf<MemoryStatusEx>() };
  if (!GlobalMemoryStatusEx(ref memory)) throw new InvalidOperationException($"GlobalMemoryStatusEx failed: {Marshal.GetLastWin32Error()}.");
  return new SystemSnapshot(Environment.OSVersion.VersionString,RuntimeInformation.OSArchitecture.ToString(),Environment.ProcessorCount,memory.TotalPhysical,memory.AvailablePhysical,Process.GetProcesses().Length,DateTimeOffset.UtcNow);
 }
 [StructLayout(LayoutKind.Sequential,CharSet=CharSet.Auto)] private struct MemoryStatusEx { public uint Length; public uint MemoryLoad; public ulong TotalPhysical; public ulong AvailablePhysical; public ulong TotalPageFile; public ulong AvailablePageFile; public ulong TotalVirtual; public ulong AvailableVirtual; public ulong AvailableExtendedVirtual; }
 [DllImport("kernel32.dll",SetLastError=true)] [return: MarshalAs(UnmanagedType.Bool)] private static extern bool GlobalMemoryStatusEx(ref MemoryStatusEx buffer);
}
