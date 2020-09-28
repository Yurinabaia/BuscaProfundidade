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
		public List<string> NOMESVERTICE = new List<string>();
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
						NOMESVERTICE.Add(LETRA(a) + "-" + LETRA(s));
						Console.WriteLine("---> " + LETRA(s) + " = " + s);
					}
					Console.WriteLine("\n\n\n\n");
					a++;
				}
			}

			foreach (var item in NOMESVERTICE)
			{
				Console.WriteLine(item);
			}
		}


		//Cria o Digrafo 'G'
		public void criarGrafo()
		{
			addArestas(0, 1, 3);//A -> B, A ->D
			addArestas(1, 2, 4);
			addArestas(2, 4);
			addArestas(3, 5);
			addArestas(4, 0);
			addArestas(4, 5);
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
