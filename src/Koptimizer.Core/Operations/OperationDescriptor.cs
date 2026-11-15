namespace Koptimizer.Core.Operations;
public sealed record OperationDescriptor(string Id, string Name, string Front, string Description, OperationRisk Risk, bool RequiresAdministrator, bool IsImplemented);
