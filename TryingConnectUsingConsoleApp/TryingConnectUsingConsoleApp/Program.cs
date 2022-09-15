﻿using Npgsql;

var cs = "Host=localhost;Username=postgres;Password=Javierpedro2;Database=ListofName";

using var con = new NpgsqlConnection(cs);
con.Open();

var sql = "SELECT version()";

using var cmd = new NpgsqlCommand(sql, con);

var version = cmd.ExecuteScalar().ToString();
Console.WriteLine($"PostgreSQL version: {version}");