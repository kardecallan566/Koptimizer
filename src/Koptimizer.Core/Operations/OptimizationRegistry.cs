namespace Koptimizer.Core.Operations;
public sealed class OptimizationRegistry
{
 private readonly Dictionary<string,IOptimizationOperation> _operations = new(StringComparer.OrdinalIgnoreCase);
 public void Register(IOptimizationOperation operation) { ArgumentNullException.ThrowIfNull(operation); if (!_operations.TryAdd(operation.Descriptor.Id,operation)) throw new InvalidOperationException($"Operation '{operation.Descriptor.Id}' already registered."); }
 public IReadOnlyCollection<OperationDescriptor> GetCatalog() => _operations.Values.Select(x=>x.Descriptor).OrderBy(x=>x.Front).ThenBy(x=>x.Id).ToArray();
 public bool TryGet(string id,out IOptimizationOperation? operation) => _operations.TryGetValue(id,out operation);
}
