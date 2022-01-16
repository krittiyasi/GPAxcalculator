using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPAxcalculator
{
    internal class GPAcalculator
    {
        private double sum = 0;
        private int n = 0;
        private double Max = 0;
        private double Min = 0;
        private string Maxname = "";
        private string Minname = "";
        private string ALLDATA = "";
        /// <summary>
        /// Add new to class
        /// </summary>
        /// <param name="gpa">gpa score</param>
        public void addGPA(double gpa, string name)
        {
            this.sum += gpa;
            this.n++;
            this.ALLDATA += name + " " + gpa + "\r\n";


            if (this.Max < gpa)
            {  
                this.Max = gpa;
                this.Maxname = name;
            }
            if (this.Max > gpa)
            {
                this.Min = gpa;
                this.Minname = name;
            }
        }
        /// <summary>
        /// Return GPAx of class
        /// </summary>
        /// <returns></returns>
        public double getGPAX()
        {
            double result = this.sum / this.n;
            return result;
        }
        public double getMax()
        {
            return this.Max;
        }
        public string getMaxName()
        {
            return Maxname;
        }
        public string getALLDATA()
        {
            return ALLDATA;
        }
        public double getMin()
        {
            return this.Min;
        }
        public string getMinName()
        {
            return Minname;
        }


    }
}
