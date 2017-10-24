using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ValidandoComDataAnnotations
{
    public static class Validacao
    {
        public static IEnumerable<ValidationResult> getValidationErros(object obj)
        {
            var resultadoValidacao = new List<ValidationResult>();
            var contexto = new ValidationContext(obj, null, null);
            Validator.TryValidateObject(obj, contexto, resultadoValidacao, true);
            return resultadoValidacao;
        }
    }
}
