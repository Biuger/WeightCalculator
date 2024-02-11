using TecNM.Practica2.Core.Entities;
using TecNM.Practica2.Core.Services.Interfaces;

namespace TecNM.Practica2.Core.Services;

public class WeightService : IWeightService {
    public Person ProcessWeight(Person person){
        var person1 = new Person();
       
       person1.Weight = person.Weight / 9.81 * 3.711;

        return person1;
    }
}