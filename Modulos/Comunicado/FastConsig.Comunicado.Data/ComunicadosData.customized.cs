
#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Framework;
using Framework.Data;
using FastConsig.Comunicado.Entity;
#endregion

namespace FastConsig.Comunicado.Data
{
	public partial class ComunicadosData
	{
		
		public ComunicadosData() {
			this.CustomizeQuery += new CustomizeQueryDelegate(Handle_CustomizeQuery);
		}

		void Handle_CustomizeQuery(QueryBuilder query) {
         //*************************************************************************
         //*** OBS: Nao esqueca de criar as propriedades na Entity customized!!! ***
         //*************************************************************************

         //LEFT JOIN com a tabela ComunicadosStatus
         //------------------------------------------------------------------
         query.Join(Comunicados.METADADO.Status, Join.Left, ComunicadosStatus.METADADO.Id)
              .Field(ComunicadosStatus.METADADO.Descricao, "DescricaoStatus");
         //------------------------------------------------------------------

         //JOIN com a tabela Usuario
         //------------------------------------------------------------------
         //query.Join(Comunicados.METADADO.Usuario, Join.Inner, Usuario.METADADO.Id)
         //     .Field(Usuario.METADADO.Login, "LoginUsuario")
         //     .Field(Usuario.METADADO.Nome, "NomeUsuario")
         //     .Field(Usuario.METADADO.Bloqueado, "BloqueadoUsuario")
         //     .Field(Usuario.METADADO.Habilitado, "HabilitadoUsuario")
         //     .Field(Usuario.METADADO.Email, "EmailUsuario")
         //     .Field(Usuario.METADADO.DataUltimoLogin, "DataUltimoLoginUsuario")
         //     .Field(Usuario.METADADO.DataRegistro, "DataRegistroUsuario")
         //     .Field(Usuario.METADADO.UsuarioRegistro, "UsuarioRegistroUsuario")
         //     .Field(Usuario.METADADO.Departamento, "DepartamentoUsuario")
         //     .Field(Usuario.METADADO.cpfcnpj, "cpfcnpjUsuario")
         //     .Field(Usuario.METADADO.Promotora, "PromotoraUsuario")
         //     .Field(Usuario.METADADO.Senha, "SenhaUsuario")
         //     .Field(Usuario.METADADO.DataUltimaTrocaSenha, "DataUltimaTrocaSenhaUsuario")
         //     .Field(Usuario.METADADO.Celular, "CelularUsuario")
         //     .Field(Usuario.METADADO.Dominio, "DominioUsuario")
         //     .Field(Usuario.METADADO.PreferenciaUsuario, "PreferenciaUsuarioUsuario")
         //     .Field(Usuario.METADADO.RedeLojas, "RedeLojasUsuario")
         //     .Field(Usuario.METADADO.Loja, "LojaUsuario")
         //     .Field(Usuario.METADADO.TermoUsuario, "TermoUsuarioUsuario");
         //------------------------------------------------------------------

         //JOIN com a tabela Usuario
         //------------------------------------------------------------------
         //query.Join(Comunicados.METADADO.UsuarioAlteracao, Join.Inner, Usuario.METADADO.Id)
         //     .Field(Usuario.METADADO.Login, "LoginUsuario")
         //     .Field(Usuario.METADADO.Nome, "NomeUsuario")
         //     .Field(Usuario.METADADO.Bloqueado, "BloqueadoUsuario")
         //     .Field(Usuario.METADADO.Habilitado, "HabilitadoUsuario")
         //     .Field(Usuario.METADADO.Email, "EmailUsuario")
         //     .Field(Usuario.METADADO.DataUltimoLogin, "DataUltimoLoginUsuario")
         //     .Field(Usuario.METADADO.DataRegistro, "DataRegistroUsuario")
         //     .Field(Usuario.METADADO.UsuarioRegistro, "UsuarioRegistroUsuario")
         //     .Field(Usuario.METADADO.Departamento, "DepartamentoUsuario")
         //     .Field(Usuario.METADADO.cpfcnpj, "cpfcnpjUsuario")
         //     .Field(Usuario.METADADO.Promotora, "PromotoraUsuario")
         //     .Field(Usuario.METADADO.Senha, "SenhaUsuario")
         //     .Field(Usuario.METADADO.DataUltimaTrocaSenha, "DataUltimaTrocaSenhaUsuario")
         //     .Field(Usuario.METADADO.Celular, "CelularUsuario")
         //     .Field(Usuario.METADADO.Dominio, "DominioUsuario")
         //     .Field(Usuario.METADADO.PreferenciaUsuario, "PreferenciaUsuarioUsuario")
         //     .Field(Usuario.METADADO.RedeLojas, "RedeLojasUsuario")
         //     .Field(Usuario.METADADO.Loja, "LojaUsuario")
         //     .Field(Usuario.METADADO.TermoUsuario, "TermoUsuarioUsuario");
         //------------------------------------------------------------------

         //JOIN com a tabela Usuario
         //------------------------------------------------------------------
         //query.Join(Comunicados.METADADO.UsuarioPublicador, Join.Inner, Usuario.METADADO.Id)
         //     .Field(Usuario.METADADO.Login, "LoginUsuario")
         //     .Field(Usuario.METADADO.Nome, "NomeUsuario")
         //     .Field(Usuario.METADADO.Bloqueado, "BloqueadoUsuario")
         //     .Field(Usuario.METADADO.Habilitado, "HabilitadoUsuario")
         //     .Field(Usuario.METADADO.Email, "EmailUsuario")
         //     .Field(Usuario.METADADO.DataUltimoLogin, "DataUltimoLoginUsuario")
         //     .Field(Usuario.METADADO.DataRegistro, "DataRegistroUsuario")
         //     .Field(Usuario.METADADO.UsuarioRegistro, "UsuarioRegistroUsuario")
         //     .Field(Usuario.METADADO.Departamento, "DepartamentoUsuario")
         //     .Field(Usuario.METADADO.cpfcnpj, "cpfcnpjUsuario")
         //     .Field(Usuario.METADADO.Promotora, "PromotoraUsuario")
         //     .Field(Usuario.METADADO.Senha, "SenhaUsuario")
         //     .Field(Usuario.METADADO.DataUltimaTrocaSenha, "DataUltimaTrocaSenhaUsuario")
         //     .Field(Usuario.METADADO.Celular, "CelularUsuario")
         //     .Field(Usuario.METADADO.Dominio, "DominioUsuario")
         //     .Field(Usuario.METADADO.PreferenciaUsuario, "PreferenciaUsuarioUsuario")
         //     .Field(Usuario.METADADO.RedeLojas, "RedeLojasUsuario")
         //     .Field(Usuario.METADADO.Loja, "LojaUsuario")
         //     .Field(Usuario.METADADO.TermoUsuario, "TermoUsuarioUsuario");
         //------------------------------------------------------------------

         //JOIN com a tabela Usuario
         //------------------------------------------------------------------
         //query.Join(Comunicados.METADADO.UsuarioDesativacao, Join.Inner, Usuario.METADADO.Id)
         //     .Field(Usuario.METADADO.Login, "LoginUsuario")
         //     .Field(Usuario.METADADO.Nome, "NomeUsuario")
         //     .Field(Usuario.METADADO.Bloqueado, "BloqueadoUsuario")
         //     .Field(Usuario.METADADO.Habilitado, "HabilitadoUsuario")
         //     .Field(Usuario.METADADO.Email, "EmailUsuario")
         //     .Field(Usuario.METADADO.DataUltimoLogin, "DataUltimoLoginUsuario")
         //     .Field(Usuario.METADADO.DataRegistro, "DataRegistroUsuario")
         //     .Field(Usuario.METADADO.UsuarioRegistro, "UsuarioRegistroUsuario")
         //     .Field(Usuario.METADADO.Departamento, "DepartamentoUsuario")
         //     .Field(Usuario.METADADO.cpfcnpj, "cpfcnpjUsuario")
         //     .Field(Usuario.METADADO.Promotora, "PromotoraUsuario")
         //     .Field(Usuario.METADADO.Senha, "SenhaUsuario")
         //     .Field(Usuario.METADADO.DataUltimaTrocaSenha, "DataUltimaTrocaSenhaUsuario")
         //     .Field(Usuario.METADADO.Celular, "CelularUsuario")
         //     .Field(Usuario.METADADO.Dominio, "DominioUsuario")
         //     .Field(Usuario.METADADO.PreferenciaUsuario, "PreferenciaUsuarioUsuario")
         //     .Field(Usuario.METADADO.RedeLojas, "RedeLojasUsuario")
         //     .Field(Usuario.METADADO.Loja, "LojaUsuario")
         //     .Field(Usuario.METADADO.TermoUsuario, "TermoUsuarioUsuario");
         //------------------------------------------------------------------


      }

   }
}
