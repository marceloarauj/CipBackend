using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace ProjetoEscolar.Services
{
    public class FileService
    {
        
        public void AddFile(List<IFormFile> files){

            bool exists = Directory.Exists("C:\\avonale");
            Console.Write(exists);
        }
    }
}