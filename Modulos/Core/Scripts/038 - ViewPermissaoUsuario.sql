CREATE view dbo.ViewPermissaoUsuario as 
SELECT DISTINCT
   U.Id 'IdUsuario'
  ,U.Login
  ,GF.Id 'IdGrupo'
  ,GF.Nome 'NomeGrupo'
  ,GF.Ordem 'Ordem'
  ,GF.Icone 'IconeGrupo'
  ,F.Id 'IdFuncionalidade'
  ,F.Nome
  ,F.Titulo
  ,F.Descricao
  ,F.Url
  ,F.Sequencia
  ,F.Visivel
  ,UP.IdPerfil
  ,EV.Nome 'NomeAcao'
  ,PEVF.Habilitado 
FROM Usuario U
INNER JOIN UsuarioPerfil UP
   ON UP.IdUsuario = U.Id
INNER JOIN PerfilFuncionalidade PF
   ON PF.IdPerfil = UP.IdPerfil
INNER JOIN Perfil P
   ON P.Id = PF.IdPerfil
      AND P.Habilitado = 1
INNER JOIN Funcionalidade F
   ON F.Id = PF.IdFuncionalidade
      AND F.Habilitado = 1
INNER JOIN GrupoFuncionalidade GF
   ON GF.Id = F.IdGrupoFuncionalidade
      AND GF.Habilitado = 1
LEFT JOIN EventoFuncionalidade EV
   ON PF.IdFuncionalidade = EV.IdFuncionalidade
LEFT JOIN PerfilEventoFuncionalidade PEVF
   on EV.Id = PEVF.IdEventoFuncionalidade
      AND PEVF.IdPerfil = UP.IdPerfil
