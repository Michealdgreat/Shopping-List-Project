﻿using Microsoft.Extensions.Configuration;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace ShoppingLibrary.DataAccess;

public class SqlDataAccess : ISqlDataAccess
{
    private readonly IConfiguration _config;

    public SqlDataAccess(IConfiguration config)
    {
        _config = config;
    }

    public async Task<List<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionStringName)
    {
        string connectionString = _config.GetConnectionString(connectionStringName);

        using IDbConnection connection = new SqlConnection(connectionString); //the connection close after the curly braces
        //Dapper Query
        var Rows = await connection.QueryAsync<T>(storedProcedure,
                                           parameters,
                                           commandType: CommandType.StoredProcedure);

        return Rows.ToList();
    }

    public Task SaveData<T>(string storedProcedure, T parameters, string connectionStringName) //returns a task
    {
        string connectionString = _config.GetConnectionString(connectionStringName);

        using IDbConnection connection = new SqlConnection(connectionString);

        return connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);


    }


}
