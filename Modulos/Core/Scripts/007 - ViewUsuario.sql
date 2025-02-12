CREATE VIEW ViewUsuario AS
SELECT
   Id as Id
  ,Login as Login
  ,Nome as Nome
  ,Bloqueado
  ,Habilitado
  ,Email as Email
  ,DataUltimoLogin
  ,DataRegistro
  ,UsuarioRegistro as UsuarioRegistro
  ,Departamento
  ,cpfcnpj
  ,Promotora
  ,Senha as Senha
  ,DataUltimaTrocaSenha
  ,Celular as Celular
  ,Dominio
  ,PreferenciaUsuario as PreferenciaUsuario
  ,RedeLojas as RedeLojas
  ,Loja as Loja
FROM Usuario
