namespace Lesson_04_ExerciseUIandUIwithCode.Views;

public partial class CalculateAgePage : ContentPage
{
	public CalculateAgePage()
	{
		InitializeComponent();
  }

  private void btnCalculateAge_Clicked(object sender, EventArgs e)
  {
    string str = entryName.Text +" ";
    str += "בעוד 10 שנים תהיה בן ";
    str += (10+int.Parse(entryBirthYear.Text)).ToString();
    lblSentence.Text = str;
  }
}
