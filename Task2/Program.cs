
using Task2;

var photobook = new Photobook(16);
System.Console.WriteLine(photobook.GetNumberPages());

var photoBookTest = new PhotoBookTest(24);
System.Console.WriteLine(photoBookTest.GetNumberPages());

var bigPhotoBook = new BigPhotoBook(64);
System.Console.WriteLine(bigPhotoBook.GetNumberPages());