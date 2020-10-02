using System;
using System.Collections.Generic;
using System.Text;

namespace InteropControls
{
    public interface IErrorHandler
    {
        void HandleError(Exception ex);
    }
}
