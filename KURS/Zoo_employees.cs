using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KURS
{
    abstract class Zoo_employees
    {
        public bool Cage_acces { get; set; }
        public string Profession { get; set; }
        public string Name { get;  }
        public int Age { get;  }
        public string Sex { get;  }
        public double Salary { get; set; }
        public static int Counter { get; }
    }
    class Veterinarial : Zoo_employees
    {
        Veterinarial() : base()
        {
            Cage_acces = true;
            Profession = "Ветеринар";
        }
        public void medical_examination(Animals animal)
        {
            animal.card.Weight = animal.Weight;
            animal.card.Height = animal.Height;
            animal.card.Development = animal.Development;
        }
    }
    class Cleaner : Zoo_employees
    {
        Cleaner() : base()
        {
            Cage_acces = true;
            Profession = "Уборщик";
        }
        public void Clean()
        {

        }
    }
    class Trainer : Zoo_employees
    {
        Trainer() : base()
        {
            Cage_acces = true;
            Profession = "Дрессировщик";
        }
        public void Train()
        {

        }
    }
    class Builder_repairman : Zoo_employees
    {
        Builder_repairman() : base()
        {
            Cage_acces = false;
            Profession = "Строитель-ремонтник";
        }
        public void Repair()
        {
            
        }
    }
    class Administrator : Zoo_employees
    {
        Administrator() : base()
        {
            Cage_acces = false;
            Profession = "Aдминистратор";
        }
    }
}
