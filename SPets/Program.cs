using System;
using static System.Console;
using SPets.src;

namespace SPets
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(@"Bem-vindes a SPets!
Somos uma pet-shop acessível e inclusa, criada pelos alunos da turma .NET2 da Generation. Aqui, temos desde serviços e produtos até adoção de pets.
Sinta - se à vontade para navegar por nossas opções.
");
            Produtos racao = new Produtos("Ração para cachorro", 50, "123");
            Produtos racao2 = new Produtos("Ração para gatos", 50, "132");
            
            Servicos banho = new Servicos("Banho", 20);
            Servicos tosa = new Servicos("Tosa", 20);

            Animais Teba = new Animais("Teba", "gato");
            Animais Pariston = new Animais("Pariston", "rato");
            Animais Cheadle = new Animais("Cheadle", "cachorro");
            Animais Boa = new Animais("Boa", "Calopsita");


            int opUser;
            
            float carrinho = 0;

            //1-produtos, serviço, adotar, pagar e sair
            do
            {
                WriteLine("\n------ Escolha uma das opções abaixo ------\n" +
                    "Digite 1 para acessar nosso estoque de produtos\n" +
                    "Digite 2 para acessar nossos serviços\n" +
                    "Digite 3 para acessar nossa página de adoção\n" +
                    "Digite 4 para acessar seu carrinho\n" +
                    "Digite 5 para consultas veterinárias\n" +
                    "Digite 6 para sair da nossa página.");
                opUser = int.Parse(ReadLine());
                if (opUser > 6)
                {
                    Clear();
                    WriteLine("Opção inválida!!!\n" +
                        "Escolha uma opção válida entre 1 e 5, por favor.\n");
                    continue;
                }
                switch (opUser)
                {
                    case 1:
                        racao.Prod();
                        racao2.Prod();
                        WriteLine("\nSelecione o produto que deseja comprar.\n" +
                            "\nDigite 1 para ração de cachorro\n" +
                            "Digite 2 para ração de gato");
                        int opRacao = int.Parse(ReadLine());
                        if (opRacao == 1)
                            {
                            WriteLine("\nInforme a quantidade desejada de ração");
                            int qtdRacao = int.Parse(ReadLine());
                            carrinho = carrinho + (racao.Preco * qtdRacao);
                            WriteLine($"Seu carrinho tem o valor de {carrinho}.\n");
                        }
                        else if (opRacao == 2)
                        {
                            WriteLine("\nInforme a quantidade desejada de ração");
                            int qtdRacao2 = int.Parse(ReadLine());
                            carrinho = carrinho + (racao2.Preco * qtdRacao2);
                            WriteLine($"Seu carrinho tem o valor de {carrinho}.\n");
                        }
                        else
                        {//testar continue
                            WriteLine("Opção inválida!!! \n");
                        }
                        break;
                        case 2:
                        banho.Serv();
                        tosa.Serv();
                        WriteLine("\nSelecione o serviço desejado.\n" +
                            "\nDigite 1 para banho\n" +
                            "Digite 2 para tosa");
                        int opServ = int.Parse(ReadLine());
                        carrinho = carrinho + banho.Preco;
                        WriteLine($"\nSeu carrinho tem o valor de {carrinho}.\n");
                        break;

                    case 3:
                        WriteLine("\nVenha ao nosso petshop e conheça seu novo melhor amigo!!!\n" +
                            "Nossos amiguinhos são:");
                        Teba.Adocao();
                        Pariston.Adocao();
                        Cheadle.Adocao();
                        Boa.Adocao();
                        break;
                    case 4:
                        WriteLine($"\nO valor total do seu carrinho é: R$ {carrinho}.\n" +
                            $"Forma de pagamento disponível: PIX\n" +
                            $"Chave: pagamentos@spets.com");
                        break;
                    case 5:
                        WriteLine("\nEm nosso petshop temos: \n" +
                            "A veterinária Ana Lu.\n" +
                            "Para mais informações, contate-nos em nosso WhatsApp - (11) 4002-8922");
                        break;
                    case 6:
                        WriteLine("Volte sempre!!!");
                        break;
                }
            } while (opUser != 6);
        }
    }
}
