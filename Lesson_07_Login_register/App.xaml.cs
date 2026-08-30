using Lesson_07_Login_register.Services;

namespace Lesson_07_Login_register
{
  public partial class App : Application
  {
    public App()
    {
      InitializeComponent();
      this.UserAppTheme = AppTheme.Light;
      DataRepository.FillFakeData();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
      return new Window(new AppShell());
    }
  }
}
