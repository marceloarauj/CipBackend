using System;
using System.Collections.Generic;
using Amazon.S3;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProjetoEscolar.Services;

namespace ProjetoEscolar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileController:ControllerBase
    {
        public FileController(FileService fileService,IConfiguration configuration, IAmazonS3 amazon){
            this.fileService = fileService;
            this.Configuration = configuration;
            this.amazon = amazon;
        }
        private FileService fileService;
        private IConfiguration Configuration;
        private IAmazonS3 amazon;
        [HttpPost]
        public ActionResult AddFile(List<IFormFile> files){
           
            fileService.AddFile(files);
            return Ok();
        }
        [HttpGet]
        public ActionResult Teste(){
            AmazonServiceExample.Testando(amazon);
            return Ok();
        }
    }
    
}