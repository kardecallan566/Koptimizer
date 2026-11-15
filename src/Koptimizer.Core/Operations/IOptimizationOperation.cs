namespace Koptimizer.Core.Operations;
public interface IOptimizationOperation { OperationDescriptor Descriptor { get; } Task<OptimizationResult> ExecuteAsync(CancellationToken cancellationToken = default); }
