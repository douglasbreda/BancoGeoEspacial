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

        public void GerarKml(string pLinhaDados, eTipoDadoGeografico pTipoDados)
        {
            Placemark placemark = new Placemark();
            placemark.Name = "Kml";
            //if (pTipoDados == eTipoDadoGeografico.point)
            //    placemark.Geometry = new Point();
            //else
            //    placemark.Geometry = new Polygon();

            // This is the root element of the file
            Kml kml = new Kml();
            kml.Feature = placemark;

            Serializer serializer = new Serializer();
            serializer.Serialize(kml);

            string sXml = serializer.Xml.Insert(122, pLinhaDados);

            string caminho = @"C:\Users\" + Environment.UserName + @"\Desktop\ArquivoKml" + DateTime.Now.ToString().Replace("/", "-").Replace(":", ".") + ".kml";
            StreamWriter arquivo = new StreamWriter(caminho);
            arquivo.WriteLine(sXml);
            arquivo.Close();
            //MessageBox.Show("Arquivo Gravado em " + caminho + " com sucesso");
        }
    }
}
