using System;

namespace View.ViewEventArgs;

public class ObjectUpdatedEventArgs : EventArgs
{
    public ObjectUpdatedEventArgs(object updatedObject)
    {
        UpdatedObject = updatedObject ?? throw new ArgumentNullException(nameof(updatedObject));
    }

    public object UpdatedObject { get; }
}
