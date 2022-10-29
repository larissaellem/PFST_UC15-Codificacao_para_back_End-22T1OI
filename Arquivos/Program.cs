using UC15_Projetos.classes;

PessoaFisica pessoaFisica = new PessoaFisica();

pessoaFisica.cpf = "123.456.789-00";
pessoaFisica.dataNascimento = new DateTime(1997, 10, 30);
pessoaFisica.nome = "João";
pessoaFisica.rendimento = 1000;
pessoaFisica.endereco = new Endereco();
pessoaFisica.endereco.logradouro = "Rua 1";
pessoaFisica.endereco.numero = 1;
pessoaFisica.endereco.complemento = "Casa 1";
pessoaFisica.endereco.endComercial = false;
pessoaFisica.endereco.cep = "12345-678";

Console.WriteLine($"Bem vindo {pessoaFisica.nome}! Seu CPF é {pessoaFisica.cpf} e sua data de nascimento é {pessoaFisica.dataNascimento.ToUniversalTime()}.");

Console.WriteLine($"Você pagará um imposto no valor de R$ {pessoaFisica.CalcularImposto()}.");

pessoaFisica.rendimento = 4000;

Console.WriteLine($"Você pagará um imposto no valor de R$ {pessoaFisica.CalcularImposto()}.");

Console.WriteLine($"Sua data de nascimento é {pessoaFisica.dataNascimento} e essa data é válida? (date) {pessoaFisica.ValidarDataNascimento(pessoaFisica.dataNascimento)}.");

Console.WriteLine($"Sua data de nascimento é 02/01/2016 e essa data é válida? (string) {pessoaFisica.ValidarDataNascimento("02/01/2016")}.");

Console.WriteLine(@$"
RELATÓRIO DE PESSOA FÍSICA
Nome: {pessoaFisica.nome}
CPF: {pessoaFisica.cpf}
Data de nascimento: {pessoaFisica.dataNascimento.ToUniversalTime()}
Rendimento: {pessoaFisica.rendimento}
Endereço: {pessoaFisica.endereco.logradouro}, {pessoaFisica.endereco.numero} - {pessoaFisica.endereco.complemento}
CEP: {pessoaFisica.endereco.cep}
Maior de idade? {pessoaFisica.ValidarDataNascimento(pessoaFisica.dataNascimento)}
");