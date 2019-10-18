using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServiceModels.Validators
{
    public class BaseValidators
    {


        public List<ValidationError> RequiredObjectValidate<T>(T obj)
        {
            List<ValidationError> errorList = null;

            var context = new ValidationContext(obj, null, null);
            var result = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(obj, context, result, true);

            if (!isValid)
            {
                errorList = new List<ValidationError>();

                foreach (var str in result)
                {
                    errorList.Add(new ValidationError()
                    {
                        Error = str.ErrorMessage.ToString(),
                        FieldName = str.MemberNames
                    });
                }
            }

            return errorList;

        }


    }

    public class ValidationError
    {
        public ValidationError()
        {
        }

        public string Error { get; set; }
        public IEnumerable<string> FieldName { get; set; }
    }
}
