using System.Linq;
using AutenticacaoEFCookie.Models;

namespace AutenticacaoEFCookie.Dados
{
    public class CodeFirstBanco
    {
        public static void Inicializar(AutenticacaoContext contexto){
            contexto.Database.EnsureCreated();

            if(contexto.Usuarios.Any())return;

            var usuario = new Usuario(){
                Nome = "Jessica",
                Email = "jessica.jdss@gmail.com",
                Senha = "123456"
            };
            contexto.Usuarios.Add(usuario);

            var permissao = new Permissao(){
                Nome = "Financeiro"
            };

            contexto.Permissoes.Add(permissao);

            var usuariopermissao = new UsuarioPermissao(){
                IdUsuario = usuario.IdUsuario,
                IdPermissao = permissao.IdPermissao
            };

            contexto.UsuariosPermissoes.Add(usuariopermissao);
            contexto.SaveChanges();


        }
    }
}