CREATE VIEW ViewComunicados AS 
SELECT x.*, l.DataLeitura FROM (select c.Id as Comunicado, u.Id as Usuario, c.DataVigenciaInicial, c.DataVigenciaFinal, c.Titulo, c.ConfirmacaoLeitura, C.Publicado from Comunicados c, Usuario u) X 
LEFT JOIN ComunicadosConfirmacaoLeitura l on l.Usuario = X.Usuario and l.Comunicado = X.Comunicado
WHERE x.Publicado = 1
