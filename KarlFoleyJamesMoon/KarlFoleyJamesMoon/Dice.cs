using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlFoleyJamesMoon
{
    // Karl Foley and James Moon, May 2020
    // Dice class used to count the amount of dice rolled
    class Dice
    {
        private int iFaceone, iFaceTwo, iFacethree, iFaceFour, iFaceFive, iFaceSix;

        #region Public properties
        //Only readable properties
        //Setting them is done though a incrmentor methord or in constructor.
        public int iOne
        {
            get
            {
                return iFaceone;
            }
        }
        public int iTwo
        {
            get
            {
                return iFaceTwo;
            }
        }
        public int ithree
        {
            get
            {
                return iFacethree;
            }
        }
        public int iFour
        {
            get
            {
                return iFaceFour;
            }
        }
        public int iFive
        {
            get
            {
                return iFaceFive;
            }
        }
        public int iSix
        {
            get
            {
                return iFaceSix;
            }
        }
        #endregion
        #region Constructor
        public Dice()
        {
            iFaceone = 0;
            iFaceTwo = 0;
            iFacethree = 0;
            iFaceFour = 0;
            iFaceFive = 0;
            iFaceSix = 0;
        }
        #endregion
        #region Increment methods for each varible
        public void IncrementFaceOne()
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
        #endregion
    }
}
