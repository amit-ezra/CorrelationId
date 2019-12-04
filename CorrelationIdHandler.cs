using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using CorrelationId;

namespace CorrelationId
{
  public class CorrelationIdHandler : DelegatingHandler
  {
    ICorrelationContextAccessor correlationContext;

    public CorrelationIdHandler(ICorrelationContextAccessor correlationContext)
    {
      this.correlationContext = correlationContext;
    }

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
      request.Headers.Add(correlationContext.CorrelationContext.Header, correlationContext.CorrelationContext.CorrelationId);
      return base.SendAsync(request, cancellationToken);
    }
  }
}
