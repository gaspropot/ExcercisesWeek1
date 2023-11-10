using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcercisesWeek1.Assignment2
{
    public class PhotoBookTest
    {
        public static void Main()
        {
            var defaultPhotoBook = new PhotoBook();
            Console.WriteLine(defaultPhotoBook.GetNumberPages());

            var customPhotoBook = new PhotoBook(55);
            Console.WriteLine(customPhotoBook.GetNumberPages());

            var bigPhotoBook = new BigPhotoBook();
            Console.WriteLine(bigPhotoBook.GetNumberPages());
        }
    }
}
