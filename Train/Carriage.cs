using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
  internal class Carriage
  {
    public bool LightStatus { get; set; }
    public Carriage Next { get; set; }
    public Carriage Previous { get; set; }
    public Carriage(bool lightStatus)
    {
      LightStatus = lightStatus;
      Next = this;
      Previous = this;
    }

 

  }
}
