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

    public override float CalcularImposto(float rendimento)
    {
      throw new NotImplementedException();
    }
  }
}