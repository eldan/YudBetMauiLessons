using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_07_Login_register.Models;

namespace Lesson_07_Login_register.Services
{
  internal class DataRepository
  {
    static List<MusicalInstrument> instruments = new List<MusicalInstrument>();
    static List<User> users = new List<User>(); // this should be in DB.
    static public User authUser;

    public static void FillFakeData()
    {
      instruments.Add(new MusicalInstrument() { InstrumentName = "Saxaphone", Family = "Wind instrument", Image = "saxophone.jpg", HasWood = false });
      instruments.Add(new MusicalInstrument() { InstrumentName = "Piano", Family = "Keyboard instrument", Image = "piano.jpg", HasWood = true });
      instruments.Add(new MusicalInstrument() { InstrumentName = "Organ", Family = "Keyboard instrument", Image = "organ.jpg", HasWood = true });
      instruments.Add(new MusicalInstrument() { InstrumentName = "Synthesiser", Family = "Keyboard instrument", Image = "synth.jpg", HasWood = false });
      instruments.Add(new MusicalInstrument() { InstrumentName = "Drums", Family = "Percussion instrument", Image = "drums.jpg", HasWood = false });
      instruments.Add(new MusicalInstrument() { InstrumentName = "Bass Guitar", Family = "String instrument", Image = "bassguitar.jpg", HasWood = true });

      users.Add(new User()
      {
        Id = "1safd4301",
        PName = "John",
        FName = "Doe",
        Email = "john.doe@email.com",
        Password = "Password123",
        BirthDay = new DateTime(1995, 5, 12),
        Instruments = new List<MusicalInstrument> { instruments[1], instruments[5] }, // Piano, Bass Guitar
        MainInstrument = instruments[1] // Piano
      });

      users.Add(new User()
      {
        Id = "1sag3sg3s02",
        PName = "Jane",
        FName = "Smith",
        Email = "jane.smith@email.com",
        Password = "SecurePass!5",
        BirthDay = new DateTime(1998, 11, 23),
        Instruments = new List<MusicalInstrument> { instruments[0] }, // Saxaphone
        MainInstrument = instruments[0]
      });

      users.Add(new User()
      {
        Id = "fdsg4asfsg",
        PName = "Michael",
        FName = "Brown",
        Email = "mike.b@email.com",
        Password = "DrumsRock99",
        BirthDay = new DateTime(1990, 3, 14),
        Instruments = new List<MusicalInstrument> { instruments[4], instruments[3] }, // Drums, Synthesiser
        MainInstrument = instruments[4] // Drums
      });

      users.Add(new User()
      {
        Id = "10yuod24",
        PName = "Emily",
        FName = "Davis",
        Email = "emily.d@email.com",
        Password = "PianoKey88!",
        BirthDay = new DateTime(2001, 8, 30),
        Instruments = new List<MusicalInstrument> { instruments[1], instruments[2] }, // Piano, Organ
        MainInstrument = instruments[1]
      });

      users.Add(new User()
      {
        Id = "sdfgdsgfds3",
        PName = "David",
        FName = "Wilson",
        Email = "david.w@email.com",
        Password = "SynthWave80s",
        BirthDay = new DateTime(1988, 1, 5),
        Instruments = new List<MusicalInstrument> { instruments[3] }, // Synthesiser
        MainInstrument = instruments[3]
      });

      users.Add(new User()
      {
        Id = "ioytui5",
        PName = "Sarah",
        FName = "Miller",
        Email = "sarah.m@email.com",
        Password = "JazzSax#1",
        BirthDay = new DateTime(1993, 7, 19),
        Instruments = new List<MusicalInstrument> { instruments[0], instruments[1] }, // Saxaphone, Piano
        MainInstrument = instruments[0]
      });

      users.Add(new User()
      {
        Id = "dfghjh3546",
        PName = "Chris",
        FName = "Garcia",
        Email = "chris.g@email.com",
        Password = "BassLine44",
        BirthDay = new DateTime(1996, 12, 25),
        Instruments = new List<MusicalInstrument> { instruments[5] }, // Bass Guitar
        MainInstrument = instruments[5]
      });

      users.Add(new User()
      {
        Id = "1032gn58",
        PName = "Jessica",
        FName = "Martinez",
        Email = "jess.m@email.com",
        Password = "OrganMusic2",
        BirthDay = new DateTime(1985, 4, 2),
        Instruments = new List<MusicalInstrument> { instruments[2] }, // Organ
        MainInstrument = instruments[2]
      });

      users.Add(new User()
      {
        Id = "dfhghjf54fgh",
        PName = "James",
        FName = "Anderson",
        Email = "james.a@email.com",
        Password = "BeatsPerMinute",
        BirthDay = new DateTime(2003, 10, 10),
        Instruments = new List<MusicalInstrument> { instruments[4], instruments[5] }, // Drums, Bass Guitar
        MainInstrument = instruments[4]
      });

      users.Add(new User()
      {
        Id = "wythrjcbv5",
        PName = "Anna",
        FName = "Thomas",
        Email = "anna.t@email.com",
        Password = "ClassicMelody!",
        BirthDay = new DateTime(1999, 6, 15),
        Instruments = new List<MusicalInstrument> { instruments[1] }, // Piano
        MainInstrument = instruments[1]
      });
    }

    public static bool CheckUserAuth(string u, string p)
    {
      // Find the first user matching the credentials case-insensitively for the email
      var user = users.Find(userItem =>
          userItem.Email.ToLower() == u.ToLower() && userItem.Password == p);

      if (user != null)
      {
        authUser = user; // Store the matching user session
        return true;
      }

      authUser = null; // Clear any existing session on failed login
      return false;
    }

    public static bool RegisterNewUser(string u, string p, DateTime d, string pName, string fName)
    {
      var foundUserWithSameCredentials = users.Find(userItem =>
          userItem.Email.ToLower() == u.ToLower());

      if (foundUserWithSameCredentials != null)
      {
        return false;
      }

      var newUser = new User() { Email = u, Password = p , FName = fName, PName = pName};
      users.Add(newUser);
      return true;
    }

    public static List<MusicalInstrument> GetInsturmnetList()
    {
      return instruments;
    }

  }
}
