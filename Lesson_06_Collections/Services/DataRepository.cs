using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_06_Collections.Models;

namespace Lesson_06_Collections.Services
{
  internal class DataRepository
  {
    static List<MusicalInstrument> instruments = new List<MusicalInstrument>();
    //static List<User>...

    public static void FillFakeData()
    {
      instruments.Add(new MusicalInstrument() { InstrumentName = "Saxaphone", Family = "Wind instrument", Image = "saxophone.jpg", HasWood = false });
      instruments.Add(new MusicalInstrument() { InstrumentName = "Piano", Family = "Keyboard instrument", Image = "piano.jpg", HasWood = true });
      instruments.Add(new MusicalInstrument() { InstrumentName = "Organ", Family = "Keyboard instrument", Image = "organ.jpg", HasWood = true });
      instruments.Add(new MusicalInstrument() { InstrumentName = "Synthesiser", Family = "Keyboard instrument", Image = "synth.jpg", HasWood = false });
      instruments.Add(new MusicalInstrument() { InstrumentName = "Drums", Family = "Percussion instrument", Image = "drums.jpg", HasWood = false });
      instruments.Add(new MusicalInstrument() { InstrumentName = "Bass Guitar", Family = "String instrument", Image = "bassguitar.jpg", HasWood = true });
    }
    public static List<MusicalInstrument> GetInsturmnetList()
    {
      return instruments;
    }

  }
}
