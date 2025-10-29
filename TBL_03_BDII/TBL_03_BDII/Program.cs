using System;
using Npgsql;
using System.Collections.Generic;

public class SqlEmbutida
{
    private static string ConnectionString = "Host=localhost;Port=5432;Username=postgres;Password=PostgreSQL123;Database=postgres";

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Inserir aluno");
            Console.WriteLine("2. Listar alunos");
            Console.WriteLine("3. Buscar aluno por nome");
            Console.WriteLine("4. Atualizar idade");
            Console.WriteLine("5. Excluir aluno");
            Console.WriteLine("6. Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    InserirAluno();
                    break;
                case "2":
                    ListarAlunos();
                    break;
                case "3":
                    BuscarAlunoPorNome();
                    break;
                case "4":
                    AtualizarIdade();
                    break;
                case "5":
                    ExcluirAluno();
                    break;
                case "6":
                    Console.WriteLine("Saindo...");
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }

    public static void InserirAluno()
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        string sql = "INSERT INTO alunos (nome, idade) VALUES (@nome, @idade)";
        using (var conn = new NpgsqlConnection(ConnectionString))
        {
            try
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("nome", nome);
                    cmd.Parameters.AddWithValue("idade", idade);
                    int linhas = cmd.ExecuteNonQuery();
                    Console.WriteLine($"Aluno inserido com sucesso ({linhas} linha(s) afetada(s)).");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao inserir: {ex.Message}");
            }
        }
    }

    public static void ListarAlunos()
    {
        string sql = "SELECT id, nome, idade FROM alunos ORDER BY id";
        using (var conn = new NpgsqlConnection(ConnectionString))
        {
            conn.Open();
            using (var cmd = new NpgsqlCommand(sql, conn))
            using (var reader = cmd.ExecuteReader())
            {
                Console.WriteLine("\n--- Lista de Alunos ---");
                if (!reader.HasRows)
                {
                    Console.WriteLine("Nenhum aluno encontrado.");
                    return;
                }

                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader.GetInt32(0)}, Nome: {reader.GetString(1)}, Idade: {reader.GetInt32(2)}");
                }
            }
        }
    }

    public static void BuscarAlunoPorNome()
    {
        Console.Write("Digite o nome do aluno: ");
        string nome = Console.ReadLine();

        string sql = "SELECT id, nome, idade FROM alunos WHERE nome ILIKE @nome";
        using (var conn = new NpgsqlConnection(ConnectionString))
        {
            conn.Open();
            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("nome", "%" + nome + "%");
                using (var reader = cmd.ExecuteReader())
                {
                    Console.WriteLine($"\n--- Resultados para '{nome}' ---");
                    if (!reader.HasRows)
                    {
                        Console.WriteLine("Nenhum aluno encontrado.");
                        return;
                    }

                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader.GetInt32(0)}, Nome: {reader.GetString(1)}, Idade: {reader.GetInt32(2)}");
                    }
                }
            }
        }
    }

    public static void AtualizarIdade()
    {
        Console.Write("Digite o ID do aluno: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Nova idade: ");
        int novaIdade = int.Parse(Console.ReadLine());

        string sql = "UPDATE alunos SET idade = @idade WHERE id = @id";
        using (var conn = new NpgsqlConnection(ConnectionString))
        {
            conn.Open();
            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("idade", novaIdade);
                cmd.Parameters.AddWithValue("id", id);
                int linhas = cmd.ExecuteNonQuery();
                Console.WriteLine(linhas > 0 ? "Idade atualizada com sucesso!" : "Aluno não encontrado.");
            }
        }
    }

    public static void ExcluirAluno()
    {
        Console.Write("Digite o ID do aluno para excluir: ");
        int id = int.Parse(Console.ReadLine());

        string sql = "DELETE FROM alunos WHERE id = @id";
        using (var conn = new NpgsqlConnection(ConnectionString))
        {
            conn.Open();
            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("id", id);
                int linhas = cmd.ExecuteNonQuery();
                Console.WriteLine(linhas > 0 ? "Aluno excluído com sucesso!" : "Aluno não encontrado.");
            }
        }
    }
}