
using ConsoleEstudos02.SetorEstoque;

Estoque estoque = new Estoque("A1B");
Estoque estoque2 = new Estoque("A2B");
Estoque estoque3 = new Estoque("A3B");
Estoque estoque4 = new Estoque("A4B");
Estoque estoque5 = new Estoque("A5B");
Estoque estoque6 = new Estoque("A6B");


estoque.guardarPedaco();
estoque.guardarPedaco();
estoque2.guardarPedaco();
estoque2.guardarPedaco();
estoque3.guardarPedaco();
estoque4.guardarPedaco();
estoque5.guardarPedaco();
estoque5.guardarPedaco();
estoque6.guardarPedaco();
estoque6.guardarPedaco();
estoque4.guardarPedaco();
estoque3.guardarPedaco();
estoque2.guardarPedaco();
estoque2.guardarPedaco();


Console.WriteLine(estoque.listarQuantidadeLivre());
Console.WriteLine(estoque2.listarQuantidadeLivre());
Console.WriteLine(estoque3.listarQuantidadeLivre());
Console.WriteLine(estoque4.listarQuantidadeLivre());
Console.WriteLine(estoque5.listarQuantidadeLivre());
Console.WriteLine(estoque6.listarQuantidadeLivre());



