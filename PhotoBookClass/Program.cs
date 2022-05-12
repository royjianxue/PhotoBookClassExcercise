using System;

namespace PhotoBookClass
{
    class Program
    {
        static void Main(string[] args)
        {
            PhotoBook photoBook = new PhotoBook();
            Console.WriteLine("There are {0} pages in the photobook.", photoBook.GetNumberPages());

            PhotoBook photoBook1 = new PhotoBook(24);
            Console.WriteLine("There are {0} pages in the photobook.", photoBook1.GetNumberPages());

            BigPhotoBook photoBook2 = new BigPhotoBook();
            Console.WriteLine("There are {0} pages in the photobook.", photoBook2.GetNumberPages());

            Console.ReadLine();
        }
    }

    public class PhotoBook
    {

        public PhotoBook()
        {
            this.numPages = 16;
        }

        public PhotoBook(int numPages)
        {
            this.numPages = numPages;
        }

        protected int numPages;
        public int GetNumberPages()
        {
            return numPages;
        }
    }

    public class BigPhotoBook : PhotoBook
    {
        public BigPhotoBook()
        {
            numPages = 64;

        }



    }






}
