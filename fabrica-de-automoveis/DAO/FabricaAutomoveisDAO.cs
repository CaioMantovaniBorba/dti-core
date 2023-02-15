using DAO;
using DTIDAO.Core;
using fabrica_de_automoveis.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UtilDLL;

namespace fabrica_de_automoveis.DAO
{
    public class FabricaAutomoveisDAO : IDAOBase<Domain.FabricaAutomoveis, Domain.FabricaAutomoveisDTO>
    {
        public string delete(FabricaAutomoveis dominio)
        {
            var sqlString = $"DELETE FROM AUTOMOVEIS " +
                $"WHERE ID_AUTOMOVEL = {dominio.id_automovel}";
            return BDOracle.executaComandoCommit(sqlString);
        }

        public FabricaAutomoveis Get(int id)
        {
            var sqlString = 
                "SELECT ID_AUTOMOVEL, \n" + 
                "MODELO_AUTOMOVEL, \n" + 
                "ANO_AUTOMOVEL\n" + 
                "FROM AUTOMOVEIS\n" + 
                $"WHERE AUTOMOVEIS.ID_AUTOMOVEL = {id}";

            var dt = BDOracle.getDataTable(sqlString);  
            
            try
            {
                var registro = dt.Rows[0];
                var automovel = new FabricaAutomoveis();

                automovel.id_automovel = Convert.ToInt32(registro["ID_AUTOMOVEL"]);
                automovel.modelo_automovel = registro["MODELO_AUTOMOVEL"].ToString();
                automovel.ano_automovel = Convert.ToInt32(registro["ANO_AUTOMOVEL"]);

                return automovel;
            } catch
            {
                return null;
            }
        }

        public FabricaAutomoveisDTO GetDTO(int id)
        {
            var sqlString =
               "SELECT ID_AUTOMOVEL, \n" +
               "MODELO_AUTOMOVEL, \n" +
               "ANO_AUTOMOVEL\n" +
               "FROM AUTOMOVEIS\n" +
               $"WHERE AUTOMOVEL.ID_AUTOMOVEL = {id}";

            var dt = BDOracle.getDataTable(sqlString);

            try
            {
                var registro = dt.Rows[0];
                var automovel = new FabricaAutomoveisDTO();

                automovel.id_automovel = Convert.ToInt32(registro["ID_AUTOMOVEL"]);
                automovel.modelo_automovel = registro["MODELO_AUTOMOVEL"].ToString();
                automovel.ano_automovel = Convert.ToInt32(registro["ANO_AUTOMOVEL"]);

                return automovel;
            }
            catch
            {
                return null;
            }
        }

        public string insert(FabricaAutomoveis dominio)
        {
            var camposInsert = new ListaCampos();

            camposInsert.Add("MODELO_AUTOMOVEL", Util.strNULL(dominio.modelo_automovel));
            camposInsert.Add("ANO_AUTOMOVEL", Util.strNULL(dominio.ano_automovel));

            var nomeTabela = "AUTOMOVEIS";
            var sqlString = Util.montaSQLInsert(nomeTabela, camposInsert);

            var id = 0;
            var retorno = BDOracle.executaComandoCommitHandle(sqlString, "ID_AUTOMOVEL", ref id);
            dominio.id_automovel = id;
            return retorno;
        }

        public List<FabricaAutomoveisDTO> Listar(NTIFiltro filtro)
        {
            var sqlString =
               "SELECT ID_AUTOMOVEL, \n" +
               "MODELO_AUTOMOVEL, \n" +
               "ANO_AUTOMOVEL\n" +
               "FROM AUTOMOVEIS\n" +
               $"WHERE 1=1";

            if (filtro != null)
            {
                sqlString += filtro.getExpressoes();
            }

            var dt = BDOracle.getDataTable(sqlString);
             
            var lista = dt.DataTableToList<FabricaAutomoveisDTO>();
            return lista; 
        }

        public string update(FabricaAutomoveis dominio)
        {
            var camposUpdate = new ListaCampos();

            camposUpdate.Add("MODELO_AUTOMOVEL", Util.strNULL(dominio.modelo_automovel));
            camposUpdate.Add("ANO_AUTOMOVEL", Util.strNULL(dominio.ano_automovel));

            var nomeTabela = "AUTOMOVEIS";
            var sqlString = Util.montaSQLUpdate(nomeTabela, camposUpdate);
            sqlString += $"ID_AUTOMOVEL = {dominio.id_automovel}";

            return BDOracle.executaComandoCommit(sqlString);
        }
    }
}
