using UC15_Projetos.classes;

PessoaFisica pessoaFisica = new PessoaFisica();

pessoaFisica.cpf = "123.456.789-00";
pessoaFisica.dataNascimento = new DateTime(1997, 10, 30);
pessoaFisica.nome = "João";
pessoaFisica.rendimento = 1000;
pessoaFisica.endereco = "Rua 1, 123";

Console.WriteLine($"Bem vindo {pessoaFisica.nome}! Seu CPF é {pessoaFisica.cpf} e sua data de nascimento é {pessoaFisica.dataNascimento.ToUniversalTime()}.");

Console.WriteLine($"Você pagará um imposto no valor de R$ {pessoaFisica.CalcularImposto()}.");

pessoaFisica.rendimento = 4000;

Console.WriteLine($"Você pagará um imposto no valor de R$ {pessoaFisica.CalcularImposto()}.");