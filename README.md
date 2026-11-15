# Koptimizer

Unified Windows performance toolkit with three integrated fronts: Gaming (A), Windows (B), and Local AI (C). One desktop application, shared diagnostics, optimization engine, telemetry, audit log and restore center.

## Principles
- Measure before and after; do not promise unmeasured FPS gains.
- Read-only diagnostics by default; explicit consent for changes.
- Capture original values before reversible changes.
- Never bulk-disable services, security controls, drivers or scheduled tasks.
- Every operation declares prerequisites, risk, verification and rollback.
- Hardware-aware recommendations; initial validation target: ASUS TUF A15, Ryzen 7 7435HS, NVIDIA RTX 3050 Laptop GPU.

## Planned solution
- `Koptimizer.App`: Windows desktop UI and dashboard.
- `Koptimizer.Core`: operation contracts, policy, orchestration, logging and restore.
- `Koptimizer.Windows`: Windows inventory, diagnostics and supported actions.
- `Koptimizer.Gaming`: game profiles and graphics/performance diagnostics.
- `Koptimizer.LocalAI`: Ollama integration and inference diagnostics.
- `Koptimizer.Tests`: unit, safety and rollback tests.

See [Roadmap](docs/ROADMAP.md) and [Optimization catalog](docs/OPTIMIZATION_CATALOG.md).

Koptimizer is independent and is not affiliated with Microsoft, NVIDIA or ASUS.
