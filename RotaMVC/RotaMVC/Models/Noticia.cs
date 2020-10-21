using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RotaMVC.Models
{
    public class Noticia
    {
        public int NoticiaId { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public string Categoria { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }

        public IEnumerable<Noticia> TodasAsNoticias()
        {
            var retorno = new Collection<Noticia>()
            {
                new Noticia
                {
                    NoticiaId = 1,
                    Categoria = "Esportes",
                    Titulo = "Neymar ganha jogo",
                    Conteudo = "Neymar é o melhor jogador do mundo",
                    Data = new DateTime(2018, 7, 6)
                },
                new Noticia
                {
                    NoticiaId = 2,
                    Categoria = "Politica",
                    Titulo = "Bolsonaro presidente",
                    Conteudo = "Bolsonaro ganha eleições em 2018",
                    Data = new DateTime(2018, 10, 19)
                },
                new Noticia
                {
                    NoticiaId = 3,
                    Categoria = "Cultura",
                    Titulo = "PinkFloyd vem no Brasil",
                    Conteudo = "Show da maior banda de psicodelia do mundo",
                    Data = new DateTime(1985, 5, 17)
                },
                new Noticia
                {
                    NoticiaId = 4,
                    Categoria = "Politica",
                    Titulo = "Tchau, Dilma",
                    Conteudo = "Dilma é deposta do governo, Temer assume",
                    Data = new DateTime(2017, 4, 8)
                },
                new Noticia
                {
                    NoticiaId = 5,
                    Categoria = "Humor",
                    Titulo = "Porta dos Fundos, melhor canal",
                    Conteudo = "Canal do youtube faz sucesso fazendo as pessoas rirem",
                    Data = new DateTime(2014, 5, 16)
                },
                new Noticia
                {
                    NoticiaId = 6,
                    Categoria = "Guerra",
                    Titulo = "Guerra do Oriente Médio",
                    Conteudo = "Iran e Iraque entram em guerra pelo petróleo",
                    Data = new DateTime(2006, 3, 13)
                }
        };
            return retorno;
        }
    }
}