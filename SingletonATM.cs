using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationATM {
  class SingletonATM {
    private static SingletonATM instance;

    private SingletonATM() { }

    public static SingletonATM getInstance() {
      if (instance == null)
        instance = new SingletonATM();
      return instance;
    }
  }
}
