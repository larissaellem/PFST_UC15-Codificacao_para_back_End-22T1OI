using UC15_Projetos.Interfaces;
namespace UC15_Projetos.classes
{

  public class PessoaJuridica : Pessoa, IPessoaJuridica
  {
    public string? cnpj { get; set; }
    public string? razaoSocial { get; set; }

    public bool ValidarCnpj(string cnpj)
    {
      throw new NotImplementedException();
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