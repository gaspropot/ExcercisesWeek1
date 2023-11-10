using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcercisesWeek1.Assignment2
{
    public class BigPhotoBook
    {
        private int numPages { get; set; }

        public BigPhotoBook()
        {
            numPages = 64;
        }

        public int GetNumberPages()
        {
            return numPages;
        }
    }
}
