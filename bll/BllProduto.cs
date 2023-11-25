using dal;
using model;
using System.Data;

namespace bll
{
    public class BllProduto
    {
        public static Produto Selecionar(int id)
        {
            return DalProduto.Selecionar(id);
        }

        public static void Inserir(Produto p)
        {
            DalProduto.Inserir(p);
        }

        public static void Atualizar(Produto p)
        {
            DalProduto.Atualizar(p);
        }

        public static void Deletar(int id)
        {
            DalProduto.Deletar(id);
        }

        public static void DeletarPorCategoria(int id)
        {
            DalProduto.DeletarPorCategoria(id);
        }

        public static DataTable Listar()
        {
            return DalProduto.Listar();
        }
    }
}