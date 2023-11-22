using model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace dal
{
    public class DalProduto
    {
        private static String tbl = "tblProduto";

        public static Produto Selecionar(int id)
        {
            using SqlCommand sql = new DalConexao().AbrirConexao();

            sql.CommandText = "SELECT * FROM " + tbl + " WHERE prdId = @prdId;";
            sql.Parameters.Add("@prdId", SqlDbType.Int).Value = id;

            using SqlDataReader reader = sql.ExecuteReader();

            if (reader.Read() && reader.HasRows)
            {
                id = (int)reader["prdId"];
                string descricao = (string)reader["prdDescricao"];
                double prcCusto = (double)reader["prdPrcCusto"];
                double prcVenda = (double)reader["prdPrcVenda"];
                int quantidade = (int)reader["prdQuantidade"];
                int categoria = (int)reader["catId"];

                return new Produto(id, descricao, prcCusto, prcVenda, quantidade, categoria);
            }
            else
            {
                return new Produto();
            }
        }

        public static void Inserir(Produto p)
        {
            using SqlCommand sql = new DalConexao().AbrirConexao();

            sql.CommandText = "INSERT INTO " + tbl + " (prdDescricao, prdPrcCusto, prdPrcVenda, prdQuantidade, catId) VALUES (@prdDescricao, @prdPrcCusto, @prdPrcVenda, @prdQuantidade, @catId);";

            sql.Parameters.Add("@prdDescricao", SqlDbType.VarChar).Value = p.Descricao;
            sql.Parameters.Add("@prdPrcCusto", SqlDbType.Decimal).Value = p.PrcCusto;
            sql.Parameters.Add("@prdPrcVenda", SqlDbType.Decimal).Value = p.PrcVenda;
            sql.Parameters.Add("@prdQuantidade", SqlDbType.Int).Value = p.Quantidade;
            sql.Parameters.Add("@catId", SqlDbType.VarChar).Value = p.Categoria;

            sql.ExecuteNonQuery();
        }

        public static void Atualizar(Produto p)
        {
            using SqlCommand sql = new DalConexao().AbrirConexao();

            sql.CommandText = "UPDATE " + tbl + " SET prdDescricao = @prdDescricao, prdPrcCusto = @prdPrcCusto, prdPrcVenda = @prdPrcVenda, prdQuantidade = @prdQuantidade, catId = @catId WHERE prdId = @prdId;";

            sql.Parameters.Add("@prdId", SqlDbType.Int).Value = p.Id;
            sql.Parameters.Add("@prdDescricao", SqlDbType.VarChar).Value = p.Descricao;
            sql.Parameters.Add("@prdPrcCusto", SqlDbType.Decimal).Value = p.PrcCusto;
            sql.Parameters.Add("@prdPrcVenda", SqlDbType.Decimal).Value = p.PrcVenda;
            sql.Parameters.Add("@prdQuantidade", SqlDbType.Int).Value = p.Quantidade;
            sql.Parameters.Add("@catId", SqlDbType.Int).Value = p.Categoria;

            sql.ExecuteNonQuery();
        }

        public static void Deletar(int id)
        {
            using SqlCommand sql = new DalConexao().AbrirConexao();

            sql.CommandText = "DELETE FROM " + tbl + " WHERE prdId = @prdId;";

            sql.Parameters.Add("@prdId", SqlDbType.Int).Value = id;

            sql.ExecuteNonQuery();
        }

        public static DataTable Listar()
        {
            using SqlCommand sql = new DalConexao().AbrirConexao();

            sql.CommandText = "SELECT prdId, prdDescricao, prdPrcCusto, prdPrcVenda, prdQuantidade, catDescricao FROM " + tbl + " LEFT JOIN tblCategorias ON tblProdutos.catId = tblCategorias.catId;";

            DataTable tabela = new();
            SqlDataAdapter adaptador = new(sql);
            adaptador.Fill(tabela);

            return tabela;
        }
    }
}