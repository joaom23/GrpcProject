Create database Utilizadores

Use Utilizadores 

Create Table Jogadores(

Id Integer Identity(1,1) NOT NULL,
Nome Varchar(50) NOT NULL,
Idade Integer NOT NULL,
Numeros Integer NOT NULL,
Estrelas Integer NOT NULL,
Data_Aposta DATE NOT NULL DEFAULT GETDATE(),

PRIMARY KEY(Id),
CHECK (Data_Aposta >= GETDATE())

);

Create Table Aposta(

Id_A Integer NOT NULL,
Numeros Integer NOT NULL,
Estrelas Integer NOT NULL,
Data_Aposta DATE NOT NULL DEFAULT GETDATE(),

Foreign Key (Id_A) References Jogadores(Id),
CHECK (Data_Aposta >= GETDATE())
);

Create Table Gestor(

Nome Varchar(50) NOT NULL,
Numeros Integer NOT NULL,
Estrelas Integer NOT NULL,

);
