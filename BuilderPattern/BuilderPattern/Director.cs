﻿namespace BuilderPattern
{
    public class Director
    {
        private AbstractBuilder _AbstractBuilder = null;

        public Director(AbstractBuilder builder)
        {
            this._AbstractBuilder = builder;
        }

        public Car GetCar()
        {
            this._AbstractBuilder.Engine();
            this._AbstractBuilder.Wheels();
            this._AbstractBuilder.Light();

            return this._AbstractBuilder.Car();
        }
    }
}