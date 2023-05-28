using OpenHtmlToPdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Loba.Service.Util
{
    public class PdfUtil
    {
        public string FormatarAta(string corpoPdf)
        {
            var replacements = new Dictionary<string, string>()
            {
                { "algoritmo",             "<b>algoritmo</b>"}
               ,{ "bigdata",               "<b>big data</b>"}
               ,{ "cibersegurança",        "<b>cibersegurança</b>"}
               ,{ "digitalização",         "<b>digitalização</b>"}
               ,{ "inteligencia artificial","<b>inteligencia artificial</b>"}
               ,{ "internet das coisas",     "<b>internet das coisas</b>"}
               ,{ "IOT",                   "<b>IOT</b>"}
               ,{ "backup",                "<b>backup</b>"}
               ,{ "bug",                   "<b>bug</b>"}
               ,{ "cookies",               "<b>cookies</b>"}
               ,{ "frontend",              "<b>frontend</b>"}
               ,{ "backend",               "<b>backend</b>"}
               ,{ "bancodedados",          "<b>banco de dados</b>"}
               ,{ "programação",           "<b>programação</b>"}
               ,{ "login",                 "<b>login</b>"}
               ,{ "hardware",              "<b>hardware</b>"}
               ,{ "software",              "<b>software</b>"}
               ,{ "raspberry",             "<b>raspberry</b>"}
               ,{ "obsolescencia",         "<b>obsolescencia</b>"}
               ,{ "automacao",             "<b>automacao</b>"}
               ,{ "internet",              "<b>internet</b>"}
               ,{ "app",                   "<b>app</b>"}
               ,{"boa tarde",              "<i>boa tarde</i>" }
               ,{"boa noite",              "<i>boa noite</i>" }
               ,{"bom dia",                "<i>bom dia</i>" }
               ,{"reunião",                "<i>reunião</i>" }
               ,{"reuniões",               "<i>reuniões</i>" }
               ,{"alinhamento",            "<b>alinhamento</b>" }
               ,{"apresentação",           "<b>apresentação</b>" }
               ,{"prazos",                 "<b>prazos</b>" }
               ,{"metas",                  "<b>metas</b>" }
               ,{"objetivos",              "<b>objetivos</b>" }
               ,{"alterações",             "<b>alterações</b>" }
               ,{"alteração",              "<b>alteração</b>" }
               ,{"prazo",                  "<b>prazo</b>" }
               ,{"fundamental",            "<b>fundamental</b>" }
               ,{"prioridade",             "<b>prioridade</b>" }
               ,{"restrições",             "<b>restrições</b>" }
               ,{"restrição",              "<b>restrição</b>" }
               ,{"entregas",               "<b>entregas</b>" }
               ,{"entrega",                "<b>entrega</b>" }
               ,{"demandas",               "<b>demandas</b>" }
               ,{"demanda",                "<b>demanda</b>" }
                ,{"qualidade de software", "<b>qualidade de software</b>" }
                ,{"voz",                "<b>voz</b>" }
                ,{"reconhecimento",                "<b>reconhecimento</b>" }
                ,{"confecção",                "<b>confecção</b>" }
                ,{"secretária",                "<b>secretária</b>" }
                ,{"ata",                "<b>ata</b>" }
                ,{"facilitar",                "<b>facilitar</b>" }
            };

            var regex = new Regex(String.Join("|", replacements.Keys));
            var replaced = regex.Replace(corpoPdf, m => replacements[m.Value]);

            return replaced;
        }

        public string SepararEmParagrafos(string texto)
        {
            int size = 100;

            var palavras = texto.Split(new[] { ' ' },
                              StringSplitOptions.RemoveEmptyEntries);
            List<string> listaPalavras = new List<string>();
            string tmp = "";

            int i = 0;
            for (i = 0; i < palavras.Length; i++)
            {
                if ((tmp.Length + palavras[i].Length) > size)
                {
                    listaPalavras.Add(tmp);
                    tmp = "";
                }
                tmp += " " + palavras[i];
            }
            if (!String.IsNullOrWhiteSpace(tmp))
            {
                listaPalavras.Add(tmp);
            }

            StringBuilder sb = new StringBuilder();
            foreach (string itemLista in listaPalavras)
            {
                sb.Append(itemLista + "</br>");
            }

            string textoComParagrafos = sb.ToString();

            return textoComParagrafos;
        }

        public void CriarPDF(string corpoPdf, string path)
        {
            corpoPdf = SepararEmParagrafos(corpoPdf);

            string corpo = FormatarAta(corpoPdf);

            string html = "<!DOCTYPE html>" +
                            "<html>" +
                            "<head><meta charset='UTF-8'><title>Title</title></head>" +
                            "<body>" +
                           corpo +
                            "</body>" +
                            "</html>";

            var pdf = Pdf
                .From(html)
                .OfSize(PaperSize.A4)
                .WithTitle("ataReuniao" + Guid.NewGuid())
                .WithoutOutline()
                .WithMargins(1.25.Centimeters())
                .Portrait()
                .Comressed()
                .Content();

            using (FileStream fs = System.IO.File.Create(path))
            {
                fs.Write(pdf, 0, pdf.Length);
            }
        }

    }
}
