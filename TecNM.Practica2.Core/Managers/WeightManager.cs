using TecNM.Practica2.Core.Entities;
using TecNM.Practica2.Core.Managers.Interfaces;
using TecNM.Practica2.Core.Services.Interfaces;

namespace TecNM.Practica2.Core.Managers;

public class WeightManager : IweightManager {
    private readonly IWeightService _service;//Que es privado _
    public WeightManager(IWeightService service){
        _service = service;
    }
    public Person GetWeight(Person person){
        return _service.ProcessWeight(person);
    }

}