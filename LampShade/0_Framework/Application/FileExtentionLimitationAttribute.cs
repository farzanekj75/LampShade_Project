using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Framework.Application
{
    public class FileExtentionLimitationAttribute : ValidationAttribute, IClientModelValidator
    {
        private readonly string[] _validExtention;

        public FileExtentionLimitationAttribute(string[] validExtention)
        {
            _validExtention = validExtention;
        }
        public override bool IsValid(object value)
        {
            var file = value as IFormFile;
            if(file == null) return true;
            var fileExtention = Path.GetExtension(file.FileName);
            return _validExtention.Contains(fileExtention);
        }

        public void AddValidation(ClientModelValidationContext context)
        {
          //  context.Attributes.Add("data-va1", "true");
            context.Attributes.Add("data-va1-fileExtentionLimit", ErrorMessage);
        }
    }
}
