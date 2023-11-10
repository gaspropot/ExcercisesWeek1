using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcercisesWeek1.Assignment2
{
    public class PhotoBook
    {
        private int numPages { get; set; }

        public PhotoBook()
        {
            numPages = 16;
        }

        public PhotoBook(int numberOfPages)
        {
            numPages = numberOfPages;
        }

        public int GetNumberPages()
        {
            return numPages;
        }
    }
}
