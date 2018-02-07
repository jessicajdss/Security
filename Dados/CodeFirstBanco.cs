using AutenticacaoEFCookie.Models;

namespace AutenticacaoEFCookie.Dados
{
    public class CodeFirstBanco
    {
        public static void Inicializar(AutenticacaoContext contexto){
            contexto.Database.EnsureCreated();

            var usuario = new Usuario(){
                Nome = "Jessica",
                Email = "jessica.jdss@gmail.com",
                Senha = "123456"
            };
            contexto.Usuarios.Add(usuario);

            var permissao = new Permissao(){
                
            }


        }
    }
}