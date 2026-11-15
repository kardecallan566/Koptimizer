# Optimization catalog

Planning inventory. A catalog item is not exposed as an actionable control until implemented and validated.

Risk: Low = read-only/routine; Medium = user configuration change; High = potentially destabilizing or broad.

## A — Gaming
| ID | Capability | First implementation | Risk |
|---|---|---|---|
| A01 | Gaming power profile | Inspect current power mode | Low |
| A02 | Background processes | Identify heavy apps; user chooses close | Medium |
| A03 | Startup impact | Inventory startup entries | Low |
| A04 | NVIDIA profile | Inspect supported driver settings | Medium |
| A05 | FPS/frametime | Capture repeatable baseline | Low |
| A06 | Latency | Test one variable at a time | Medium |
| A07 | GPU/CPU telemetry | Read utilization and clocks when available | Low |
| A08 | Thermal diagnostics | Detect sensor/throttling indicators | Low |
| A09 | Game Mode | Inspect state; offer consent-based toggle | Medium |
| A10 | Per-game profiles | Save user-approved settings | Medium |
| A11 | Benchmarks | Compare controlled runs | Low |
| A12 | Restore profile | Restore recorded values | Low |

## B — Windows
| ID | Capability | First implementation | Risk |
|---|---|---|---|
| B01 | Startup manager | Inventory; confirm before disabling | Medium |
| B02 | Services | Audit only; no bulk disabling | High |
| B03 | Temporary files | Preview targets and size before cleanup | Medium |
| B04 | Memory | Diagnose pressure; no fake RAM cleaners | Low |
| B05 | Process monitor | Read-only inventory | Low |
| B06 | Power | Inspect/select available plans | Medium |
| B07 | Background apps | Identify candidates and explain impact | Medium |
| B08 | System settings | Audit individual settings | Medium |
| B09 | Bottleneck diagnostics | CPU/RAM/disk analysis | Low |
| B10 | Storage | Usage analysis and safe cleanup preview | Low |
| B11 | Integrity | Documented Windows health checks | Low |
| B12 | Restore center | Back up supported settings | Low |

## C — Local AI
| ID | Capability | First implementation | Risk |
|---|---|---|---|
| C01 | Ollama detection | Detect API/service/version | Low |
| C02 | VRAM monitor | Observe usage/pressure | Low |
| C03 | RAM monitor | Observe inference memory | Low |
| C04 | Model inventory | List installed/running models | Low |
| C05 | Workload profiles | Interactive/coding/batch recommendations | Medium |
| C06 | CPU/GPU balance | Diagnose; no forced affinity by default | Medium |
| C07 | Context/concurrency | Explain memory trade-offs; preview config | Medium |
| C08 | GGUF inventory | Read available metadata | Low |
| C09 | Thermal monitor | Read supported sensors | Low |
| C10 | Inference bottlenecks | Correlate telemetry with workload | Low |
| C11 | Model profiles | Store per-model recommendations | Medium |
| C12 | Benchmark | Compare fixed prompts/settings | Low |

## Acceptance criteria
Every operation documents purpose, supported systems, prerequisites and risk; validates permissions and inputs; captures original state for reversible mutations; logs outcome/errors; verifies post-change state; and provides rollback or explains why rollback is unavailable. Tests cover success, failure and cancellation.
