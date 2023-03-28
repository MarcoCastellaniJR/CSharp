


using ConsoleEstudos.ContaCorrente;
using ConsoleEstudos.PessoaFisicas;

PessoaFisica pessoa1 = new PessoaFisica("098.809.098-09", "Marco", "Castellani");


ContaCorrente c1 = new ContaCorrente("MA", "Itapira");
c1.titular = pessoa1;
Console.WriteLine(c1.resumoDaContaCriada());
Console.WriteLine(pessoa1.apresentacaoPessoaFisica());

Console.WriteLine(c1.titularDaConta());