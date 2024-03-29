﻿using AbstractFactory.Classes.Products;
using AbstractFactory.Interfaces.Factories;
using AbstractFactory.Interfaces.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes.Factories
{
    // Each Concrete Factory has a corresponding product variant.
    public class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}
