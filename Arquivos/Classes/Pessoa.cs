using UC15_Projetos.Interfaces;
namespace UC15_Projetos.classes
{

  public abstract class Pessoa : IPessoa
  {
    public string? nome { get; set; }

    public int rendimento { get; set; }

    public string? endereco { get; set; }

    public abstract float CalcularImposto();
  }
}