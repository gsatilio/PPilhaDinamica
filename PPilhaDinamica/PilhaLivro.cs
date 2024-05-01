namespace PPilhaDinamica
{
    internal class PilhaLivro
    {
        Livro topo;
        int contador;

        public PilhaLivro()
        {
            topo = null;
            //Console.WriteLine("Pilha criada com sucesso!");
        }
        public void push(Livro aux)
        {
            if (vazia() == true)
            {
                topo = aux;
            }
            else
            {
                aux.setAnterior(topo);
                topo = aux;
            }
            contador++;
        }
        bool vazia()
        {
            if (topo == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void print()
        {
            Livro aux = topo;
            if (vazia())
            {
                Console.WriteLine("Pilha Vazia!");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.getAnterior();
                } while (aux != null);
                Console.WriteLine("Fim da impressão! Existem " + contador +" livros cadastrados!");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
        public void printEspecifico(string livronome)
        {
            int contador_aux = 0;
            bool encontrado = false;
            Livro aux = topo;
            if (vazia())
            {
                Console.WriteLine("Pilha Vazia! Não há como buscar.");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                contador_aux = contador;
                do
                {
                    contador_aux--;
                    if (aux.getTitulo() == livronome)
                    {
                        encontrado = true;
                        Console.WriteLine("Livro localizado na posição: " + contador_aux);
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                    }
                    aux = aux.getAnterior();
                } while (aux != null);
                if (!encontrado)
                {
                    Console.WriteLine("Livro não localizado!");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
        public void pop()
        {
            if (vazia())
            {
                Console.WriteLine("Pilha Vazia! Impossível Remover!");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                contador--;
                topo = topo.getAnterior();
            }
        }
    }
}
