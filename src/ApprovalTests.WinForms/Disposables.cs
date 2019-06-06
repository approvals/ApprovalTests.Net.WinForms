using System;

namespace ApprovalTests.WinForms
{
    public class Disposables : IDisposable
    {
        private readonly Action _onDispose;

        private Disposables(Action onDispose)
        {
            _onDispose = onDispose;
        }

        public static IDisposable Create(Action on_dispose)
        {
            return new Disposables(on_dispose);
        }

        public void Dispose()
        {
            _onDispose();
        }
    }
}