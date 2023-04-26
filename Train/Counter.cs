using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
  class Counter
  {
    private TrainObject train;
    private List<Carriage> randomTrain;
    private Carriage head;

    public Counter()
    {
      train = new TrainObject();
      randomTrain = train.MakeTrain();
      head = randomTrain[train.randomPosition()];
    }
    public void CountCarriages()
    {
      int count = 0;
      bool end = true;
      if (!head.LightStatus)
      {
        head.LightStatus = true;
      }
      Carriage current = head;
      do
      {
        current = current.Next;
        count++;
        if (current.LightStatus)
        {
          current.LightStatus = false;
          for (int i = count; i > 0; i--)
          {
            current = current.Previous;
          }
          if (!current.LightStatus)
          {
            System.Console.WriteLine("Count of carriages: " + count);
            end = false;
          }
          else
          {
            count = 0;
          }

        }
      } while (end);
    }

    
  }
}
