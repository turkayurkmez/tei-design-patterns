// See https://aka.ms/new-console-template for more information
using Decorator;
using System.IO.Compression;
using System.Security.Cryptography;

/*
 * Problem:
 * 
 *  Zaten bellekte oluşturulmuş bir nesneye yeni özellikler kazandırmak istiyorsunuz (elbette bellekte olduğu için miras almanız imkansız)
 */

Message message = new Message();

ZippedMessageDecorator zippedMessageDecorator = new ZippedMessageDecorator(message);
zippedMessageDecorator.ZippedRate = 0.2;
zippedMessageDecorator.Zip();
CryptedMessageDecorator cryptedMessageDecorator = new CryptedMessageDecorator(zippedMessageDecorator);
cryptedMessageDecorator.CryptoAlgorithm = "HMACSHA256";
cryptedMessageDecorator.Crypted();
AddSignMessageDecorator signMessageDecorator = new AddSignMessageDecorator(cryptedMessageDecorator);
signMessageDecorator.AddSign("Türkay Ürkmez");

signMessageDecorator.Send();

 