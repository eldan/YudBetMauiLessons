namespace Lesson_04_ExerciseUIandUIwithCode.Views;

public partial class CalculateAgeWithCandlesPage : ContentPage
{
	public CalculateAgeWithCandlesPage()
	{
		InitializeComponent();
    // יצירת מלל
    Label eldanLabel = new Label
    {
      Text = "Yo Yo",
      TextColor = Colors.Orange
    };
    // הוספת מלל פשוט לאלמנט בשם:
    // layoutFields
    layoutFields.Children.Add(eldanLabel);

    // יצירת כפתור
    Button customButton = new Button
    {
      BackgroundColor = Colors.Brown,
      Text = "Calculate Age"
    };
    // הוספת אירוע בתכנות ללחיצה על הפתור
    customButton.Clicked += btnCalculateAge_Clicked;

    // הוספת הכפתור לאלמנט בשם:
    // layoutFields
    layoutFields.Children.Add(customButton);

  }
  private void btnCalculateAge_Clicked(object sender, EventArgs e)
  {
    string str = entryName.Text + " ";
    str += "בעוד 10 שנים תהיה בן ";
    str += (10 + int.Parse(entryBirthYear.Text)).ToString();
    lblSentence.Text = str;

    candleHolder.Children.Clear();

    for (int i = 0; i < 10 + int.Parse(entryBirthYear.Text); i++)
    {
      Image candle = new Image
      {
        Aspect = Aspect.AspectFit,
        HeightRequest = 100,
        WidthRequest = 50,
        Source = "candle.png"
      };
      candleHolder.Children.Add(candle);
    }
  }
}
