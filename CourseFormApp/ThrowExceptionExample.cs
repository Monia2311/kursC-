using CourseFormApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFormApp
{
    public class ThrowExceptionExample
    {
        public void Run()
        {
            MessageBox.Show("Throwing exception.");
            throw new OurOwnException("Do not click that button!");
        }
        
    }
}
