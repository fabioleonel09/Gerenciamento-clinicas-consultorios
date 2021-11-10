using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segmentoOtoneurologia
{
    static class autenticacao
    {
        static string novoUsuario;
        static string tipoProfissional;
        static string novaSenha;

        public static void Entrar(string novoUsuario1, string tipoProfissional1, string novaSenha1)
        {
            novoUsuario = novoUsuario1;
            tipoProfissional = tipoProfissional1;
            novaSenha = novaSenha1;
        }
    }
}
