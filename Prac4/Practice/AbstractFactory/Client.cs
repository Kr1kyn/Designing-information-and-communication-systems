using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class Client
    {
        public string Name { get { return abstractCar.Name; } }
        private AbstractCar abstractCar;
        private AbstractEngine abstractEngine;
        private AbstarctBody abstarctBody;
        public Client(CarFactory car_factory)
        {
            abstractCar = car_factory.CreateCar();
            abstractEngine = car_factory.CreateEngine();
            abstarctBody = car_factory.CreateBody();
        }
        public int RunMaxSpeed()
        {
            return abstractCar.MaxSpeed(abstractEngine);
        }
        public string GetBodyStyle()
        {
            return abstarctBody.BodyType;
        } 
        public override string ToString()
        {
            return abstractCar.Name;
        }
    }
}
