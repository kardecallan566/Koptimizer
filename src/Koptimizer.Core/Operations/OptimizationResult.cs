namespace Koptimizer.Core.Operations;
public sealed record OptimizationResult(bool Succeeded, string Summary, DateTimeOffset CompletedAt, IReadOnlyDictionary<string,string>? Details = null);
