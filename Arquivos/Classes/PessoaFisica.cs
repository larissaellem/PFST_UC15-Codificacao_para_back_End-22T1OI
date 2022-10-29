using UC15_Projetos.Interfaces;
namespace UC15_Projetos.classes
{

  public class PessoaFisica : Pessoa, IPessoaFisica
  {
    public string? cpf { get; set; }
    public DateTime dataNascimento { get; set; }

    public bool ValidarDataNascimento(DateTime dataNascimento)
    {
      throw new NotImplementedException();
    }

    public override float CalcularImposto(float rendimento)
    {
      throw new NotImplementedException();
    }
  }
}