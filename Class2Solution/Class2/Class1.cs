using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    internal class Class1
    {
        int _id;
        string _name;
        
        public int Id
        {
            get
            { 
                return this._id; 
            }
            set
            {
                this._id = value;
            }
        } 
        internal string Name
        {
            get 
            { return this._name; }
                
            set { this._name = value; }
        }
        public double Salary
        {
            get;set;
        }

         

            
    }
}
