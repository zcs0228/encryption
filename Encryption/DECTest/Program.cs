using Encryption.DESFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DECTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileIn = @"c:\AccountBox";
            string fileOut = @"c:\AccountBox.bat";
            DESFileEncryption.EncryptFile(fileIn, fileOut, "zcs&wxt00896014");
            //DESFileEncryption.DecryptFile(fileOut, fileIn, "zcs&wxt");
        }
    }
}
