using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiTowerConsole.Models
{
    public class Tower
    {

        private Disc top;
        private int numberOfDiscs = 0;
        private int numberOfTowers;
        private string positionX;

        public Tower(int numberOfTowers, string positionX)
        {
            top = null;
            this.numberOfTowers = numberOfTowers;
            this.positionX = positionX;
        }

        public void Stack(int id)
        {
            var newDisc = new Disc();

            newDisc.Id = id;
            newDisc.Previous = top;
            top = newDisc;
            numberOfDiscs++;
        }

        public int Unstack()
        {
            Disc deleteDisc = top;
            top = top.Previous;
            numberOfDiscs--;

            return deleteDisc.Id;
        }

        public void Print()
        {
            Disc aux = top;

            while (aux != null)
            {
                Console.WriteLine(positionX);
                Console.WriteLine(aux.Id);
                aux = aux.Previous;
            }

            Console.WriteLine(positionX);
            Console.WriteLine("---------");
            Console.WriteLine(positionX);
            Console.WriteLine($"Tower #: {numberOfTowers}");
            Console.WriteLine();
        }
    }
}
