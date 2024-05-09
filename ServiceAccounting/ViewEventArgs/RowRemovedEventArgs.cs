namespace View.ViewEventArgs;

public class RowRemovedEventArgs
{
    public RowRemovedEventArgs(int removedObjectIndex)
    {
        Index = removedObjectIndex;
    }

    public int Index { get; }
}
