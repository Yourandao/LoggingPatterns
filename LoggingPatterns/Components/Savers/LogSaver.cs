namespace LoggingPatterns.Components.Savers {
    public abstract class LogSaver : IHandler {
        private IHandler _handler;

        public virtual object Handle(object request) {
            return this._handler?.Handle(request);
        }

        public IHandler SetNext(IHandler handler) {
            this._handler = handler;

            return handler;
        }
    }
}
