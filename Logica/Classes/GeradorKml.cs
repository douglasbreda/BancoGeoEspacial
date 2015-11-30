using Bibilioteca;
using NegocioPrincipal;
using SharpKml.Base;
using SharpKml.Dom;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Classes
{
    public class GeradorKml : LogicaNegocio
    {
        public GeradorKml()
        {

        }

        /// <summary>
        /// Gerador de Kml
        /// </summary>
        /// <param name="pLinhaDados"></param>
        /// <param name="pTipoDados"></param>
        /// <param name="pNome"></param>
        /// <param name="pNumOcorrencia"></param>
        public void GerarKml(string pLinhaDados, eTipoDadoGeografico pTipoDados, string pNome, int pNumOcorrencia)
        {
            Placemark placemark = new Placemark();
            placemark.Name = pNome;
            string sCor = "";

            if (pNumOcorrencia >= 20)
                sCor = "ff0000ff";
            else if (pNumOcorrencia >= 10)
                sCor = "ff8080ff";
            else if (pNumOcorrencia >= 5)
                sCor = "ffc0c0ff";
            else if (pNumOcorrencia >= 0)
                sCor = "ffffffff";


            StringBuilder sbStilo = new StringBuilder();
            sbStilo.AppendLine("<color>");
            sbStilo.AppendLine(sCor);
            sbStilo.AppendLine("</color>");


                                     string sXml = "";
            // This is the root element of the file
            Kml kml = new Kml();
            kml.Feature = placemark;

            Serializer serializer = new Serializer();
            serializer.Serialize(kml);

            int iIndiceStilo = serializer.Xml.LastIndexOf("<Placemark>") + 11;

            sXml = serializer.Xml.Insert(iIndiceStilo, sbStilo.ToString());

            int iIndiceInicial = sXml.LastIndexOf("</name>") + 8;

            sXml = sXml.Insert(iIndiceInicial, pLinhaDados);

            string caminho = @"C:\Users\" + Environment.UserName + @"\Desktop\ArquivoKml" + DateTime.Now.ToString().Replace("/", "-").Replace(":", ".") + ".kml";
            StreamWriter arquivo = new StreamWriter(caminho);
            arquivo.WriteLine(sXml);
            arquivo.Close();
            //MessageBox.Show("Arquivo Gravado em " + caminho + " com sucesso");
        }
    }
}
