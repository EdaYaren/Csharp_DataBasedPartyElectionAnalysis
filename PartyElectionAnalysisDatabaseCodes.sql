
CREATE DATABASE DbElectionProject

USE DbElectionProject

CREATE TABLE Tbl_District(
DistrictID TINYINT PRIMARY KEY IDENTITY(1,1),  -- İlçe sayısı az olduğu için tiny int kullanılır.
DistrictName VARCHAR(20),
Party_A SMALLINT,     -- İlçelere göre partilerin oy sayılarının girildiği sütunlar
Party_B SMALLINT,
Party_C SMALLINT,
Party_D SMALLINT,
Party_E SMALLINT
)

INSERT INTO Tbl_District VALUES
('Çankaya', 125, 25, 75, 136, 88)

SELECT * FROM Tbl_District
