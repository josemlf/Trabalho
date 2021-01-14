using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMercado
{
    class Funcionario
    {
        //Atributos
        string nome;

        //Construtor
        public Funcionario(string nome)
        {
            this.nome = nome;
        }

        //GET e SET 
        public string Nome { get => nome; set => nome = value; }

        //METODOS
        public void Vender() 
        {
            Console.WriteLine("Salvar o erro");
            Console.WriteLine("Provocar o erro :(");
        }
    }
}
