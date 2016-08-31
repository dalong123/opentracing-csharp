using OpenTracing.Propagation;

namespace OpenTracing.NullTracer
{
    public class NullTracer : ITracer
    {
        public static readonly NullTracer Instance = new NullTracer();

        private NullTracer()
        {
        }

        public ISpan StartSpan(string operationName, StartSpanOptions options = null)
        {
            return NullSpan.Instance;
        }

        public void Inject<TCarrier>(ISpanContext spanContext, Format<TCarrier> format, TCarrier carrier)
        {
        }

        public ISpanContext Extract<TCarrier>(Format<TCarrier> format, TCarrier carrier)
        {
            return null;
        }
    }
}