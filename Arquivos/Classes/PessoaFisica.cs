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

    public override float CalcularImposto()
    {
      if (this.rendimento <= 1500)
      {
        return 0;
      }

      else if (this.rendimento > 1500 && this.rendimento <= 3500)
      {
        return this.rendimento * 0.02f;
      }

      else if (this.rendimento > 3500 && this.rendimento <= 6000)
      {
        return this.rendimento * 0.035f;
      }

      else
      {
        return this.rendimento * 0.05f;
      }
    }
  }
}