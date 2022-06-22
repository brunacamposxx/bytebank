// define qual namespace está sendo usado
// assim consigo acessar a classe 'ContaCorrente'
using ByteBank;
using ByteBank.Titular;

Console.WriteLine("Boas Vindas ao banco ByteBank!");

// cria um novo objeto da classe ContaCorrente. Instancia o objeto.
ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Henrique Nogueira"; // acessa a propriedade da classe definida como public
conta1.conta = "10124-X";
conta1.numero_agencia = 1000;
conta1.nome_agencia = "Agencia Digital";
conta1.saldo = 100;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Bruna Campos"; // acessa a propriedade da classe definida como public
conta2.conta = "10125-X";
conta2.numero_agencia = 1000;
conta2.nome_agencia = "Agencia Digital";
conta2.saldo = 100;

Console.WriteLine("Saldo pre transferencia da bruna " + conta2.saldo);
Console.WriteLine("Saldo pre transferencia de henrique " + conta1.saldo);
bool transferencia = conta1.Transferir(50, conta2);
Console.WriteLine("Transferencia realizada com sucesso? " + transferencia);
Console.WriteLine("Saldo pos transferencia da bruna " + conta2.saldo);
Console.WriteLine("Saldo pos transferencia de henrique " + conta1.saldo);

Cliente cliente = new Cliente();
cliente.nome = "Scott";
cliente.CPF = "12345678910";
cliente.profissao = "Rei";

Cliente sarah = new Cliente();
Console.WriteLine("Olá");

ContaCorrente conta3 = new ContaCorrente();
conta3.titular = cliente;
conta3.conta = "264829-x";
conta3.numero_agencia = 35;
conta3.nome_agencia = "Agencia Digital";

Console.WriteLine("Nome do cliente: " + cliente.nome);
Console.WriteLine(conta3.titular.nome);

//string titular = "Bruna Campos";
//string conta = "10123-x";
//int numero_agencia = 1000;
//string nome_agencia = "Agencia Digital";
//double saldo = 93.50;

//Console.WriteLine($"Titular: { conta1.titular}");
//Console.WriteLine("Conta: " + conta1.conta);
//Console.WriteLine("Número da Agencia: " + conta1.numero_agencia);
//Console.WriteLine("Nome da Agencia: " + conta1.nome_agencia);
//Console.WriteLine("Saldo atual: " + conta1.saldo);



Console.ReadKey();