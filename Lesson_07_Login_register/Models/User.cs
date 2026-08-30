using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_07_Login_register.Models
{
  internal class User
  {
    public string Id { get; set; }
    public string PName { get; set; }
    public string FName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime BirthDay { get; set; }
    public List<MusicalInstrument> Instruments { get; set; }
    public MusicalInstrument MainInstrument { get; set; }
  }
}
