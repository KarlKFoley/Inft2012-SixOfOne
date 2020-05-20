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

        public void SetiFaceone(int iAmountOfOnes)
        {
            iFaceone += iAmountOfOnes;
        }

        public void SetiFaceTwo(int iAmountOfTwos)
        {
            iFaceone += iAmountOfTwos;
        }
        public void SetiFaceThree(int iAmountOfThrees)
        {
            iFaceone += iAmountOfThrees;
        }
        public void SetiFaceFour(int iAmountOfFours)
        {
            iFaceone += iAmountOfFours;
        }
        public void SetiFaceFive(int iAmountOfFives)
        {
            iFaceone += iAmountOfFives;
        }
        public void SetiFaceSix(int iAmountOfSixs)
        {
            iFaceone += iAmountOfSixs;
        }

        public int GetiFaceone()
        {
            return iFaceone;
        }

        public int GetiFaceTwo()
        {
            return iFaceone;
        }
        public int GetiFacethree()
        {
            return iFaceone;
        }
        public int GetiFaceFour()
        {
            return iFaceone;
        }
        public int GetiFaceFive()
        {
            return iFaceone;
        }
        public int GetiFaceSix()
        {
           return iFaceone;
        }
    }
}
