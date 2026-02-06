public class PresentData
{
    private bool _isPicked = false;

    public bool IsPicked
    {
        get { return _isPicked; }
    }
    public bool PickItem()
    {
        _isPicked = true;
        return _isPicked;

    }
    public bool UnpickItem ()
    {
        _isPicked = false;
        return _isPicked;
    }
}