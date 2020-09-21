using System;

namespace BuscaProfundidade
{
    class Program
    {
        static void Main(string[] args)
        {
            //O grafo está sendo criado na classe grafo manualmente
            //Para escolher seu grafo entre na classe grafo e faça seu grafo

            Grafo grafo = new Grafo(6);//Coloque a quantidade de vertice que possir o grafo

            BuscaEmProfundidade solucao = new BuscaEmProfundidade(grafo);
            solucao.buscaProfundidade();

        }
    }
}
