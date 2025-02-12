CREATE VIEW ViewPerfilEventoFuncionalidade AS 
SELECT 
	EF.Id,
	EF.Nome, 
	PEF.Id 'PerfilEventoFuncionalidadeId',  
	PEF.Habilitado , 
	PF.Id 'IdPerfilFuncionalidade',
	EF.IdFuncionalidade, 
	PF.Id 'IdPerfil'
FROM EventoFuncionalidade EF 
     LEFT JOIN PerfilEventoFuncionalidade PEF ON EF.ID = PEF.IdEventoFuncionalidade
	 LEFT JOIN Perfil PF ON PF.Id =PEF.IdPerfil

