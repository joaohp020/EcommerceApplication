using Microsoft.AspNetCore.Authentication;

namespace EcommerceApplication.API.Models
{
    public class AuthenticationModel
    {
        public string identifierUser { get; set; }
        public string pass { get; set; }
        public long? idCompany { get; set; }

        public void Validate()
        {
            var validator = new List<string>(); //AuthenticationValidator();

            var resultadoValidacao = validator;//.Validate(this);

            //if (!resultadoValidacao.IsValid)
            //    throw new Exception(string.Join(";", resultadoValidacao.Errors.Select(e => e.ErrorMessage).ToList()));
        }
    }
}
