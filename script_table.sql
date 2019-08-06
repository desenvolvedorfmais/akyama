drop table tbBiometria_Akiama;
create table tbBiometria_Akiama
(
  id             int PRIMARY KEY identity,
  biometriaBytes varbinary(8000),
  templateImage  varbinary(8000)
)
go


create unique index tbBiometria_Akiama_id_uindex
  on tbBiometria_Akiama (id)
go
