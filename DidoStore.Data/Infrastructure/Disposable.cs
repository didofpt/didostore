using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DidoStore.Data.Infrastructure
{
    public class Disposable : IDisposable
    {
        private bool isDisposed;

        ~Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if(!isDisposed && disposing)
            {
                DisposeCore();
            }

            isDisposed = true;
        }


        /// <summary>
        /// Override this method to dispose a custom object
        /// </summary>
        protected virtual void DisposeCore()
        {

        }
    }
}
