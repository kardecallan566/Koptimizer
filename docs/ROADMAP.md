# Roadmap

## Phase 0 — Foundation
- [x] Define unified product with Gaming, Windows and Local AI fronts.
- [x] Establish safety and rollback principles.
- [x] Scaffold .NET solution, WPF shell and project boundaries.
- [x] Add Windows-only CI build workflow.
- [ ] Validate first CI run and fix build issues.

## Phase 1 — Core
- [x] Initial read-only system snapshot (OS, architecture, logical processors, RAM, process count).
- [x] Optimization contracts and registry foundation.
- [ ] Navigation and dashboard data binding.
- [ ] Hardware inventory (CPU/GPU/model/driver).
- [ ] Structured logs and operation history.
- [ ] Backup/restore center and operation policy.

## Phase 2 — Windows (B)
- [ ] Startup inventory and consent-based changes.
- [ ] Process/resource monitor.
- [ ] Temporary-file analysis and preview.
- [ ] Power-plan inventory and controlled selection.
- [ ] System health and storage diagnostics.

## Phase 3 — Gaming (A)
- [ ] Game detection and per-game profiles.
- [ ] NVIDIA settings inspection and supported configuration.
- [ ] Windows gaming settings audit.
- [ ] FPS/frametime benchmark integration.
- [ ] Before/after reports.

## Phase 4 — Local AI (C)
- [ ] Ollama availability, API and model inventory.
- [ ] CPU/RAM/GPU/VRAM telemetry.
- [ ] Workload profiles for interactive, coding and batch use.
- [ ] Context/concurrency recommendations with memory estimates.
- [ ] Inference benchmark and bottleneck diagnostics.

## Phase 5 — Advanced and release
- [ ] ASUS-specific thermal/device diagnostics.
- [ ] Opt-in automation and exportable reports.
- [ ] Installer, signing and release pipeline.

## Release gates
Every feature must build, be tested, handle errors/cancellation, log results, verify changes and document rollback limitations. No optimization is marked complete based on UI alone.
