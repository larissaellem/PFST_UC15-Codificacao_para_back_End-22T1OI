using UC15_Projetos.Interfaces;
namespace UC15_Projetos.classes
{

  public class PessoaFisica : Pessoa, IPessoaFisica
  {
    public string? cpf { get; set; }
    public DateTime dataNascimento { get; set; }

    public bool ValidarDataNascimento(DateTime dataNascimento)
    {
      DateTime dataAtual = DateTime.Today;
      double anos = (dataAtual - dataNascimento).TotalDays / 365;

      if (anos >= 18)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public bool ValidarDataNascimento(string dataNascimento)
    {

      if (DateTime.TryParse(dataNascimento, out DateTime dataConvertida))
      {
        DateTime dataAtual = DateTime.Today;
        double anos = (dataAtual - dataConvertida).TotalDays / 365;

        if (anos >= 18)
        {
          return true;
        }
      }
      return false;
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