using Microsoft.Extensions.DependencyInjection;
using CorrelationId;

namespace CorrelationId
{
  /// <summary>
  /// Extensions on the <see cref="IServiceCollection"/>.
  /// </summary>
  public static class CorrelationIdHeaderServiceExtensions
  {
    /// <summary>
    /// Adds required services to support the Correlation ID functionality.
    /// </summary>
    /// <param name="serviceCollection"></param>
    public static IServiceCollection AddCorrelationIdHeaderHandler(this IServiceCollection serviceCollection)
    {
      return serviceCollection.AddTransient<CorrelationIdHandler>();
    }
  }
}