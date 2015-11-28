using Microsoft.Reporting.WinForms;
using System.Data;
using System.Text;

namespace Relatorios
{
    public class ClasseRelatorios //: LogicaNegocio
    {
        #region [Paths]



        #endregion End [Paths]

        #region [Methods]

        public void ExibirRelatorio(DataSet pNomeDados, string pCaminhoPadrao)
        {
            ReportDataSource oDataSet = new ReportDataSource(pNomeDados.DataSetName + "_" + pNomeDados.Tables[0].TableName, pNomeDados.Tables[0]);
            formReportPadrao oRelatorio = new formReportPadrao();
            oRelatorio.reportPadrao.LocalReport.ReportEmbeddedResource = pCaminhoPadrao;
            oRelatorio.reportPadrao.LocalReport.DataSources.Add(oDataSet);
            oRelatorio.Show();
        }

        #endregion End [Methods]




    }
}
