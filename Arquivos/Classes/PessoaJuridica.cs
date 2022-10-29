using System.Text.RegularExpressions;
using UC15_Projetos.Interfaces;
namespace UC15_Projetos.classes
{

  public class PessoaJuridica : Pessoa, IPessoaJuridica
  {
    public string? cnpj { get; set; }
    public string? razaoSocial { get; set; }

    public bool ValidarCnpj()
    {
      if (this.cnpj == null)
      {
        return false;
      }

      bool cnpjValido = Regex.IsMatch(this.cnpj, @"^(\d{14}) | (\d{2}.\d{3}.\d{3}/\d{4}-\d{2})$");

      if (cnpjValido)
      {
        string subStringCnpj14 = this.cnpj.Substring(8, 4);

        if (subStringCnpj14 == "0001")
        {
          return true;
        }

      }
      string subStringCnpj18 = this.cnpj.Substring(11, 4);

      if (subStringCnpj18 == "0001")
      {
        return true;
      }

      return false;
    }

    public override float CalcularImposto()
    {
      if (this.rendimento <= 3000)
      {
        return this.rendimento * 0.03f;
      }

      else if (this.rendimento > 3000 && this.rendimento <= 6000)
      {
        return this.rendimento * 0.05f;
      }

      else if (this.rendimento > 6000 && this.rendimento <= 10000)
      {
        return this.rendimento * 0.07f;
      }

      else
      {
        return this.rendimento * 0.09f;
      }
    }
  }
}