namespace Lesson_06_Collections
{
  public partial class App : Application
  {
    public App()
    {
      InitializeComponent();
      Services.DataRepository.FillFakeData();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
      return new Window(new AppShell());
    }
  }
}
