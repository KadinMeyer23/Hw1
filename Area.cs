//Written By Kadin Meyer
// 1/27/2025

using System;
using System.Collections.Generic;

namespace AreaOfTriangle
{
    public class Area
    {
        // Declaration of Class Variables
        private int baseTri = -10000;
        private int heightTri = -10000;


        //Gets and Sets

        public int BaseTri 
        { 
            get { return this.baseTri; } 
            set { this.baseTri = value; }
        }

        public int HeightTri
        {
            get { return this.heightTri; }
            set { this.heightTri = value; }
        }

        //Methods

        public double calcArea() 
        {
           double area = 0;
            area = (BaseTri*HeightTri)/2;
            return area;
        
        }   


    }
}
