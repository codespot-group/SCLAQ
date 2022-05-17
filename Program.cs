﻿class Program
{
    static void Main(string[] args)
    {
        string sql = @"
            CREATE TABLE Fornecedores (
                id INT NULL,
                nome varchar(100) NULL, 
                cnpj VARCHAR(16) NULL,
                endereco varchar(100) NULL,
                telefone varchar(100) NULL,
                email varchar(100) NULL
            );

            CREATE TABLE Fornecedores2 (
                id INT NULL,
                nome varchar(100) NULL, 
                cnpj VARCHAR(16) NULL,
                endereco varchar(100) NULL,
                telefone varchar(100) NULL,
                email varchar(100) NULL
            );
        ";

        List<TableModel> tables = TableModel.multiple(sql);

        foreach (TableModel table in tables)
        {
            System.Console.WriteLine(table.name);

            foreach (AttributeModel attribute in table.attributes)
            {
                System.Console.WriteLine(attribute.name + "|" + attribute.type);
            }
        }
    }
}
