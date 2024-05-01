using PPilhaDinamica;

internal class Program
{
    private static void Main(string[] args)
    {
        PilhaLivro minhapilha = new PilhaLivro();
        int opc;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Principal - Pilha de Livros");
            Console.WriteLine("Opções:");
            Console.WriteLine("1 - Inserir Livro");
            Console.WriteLine("2 - Remover Livro");
            Console.WriteLine("3 - Imprimir Pilha");
            Console.WriteLine("4 - Localizar um Livro");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Informe a opção desejada: < >\b\b");
            opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    minhapilha.push(cadastro_livro());
                    break;
                case 2:
                    minhapilha.pop();
                    break;
                case 3:
                    minhapilha.print();
                    break;
                case 4:
                    Console.WriteLine("Informe o título do seu livro a ser buscado:");
                    minhapilha.printEspecifico(Console.ReadLine());
                    break;
                case 0:
                    Console.WriteLine("Fim do Programa");
                    break;
                default:
                    Console.WriteLine("Opção inexistente!");
                    break;
            }
        } while (opc != 0);
    }
    static Livro cadastro_livro()
    {
        string titulo;
        Console.WriteLine("Informe o título do novo livro:");
        titulo = Console.ReadLine();
        return new Livro(titulo);
    }
}