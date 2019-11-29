using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace MVC_Rotas.Models
{
    public class Noticia
    {
        public int noticiaID { get; set; }
        public string titulo { get; set; }
        public string categoria { get; set; }
        public string conteudo { get; set; }
        public DateTime data { get; set; }

        public IEnumerable<Noticia> TodasAsNoticias()
        {
            var retorno = new Collection<Noticia>
                {
                    new Noticia
                        {
                            noticiaID = 1,
                            categoria = "Esportes",
                            titulo = "Felipe Massa ganha F1",
                            conteudo = "Numa tarde de chuva Felipe Massa ganha F1 no Brasil...",
                            data = new DateTime(2017,3,1)
                        },
                    new Noticia
                        {
                            noticiaID = 2,
                            categoria = "Política",
                            titulo = "Presidente assina convênios",
                            conteudo = "Durante reunião o presidente Ismael Freitas assinou os convênios...",
                            data = new DateTime(2017,3,1)
                        },
                    new Noticia
                        {
                            noticiaID = 3,
                            categoria = "Política",
                            titulo = "Vereador é eleito pela 4ª vez",
                            conteudo = "Vereador Fabio Pratt é eleito pela quarta vez...",
                            data = new DateTime(2017,3,1)
                        },
                    new Noticia
                        {
                            noticiaID = 4,
                            categoria = "Esportes",
                            titulo = "O tão sonhado titulo chegou",
                            conteudo = "Em um jogo que levou os torcedores ao delirio...",
                            data = new DateTime(2017,3,1)
                        },
                    new Noticia
                        {
                            noticiaID = 5,
                            categoria = "Humor",
                            titulo = "O Comediante Anderson Renato fará shou hoje",
                            conteudo = "O comediante mais engraçados dos comentários do Youtube fará show...",
                            data = new DateTime(2017,3,1)
                        },
                    new Noticia
                        {
                            noticiaID = 6,
                            categoria = "Policial",
                            titulo = "Tenente coronel Lucas Farias Santos assume o controle",
                            conteudo = "Durante a retomada do morro o tenente coronel disse...",
                            data = new DateTime(2017,3,1)
                        },
                    new Noticia
                        {
                            noticiaID = 7,
                            categoria = "Esportes",
                            titulo = "Atacante do Barcelona faz 4 gols",
                            conteudo = "O atacante Lucas Farias Santos Messi, fez 4 gols e decidiu o titulo...",
                            data = new DateTime(2017,3,1)
                        }
                };
            return retorno;
        }
    }
}

