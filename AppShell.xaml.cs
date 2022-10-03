namespace AppShell;

public partial class AppShell : Shell
{
    private bool _subItemVisible;
    public AppShell()
    {
        InitializeComponent();

        _subItemVisible = true;
    }

    private void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
    {
        _subItemVisible = !_subItemVisible;
        
        Resources["myVisible"] = _subItemVisible;
        ForceLayout();
        InvalidateMeasure();
    }

    private void menuItem2_Clicked(object sender, EventArgs e)
    {
        var item = Items[4];
        item.FlyoutItemIsVisible = _subItemVisible;
        item.IsVisible = _subItemVisible;
    }
}
