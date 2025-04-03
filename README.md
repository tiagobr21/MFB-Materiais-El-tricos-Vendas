# Desafio Amazonas Inovare

* Passo a passo para rodar o sistema:

  * pré-requisitos :
    - Visual Studio 2022
    - .NET 6.0
    - Sql Server 2022
    - SQL Server Management Studio (SSMS) 20.2

* Banco de dados
  - Entrando no seu Serviço Sql server no Sql Server Management,Vé me nova consulta e Crie um banco de dados chamado MBF_Vendas: **CREATE DATABASE MBF_Vendas;**
  - Após criar, pegue o script sql para criar as tabelas da base de dados -> MBF_Vendas.sql . Cole e Execute o script
  - No projeto, no arquivo App.config configure a conexão com o com banco de dados:
   ** <?xml version="1.0" encoding="utf-8" ?>
     <configuration>
     	<connectionStrings>
     		<add name="connstring" connectionString="Server=10.58.64.215,1433;Database=MBF_Vendas;User Id=sa;Password=Bondade07!;TrustServerCertificate=True;"/>
     	</connectionStrings>
     </configuration>      **
