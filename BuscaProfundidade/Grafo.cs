using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BuscaProfundidade
{
	public class Grafo
	{
		public List<int>[] vertices = new List<int>[10];
		public int numeroVertices { get; set; }
		public Grafo(int numVertices)
		{
			for (int i = 0; i < numVertices; i++)
				vertices[i] = new List<int>();

			numeroVertices = numVertices;
			criarGrafo();
		}

		public void addArestas(int i, params int[] j)
		{
			foreach (var item in j)
			{
				vertices[i].Add(item);
			}
		}
		public void IMPRIMIR()
		{
			int a = 0;
			foreach (var item in vertices)
			{
				if (a < numeroVertices)
				{
					Console.WriteLine("VERTICE " + LETRA(a) + " = " + a);
					foreach (var s in vertices[a])
					{
						Console.WriteLine("---> " + LETRA(s) + " = " + s);
					}
					Console.WriteLine("\n\n\n\n");
					a++;
				}
			}
		}
		//Cria o Digrafo 'G'
		public void criarGrafo()
		{
			addArestas(0, 1, 3);//A -> B, A ->D
			addArestas(1, 4);
			addArestas(2, 4, 5);
			addArestas(3, 1);
			addArestas(4, 3);
			addArestas(5, 5);
			IMPRIMIR();
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
	}
}
