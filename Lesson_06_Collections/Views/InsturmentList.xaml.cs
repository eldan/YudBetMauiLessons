using Lesson_06_Collections.Models;
using System.Diagnostics.Metrics;

namespace Lesson_06_Collections.Views;

public partial class InsturmentList : ContentPage
{
		List<MusicalInstrument> instruments;

		public InsturmentList()
		{
				InitializeComponent();
				instruments = Services.DataRepository.GetInsturmnetList();
        listInstruments.Children.Clear();
        foreach (MusicalInstrument instrument in instruments)
              {
                var layout = new HorizontalStackLayout
                {
                  Spacing = 10
                };

                var lblName = new Label
                {
                  Text = instrument.InstrumentName,
                  TextColor = Colors.Black,
                  VerticalOptions = LayoutOptions.Center
                };

                var lblType = new Label
                {
                  Text = instrument.Family,
                  TextColor = Colors.Black,
                  VerticalOptions = LayoutOptions.Center
                };

                var image = new Image
                {
                  Aspect = Aspect.AspectFill,
                  Source = instrument.Image,
                  VerticalOptions = LayoutOptions.Center,
                  HeightRequest = 50
                };

                layout.Children.Add(lblName);
                layout.Children.Add(lblType);
                layout.Children.Add(image);
           
                listInstruments.Add(layout);
        }
          


    }
}
