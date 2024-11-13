namespace Maui8100Issues;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
#if __ANDROID__
        Microsoft.Maui.Handlers.LabelHandler.Mapper.AppendToMapping("LineBreakLabels", (h, v) =>
        {
            h.PlatformView.BreakStrategy = Android.Text.BreakStrategy.Simple;
        });
#endif
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}