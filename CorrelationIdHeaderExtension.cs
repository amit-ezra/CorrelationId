using System;
using Microsoft.Extensions.DependencyInjection;

namespace CorrelationId
{
  public static class CorrelationIdHeaderExtension
  {
    public static IHttpClientBuilder AddCorrelationIdHandler(this IHttpClientBuilder builder)
    {
      if (builder == null) throw new ArgumentNullException(nameof(builder));

      return builder.AddHttpMessageHandler<CorrelationIdHandler>();
    }
  }
}
