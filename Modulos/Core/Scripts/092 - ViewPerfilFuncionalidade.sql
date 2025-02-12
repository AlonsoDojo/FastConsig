CREATE VIEW ViewPerfilFuncionalidade AS 
SELECT	PF.IdFuncionalidade,
		F.IdGrupoFuncionalidade,
		PF.IdPerfil,
		GF.Nome 'NomeGrupo',
		F.Sequencia,
		F.Nome,
		F.Url,
		F.Habilitado
FROM	PerfilFuncionalidade PF
		INNER JOIN Funcionalidade F ON F.Id = PF.IdFuncionalidade
		INNER JOIN GrupoFuncionalidade GF ON GF.Id = F.IdGrupoFuncionalidade
