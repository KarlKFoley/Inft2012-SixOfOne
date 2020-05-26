using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlFoleyJamesMoon
{
    class Dice
    {
        private int iFaceone, iFaceTwo, iFacethree, iFaceFour, iFaceFive, iFaceSix;

        public Dice()
        {
            iFaceone = 0;
            iFaceTwo = 0;
            iFacethree = 0;
            iFaceFour = 0;
            iFaceFive = 0;
            iFaceSix = 0;
        }

        public void IncrementFaceone()
        {
            iFaceone++;
        }

        public void IncrementFaceTwo()
        {
            iFaceTwo ++;
        }
        public void IncrementFaceThree()
        {
            iFacethree ++;
        }
        public void IncrementFaceFour()
        {
            iFaceFour ++;
        }
        public void IncrementFaceFive()
        {
            iFaceFive ++;
        }
        public void IncrementFaceSix()
        {
            iFaceSix ++;
        }

        public int GetiFaceone()
        {
            return iFaceone;
        }

        public int GetiFaceTwo()
        {
            return iFaceTwo;
        }
        public int GetiFacethree()
        {
            return iFacethree;
        }
        public int GetiFaceFour()
        {
            return iFaceFour;
        }
        public int GetiFaceFive()
        {
            return iFaceFive;
        }
        public int GetiFaceSix()
        {
           return iFaceSix;
        }
    }
}
