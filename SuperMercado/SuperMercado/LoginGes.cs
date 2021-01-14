using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMercado
{
    class LoginGes
    {
        public string nome;
        public int id;
        public string pass;

        public LoginGes(string nome, int id, string pass)
        {
            this.nome = nome;
            this.id = id;
            this.pass = pass;
        }

        public string Nome { get => nome; set => nome = value; }
        public int Id { get => id; set => id = value; }
        public string Pass { get => pass; set => pass = value; }

        public void FazerLogin()
        {
            string nome = "testuser";

            if (nome == nome)
            {
                    
            }
        }


    }
}
