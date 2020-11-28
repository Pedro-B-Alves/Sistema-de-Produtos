using System;

namespace Sistema_de_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadastrar = "n";
            int contador = 0;
            string sair = "n";
            string[] nome = new string[10];
            float[] preco = new float[10];
            bool[] promocao = new bool[10];
            string[] nomeUsuario = new string[300];
            string[] email = new string[300];
            string[] senha = new string[300];
            Console.Clear();
            nomeUsuario[0]  = "admin";
            email[0] = "admin@gmail.com";
            senha[0] = "admin123";
            string loginEmail;
            string loginSenha;
            string permicaoEmail = "negado";
            string permicaoSenha = "negado";

                    Console.WriteLine("Digite o seu e-mail");
                    loginEmail = Console.ReadLine();
                    for (var i = 0; i < 300; i++){
                        if(email[i] == loginEmail){
                            permicaoEmail = "permitido";
                        }
                        
                    }
                    Console.WriteLine("Digite a sua senha");
                    loginSenha = Console.ReadLine();
                    for (var i = 0; i < 300; i++){
                        if(senha[i] == loginSenha){
                            permicaoSenha = "permitido";
                        }
                    }

                    if(permicaoEmail == "permitido" && permicaoSenha == "permitido"){
                        for (var i = 0; i < 300; i++){
                            if(loginEmail == email[i]){
                                Console.WriteLine($"Bem-vindo {nomeUsuario[i]}");
                                if(loginEmail == "admin@gmail.com"){
                                    Console.WriteLine($"Deseja fazer o cadastro de alguém s/n");
                                    string fazercadastro = Console.ReadLine();
                                    if(fazercadastro == "s"){
                                        for (var j = 1; j < 300; j++){
                                            Console.WriteLine("Digite o seu Nome de Usuário");
                                            nomeUsuario[j] = Console.ReadLine();
                                            Console.WriteLine("Digite o seu e-mail");
                                            email[j] = Console.ReadLine();
                                            Console.WriteLine("Digite o sua senha");
                                            senha[j] = Console.ReadLine();
                                            Console.WriteLine("Dejesa cadastrar mais pessoas s/n");
                                            string cadastrarMais = Console.ReadLine();
                                            if(cadastrarMais == "n"){
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }else{
                        Console.WriteLine("Acesso negado");
                        return;
                        
                    }
                    Console.WriteLine("Deseja fazer login como usuário s/n");
                    string novoLogin = Console.ReadLine();
                    if(novoLogin == "s"){
                        Console.WriteLine("Digite o seu e-mail");
                        loginEmail = Console.ReadLine();
                        for (var i = 0; i < 300; i++){
                            if(email[i] == loginEmail){
                                permicaoEmail = "permitido";
                            }
                        
                        }
                        Console.WriteLine("Digite a sua senha");
                        loginSenha = Console.ReadLine();
                        for (var i = 0; i < 300; i++){
                            if(senha[i] == loginSenha){
                                permicaoSenha = "permitido";
                            }
                        }
                        if(permicaoEmail == "permitido" && permicaoSenha == "permitido"){
                        for (var i = 0; i < 300; i++){
                            if(loginEmail == email[i]){
                                Console.WriteLine($"Bem-vindo {nomeUsuario[i]}");
                                if(loginEmail == "admin@gmail.com"){
                                    Console.WriteLine($"Deseja fazer o cadastro de alguém s/n");
                                    string fazercadastro = Console.ReadLine();
                                    if(fazercadastro == "s"){
                                        for (var j = 1; j < 300; j++){
                                            Console.WriteLine("Digite o seu Nome de Usuário");
                                            nomeUsuario[j] = Console.ReadLine();
                                            Console.WriteLine("Digite o seu e-mail");
                                            email[j] = Console.ReadLine();
                                            Console.WriteLine("Digite o sua senha");
                                            senha[j] = Console.ReadLine();
                                            Console.WriteLine("Dejesa cadastrar mais pessoas s/n");
                                            string cadastrarMais = Console.ReadLine();
                                            if(cadastrarMais == "n"){
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }else{
                        Console.WriteLine("Acesso negado");
                        return;
                        
                    }
                    }
                    
                    do
                        {
                            Console.WriteLine("Menu");
                            Console.WriteLine("Digite o número da parte que você quer");
                            Console.WriteLine("[1] - Cadastrar Produto");
                            Console.WriteLine("[2] - Listar Produtos");
                            Console.WriteLine("[0] - Sair");
                            int opcao = int.Parse(Console.ReadLine());
                            switch(opcao){
                                case 1:
                                    do  
                                        {
                                            if(contador < 10){
                                            Console.WriteLine($"Digite o nome do {contador+1}º produto");
                                            nome[contador] = Console.ReadLine();
                                            Console.WriteLine($"Digite o preço do {contador+1}º produto");
                                            preco[contador] = float.Parse(Console.ReadLine());
                                            Console.WriteLine($"Digite se o {contador+1}º produto está em promoção True/False");
                                            promocao[contador] = bool.Parse(Console.ReadLine());
                                            Console.WriteLine("Deseja cadastrar mais um? s/n");
                                            cadastrar = Console.ReadLine();
                                            contador++;
                                            }else{
                                                Console.WriteLine("Limite excedido");
                                                break;
                                            }
                                        }while(cadastrar != "n");
                                    break;
                                case 2:
                                    for (var i = 0; i < contador; i++){
                                        Console.WriteLine($"{i+1}º produto");
                                        Console.WriteLine($"Possui o nome {nome[i]} e o preço de {preco[i]} Reais.Estando com a promoção em {promocao[i]}");
                                    }
                                    break;
                                case 0:
                                    Console.WriteLine("Esperamos te ver novamente");
                                    sair = "s";
                                    break;
                                default:
                                    Console.WriteLine("Você digitou uma opção inválida");
                                    break;  
                            }
                        }while(sair == "n");
        }
    }
}
