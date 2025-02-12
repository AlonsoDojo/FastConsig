create view ViewPerfilUsuario AS 
Select	UP.Id, UP.IdPerfil, P.Nome 'NomePerfil', UP.IdUsuario, U.Login
From	UsuarioPerfil UP
		INNER JOIN Perfil P on P.Id = UP.IdPerfil
		INNER JOIN Usuario U on U.Id = UP.IdUsuario