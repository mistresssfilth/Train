using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
  class TrainObject
  {
    private Random random = new Random();
    public Carriage head { get; set; }
    public Carriage tail { get; set; }
    private int countOfCarriages;
    private List<Carriage> train = new List<Carriage>();

    public TrainObject()
    {
      countOfCarriages = random.Next(1, 1000);

    }
    public List<Carriage> MakeTrain()
    {
      for (int i = 0; i < countOfCarriages; i++)
      {
        train.Add(AddCarriage(Convert.ToBoolean(random.Next(2))));

      }
      return train;
    }
    public int randomPosition()
    {
      return random.Next(1, countOfCarriages);

    }
    private Carriage AddCarriage(bool value)
    {
      Carriage carriage = new Carriage(value);
      if (train.Count == 0)
        head = carriage;
      else
      {
        carriage.Next = head;
        carriage.Previous = tail;
        head.Previous = carriage;
        tail.Next = carriage;
      }
      tail = carriage;
      return carriage;
    }
   
  }
}
