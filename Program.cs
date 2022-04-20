using EFCoreConsole.Context;
using EFCoreConsole.Entities;
using Microsoft.EntityFrameworkCore;

using (var db = new DataContext())
{
    // Cria a base de dados e as tabelas (se não estiverem criadas)
    db.Database.EnsureCreated();

    // Verifica se existe algum registro na tabela "Livros"
    if (db.Livros.Any())
    {
        // Exclui todos os registros da tabela "Livros" e reinicia a contagem da chave primária auto-incremental
        db.Database.ExecuteSqlRaw("TRUNCATE ONLY \"Livros\" RESTART IDENTITY;");
    }

    // Adiciona vários livros
    db.Livros.Add(new Livro("Domain-Driven Design: Tackling Complexity in the Heart of Software", "Eric Evans", 2003));
    db.Livros.Add(new Livro("Agile Principles, Patterns, and Practices in C#", "Robert C. Martin", 2006));
    db.Livros.Add(new Livro("Clean Code: A Handbook of Agile Software Craftsmanship", "Robert C. Martin", 2008));
    db.Livros.Add(new Livro("Implementing Domain-Driven Design", "Vaughn Vernon", 2013));
    db.Livros.Add(new Livro("Patterns, Principles, and Practices of Domain-Driven Design", "Scott Millet", 2015));
    db.Livros.Add(new Livro("Refactoring: Improving the Design of Existing Code ", "Martin Fowler", 2012 ));
    
    // Persiste os dados no banco de dados
    db.SaveChanges();
}







