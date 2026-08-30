namespace Lesson_07_Login_register.Views;
using Lesson_07_Login_register.Services;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

  private void btnLogin_Clicked(object sender, EventArgs e)
  {
    string email = entryEmail.Text;
    string password = entryPassword.Text;
    string emailErr = "";
    bool isFormValid = true;


    errPassword.Text = "";
    errEmail.Text = "";

    lblGlobalMsg.IsVisible = false;
    lblGlobalMsg.Text = "";

    if (email == null || password==null)
    {
      return;
    }

    if (!email.Contains("@"))
    {
      emailErr = "you need a @ in the email. ";
      isFormValid = false;
    }

    if (email.Length < 5)
    {
      emailErr += "Email is too short. ";
      isFormValid = false;
    }

    errEmail.Text = emailErr;

    if (isFormValid)
    {
      if (DataRepository.CheckUserAuth(email, password))
      {
        lblGlobalMsg.IsVisible = true;
        lblGlobalMsg.Text = "Welcome "+ DataRepository.authUser.FName+" "+ DataRepository.authUser.PName;
      } else
      {
        errPassword.Text = "...problem with password";
      }
    }
  }
}
