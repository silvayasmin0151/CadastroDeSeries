using System.Collections.Generic;

namespace series.interfaces
{
    public interface Irepositorio<T>
    {
         List<T> Lista();
         T RetornarPorId(int id);
         void Insere(T endidade);
         void Exclui(int id);
         void Atualiza(int id, T entidade);
         int ProximoId();
    }
}