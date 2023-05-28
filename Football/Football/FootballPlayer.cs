using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class FootballPlayer : Person
    {
        private int number;
        private double height;

        public FootballPlayer(string name, int age) : base(name, age)
        {
        }

        public int GetNumber()
        {
            return number;
        }

        public override string ToString()
        {
            return "FootballPlayer{" +
                "number=" + number +
                ", height=" + height +
                ", age=" + GetAge() +
                ", name=" + GetName() +
                '}';
        }

        public void SetNumber(int number)
        {
            this.number = number;
        }

        public double GetHeight()
        {
            return height;
        }

        public void SetHeight(double height)
        {
            this.height = height;
        }
    }
}
