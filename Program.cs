using ByteBank.Contas;
using ByteBank.Titular;

//ContaCorrente contaDoAndre = new ContaCorrente();
//contaDoAndre.titular = "André Silva";
//contaDoAndre.numero_agencia = 15;
//contaDoAndre.conta = "1010-X";
//contaDoAndre.saldo = 100;

//Console.WriteLine($"Saldo da conta do André = {contaDoAndre.saldo:c}");

//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = "Maria José";
//contaDaMaria.numero_agencia = 17;
//contaDaMaria.conta = "2534-B";
//contaDaMaria.saldo = 500;

//Console.WriteLine($"Saldo da conta da Maria = {contaDaMaria.saldo:c}");

//contaDoAndre.Transferir(20, contaDaMaria);
//Console.WriteLine($"Saldo do André = {contaDoAndre.saldo:c}");
//Console.WriteLine($"Saldo da Maria = {contaDaMaria.saldo:c}");

//Cliente cliente = new Cliente();
//cliente.nome = "André Silva";
//cliente.cpf = "14370559669";
//cliente.profissao = "Desenvolvedor";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-X";
//conta.numero_agencia = 15;
//conta.saldo = 100;

//Console.WriteLine("Titular = " + conta.titular.nome);
//Console.WriteLine("Cpf = " + conta.titular.cpf);
//Console.WriteLine("Profissao = " + conta.titular.profissao);
//Console.WriteLine("Nº Conta = " + conta.conta);
//Console.WriteLine("Saldo = " + conta.saldo);
//Console.WriteLine("Nº Agência = " + conta.numero_agencia);

//ContaCorrente conta3 = new ContaCorrente();
//conta3.Conta = "12";
//conta3.Numero_agencia = 3;
//conta3.SetSaldo(-10);
//conta3.Depositar(100);
//Console.WriteLine($"Número da Conta: {conta3.Conta}");
//Console.WriteLine($"Saldo Disponível: {conta3.GetSaldo():c}");

//ContaCorrente conta4 = new(18, "123456-B");
//conta4.SetSaldo(500);
//conta4.Titular = new Cliente();

//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.Numero_agencia);

ContaCorrente conta5 = new(13, "123456-C");
conta5.SetSaldo(200);
Console.WriteLine(ContaCorrente.Total_de_contas_criadas);

ContaCorrente conta6 = new(14, "123456-D");
conta6.SetSaldo(300);
Console.WriteLine(ContaCorrente.Total_de_contas_criadas);

ContaCorrente conta7 = new(15, "123456-E");
conta7.SetSaldo(300);
Console.WriteLine(ContaCorrente.Total_de_contas_criadas);

Cliente cliente01 = new("Matheus Antonio", "14370559669", "Desenvolvedor Senior");
Console.WriteLine($"Total de Clientes: {Cliente.Total_de_Clientes}");
Cliente cliente02 = new("Marcos", "12345678941", "testeteste");
Console.WriteLine($"Total de Clientes: {Cliente.Total_de_Clientes}");

