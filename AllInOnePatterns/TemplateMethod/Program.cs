// See https://aka.ms/new-console-template for more information
using TemplateMethod;

Console.WriteLine("Hello, World!");
/*
 * Problem:
 * 
 * Elimizde aynı işlem için aynı adımları aynı sırayla atan binlerce nesne olduğunu düşünün. Tamamen aynı olacak bu işlemi binlerce nesnede tek tek YAPMAMAK için nasıl hareket emeliyiz?
 */

//1. Tüm işlemler aynıysa tek metodu barındıran bir arayüz yaz:

SelectAllProductsDto selectAllProductsDto = new SelectAllProductsDto();
selectAllProductsDto.Run();

SelectAllCustomersDto selectAllCustomersDto = new SelectAllCustomersDto();

selectAllCustomersDto.Run();


