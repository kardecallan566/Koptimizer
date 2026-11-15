# Koptimizer

Unified Windows performance toolkit with three integrated fronts: Gaming (A), Windows (B), and Local AI (C). One desktop application, shared diagnostics, optimization engine, telemetry, audit log and restore center.

## Principles
- Measure before and after; do not promise unmeasured FPS gains.
- Read-only diagnostics by default; explicit consent for changes.
- Capture original values before reversible changes.
- Never bulk-disable services, security controls, drivers or scheduled tasks.
- Every operation declares prerequisites, risk, verification and rollback.
- Hardware-aware recommendations; initial validation target: ASUS TUF A15, Ryzen 7 7435HS, NVIDIA RTX 3050 Laptop GPU.

## Architecture
- `Koptimizer.App`: WPF desktop UI and dashboard.
- `Koptimizer.Core`: operation contracts and registry.
- `Koptimizer.Windows`: Windows diagnostics and supported actions.
- `Koptimizer.Gaming`: gaming profiles and diagnostics.
- `Koptimizer.LocalAI`: Ollama and inference diagnostics.

## Build
Requires Windows and the .NET 10 SDK:
```powershell
dotnet restore Koptimizer.sln
dotnet build Koptimizer.sln -c Release
dotnet run --project src/Koptimizer.App/Koptimizer.App.csproj
```

See [Roadmap](docs/ROADMAP.md) and [Optimization catalog](docs/OPTIMIZATION_CATALOG.md).

Koptimizer is independent and is not affiliated with Microsoft, NVIDIA or ASUS.
