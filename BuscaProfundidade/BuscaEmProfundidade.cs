using System;
using System.Collections.Generic;
using System.Text;

namespace BuscaProfundidade
{
    public class BuscaEmProfundidade
    {
		public static byte branco = 0;
		public static byte cinza = 1;
		public static byte preto = 2;
		private int[] d, t, antecessor;
		private String saida;
		private Grafo grafo;
		private int TEMPO = 0;

		public BuscaEmProfundidade(Grafo g)
		{
			this.grafo = g;
			int n = grafo.numeroVertices;
			d = new int[n];
			t = new int[n];
			antecessor = new int[n];
			saida = "";
		}


	 ///Metodo auxiliar da busca em profundidade.
	 // u
	// tempo

		private int visitaDfs(int u, int tempo, int[] cor)
		{
			Console.WriteLine("Tempo " + tempo);

			Console.WriteLine(" Visitando o vertice: " + LETRA(u) + " == " + u);
			saida += u + ", ";  //Armazena a ordem de visita dos vertices em uma string
			cor[u] = cinza;
			this.d[u] = ++tempo;
			if (grafo.vertices[u].Count != 0)
			{
				List<int> listaAdj = grafo.vertices[u];
				foreach (int v in listaAdj)
				{
					if (cor[v] == branco)
					{
						this.antecessor[v] = u;
						tempo = this.visitaDfs(v, tempo, cor);
					}
				}
			}
			Console.WriteLine("MAIS " +tempo);
			cor[u] = preto;
			this.t[u] = ++tempo;
			return tempo;
		}

		//Metodo da busca de profundidade.
		public void buscaProfundidade()
		{
			int tempo = 0;
			int[] cor = new int[this.grafo.numeroVertices];
			for (int u = 0; u < this.grafo.numeroVertices; u++)
			{
				cor[u] = branco;
				this.antecessor[u] = -1;
			}
			for (int u = 0; u < grafo.numeroVertices; u++)
			{
				if (cor[u] == branco)
					tempo = this.visitaDfs(u, tempo, cor);
			}
			Console.WriteLine("\n Ordem de visita: ");
			string a = saida.Substring(0, saida.LastIndexOf(""));
			string[] splitando = saida.Split(',');
			for (int i = 0; i < splitando.Length - 1; i++)
			{
				Console.Write(LETRA(int.Parse(splitando[i])));
				if(i != splitando.Length - 2)
				Console.Write(", ");

			}
			Console.WriteLine();

			Console.WriteLine(saida.Substring(0, saida.LastIndexOf(",")));
			Console.WriteLine("\n");
		}

		public static string LETRA(int pos)
		{
			if (pos > -1)
			{
				string palavra = "ABCDEFGHIJKLMNOPQRSTUVXWYZ";
				return palavra.ToCharArray()[pos].ToString();
			}
			else
				return "-1";
		}
		public static string CORES(int s) 
		{
			string cor = "";
			if (s == 0)
			{
				cor = "Branco";
			}
			else if (s == 1)
			{
				cor = "Cinza";
			}
			else
				cor = "Preto";

			return cor;
		}
	}
}
