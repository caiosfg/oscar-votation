using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Introducao.Models
{
    public class Noticias
    {
        public int NoticiaId { get; set; }
        public string Titulo { get; set; }
        public string Categoria { get; set; }
        public string Conteudo { get; set; }
        public DateTime Data { get; set; }

        public IEnumerable<Noticias> TodasAsNoticias()
        {
            var retorno = new Collection<Noticias>
                {
                    new Noticias
                        {
                            NoticiaId = 1,
                            Categoria = "Elenco",
                            Titulo = "Charles Bronson confirmado",
                            Conteudo = "Numa tarde de chuva Charles Bronson confirmado em Mercenarios XV...",
                            Data = new DateTime(2017,3,1)
                        },
                    new Noticias
                        {
                            NoticiaId = 2,
                            Categoria = "Roteiro",
                            Titulo = "Woody Allen visto anotando em folha",
                            Conteudo = "Durante reunião Woody Allen rabiscava um papel de pão...",
                            Data = new DateTime(2017,3,1)
                        },
                    new Noticias
                        {
                            NoticiaId = 3,
                            Categoria = "Roteiro",
                            Titulo = "José Padilha é eleito pela 4ª vez",
                            Conteudo = "José Padilha é eleito pela quarta vez ao Oscar de melhor roteiro...",
                            Data = new DateTime(2017,3,1)
                        },
                    new Noticias
                        {
                            NoticiaId = 4,
                            Categoria = "Melhor Ator",
                            Titulo = "O tão sonhado titulo chegou",
                            Conteudo = "Durante espera, Rodrigo Santoro ganha premio e torcedores vão ao delirio...",
                            Data = new DateTime(2017,3,1)
                        },
                    new Noticias
                        {
                            NoticiaId = 5,
                            Categoria = "Humor",
                            Titulo = "O Comediante Whindersson Nunes fará shou hoje",
                            Conteudo = "O comediante mais engraçados dos comentários do Youtube fará show...",
                            Data = new DateTime(2017,3,1)
                        },
                    new Noticias
                        {
                            NoticiaId = 6,
                            Categoria = "Policial",
                            Titulo = "Durante coletiva coronel Cinelli assume o controle",
                            Conteudo = "Durante a cobertura do Oscar o tenente coronel disse...",
                            Data = new DateTime(2017,3,1)
                        },
                    new Noticias
                        {
                            NoticiaId = 7,
                            Categoria = "Roteiro",
                            Titulo = "Tiririca é indicado a 4 vezes",
                            Conteudo = "O comediante Tiririca, é mencionado 4 vezes na disputa ao titulo...",
                            Data = new DateTime(2017,3,1)
                        }
                };
            return retorno;
        }
    }
}