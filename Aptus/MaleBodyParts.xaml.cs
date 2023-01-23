namespace Aptus;

public partial class MaleBodyParts : ContentPage
{
	public MaleBodyParts()
	{
		InitializeComponent();
	}
    void TapBenchPress(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Exercises.BenchPress());
    }

    void TapInclineBenchPress(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Exercises.InclineBenchPress());
    }
}