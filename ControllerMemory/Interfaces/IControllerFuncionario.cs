using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelCantina;
namespace ControllerCantina.Interfaces
{
   public interface IControllerFuncionario
    {
          bool GravarFuncionario(Funcionario funcionario);
          bool AtualizarFuncionario(Funcionario funcionario);
          bool ExcluirFuncionario(Funcionario funcionario);
          IList<Funcionario> BuscarFuncionarios(String criterios);
         Funcionario LocalizarFuncionarioPorID(Guid id);
    }
}
