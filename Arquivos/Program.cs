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



// pj
PessoaJuridica pessoaJuridica = new PessoaJuridica();
pessoaJuridica.cnpj = "13.456.789/0001-00";
pessoaJuridica.razaoSocial = "Empresa Fantasia";
pessoaJuridica.rendimento = 1000;
pessoaJuridica.endereco = new Endereco();
pessoaJuridica.endereco.logradouro = "Rua 20";
pessoaJuridica.endereco.numero = 882;
pessoaJuridica.endereco.complemento = "4 Andar, sala 10";
pessoaJuridica.endereco.cep = "12345-678";
pessoaJuridica.endereco.endComercial = true;

Console.WriteLine($"\n=================\nBem vindo {pessoaJuridica.razaoSocial}! Seu CNPJ é {pessoaJuridica.cnpj}.");
Console.WriteLine(@$"
RELATÓRIO DE PESSOA JURÍDICA
Razao Social: {pessoaJuridica.razaoSocial}
CNPJ: {pessoaJuridica.cnpj}
Rendimento: {pessoaJuridica.rendimento}
Endereço: {pessoaJuridica.endereco.logradouro}, {pessoaJuridica.endereco.numero} - {pessoaJuridica.endereco.complemento}
Endereço Comercial: {pessoaJuridica.endereco.endComercial}
CEP: {pessoaJuridica.endereco.cep}
Cpnj Valido: {pessoaJuridica.ValidarCnpj()}
");

